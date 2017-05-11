using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TotalAtendimento
{
    public partial class ObjConversa : UserControl
    {
        public const int ORIGEM_CLIENTE = 1;
        public const int ORIGEM_ESTABELECIMENTO = 2;
        public const int ORIGEM_DESCONHECIDA = 0;

        private string isIMEI;
        private string isEndereco;
        private string isNomeCliente;
        private int iiUltimaOrigem = 0;
        
        public ObjConversa()
        {
            InitializeComponent();
        }

        public void AtualizaConversa(string asEndereco, string asIMEI, string asNomeCliente)
        {
            bool lbInicioNovasMensagens = false;
            string lsMensagem;
            int liOrigem;
            int liNovaMensagem;

            isIMEI = asIMEI;
            isNomeCliente = asNomeCliente;
            isEndereco = asEndereco;

            rtb_conversa.Clear();
            iiUltimaOrigem = ORIGEM_DESCONHECIDA;

            SQLiteDataReader sdrResultado;
            sdrResultado = SqLite.ExecutaSelect("SELECT MENSAGEM, REMETENTE, MENSAGEM_NOVA FROM CONVERSAS WHERE IMEI = ? ORDER BY MENSAGEM_NOVA, DATA_ENVIO", new object[] { "123789" });
            
            while (sdrResultado.Read())
            {
                lsMensagem = sdrResultado.GetString(0);
                liOrigem = sdrResultado.GetInt16(1);
                liNovaMensagem = sdrResultado.GetInt16(2);

                if (!lbInicioNovasMensagens)
                {
                    if (liNovaMensagem == 1)
                    {
                        iiUltimaOrigem = ORIGEM_DESCONHECIDA;
                        lbInicioNovasMensagens = true;
                    }
                }
                AdicionarMensagem(lsMensagem, liOrigem, (liNovaMensagem == 1));
            }
            sdrResultado.Close();
            if (!lbInicioNovasMensagens)
                iiUltimaOrigem = ORIGEM_DESCONHECIDA;

            et_mensagem.Clear();
        }

        public void HabilitarConversa(bool abHabilitar)
        {
            this.et_mensagem.Enabled = abHabilitar;
            this.bt_enviar.Enabled = abHabilitar;
        }

        public void NovaMensagemCliente(string asMensagem, string asIMEI)
        {
            AdicionarMensagem(asMensagem, asIMEI, ORIGEM_CLIENTE);
        }

        private void NovaMensagemEstabelecimento()
        {
            string lsMensagem = et_mensagem.Text;

            if(!CentralTCP.EnviarNovaMensagem(isEndereco, lsMensagem))
            {
                MessageBox.Show("Erro ao enviar mensagem", "Erro");
                return;
            }

            this.AdicionarMensagem(lsMensagem, isIMEI, ObjConversa.ORIGEM_ESTABELECIMENTO);

            et_mensagem.Clear();
        }

        private void AdicionarMensagem(string asMensagem, string asIMEI, int aiOrigem)
        {
            SalvarMensagem(asMensagem, asIMEI, aiOrigem);
            if (asIMEI == isIMEI)
            {
                AdicionarMensagem(asMensagem, aiOrigem, true);
            }
        }

        private void AdicionarMensagem(string asMensagem, int aiOrigem, bool abNovaMensagem)
        {
            string lsNomeOrigem = "";
            Color lclCorOrigem = rtb_conversa.ForeColor;

            if (aiOrigem == ORIGEM_CLIENTE)
            {
                lsNomeOrigem = isNomeCliente;
                if (abNovaMensagem) lclCorOrigem = Color.Green;
            }
            else if (aiOrigem == ORIGEM_ESTABELECIMENTO)
            {
                lsNomeOrigem = "Estabelecimento";
                if (abNovaMensagem) lclCorOrigem = Color.Purple;
            }

            if (iiUltimaOrigem == aiOrigem)
            {
                if (!(rtb_conversa.Text == "")) asMensagem = Environment.NewLine + asMensagem;
                rtb_conversa.AppendText(asMensagem);
            }
            else
            {
                if (!(rtb_conversa.Text == "")) lsNomeOrigem = Environment.NewLine + Environment.NewLine + lsNomeOrigem;

                rtb_conversa.SelectionStart = rtb_conversa.TextLength;
                rtb_conversa.SelectionLength = 0;

                rtb_conversa.SelectionFont = new Font(Font, FontStyle.Bold);
                rtb_conversa.SelectionColor = lclCorOrigem;
                rtb_conversa.AppendText(lsNomeOrigem + ": ");

                rtb_conversa.SelectionFont = rtb_conversa.Font;
                rtb_conversa.SelectionColor = rtb_conversa.ForeColor;

                rtb_conversa.AppendText(asMensagem);
                iiUltimaOrigem = aiOrigem;
            }

            rtb_conversa.ScrollToCaret();
        }

        private void SalvarMensagem(string asMensagem, string asIMEI, int aiOrigem)
        {
            long llDataAtual;

            SqLite.ExecutaComando("INSERT INTO CONVERSAS (IMEI, MENSAGEM, DATA_ENVIO, REMETENTE, MENSAGEM_NOVA) VALUES" +
            "('" + asIMEI + "', '" + asMensagem + "', " + DateTime.Now.Ticks + ", " + aiOrigem + ", 1)");
        }

        private void et_mensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (et_mensagem.Text == "" && e.KeyChar == '\r')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '\r')
            {
                NovaMensagemEstabelecimento();
                e.Handled = true;
            }
        }

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            NovaMensagemEstabelecimento();
        }
    }
}
