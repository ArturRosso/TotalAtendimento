using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace TotalAtendimento
{
    public partial class ObjInfClientes : UserControl
    {
        public const int PEDIDO_ABERTO = 1;
        public const int PEDIDO_PROCESSANDO = 2;
        public const int PEDIDO_ENTREGUE = 3;
        public const int PEDIDO_PAGO = 4;

        public const int COLUNA_CODIGO_PEDIDO = 0;
        public const int COLUNA_DATA_PEDIDO = 1;
        public const int COLUNA_QUANTIDADE = 2;
        public const int COLUNA_VALOR_PEDIDO = 3;
        public const int COLUNA_STATUS_PEDIDO = 4;

        public const int MESA_DESCONHECIDA = -1;

        public ObjInfClientes()
        {
            InitializeComponent();
        }
        
        public void AtualizarInformacoesCliente(string asIMEI, string asNome, int aiNumeroMesa)
        {
            SetMesa(aiNumeroMesa);
            SetNome(asNome);
            AtualizaPedidos(asIMEI);
        }

        public void AtualizaStatus(bool abConectado)
        {
            if (abConectado)
            {
                lb_status.Text = "Conectado";
                lb_status.ForeColor = Color.Green;
            }
            else
            {
                lb_status.Text = "Desconectado";
                lb_status.ForeColor = Color.Red;
            }

        }

        public void SetMesa(int aiMesa)
        {
            if(aiMesa == MESA_DESCONHECIDA)
                lb_mesa.Text = "Desconhecida";
            else
                lb_mesa.Text = aiMesa.ToString();
        }

        public void SetNome(string asNome)
        {
            lb_nome.Text = asNome;
        }

        private void AtualizaPedidos(string asIMEI)
        {
            DataTable ldtConsulta;
            string lsConsulta;

            lsConsulta = "SELECT " +
                                "PEDIDOS.CODI_PEDIDO, " +
                                "STRFTIME('%d-%m-%Y %H:%M:%S', DATA_PEDIDO/10000000 - 62135596800, 'unixepoch') AS DATA_PEDIDO, " +
                                "COUNT(P_ITENS.SEQUENCIAL_ITEM) AS QTDE_ITENS, " +
                                "VALOR_PEDIDO, " +
                                "CASE STATUS_PEDIDO " +
                                    "WHEN 1 THEN 'Aberto' " +
                                    "WHEN 2 THEN 'Em Processo' " +
                                    "WHEN 3 THEN 'Entregue' " +
                                    "WHEN 4 THEN 'Pago' " +
                                "END AS STATUS_PEDIDO " +
                          "FROM " +
                                "PEDIDOS " +
                                "INNER JOIN PEDIDOS_ITENS P_ITENS ON PEDIDOS.CODI_PEDIDO = P_ITENS.CODI_PEDIDO " +
                          "WHERE " +
                                "PEDIDOS.IMEI = ? " +
                          "GROUP BY " +
                                "PEDIDOS.CODI_PEDIDO, " +
                                "DATA_PEDIDO, " +
                                "VALOR_PEDIDO, " +
                                "STATUS_PEDIDO";

            ldtConsulta = SqLite.ExecutaSelectGrid(lsConsulta, new object[1] { asIMEI });

            gr_pedidos.DataSource = ldtConsulta.DefaultView;

            FormataColuna(COLUNA_CODIGO_PEDIDO, "Código", 60, DataGridViewContentAlignment.MiddleCenter);
            FormataColuna(COLUNA_DATA_PEDIDO, "Data Pedido", 120, DataGridViewContentAlignment.MiddleCenter);
            FormataColuna(COLUNA_QUANTIDADE, "Quantidade Itens", gr_pedidos.Width - 380, DataGridViewContentAlignment.MiddleRight);
            FormataColuna(COLUNA_VALOR_PEDIDO, "Valor Pedido", 100, DataGridViewContentAlignment.MiddleRight);
            FormataColuna(COLUNA_STATUS_PEDIDO, "Status Pedido", 100, DataGridViewContentAlignment.MiddleCenter);
        }

        private void FormataColuna(int aiColuna, string asTextocabecalho, int aiTamanhoColuna, DataGridViewContentAlignment adgaAlinhamento)
        {
            gr_pedidos.Columns[aiColuna].HeaderText = asTextocabecalho;
            gr_pedidos.Columns[aiColuna].Width = aiTamanhoColuna;
            gr_pedidos.Columns[aiColuna].DefaultCellStyle.Alignment = adgaAlinhamento;
            gr_pedidos.Columns[aiColuna].HeaderCell.Style.Alignment = adgaAlinhamento;
            gr_pedidos.Columns[aiColuna].Resizable = DataGridViewTriState.False;
        }

        private string GetStatus(int aiCodiStatus)
        {
            switch (aiCodiStatus)
            {
                case PEDIDO_ABERTO:
                    return "Aberto";
                case PEDIDO_PROCESSANDO:
                    return "Em Processo";
                case PEDIDO_ENTREGUE:
                    return "Entregue";
                case PEDIDO_PAGO:
                    return "Pago";
            }
            return "";
        }

        private void gr_pedidos_Resize(object sender, EventArgs e)
        {
            if(gr_pedidos.Columns.Count > 0)
                FormataColuna(COLUNA_QUANTIDADE, "Quantidade Itens", gr_pedidos.Width - 380, DataGridViewContentAlignment.MiddleRight);
        }
    }
}
