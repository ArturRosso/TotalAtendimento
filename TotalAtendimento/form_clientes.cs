using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TotalAtendimento
{
    public partial class form_clientes : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        NotifyIcon iniIcone = new NotifyIcon();

        public form_clientes()
        {
            //Corrige DPI, ja que em algumas resoluções a aplicação fica com a aparenci fosca.
            SetProcessDPIAware();

            //Permite que threads troquem informações
            CheckForIllegalCrossThreadCalls = false;

            //Inicia os objetos de servidor e banco de dados
            IniciarObjetos();

            InitializeComponent();
            IniciaIconeNotificacao();
        }

        private void IniciaIconeNotificacao()
        {
            Bitmap btmp = new Bitmap("teste.jpg");

            btmp.MakeTransparent(Color.White);
            System.IntPtr icH = btmp.GetHicon();
            Icon ico = Icon.FromHandle(icH);
            
            this.iniIcone.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iniIcone.Icon = ico;
            this.iniIcone.Text = "Teste";

            this.iniIcone.MouseClick += iniIcone_MouseClick;
            this.iniIcone.ContextMenu = new ContextMenu();
            this.iniIcone.ContextMenu.MenuItems.Add("Maximizar").Click += iniIcone_ContextMenu_MaximizarClick;
            this.iniIcone.ContextMenu.MenuItems.Add("Encerrar").Click += iniIcone_ContextMenu_FecharClick;
        }

        private void IniciarObjetos()
        {
            CentralUDP.IniciarServidor();

            CentralTCP.IniciaCentralTCP();
            CentralTCP.Nova_Mensagem += centralTCP_Nova_Mensagem;
            CentralTCP.Fim_Conexao += centralTCP_Fim_Conexao;
            
            SqLite.IniciarBancoDados();
        }

        private void NovaConexao(string asEndereco, string asIMEI, string asNome, int aiMesa)
        {
            if (lv_conexoes.Items.ContainsKey(asIMEI))
            {
                int liStatus = Convert.ToInt16(lv_conexoes.GetValor(asIMEI, lvConexao.COLUNA_STATUS));

                if (liStatus == lvConexao.STATUS_CONECTADO)
                {
                    if (CentralTCP.ExisteConexao(asEndereco))
                    {
                        CentralTCP.EnviarNovaMensagem(asEndereco, "IMEI duplicado");
                        CentralTCP.FecharConexao(asEndereco);
                    }
                }
                else
                {
                    lv_conexoes.SetEndereco(asEndereco, asIMEI);
                    lv_conexoes.SetMesa(aiMesa, asIMEI);
                    lv_conexoes.SetStatus(lvConexao.STATUS_CONECTADO, asIMEI);
                    lv_conexoes.AddNotificacao(asIMEI);

                    obj_inf_cliente.SetMesa(aiMesa);
                    obj_inf_cliente.SetNome(asNome);

                    if (lv_conexoes.PossuiLinhaSelecionada())
                        if (lv_conexoes.IsIMEI == asIMEI) AtualizarStatusItemSelecionado();
                }
            }
            else
            {
                lv_conexoes.AdicionarConexao(asIMEI, asNome, asEndereco, aiMesa);

                if (lv_conexoes.IsIMEI != "")
                    lv_conexoes.SetLinhaSelecionada(lv_conexoes.IsIMEI);

                SqLite.ExecutaComando("UPDATE CONVERSAS SET MENSAGEM_NOVA = 0 WHERE MENSAGEM_NOVA <> 0 AND IMEI = '" + asIMEI + "'");
            }
        }

        private void FinalizarConexao(string asEndereco)
        {
            string lsIMEI = lv_conexoes.GetIMEIEndereco(asEndereco);

            if (lsIMEI != "")
            {
                lv_conexoes.SetStatus(lvConexao.STATUS_DESCONECTADO, lsIMEI);
                lv_conexoes.AddNotificacao(lsIMEI);
                

                //Se a conexão finalizada está atualmente selecionada, atualiza a informação de status
                if (lv_conexoes.PossuiLinhaSelecionada())
                    if (lv_conexoes.IsIMEI == lsIMEI) AtualizarStatusItemSelecionado();

                lv_conexoes.SetEndereco("", lsIMEI);
            }
        }

        private void NovaMensagemCliente(string asEndereco, string asMensagem)
        {
            string lsIMEI = lv_conexoes.GetIMEIEndereco(asEndereco);

            if (lsIMEI == "") return;

            obj_conversa.NovaMensagemCliente(asMensagem, lsIMEI);
            if (lsIMEI != lv_conexoes.IsIMEI)
                lv_conexoes.AddNotificacao(lsIMEI);
        }

        private void AtualizarItemSelecionado()
        {
            obj_conversa.AtualizaConversa(lv_conexoes.IsEndereco, lv_conexoes.IsIMEI, lv_conexoes.IsNome);
            obj_inf_cliente.AtualizarInformacoesCliente(lv_conexoes.IsIMEI, lv_conexoes.IsNome, lv_conexoes.IiMesa);

            AtualizarStatusItemSelecionado();
        }

        private void AtualizarStatusItemSelecionado()
        {
            int liStatus = lv_conexoes.IiStatus;
            bool lbConectado = (liStatus == lvConexao.STATUS_CONECTADO);

            obj_inf_cliente.AtualizaStatus(lbConectado);
            obj_conversa.HabilitarConversa(lbConectado);
        }

        private Dictionary<string, Dictionary<string, string>> ConverteJsonParaObject(string asJson)
        {
            var result = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(asJson);
            return result;
        }

        private void Encerrar()
        {
            CentralTCP.Encerrar();
            CentralUDP.DesconectarServidor();
            Application.Exit();
        }

        private void centralTCP_Nova_Mensagem(string asEndereco, string asMensagem)
        {
            Dictionary<string, Dictionary<string, string>> ldyMensagem;
            Dictionary<string, string> ldyValores;

            ldyMensagem = ConverteJsonParaObject(asMensagem);

            if (ldyMensagem.ContainsKey("conversa"))
            {
                ldyValores = ldyMensagem["conversa"];
                NovaMensagemCliente(asEndereco, ldyValores["mensagem"]);
            }
            else if (ldyMensagem.ContainsKey("info"))
            {
                ldyValores = ldyMensagem["info"];
                NovaConexao(asEndereco, ldyValores["imei"], ldyValores["nome"], int.Parse(ldyValores["mesa"]));
            }
        }
        
        private void centralTCP_Fim_Conexao(string asEndereco)
        {
            FinalizarConexao(asEndereco);
        }

        private void lv_conexoes_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(lv_conexoes.PossuiLinhaSelecionada()))
            {
                lv_conexoes.SetLinhaSelecionada(lv_conexoes.IsIMEI);
                return;
            }
        }

        private void lv_conexoes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                AtualizarItemSelecionado();
                bt_excluir_cliente.Enabled = true;
            }
        }

        private void form_clientes_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                iniIcone.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void iniIcone_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            iniIcone.Visible = false;
        }

        private void iniIcone_ContextMenu_MaximizarClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            iniIcone.Visible = false;
        }

        private void iniIcone_ContextMenu_FecharClick(object sender, EventArgs e)
        {
            Encerrar();
        }

        private void form_clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void bt_excluir_cliente_Click(object sender, EventArgs e)
        {
            if(lv_conexoes.IiStatus == lvConexao.STATUS_CONECTADO)
            {
                if(MessageBox.Show("O cliente está conectado, desejá realmente excluir a conexão?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            CentralTCP.FecharConexao(lv_conexoes.IsEndereco);
            lv_conexoes.IlviLinhaSelecionada.Remove();

            if(lv_conexoes.Items.Count == 0)
            {
                obj_inf_cliente.AtualizarInformacoesCliente("", "Nome", -1);
                obj_inf_cliente.AtualizaStatus(false);

                obj_conversa.AtualizaConversa("", "", "");
                obj_conversa.HabilitarConversa(false);

                bt_excluir_cliente.Enabled = false;
            }
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection lfcFormsAbertos = Application.OpenForms;

            foreach (Form lf in lfcFormsAbertos)
            {
                if(lf.Name == "form_menu_principal")
                {
                    lf.BringToFront();
                    return;
                }
            }

            form_menu_principal lfMenuPrincipal = new form_menu_principal();
            lfMenuPrincipal.Name = "form_menu_principal";
            lfMenuPrincipal.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encerrar();
        }

        private void lv_conexoes_ScrollPositionChanged(MetroFramework.Controls.MetroListView listview, int pos)
        {

        }
    }
}
