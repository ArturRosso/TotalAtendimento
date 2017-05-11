namespace TotalAtendimento
{
    partial class ObjInfClientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_status = new System.Windows.Forms.Panel();
            this.lb_status = new System.Windows.Forms.Label();
            this.pn_nome = new System.Windows.Forms.Panel();
            this.pn_mesa = new System.Windows.Forms.Panel();
            this.gr_pedidos = new MetroFramework.Controls.MetroGrid();
            this.lb_pedidos = new MetroFramework.Controls.MetroLabel();
            this.lb_fundo = new MetroFramework.Controls.MetroTextBox();
            this.tb_fundo_nome = new MetroFramework.Controls.MetroTextBox();
            this.lb_nome = new MetroFramework.Controls.MetroLabel();
            this.lb_nome_descricao = new MetroFramework.Controls.MetroLabel();
            this.tb_fundo_status = new MetroFramework.Controls.MetroTextBox();
            this.tb_fundo_mesa = new MetroFramework.Controls.MetroTextBox();
            this.lb_status_descricao = new MetroFramework.Controls.MetroLabel();
            this.lb_mesa_descricao = new MetroFramework.Controls.MetroLabel();
            this.lb_mesa = new MetroFramework.Controls.MetroLabel();
            this.pn_status.SuspendLayout();
            this.pn_nome.SuspendLayout();
            this.pn_mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_status
            // 
            this.pn_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_status.BackColor = System.Drawing.SystemColors.Control;
            this.pn_status.Controls.Add(this.lb_status_descricao);
            this.pn_status.Controls.Add(this.lb_status);
            this.pn_status.Controls.Add(this.tb_fundo_status);
            this.pn_status.Location = new System.Drawing.Point(0, 28);
            this.pn_status.Name = "pn_status";
            this.pn_status.Size = new System.Drawing.Size(867, 26);
            this.pn_status.TabIndex = 13;
            // 
            // lb_status
            // 
            this.lb_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(82, 1);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(783, 24);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "Desconectado";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pn_nome
            // 
            this.pn_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_nome.BackColor = System.Drawing.SystemColors.Control;
            this.pn_nome.Controls.Add(this.lb_nome_descricao);
            this.pn_nome.Controls.Add(this.lb_nome);
            this.pn_nome.Controls.Add(this.tb_fundo_nome);
            this.pn_nome.Location = new System.Drawing.Point(0, 0);
            this.pn_nome.Name = "pn_nome";
            this.pn_nome.Size = new System.Drawing.Size(867, 26);
            this.pn_nome.TabIndex = 12;
            // 
            // pn_mesa
            // 
            this.pn_mesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_mesa.BackColor = System.Drawing.SystemColors.Control;
            this.pn_mesa.Controls.Add(this.lb_mesa);
            this.pn_mesa.Controls.Add(this.lb_mesa_descricao);
            this.pn_mesa.Controls.Add(this.tb_fundo_mesa);
            this.pn_mesa.Location = new System.Drawing.Point(0, 56);
            this.pn_mesa.Name = "pn_mesa";
            this.pn_mesa.Size = new System.Drawing.Size(867, 26);
            this.pn_mesa.TabIndex = 14;
            // 
            // gr_pedidos
            // 
            this.gr_pedidos.AllowUserToAddRows = false;
            this.gr_pedidos.AllowUserToDeleteRows = false;
            this.gr_pedidos.AllowUserToResizeColumns = false;
            this.gr_pedidos.AllowUserToResizeRows = false;
            this.gr_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gr_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gr_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gr_pedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gr_pedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gr_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gr_pedidos.ColumnHeadersHeight = 20;
            this.gr_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gr_pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gr_pedidos.EnableHeadersVisualStyles = false;
            this.gr_pedidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gr_pedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gr_pedidos.Location = new System.Drawing.Point(1, 114);
            this.gr_pedidos.MultiSelect = false;
            this.gr_pedidos.Name = "gr_pedidos";
            this.gr_pedidos.ReadOnly = true;
            this.gr_pedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gr_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gr_pedidos.RowHeadersVisible = false;
            this.gr_pedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gr_pedidos.RowTemplate.Height = 24;
            this.gr_pedidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gr_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gr_pedidos.Size = new System.Drawing.Size(863, 294);
            this.gr_pedidos.Style = MetroFramework.MetroColorStyle.Teal;
            this.gr_pedidos.TabIndex = 16;
            this.gr_pedidos.UseStyleColors = true;
            this.gr_pedidos.Resize += new System.EventHandler(this.gr_pedidos_Resize);
            // 
            // lb_pedidos
            // 
            this.lb_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pedidos.BackColor = System.Drawing.SystemColors.Control;
            this.lb_pedidos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_pedidos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_pedidos.Location = new System.Drawing.Point(1, 85);
            this.lb_pedidos.Name = "lb_pedidos";
            this.lb_pedidos.Size = new System.Drawing.Size(864, 26);
            this.lb_pedidos.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_pedidos.TabIndex = 17;
            this.lb_pedidos.Text = "Pedidos";
            this.lb_pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_pedidos.UseCustomBackColor = true;
            this.lb_pedidos.UseStyleColors = true;
            // 
            // lb_fundo
            // 
            this.lb_fundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lb_fundo.CustomButton.Image = null;
            this.lb_fundo.CustomButton.Location = new System.Drawing.Point(543, 1);
            this.lb_fundo.CustomButton.Name = "";
            this.lb_fundo.CustomButton.Size = new System.Drawing.Size(323, 323);
            this.lb_fundo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lb_fundo.CustomButton.TabIndex = 1;
            this.lb_fundo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lb_fundo.CustomButton.UseSelectable = true;
            this.lb_fundo.CustomButton.Visible = false;
            this.lb_fundo.Enabled = false;
            this.lb_fundo.Lines = new string[0];
            this.lb_fundo.Location = new System.Drawing.Point(0, 84);
            this.lb_fundo.MaxLength = 32767;
            this.lb_fundo.Multiline = true;
            this.lb_fundo.Name = "lb_fundo";
            this.lb_fundo.PasswordChar = '\0';
            this.lb_fundo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lb_fundo.SelectedText = "";
            this.lb_fundo.SelectionLength = 0;
            this.lb_fundo.SelectionStart = 0;
            this.lb_fundo.ShortcutsEnabled = true;
            this.lb_fundo.Size = new System.Drawing.Size(867, 325);
            this.lb_fundo.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_fundo.TabIndex = 18;
            this.lb_fundo.UseSelectable = true;
            this.lb_fundo.UseStyleColors = true;
            this.lb_fundo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lb_fundo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_fundo_nome
            // 
            this.tb_fundo_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_fundo_nome.CustomButton.Image = null;
            this.tb_fundo_nome.CustomButton.Location = new System.Drawing.Point(843, 2);
            this.tb_fundo_nome.CustomButton.Name = "";
            this.tb_fundo_nome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_fundo_nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fundo_nome.CustomButton.TabIndex = 1;
            this.tb_fundo_nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fundo_nome.CustomButton.UseSelectable = true;
            this.tb_fundo_nome.CustomButton.Visible = false;
            this.tb_fundo_nome.Enabled = false;
            this.tb_fundo_nome.Lines = new string[0];
            this.tb_fundo_nome.Location = new System.Drawing.Point(0, 0);
            this.tb_fundo_nome.MaxLength = 32767;
            this.tb_fundo_nome.Multiline = true;
            this.tb_fundo_nome.Name = "tb_fundo_nome";
            this.tb_fundo_nome.PasswordChar = '\0';
            this.tb_fundo_nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fundo_nome.SelectedText = "";
            this.tb_fundo_nome.SelectionLength = 0;
            this.tb_fundo_nome.SelectionStart = 0;
            this.tb_fundo_nome.ShortcutsEnabled = true;
            this.tb_fundo_nome.Size = new System.Drawing.Size(867, 26);
            this.tb_fundo_nome.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_fundo_nome.TabIndex = 19;
            this.tb_fundo_nome.UseCustomBackColor = true;
            this.tb_fundo_nome.UseSelectable = true;
            this.tb_fundo_nome.UseStyleColors = true;
            this.tb_fundo_nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fundo_nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_nome
            // 
            this.lb_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nome.BackColor = System.Drawing.SystemColors.Control;
            this.lb_nome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_nome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_nome.Location = new System.Drawing.Point(82, 1);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(783, 24);
            this.lb_nome.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_nome.TabIndex = 19;
            this.lb_nome.Text = "Nome";
            this.lb_nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_nome.UseCustomBackColor = true;
            this.lb_nome.UseStyleColors = true;
            // 
            // lb_nome_descricao
            // 
            this.lb_nome_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_nome_descricao.BackColor = System.Drawing.SystemColors.Control;
            this.lb_nome_descricao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_nome_descricao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_nome_descricao.Location = new System.Drawing.Point(1, 1);
            this.lb_nome_descricao.Name = "lb_nome_descricao";
            this.lb_nome_descricao.Size = new System.Drawing.Size(63, 24);
            this.lb_nome_descricao.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_nome_descricao.TabIndex = 20;
            this.lb_nome_descricao.Text = "Nome";
            this.lb_nome_descricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nome_descricao.UseCustomBackColor = true;
            this.lb_nome_descricao.UseStyleColors = true;
            // 
            // tb_fundo_status
            // 
            this.tb_fundo_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_fundo_status.CustomButton.Image = null;
            this.tb_fundo_status.CustomButton.Location = new System.Drawing.Point(843, 2);
            this.tb_fundo_status.CustomButton.Name = "";
            this.tb_fundo_status.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_fundo_status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fundo_status.CustomButton.TabIndex = 1;
            this.tb_fundo_status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fundo_status.CustomButton.UseSelectable = true;
            this.tb_fundo_status.CustomButton.Visible = false;
            this.tb_fundo_status.Enabled = false;
            this.tb_fundo_status.Lines = new string[0];
            this.tb_fundo_status.Location = new System.Drawing.Point(0, 0);
            this.tb_fundo_status.MaxLength = 32767;
            this.tb_fundo_status.Multiline = true;
            this.tb_fundo_status.Name = "tb_fundo_status";
            this.tb_fundo_status.PasswordChar = '\0';
            this.tb_fundo_status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fundo_status.SelectedText = "";
            this.tb_fundo_status.SelectionLength = 0;
            this.tb_fundo_status.SelectionStart = 0;
            this.tb_fundo_status.ShortcutsEnabled = true;
            this.tb_fundo_status.Size = new System.Drawing.Size(867, 26);
            this.tb_fundo_status.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_fundo_status.TabIndex = 21;
            this.tb_fundo_status.UseCustomBackColor = true;
            this.tb_fundo_status.UseSelectable = true;
            this.tb_fundo_status.UseStyleColors = true;
            this.tb_fundo_status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fundo_status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_fundo_mesa
            // 
            this.tb_fundo_mesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_fundo_mesa.CustomButton.Image = null;
            this.tb_fundo_mesa.CustomButton.Location = new System.Drawing.Point(843, 2);
            this.tb_fundo_mesa.CustomButton.Name = "";
            this.tb_fundo_mesa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_fundo_mesa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fundo_mesa.CustomButton.TabIndex = 1;
            this.tb_fundo_mesa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fundo_mesa.CustomButton.UseSelectable = true;
            this.tb_fundo_mesa.CustomButton.Visible = false;
            this.tb_fundo_mesa.Enabled = false;
            this.tb_fundo_mesa.Lines = new string[0];
            this.tb_fundo_mesa.Location = new System.Drawing.Point(0, 0);
            this.tb_fundo_mesa.MaxLength = 32767;
            this.tb_fundo_mesa.Multiline = true;
            this.tb_fundo_mesa.Name = "tb_fundo_mesa";
            this.tb_fundo_mesa.PasswordChar = '\0';
            this.tb_fundo_mesa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fundo_mesa.SelectedText = "";
            this.tb_fundo_mesa.SelectionLength = 0;
            this.tb_fundo_mesa.SelectionStart = 0;
            this.tb_fundo_mesa.ShortcutsEnabled = true;
            this.tb_fundo_mesa.Size = new System.Drawing.Size(867, 26);
            this.tb_fundo_mesa.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_fundo_mesa.TabIndex = 22;
            this.tb_fundo_mesa.UseCustomBackColor = true;
            this.tb_fundo_mesa.UseSelectable = true;
            this.tb_fundo_mesa.UseStyleColors = true;
            this.tb_fundo_mesa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fundo_mesa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_status_descricao
            // 
            this.lb_status_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_status_descricao.BackColor = System.Drawing.SystemColors.Control;
            this.lb_status_descricao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_status_descricao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_status_descricao.Location = new System.Drawing.Point(1, 1);
            this.lb_status_descricao.Name = "lb_status_descricao";
            this.lb_status_descricao.Size = new System.Drawing.Size(63, 24);
            this.lb_status_descricao.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_status_descricao.TabIndex = 21;
            this.lb_status_descricao.Text = "Status";
            this.lb_status_descricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_status_descricao.UseCustomBackColor = true;
            this.lb_status_descricao.UseStyleColors = true;
            // 
            // lb_mesa_descricao
            // 
            this.lb_mesa_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_mesa_descricao.BackColor = System.Drawing.SystemColors.Control;
            this.lb_mesa_descricao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_mesa_descricao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_mesa_descricao.Location = new System.Drawing.Point(1, 1);
            this.lb_mesa_descricao.Name = "lb_mesa_descricao";
            this.lb_mesa_descricao.Size = new System.Drawing.Size(83, 24);
            this.lb_mesa_descricao.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_mesa_descricao.TabIndex = 22;
            this.lb_mesa_descricao.Text = "N° Mesa";
            this.lb_mesa_descricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_mesa_descricao.UseCustomBackColor = true;
            this.lb_mesa_descricao.UseStyleColors = true;
            // 
            // lb_mesa
            // 
            this.lb_mesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mesa.BackColor = System.Drawing.SystemColors.Control;
            this.lb_mesa.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_mesa.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_mesa.Location = new System.Drawing.Point(82, 1);
            this.lb_mesa.Name = "lb_mesa";
            this.lb_mesa.Size = new System.Drawing.Size(783, 24);
            this.lb_mesa.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_mesa.TabIndex = 21;
            this.lb_mesa.Text = "Desconhecido";
            this.lb_mesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_mesa.UseCustomBackColor = true;
            this.lb_mesa.UseStyleColors = true;
            // 
            // ObjInfClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_pedidos);
            this.Controls.Add(this.gr_pedidos);
            this.Controls.Add(this.pn_mesa);
            this.Controls.Add(this.pn_status);
            this.Controls.Add(this.pn_nome);
            this.Controls.Add(this.lb_fundo);
            this.Name = "ObjInfClientes";
            this.Size = new System.Drawing.Size(867, 412);
            this.pn_status.ResumeLayout(false);
            this.pn_nome.ResumeLayout(false);
            this.pn_mesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gr_pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Panel pn_nome;
        private System.Windows.Forms.Panel pn_mesa;
        private MetroFramework.Controls.MetroGrid gr_pedidos;
        private MetroFramework.Controls.MetroLabel lb_pedidos;
        private MetroFramework.Controls.MetroTextBox lb_fundo;
        private MetroFramework.Controls.MetroTextBox tb_fundo_nome;
        private MetroFramework.Controls.MetroLabel lb_nome;
        private MetroFramework.Controls.MetroLabel lb_nome_descricao;
        private MetroFramework.Controls.MetroLabel lb_status_descricao;
        private MetroFramework.Controls.MetroTextBox tb_fundo_status;
        private MetroFramework.Controls.MetroTextBox tb_fundo_mesa;
        private MetroFramework.Controls.MetroLabel lb_mesa_descricao;
        private MetroFramework.Controls.MetroLabel lb_mesa;
    }
}
