using System;
using System.Windows.Forms;
using System.Data.SQLite;
using MetroFramework.Forms;
using BrightIdeasSoftware;
using System.Data;
using System.Linq;

namespace TotalAtendimento
{
    public partial class form_ingredientes_opicionais : MetroForm
    {
        private const int STATUS_NOVO = 1;
        private const int STATUS_EDITANDO = 2;
        private const int STATUS_CONSULTANDO = 0;

        private const int COLUNA_CODIGO = 0;
        private const int COLUNA_DESCRICAO = 1;

        private int iiStatus;

        public form_ingredientes_opicionais()
        {
            InitializeComponent();

            AtualizarListaIngredientes();

            this.StyleManager = Style_Manager;
        }

        private void SetUltimoIgrediente()
        {
            if(GetUltimoCodigoIgrediente() == 0)
            {
                NovoIngrediente();
            }

            SetIngrediente(GetUltimoCodigoIgrediente());
        }

        private bool SetIngrediente(int aiCodigo)
        {
            SQLiteDataReader lsdtValores;
            string lsComando = "SELECT CODI_INGREDIENTE, DESCRICAO FROM IGREDIENTES_OPCIONAIS WHERE CODI_INGREDIENTE = ?";

            lsdtValores = SqLite.ExecutaSelect(lsComando, new object[1] { aiCodigo });

            if (lsdtValores.Read())
            {
                string lsCodigo = lsdtValores.GetInt32(0).ToString();
                string lsDescricao = lsdtValores.GetString(1);

                itb_codigo.Text = lsCodigo;
                tb_descricao.Text = lsDescricao;
                
                HabilitarEdicao(false);

                lsdtValores.Close();

                return true;
            }

            lsdtValores.Close();
            return false;
        }

        private int GetRowIndexByValue(int aiColuna, string asValor)
        {
            int rowIndex = -1;

            DataGridViewRow row = gr_ingredientes.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[aiColuna].Value.ToString().Equals(asValor))
                .First();

            rowIndex = row.Index;

            return rowIndex;
        }

        private void NovoIngrediente()
        {
            itb_codigo.Text = (GetUltimoCodigoIgrediente() + 1).ToString();
            tb_descricao.Text = "";

            SetStatus(STATUS_NOVO);
            HabilitarEdicao(true);
            tb_descricao.Focus();
        }

        private void EditarIngrediente()
        {
            SetStatus(STATUS_EDITANDO);
            HabilitarEdicao(true);
            
            itb_codigo.Enabled = false;
            tb_descricao.Focus();
        }

        private void SalvarIngrediente()
        {
            if(itb_codigo.Text == "0")
            {
                MessageBox.Show("Não é possivel utilizar '0' como código.", "Código invalido");
                itb_codigo.Focus();
                return;
            }

            if (ExisteChave() && iiStatus == STATUS_NOVO)
            {
                MessageBox.Show("O código informado já existe", "Código invalido");
                itb_codigo.Focus();
                return;
            }

            if(tb_descricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição do ingrediente", "Descrição invalida");
                tb_descricao.Focus();
                return;
            }

            int liCodigo = int.Parse(itb_codigo.Text);
            string lsDescricao = tb_descricao.Text;

            switch (iiStatus)
            {
                case STATUS_NOVO:
                    SqLite.ExecutaComando("INSERT INTO IGREDIENTES_OPCIONAIS(CODI_INGREDIENTE, DESCRICAO)" +
                        "                            VALUES (?, ?)", new object[2] { liCodigo, lsDescricao });
                    break;

                case STATUS_EDITANDO:
                    SqLite.ExecutaComando("UPDATE IGREDIENTES_OPCIONAIS SET DESCRICAO = ?" +
                        "                            WHERE CODI_INGREDIENTE = ? ", new object[2] { lsDescricao, liCodigo });
                    break;
            }

            AtualizarListaIngredientes();
            
            NovoIngrediente();
        }

        private void ExcluirIngrediente()
        {
            int liCodigo = int.Parse(itb_codigo.Text);

            SqLite.ExecutaComando("DELETE FROM IGREDIENTES_OPCIONAIS" +
                        "                          WHERE CODI_INGREDIENTE = ?", new object[1] { liCodigo });

            AtualizarListaIngredientes();
            SetUltimoIgrediente();
        }

        private int GetUltimoCodigoIgrediente()
        {
            object lobResultado;

            string lsComando = "SELECT MAX(CODI_INGREDIENTE) FROM IGREDIENTES_OPCIONAIS";
            lobResultado = SqLite.ExecutaSelectUnicoResultado(lsComando);

            if (lobResultado == DBNull.Value) return 0;

            return Convert.ToInt32(lobResultado);
        }

        private void SetStatus(int aiStatus)
        {
            iiStatus = aiStatus;
        }

        private void HabilitarEdicao(bool abHabilitar)
        {
            itb_codigo.Enabled = abHabilitar && (iiStatus == STATUS_NOVO);
            tb_descricao.Enabled = abHabilitar;
            bt_novo.Enabled = !abHabilitar;
            gr_ingredientes.Enabled = !abHabilitar;
            tb_pesquisa.Enabled = !abHabilitar;

            if (abHabilitar)
            {
                bt_editar_salvar.Text = "&Salvar";
                bt_excluir_cancelar.Text = "&Cancelar";

                tb_descricao.Focus();
            }
            else
            {
                bt_editar_salvar.Text = "&Editar";
                bt_excluir_cancelar.Text = "E&xcluir";

                SetStatus(STATUS_CONSULTANDO);
            }
        }

        private bool ExisteChave()
        {
            if (itb_codigo.Text == "")
                return false;

            int liChave = int.Parse(itb_codigo.Text);
            string lsConsulta = "SELECT COUNT(*) " +
                "                  FROM IGREDIENTES_OPCIONAIS " +
                "                 WHERE CODI_INGREDIENTE = ?";

            object lobjResultado = SqLite.ExecutaSelectUnicoResultado(lsConsulta, new object[1]{liChave});

            return (Convert.ToInt32(lobjResultado) > 0);
        }

        private void AtualizarListaIngredientes()
        {
            AtualizarListaIngredientes(tb_pesquisa.Text);
        }

        private void AtualizarListaIngredientes(string asFiltro)
        {
            DataTable ldtConsulta;
            string lsComando;

            if(asFiltro == "")
            {
                ldtConsulta = SqLite.ExecutaSelectGrid("SELECT CODI_INGREDIENTE, DESCRICAO FROM IGREDIENTES_OPCIONAIS ORDER BY CODI_INGREDIENTE");
            }
            else
            {
                int liCodigo;

                if(int.TryParse(asFiltro, out liCodigo))
                {
                    lsComando = "SELECT CODI_INGREDIENTE, DESCRICAO FROM IGREDIENTES_OPCIONAIS" +
                        "         WHERE CODI_INGREDIENTE = ? OR" +
                        "               DESCRICAO LIKE ?" +
                        "         ORDER BY CODI_INGREDIENTE";

                    ldtConsulta = SqLite.ExecutaSelectGrid(lsComando, new object[2] { liCodigo, "%" + asFiltro + "%" } );
                }
                else
                {
                    lsComando = "SELECT CODI_INGREDIENTE, DESCRICAO FROM IGREDIENTES_OPCIONAIS" +
                        "         WHERE DESCRICAO LIKE ?" +
                        "         ORDER BY CODI_INGREDIENTE";

                    ldtConsulta = SqLite.ExecutaSelectGrid(lsComando, new object[1] {"%" + asFiltro + "%" });
                }
            }

            gr_ingredientes.DataSource = ldtConsulta.DefaultView;

            FormataColuna(COLUNA_CODIGO, "Código", 65, DataGridViewContentAlignment.MiddleCenter);
            FormataColuna(COLUNA_DESCRICAO, "Descrição", 350, DataGridViewContentAlignment.MiddleLeft);

            if(gr_ingredientes.SelectedRows.Count > 0)
                gr_ingredientes.SelectedRows[0].Selected = false;

            if(gr_ingredientes.Rows.Count > 0)
                gr_ingredientes.FirstDisplayedScrollingRowIndex = gr_ingredientes.Rows.Count - 1;
        }

        private void FormataColuna(int aiColuna, string asTextocabecalho, int aiTamanhoColuna, DataGridViewContentAlignment adgaAlinhamento)
        {
            gr_ingredientes.Columns[aiColuna].HeaderText = asTextocabecalho;
            gr_ingredientes.Columns[aiColuna].Width = aiTamanhoColuna;
            gr_ingredientes.Columns[aiColuna].DefaultCellStyle.Alignment = adgaAlinhamento;
            gr_ingredientes.Columns[aiColuna].HeaderCell.Style.Alignment = adgaAlinhamento;
            gr_ingredientes.Columns[aiColuna].Resizable = DataGridViewTriState.False;
        }

        private void bt_editar_salvar_Click(object sender, EventArgs e)
        {
            if (bt_editar_salvar.Text == "&Salvar")
            {
                SalvarIngrediente();
            } else
            {
                EditarIngrediente();
            }
        }

        private void bt_excluir_cancelar_Click(object sender, EventArgs e)
        {
            if (bt_excluir_cancelar.Text == "E&xcluir")
            {
                if (MessageBox.Show("Deseja realmente excluir o ingrediente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ExcluirIngrediente();
                }
            }
            else
            {
                SetUltimoIgrediente();
            }
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            NovoIngrediente();
        }

        private void tb_pesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarListaIngredientes(tb_pesquisa.Text);
        }

        private void gr_ingredientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int liCodigo = int.Parse(gr_ingredientes.Rows[e.RowIndex].Cells[COLUNA_CODIGO].Value.ToString());
            SetIngrediente(liCodigo);
        }

        private void gr_ingredientes_Leave(object sender, EventArgs e)
        {
            if(gr_ingredientes.SelectedRows.Count > 0)
                gr_ingredientes.SelectedRows[0].Selected = false;
        }

        private void form_ingredientes_opicionais_Load(object sender, EventArgs e)
        {
            gr_ingredientes.ClearSelection();

            SetUltimoIgrediente();
        }

        private void form_ingredientes_opicionais_MouseClick(object sender, MouseEventArgs e)
        {
            if (iiStatus == STATUS_CONSULTANDO)
            {
                HabilitarEdicao(true);
            }
        }
    }
}
