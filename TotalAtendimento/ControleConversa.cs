using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalAtendimento
{
    public partial class ControleConversa : UserControl
    {
        private bool ibPossuiItemSelecionado = false;
        private ListViewItem ilvLinhaSelecionada;
        private CentralTCP iobjTCP;

        public ControleConversa()
        {
            InitializeComponent();
        }

        public void SetItemSelecionado(ListViewItem alvLinhaSelecionada)
        {
            ilvLinhaSelecionada = alvLinhaSelecionada;
            ibPossuiItemSelecionado = true;
        }

        public void SetCentralTCP(CentralTCP aobjTCP)
        {
            iobjTCP = aobjTCP;
        }

        private void EnviarMensagem()
        {
            string lsEndereco;
            string lsIMEI;

            if (!ibPossuiItemSelecionado)
                return;

            lsEndereco  = ilvLinhaSelecionada.SubItems[2].Text;
            lsIMEI      = ilvLinhaSelecionada.Name;

            if (iobjTCP.EnderecoConectado(lsEndereco))
            {
                iobjTCP.EnviarMensagem(lsEndereco, et_mensagem.Text);
                rtb_conversa.AdicionarMensagem(et_mensagem.Text, lsIMEI, rctbConversa.ORIGEM_ESTABELECIMENTO);
            }
            else
            {
                FimConexao(lsEndereco);
            }

            et_mensagem.Clear();
        }
    }
}
