using System;
using System.Drawing;
using System.Windows.Forms;

namespace TotalAtendimento
{
    public partial class form_menu_principal : Form
    {
        public form_menu_principal()
        {
            InitializeComponent();
        }

        private void form_menu_principal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = SystemColors.ButtonFace;
                    // 4#
                    break;
                }
            }
        }

        private void mn_cadastro_ingrediente_opcional_Click(object sender, EventArgs e)
        {
            FormCollection lfcFormsAbertos = Application.OpenForms;

            foreach (Form lf in lfcFormsAbertos)
            {
                if (lf.Name == "form_ingredientes_opicionais")
                {
                    lf.BringToFront();
                    return;
                }
            }

            form_ingredientes_opicionais lfIngredienteOpcional = new form_ingredientes_opicionais();
            lfIngredienteOpcional.Name = "form_ingredientes_opicionais";
            lfIngredienteOpcional.MdiParent = this;
            lfIngredienteOpcional.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teste lfIngredienteOpcional = new Teste();
            lfIngredienteOpcional.Name = "form_base";
            lfIngredienteOpcional.MdiParent = this;
            lfIngredienteOpcional.Show();
        }

        private void adicionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection lfcFormsAbertos = Application.OpenForms;

            foreach (Form lf in lfcFormsAbertos)
            {
                if (lf.Name == "form_adicionais")
                {
                    lf.BringToFront();
                    return;
                }
            }

            form_adicionais lfIngredienteOpcional = new form_adicionais();
            lfIngredienteOpcional.Name = "form_adicionais";
            lfIngredienteOpcional.MdiParent = this;
            lfIngredienteOpcional.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection lfcFormsAbertos = Application.OpenForms;

            foreach (Form lf in lfcFormsAbertos)
            {
                if (lf.Name == "form_produtos")
                {
                    lf.BringToFront();
                    return;
                }
            }

            form_produtos lfIngredienteOpcional = new form_produtos();
            lfIngredienteOpcional.Name = "form_produtos";
            lfIngredienteOpcional.MdiParent = this;
            lfIngredienteOpcional.Show();
        }
    }
}
