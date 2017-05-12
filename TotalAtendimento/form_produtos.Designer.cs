namespace TotalAtendimento
{
    partial class form_produtos
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
            this.tc_produto = new System.Windows.Forms.TabControl();
            this.tb_produto = new System.Windows.Forms.TabPage();
            this.tb_descricao = new MetroFramework.Controls.MetroTextBox();
            this.lb_descricao = new MetroFramework.Controls.MetroLabel();
            this.lb_codigo = new MetroFramework.Controls.MetroLabel();
            this.itb_codigo = new TotalAtendimento.Int32TextBox();
            this.tp_caracteristicas = new System.Windows.Forms.TabPage();
            this.tp_opcionais = new System.Windows.Forms.TabPage();
            this.tp_adicionais = new System.Windows.Forms.TabPage();
            this.lb_valor = new MetroFramework.Controls.MetroLabel();
            this.dtb_valor = new TotalAtendimento.DecTextBox();
            this.cb_ativo = new MetroFramework.Controls.MetroCheckBox();
            this.lb_grupo = new MetroFramework.Controls.MetroLabel();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.tb_fundo_grupo = new MetroFramework.Controls.MetroTextBox();
            this.cb_unidade_pedida = new System.Windows.Forms.ComboBox();
            this.lb_unidade_medida = new MetroFramework.Controls.MetroLabel();
            this.lb_fundo_unidade_medida = new MetroFramework.Controls.MetroTextBox();
            this.lb_quantidade = new MetroFramework.Controls.MetroLabel();
            this.decTextBox1 = new TotalAtendimento.DecTextBox();
            this.lb_observacoes = new MetroFramework.Controls.MetroLabel();
            this.tb_observacoes = new MetroFramework.Controls.MetroTextBox();
            this.tc_produto.SuspendLayout();
            this.tb_produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_produto
            // 
            this.tc_produto.Controls.Add(this.tb_produto);
            this.tc_produto.Controls.Add(this.tp_caracteristicas);
            this.tc_produto.Controls.Add(this.tp_opcionais);
            this.tc_produto.Controls.Add(this.tp_adicionais);
            this.tc_produto.Location = new System.Drawing.Point(23, 63);
            this.tc_produto.Name = "tc_produto";
            this.tc_produto.SelectedIndex = 0;
            this.tc_produto.Size = new System.Drawing.Size(670, 458);
            this.tc_produto.TabIndex = 0;
            // 
            // tb_produto
            // 
            this.tb_produto.Controls.Add(this.tb_observacoes);
            this.tb_produto.Controls.Add(this.lb_observacoes);
            this.tb_produto.Controls.Add(this.decTextBox1);
            this.tb_produto.Controls.Add(this.lb_quantidade);
            this.tb_produto.Controls.Add(this.cb_unidade_pedida);
            this.tb_produto.Controls.Add(this.lb_unidade_medida);
            this.tb_produto.Controls.Add(this.lb_fundo_unidade_medida);
            this.tb_produto.Controls.Add(this.cb_grupo);
            this.tb_produto.Controls.Add(this.lb_grupo);
            this.tb_produto.Controls.Add(this.cb_ativo);
            this.tb_produto.Controls.Add(this.dtb_valor);
            this.tb_produto.Controls.Add(this.lb_valor);
            this.tb_produto.Controls.Add(this.tb_descricao);
            this.tb_produto.Controls.Add(this.lb_descricao);
            this.tb_produto.Controls.Add(this.lb_codigo);
            this.tb_produto.Controls.Add(this.itb_codigo);
            this.tb_produto.Controls.Add(this.tb_fundo_grupo);
            this.tb_produto.Location = new System.Drawing.Point(4, 25);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Padding = new System.Windows.Forms.Padding(3);
            this.tb_produto.Size = new System.Drawing.Size(662, 429);
            this.tb_produto.TabIndex = 0;
            this.tb_produto.Text = "Produto";
            this.tb_produto.UseVisualStyleBackColor = true;
            // 
            // tb_descricao
            // 
            // 
            // 
            // 
            this.tb_descricao.CustomButton.Image = null;
            this.tb_descricao.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.tb_descricao.CustomButton.Name = "";
            this.tb_descricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_descricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_descricao.CustomButton.TabIndex = 1;
            this.tb_descricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_descricao.CustomButton.UseSelectable = true;
            this.tb_descricao.CustomButton.Visible = false;
            this.tb_descricao.Lines = new string[0];
            this.tb_descricao.Location = new System.Drawing.Point(16, 84);
            this.tb_descricao.MaxLength = 32767;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.PasswordChar = '\0';
            this.tb_descricao.PromptText = "Descrição";
            this.tb_descricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_descricao.SelectedText = "";
            this.tb_descricao.SelectionLength = 0;
            this.tb_descricao.SelectionStart = 0;
            this.tb_descricao.ShortcutsEnabled = true;
            this.tb_descricao.Size = new System.Drawing.Size(363, 23);
            this.tb_descricao.TabIndex = 3;
            this.tb_descricao.UseSelectable = true;
            this.tb_descricao.UseStyleColors = true;
            this.tb_descricao.WaterMark = "Descrição";
            this.tb_descricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_descricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_descricao.Location = new System.Drawing.Point(12, 61);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(74, 20);
            this.lb_descricao.TabIndex = 2;
            this.lb_descricao.Text = "Descrição";
            this.lb_descricao.UseStyleColors = true;
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_codigo.Location = new System.Drawing.Point(12, 12);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(58, 20);
            this.lb_codigo.TabIndex = 1;
            this.lb_codigo.Text = "Código";
            this.lb_codigo.UseStyleColors = true;
            // 
            // itb_codigo
            // 
            // 
            // 
            // 
            this.itb_codigo.CustomButton.Image = null;
            this.itb_codigo.CustomButton.Location = new System.Drawing.Point(48, 1);
            this.itb_codigo.CustomButton.Name = "";
            this.itb_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.itb_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.itb_codigo.CustomButton.TabIndex = 1;
            this.itb_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itb_codigo.CustomButton.UseSelectable = true;
            this.itb_codigo.CustomButton.Visible = false;
            this.itb_codigo.Lines = new string[] {
        "0"};
            this.itb_codigo.Location = new System.Drawing.Point(16, 35);
            this.itb_codigo.MaxLength = 32767;
            this.itb_codigo.Name = "itb_codigo";
            this.itb_codigo.PasswordChar = '\0';
            this.itb_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itb_codigo.SelectedText = "";
            this.itb_codigo.SelectionLength = 0;
            this.itb_codigo.SelectionStart = 0;
            this.itb_codigo.ShortcutsEnabled = true;
            this.itb_codigo.Size = new System.Drawing.Size(70, 23);
            this.itb_codigo.TabIndex = 0;
            this.itb_codigo.Text = "0";
            this.itb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itb_codigo.UseSelectable = true;
            this.itb_codigo.UseStyleColors = true;
            this.itb_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itb_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tp_caracteristicas
            // 
            this.tp_caracteristicas.Location = new System.Drawing.Point(4, 25);
            this.tp_caracteristicas.Name = "tp_caracteristicas";
            this.tp_caracteristicas.Padding = new System.Windows.Forms.Padding(3);
            this.tp_caracteristicas.Size = new System.Drawing.Size(662, 244);
            this.tp_caracteristicas.TabIndex = 1;
            this.tp_caracteristicas.Text = "Caracteristicas";
            this.tp_caracteristicas.UseVisualStyleBackColor = true;
            // 
            // tp_opcionais
            // 
            this.tp_opcionais.Location = new System.Drawing.Point(4, 25);
            this.tp_opcionais.Name = "tp_opcionais";
            this.tp_opcionais.Padding = new System.Windows.Forms.Padding(3);
            this.tp_opcionais.Size = new System.Drawing.Size(662, 244);
            this.tp_opcionais.TabIndex = 2;
            this.tp_opcionais.Text = "Opcionais";
            this.tp_opcionais.UseVisualStyleBackColor = true;
            // 
            // tp_adicionais
            // 
            this.tp_adicionais.Location = new System.Drawing.Point(4, 25);
            this.tp_adicionais.Name = "tp_adicionais";
            this.tp_adicionais.Padding = new System.Windows.Forms.Padding(3);
            this.tp_adicionais.Size = new System.Drawing.Size(662, 244);
            this.tp_adicionais.TabIndex = 3;
            this.tp_adicionais.Text = "Adicionais";
            this.tp_adicionais.UseVisualStyleBackColor = true;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_valor.Location = new System.Drawing.Point(381, 61);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(43, 20);
            this.lb_valor.TabIndex = 4;
            this.lb_valor.Text = "Valor";
            this.lb_valor.UseStyleColors = true;
            // 
            // dtb_valor
            // 
            // 
            // 
            // 
            this.dtb_valor.CustomButton.Image = null;
            this.dtb_valor.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.dtb_valor.CustomButton.Name = "";
            this.dtb_valor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dtb_valor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtb_valor.CustomButton.TabIndex = 1;
            this.dtb_valor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dtb_valor.CustomButton.UseSelectable = true;
            this.dtb_valor.CustomButton.Visible = false;
            this.dtb_valor.Lines = new string[] {
        ",00"};
            this.dtb_valor.Location = new System.Drawing.Point(385, 84);
            this.dtb_valor.MaxLength = 32767;
            this.dtb_valor.Name = "dtb_valor";
            this.dtb_valor.PasswordChar = '\0';
            this.dtb_valor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtb_valor.SelectedText = "";
            this.dtb_valor.SelectionLength = 0;
            this.dtb_valor.SelectionStart = 0;
            this.dtb_valor.ShortcutsEnabled = true;
            this.dtb_valor.Size = new System.Drawing.Size(87, 23);
            this.dtb_valor.TabIndex = 5;
            this.dtb_valor.Text = ",00";
            this.dtb_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dtb_valor.UseSelectable = true;
            this.dtb_valor.UseStyleColors = true;
            this.dtb_valor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dtb_valor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_ativo
            // 
            this.cb_ativo.AutoSize = true;
            this.cb_ativo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_ativo.Location = new System.Drawing.Point(412, 35);
            this.cb_ativo.Name = "cb_ativo";
            this.cb_ativo.Size = new System.Drawing.Size(60, 20);
            this.cb_ativo.TabIndex = 6;
            this.cb_ativo.Text = "Ativo";
            this.cb_ativo.UseSelectable = true;
            this.cb_ativo.UseStyleColors = true;
            // 
            // lb_grupo
            // 
            this.lb_grupo.AutoSize = true;
            this.lb_grupo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_grupo.Location = new System.Drawing.Point(12, 110);
            this.lb_grupo.Name = "lb_grupo";
            this.lb_grupo.Size = new System.Drawing.Size(50, 20);
            this.lb_grupo.TabIndex = 7;
            this.lb_grupo.Text = "Grupo";
            this.lb_grupo.UseStyleColors = true;
            // 
            // cb_grupo
            // 
            this.cb_grupo.AutoCompleteCustomSource.AddRange(new string[] {
            "teste",
            "oi",
            "kkkkk",
            "isso é serios",
            "ué"});
            this.cb_grupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_grupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_grupo.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Items.AddRange(new object[] {
            "teste",
            "ei",
            "nossa",
            "bigapau"});
            this.cb_grupo.Location = new System.Drawing.Point(17, 134);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(177, 23);
            this.cb_grupo.TabIndex = 8;
            // 
            // tb_fundo_grupo
            // 
            // 
            // 
            // 
            this.tb_fundo_grupo.CustomButton.Image = null;
            this.tb_fundo_grupo.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.tb_fundo_grupo.CustomButton.Name = "";
            this.tb_fundo_grupo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_fundo_grupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fundo_grupo.CustomButton.TabIndex = 1;
            this.tb_fundo_grupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fundo_grupo.CustomButton.UseSelectable = true;
            this.tb_fundo_grupo.CustomButton.Visible = false;
            this.tb_fundo_grupo.Lines = new string[0];
            this.tb_fundo_grupo.Location = new System.Drawing.Point(16, 133);
            this.tb_fundo_grupo.MaxLength = 32767;
            this.tb_fundo_grupo.Multiline = true;
            this.tb_fundo_grupo.Name = "tb_fundo_grupo";
            this.tb_fundo_grupo.PasswordChar = '\0';
            this.tb_fundo_grupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fundo_grupo.SelectedText = "";
            this.tb_fundo_grupo.SelectionLength = 0;
            this.tb_fundo_grupo.SelectionStart = 0;
            this.tb_fundo_grupo.ShortcutsEnabled = true;
            this.tb_fundo_grupo.Size = new System.Drawing.Size(180, 25);
            this.tb_fundo_grupo.TabIndex = 9;
            this.tb_fundo_grupo.UseSelectable = true;
            this.tb_fundo_grupo.UseStyleColors = true;
            this.tb_fundo_grupo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fundo_grupo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_unidade_pedida
            // 
            this.cb_unidade_pedida.AutoCompleteCustomSource.AddRange(new string[] {
            "teste",
            "oi",
            "kkkkk",
            "isso é serios",
            "ué"});
            this.cb_unidade_pedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_unidade_pedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_unidade_pedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_unidade_pedida.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_unidade_pedida.FormattingEnabled = true;
            this.cb_unidade_pedida.Items.AddRange(new object[] {
            "teste",
            "ei",
            "nossa",
            "bigapau"});
            this.cb_unidade_pedida.Location = new System.Drawing.Point(17, 180);
            this.cb_unidade_pedida.Name = "cb_unidade_pedida";
            this.cb_unidade_pedida.Size = new System.Drawing.Size(176, 23);
            this.cb_unidade_pedida.TabIndex = 11;
            // 
            // lb_unidade_medida
            // 
            this.lb_unidade_medida.AutoSize = true;
            this.lb_unidade_medida.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_unidade_medida.Location = new System.Drawing.Point(12, 159);
            this.lb_unidade_medida.Name = "lb_unidade_medida";
            this.lb_unidade_medida.Size = new System.Drawing.Size(141, 20);
            this.lb_unidade_medida.TabIndex = 10;
            this.lb_unidade_medida.Text = "Unidade de Medida";
            this.lb_unidade_medida.UseStyleColors = true;
            // 
            // lb_fundo_unidade_medida
            // 
            // 
            // 
            // 
            this.lb_fundo_unidade_medida.CustomButton.Image = null;
            this.lb_fundo_unidade_medida.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.lb_fundo_unidade_medida.CustomButton.Name = "";
            this.lb_fundo_unidade_medida.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.lb_fundo_unidade_medida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lb_fundo_unidade_medida.CustomButton.TabIndex = 1;
            this.lb_fundo_unidade_medida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lb_fundo_unidade_medida.CustomButton.UseSelectable = true;
            this.lb_fundo_unidade_medida.CustomButton.Visible = false;
            this.lb_fundo_unidade_medida.Lines = new string[0];
            this.lb_fundo_unidade_medida.Location = new System.Drawing.Point(16, 179);
            this.lb_fundo_unidade_medida.MaxLength = 32767;
            this.lb_fundo_unidade_medida.Multiline = true;
            this.lb_fundo_unidade_medida.Name = "lb_fundo_unidade_medida";
            this.lb_fundo_unidade_medida.PasswordChar = '\0';
            this.lb_fundo_unidade_medida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lb_fundo_unidade_medida.SelectedText = "";
            this.lb_fundo_unidade_medida.SelectionLength = 0;
            this.lb_fundo_unidade_medida.SelectionStart = 0;
            this.lb_fundo_unidade_medida.ShortcutsEnabled = true;
            this.lb_fundo_unidade_medida.Size = new System.Drawing.Size(179, 25);
            this.lb_fundo_unidade_medida.TabIndex = 12;
            this.lb_fundo_unidade_medida.UseSelectable = true;
            this.lb_fundo_unidade_medida.UseStyleColors = true;
            this.lb_fundo_unidade_medida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lb_fundo_unidade_medida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_quantidade.Location = new System.Drawing.Point(197, 158);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(87, 20);
            this.lb_quantidade.TabIndex = 13;
            this.lb_quantidade.Text = "Quantidade";
            this.lb_quantidade.UseStyleColors = true;
            // 
            // decTextBox1
            // 
            // 
            // 
            // 
            this.decTextBox1.CustomButton.Image = null;
            this.decTextBox1.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.decTextBox1.CustomButton.Name = "";
            this.decTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.decTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.decTextBox1.CustomButton.TabIndex = 1;
            this.decTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.decTextBox1.CustomButton.UseSelectable = true;
            this.decTextBox1.CustomButton.Visible = false;
            this.decTextBox1.Lines = new string[] {
        ",00"};
            this.decTextBox1.Location = new System.Drawing.Point(201, 180);
            this.decTextBox1.MaxLength = 32767;
            this.decTextBox1.Name = "decTextBox1";
            this.decTextBox1.PasswordChar = '\0';
            this.decTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.decTextBox1.SelectedText = "";
            this.decTextBox1.SelectionLength = 0;
            this.decTextBox1.SelectionStart = 0;
            this.decTextBox1.ShortcutsEnabled = true;
            this.decTextBox1.Size = new System.Drawing.Size(87, 23);
            this.decTextBox1.TabIndex = 14;
            this.decTextBox1.Text = ",00";
            this.decTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.decTextBox1.UseSelectable = true;
            this.decTextBox1.UseStyleColors = true;
            this.decTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.decTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_observacoes
            // 
            this.lb_observacoes.AutoSize = true;
            this.lb_observacoes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_observacoes.Location = new System.Drawing.Point(12, 207);
            this.lb_observacoes.Name = "lb_observacoes";
            this.lb_observacoes.Size = new System.Drawing.Size(93, 20);
            this.lb_observacoes.TabIndex = 15;
            this.lb_observacoes.Text = "Observações";
            this.lb_observacoes.UseStyleColors = true;
            // 
            // tb_observacoes
            // 
            // 
            // 
            // 
            this.tb_observacoes.CustomButton.Image = null;
            this.tb_observacoes.CustomButton.Location = new System.Drawing.Point(460, 2);
            this.tb_observacoes.CustomButton.Name = "";
            this.tb_observacoes.CustomButton.Size = new System.Drawing.Size(187, 187);
            this.tb_observacoes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_observacoes.CustomButton.TabIndex = 1;
            this.tb_observacoes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_observacoes.CustomButton.UseSelectable = true;
            this.tb_observacoes.CustomButton.Visible = false;
            this.tb_observacoes.Lines = new string[0];
            this.tb_observacoes.Location = new System.Drawing.Point(6, 231);
            this.tb_observacoes.MaxLength = 32767;
            this.tb_observacoes.Multiline = true;
            this.tb_observacoes.Name = "tb_observacoes";
            this.tb_observacoes.PasswordChar = '\0';
            this.tb_observacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_observacoes.SelectedText = "";
            this.tb_observacoes.SelectionLength = 0;
            this.tb_observacoes.SelectionStart = 0;
            this.tb_observacoes.ShortcutsEnabled = true;
            this.tb_observacoes.Size = new System.Drawing.Size(650, 192);
            this.tb_observacoes.TabIndex = 16;
            this.tb_observacoes.UseSelectable = true;
            this.tb_observacoes.UseStyleColors = true;
            this.tb_observacoes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_observacoes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // form_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 565);
            this.Controls.Add(this.tc_produto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_produtos";
            this.Text = "Produtos";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.tc_produto.ResumeLayout(false);
            this.tb_produto.ResumeLayout(false);
            this.tb_produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_produto;
        private System.Windows.Forms.TabPage tb_produto;
        private System.Windows.Forms.TabPage tp_caracteristicas;
        private System.Windows.Forms.TabPage tp_opcionais;
        private System.Windows.Forms.TabPage tp_adicionais;
        private MetroFramework.Controls.MetroLabel lb_codigo;
        private Int32TextBox itb_codigo;
        private MetroFramework.Controls.MetroLabel lb_descricao;
        private MetroFramework.Controls.MetroTextBox tb_descricao;
        private DecTextBox dtb_valor;
        private MetroFramework.Controls.MetroLabel lb_valor;
        private MetroFramework.Controls.MetroCheckBox cb_ativo;
        private MetroFramework.Controls.MetroLabel lb_grupo;
        private System.Windows.Forms.ComboBox cb_grupo;
        private MetroFramework.Controls.MetroTextBox tb_fundo_grupo;
        private System.Windows.Forms.ComboBox cb_unidade_pedida;
        private MetroFramework.Controls.MetroLabel lb_unidade_medida;
        private MetroFramework.Controls.MetroTextBox lb_fundo_unidade_medida;
        private MetroFramework.Controls.MetroLabel lb_quantidade;
        private DecTextBox decTextBox1;
        private MetroFramework.Controls.MetroTextBox tb_observacoes;
        private MetroFramework.Controls.MetroLabel lb_observacoes;
    }
}