namespace TotalAtendimento
{
    partial class form_ingredientes_opicionais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_codigo = new MetroFramework.Controls.MetroLabel();
            this.lv_descricao = new MetroFramework.Controls.MetroLabel();
            this.tb_descricao = new MetroFramework.Controls.MetroTextBox();
            this.bt_novo = new MetroFramework.Controls.MetroButton();
            this.bt_editar_salvar = new MetroFramework.Controls.MetroButton();
            this.bt_excluir_cancelar = new MetroFramework.Controls.MetroButton();
            this.pn_ingredientes = new MetroFramework.Controls.MetroPanel();
            this.gr_ingredientes = new MetroFramework.Controls.MetroGrid();
            this.lb_pesquisar = new MetroFramework.Controls.MetroLabel();
            this.tb_pesquisa = new MetroFramework.Controls.MetroTextBox();
            this.lb_ingredientes_cadastrados = new MetroFramework.Controls.MetroLabel();
            this.Style_Manager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.itb_codigo = new TotalAtendimento.Int32TextBox();
            this.pn_ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr_ingredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_codigo.Location = new System.Drawing.Point(22, 71);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(58, 20);
            this.lb_codigo.TabIndex = 1;
            this.lb_codigo.Text = "Código";
            this.lb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_codigo.UseStyleColors = true;
            // 
            // lv_descricao
            // 
            this.lv_descricao.AutoSize = true;
            this.lv_descricao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lv_descricao.Location = new System.Drawing.Point(22, 125);
            this.lv_descricao.Name = "lv_descricao";
            this.lv_descricao.Size = new System.Drawing.Size(74, 20);
            this.lv_descricao.TabIndex = 3;
            this.lv_descricao.Text = "Descrição";
            this.lv_descricao.UseStyleColors = true;
            // 
            // tb_descricao
            // 
            // 
            // 
            // 
            this.tb_descricao.CustomButton.Image = null;
            this.tb_descricao.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.tb_descricao.CustomButton.Name = "";
            this.tb_descricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_descricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_descricao.CustomButton.TabIndex = 1;
            this.tb_descricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_descricao.CustomButton.UseSelectable = true;
            this.tb_descricao.CustomButton.Visible = false;
            this.tb_descricao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_descricao.Lines = new string[0];
            this.tb_descricao.Location = new System.Drawing.Point(26, 148);
            this.tb_descricao.MaxLength = 32767;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.PasswordChar = '\0';
            this.tb_descricao.PromptText = "Descrição";
            this.tb_descricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_descricao.SelectedText = "";
            this.tb_descricao.SelectionLength = 0;
            this.tb_descricao.SelectionStart = 0;
            this.tb_descricao.ShortcutsEnabled = true;
            this.tb_descricao.Size = new System.Drawing.Size(334, 23);
            this.tb_descricao.TabIndex = 4;
            this.tb_descricao.UseSelectable = true;
            this.tb_descricao.UseStyleColors = true;
            this.tb_descricao.WaterMark = "Descrição";
            this.tb_descricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_descricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_novo.Location = new System.Drawing.Point(366, 82);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 27);
            this.bt_novo.TabIndex = 5;
            this.bt_novo.Text = "&Novo";
            this.bt_novo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bt_novo.UseSelectable = true;
            this.bt_novo.UseStyleColors = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_editar_salvar
            // 
            this.bt_editar_salvar.Location = new System.Drawing.Point(366, 113);
            this.bt_editar_salvar.Name = "bt_editar_salvar";
            this.bt_editar_salvar.Size = new System.Drawing.Size(75, 27);
            this.bt_editar_salvar.TabIndex = 6;
            this.bt_editar_salvar.Text = "&Editar";
            this.bt_editar_salvar.UseSelectable = true;
            this.bt_editar_salvar.UseStyleColors = true;
            this.bt_editar_salvar.Click += new System.EventHandler(this.bt_editar_salvar_Click);
            // 
            // bt_excluir_cancelar
            // 
            this.bt_excluir_cancelar.Location = new System.Drawing.Point(366, 144);
            this.bt_excluir_cancelar.Name = "bt_excluir_cancelar";
            this.bt_excluir_cancelar.Size = new System.Drawing.Size(75, 27);
            this.bt_excluir_cancelar.TabIndex = 7;
            this.bt_excluir_cancelar.Text = "E&xcluir";
            this.bt_excluir_cancelar.UseSelectable = true;
            this.bt_excluir_cancelar.UseStyleColors = true;
            this.bt_excluir_cancelar.Click += new System.EventHandler(this.bt_excluir_cancelar_Click);
            // 
            // pn_ingredientes
            // 
            this.pn_ingredientes.Controls.Add(this.gr_ingredientes);
            this.pn_ingredientes.Controls.Add(this.lb_pesquisar);
            this.pn_ingredientes.Controls.Add(this.tb_pesquisa);
            this.pn_ingredientes.Controls.Add(this.lb_ingredientes_cadastrados);
            this.pn_ingredientes.HorizontalScrollbarBarColor = true;
            this.pn_ingredientes.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_ingredientes.HorizontalScrollbarSize = 10;
            this.pn_ingredientes.Location = new System.Drawing.Point(0, 177);
            this.pn_ingredientes.Name = "pn_ingredientes";
            this.pn_ingredientes.Size = new System.Drawing.Size(464, 231);
            this.pn_ingredientes.Style = MetroFramework.MetroColorStyle.Purple;
            this.pn_ingredientes.TabIndex = 21;
            this.pn_ingredientes.VerticalScrollbarBarColor = true;
            this.pn_ingredientes.VerticalScrollbarHighlightOnWheel = false;
            this.pn_ingredientes.VerticalScrollbarSize = 10;
            // 
            // gr_ingredientes
            // 
            this.gr_ingredientes.AllowUserToAddRows = false;
            this.gr_ingredientes.AllowUserToDeleteRows = false;
            this.gr_ingredientes.AllowUserToResizeColumns = false;
            this.gr_ingredientes.AllowUserToResizeRows = false;
            this.gr_ingredientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gr_ingredientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gr_ingredientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gr_ingredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gr_ingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gr_ingredientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.gr_ingredientes.EnableHeadersVisualStyles = false;
            this.gr_ingredientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gr_ingredientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gr_ingredientes.Location = new System.Drawing.Point(25, 27);
            this.gr_ingredientes.MultiSelect = false;
            this.gr_ingredientes.Name = "gr_ingredientes";
            this.gr_ingredientes.ReadOnly = true;
            this.gr_ingredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gr_ingredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gr_ingredientes.RowHeadersVisible = false;
            this.gr_ingredientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gr_ingredientes.RowTemplate.Height = 24;
            this.gr_ingredientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gr_ingredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gr_ingredientes.Size = new System.Drawing.Size(415, 167);
            this.gr_ingredientes.TabIndex = 9;
            this.gr_ingredientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_ingredientes_RowEnter);
            this.gr_ingredientes.Leave += new System.EventHandler(this.gr_ingredientes_Leave);
            // 
            // lb_pesquisar
            // 
            this.lb_pesquisar.AutoSize = true;
            this.lb_pesquisar.Enabled = false;
            this.lb_pesquisar.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_pesquisar.Location = new System.Drawing.Point(137, 201);
            this.lb_pesquisar.Name = "lb_pesquisar";
            this.lb_pesquisar.Size = new System.Drawing.Size(73, 20);
            this.lb_pesquisar.TabIndex = 10;
            this.lb_pesquisar.Text = "Pesquisar:";
            // 
            // tb_pesquisa
            // 
            // 
            // 
            // 
            this.tb_pesquisa.CustomButton.Image = null;
            this.tb_pesquisa.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.tb_pesquisa.CustomButton.Name = "";
            this.tb_pesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_pesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pesquisa.CustomButton.TabIndex = 1;
            this.tb_pesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pesquisa.CustomButton.UseSelectable = true;
            this.tb_pesquisa.CustomButton.Visible = false;
            this.tb_pesquisa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_pesquisa.Lines = new string[0];
            this.tb_pesquisa.Location = new System.Drawing.Point(216, 200);
            this.tb_pesquisa.MaxLength = 32767;
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.PasswordChar = '\0';
            this.tb_pesquisa.PromptText = "Pesquisa";
            this.tb_pesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pesquisa.SelectedText = "";
            this.tb_pesquisa.SelectionLength = 0;
            this.tb_pesquisa.SelectionStart = 0;
            this.tb_pesquisa.ShortcutsEnabled = true;
            this.tb_pesquisa.Size = new System.Drawing.Size(224, 23);
            this.tb_pesquisa.TabIndex = 11;
            this.tb_pesquisa.UseSelectable = true;
            this.tb_pesquisa.UseStyleColors = true;
            this.tb_pesquisa.WaterMark = "Pesquisa";
            this.tb_pesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_pesquisa.TextChanged += new System.EventHandler(this.tb_pesquisa_TextChanged);
            // 
            // lb_ingredientes_cadastrados
            // 
            this.lb_ingredientes_cadastrados.AutoSize = true;
            this.lb_ingredientes_cadastrados.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_ingredientes_cadastrados.Location = new System.Drawing.Point(21, 4);
            this.lb_ingredientes_cadastrados.Name = "lb_ingredientes_cadastrados";
            this.lb_ingredientes_cadastrados.Size = new System.Drawing.Size(214, 20);
            this.lb_ingredientes_cadastrados.TabIndex = 8;
            this.lb_ingredientes_cadastrados.Text = "Lista de ingredientes opcionais";
            this.lb_ingredientes_cadastrados.UseStyleColors = true;
            // 
            // Style_Manager
            // 
            this.Style_Manager.Owner = this;
            this.Style_Manager.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // itb_codigo
            // 
            // 
            // 
            // 
            this.itb_codigo.CustomButton.Image = null;
            this.itb_codigo.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.itb_codigo.CustomButton.Name = "";
            this.itb_codigo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.itb_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.itb_codigo.CustomButton.TabIndex = 1;
            this.itb_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itb_codigo.CustomButton.UseSelectable = true;
            this.itb_codigo.CustomButton.Visible = false;
            this.itb_codigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itb_codigo.Lines = new string[0];
            this.itb_codigo.Location = new System.Drawing.Point(26, 95);
            this.itb_codigo.MaxLength = 32767;
            this.itb_codigo.Name = "itb_codigo";
            this.itb_codigo.PasswordChar = '\0';
            this.itb_codigo.PromptText = "Código";
            this.itb_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itb_codigo.SelectedText = "";
            this.itb_codigo.SelectionLength = 0;
            this.itb_codigo.SelectionStart = 0;
            this.itb_codigo.ShortcutsEnabled = true;
            this.itb_codigo.Size = new System.Drawing.Size(70, 22);
            this.itb_codigo.TabIndex = 22;
            this.itb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itb_codigo.UseSelectable = true;
            this.itb_codigo.UseStyleColors = true;
            this.itb_codigo.WaterMark = "Código";
            this.itb_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itb_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // form_ingredientes_opicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 408);
            this.Controls.Add(this.itb_codigo);
            this.Controls.Add(this.pn_ingredientes);
            this.Controls.Add(this.bt_excluir_cancelar);
            this.Controls.Add(this.bt_editar_salvar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.lv_descricao);
            this.Controls.Add(this.lb_codigo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_ingredientes_opicionais";
            this.Padding = new System.Windows.Forms.Padding(19, 60, 19, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Ingredientes Opcionais";
            this.Load += new System.EventHandler(this.form_ingredientes_opicionais_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.form_ingredientes_opicionais_MouseClick);
            this.pn_ingredientes.ResumeLayout(false);
            this.pn_ingredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr_ingredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style_Manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lb_codigo;
        private MetroFramework.Controls.MetroLabel lv_descricao;
        private MetroFramework.Controls.MetroTextBox tb_descricao;
        private MetroFramework.Controls.MetroButton bt_novo;
        private MetroFramework.Controls.MetroButton bt_editar_salvar;
        private MetroFramework.Controls.MetroButton bt_excluir_cancelar;
        private MetroFramework.Controls.MetroPanel pn_ingredientes;
        private MetroFramework.Controls.MetroLabel lb_ingredientes_cadastrados;
        private MetroFramework.Controls.MetroLabel lb_pesquisar;
        private MetroFramework.Controls.MetroTextBox tb_pesquisa;
        private MetroFramework.Components.MetroStyleManager Style_Manager;
        private MetroFramework.Controls.MetroGrid gr_ingredientes;
        private Int32TextBox itb_codigo;
    }
}