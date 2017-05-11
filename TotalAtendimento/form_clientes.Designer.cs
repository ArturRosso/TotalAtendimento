namespace TotalAtendimento
{
    partial class form_clientes
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Desconectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Conectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup19 = new System.Windows.Forms.ListViewGroup("Desconectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup20 = new System.Windows.Forms.ListViewGroup("Conectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup21 = new System.Windows.Forms.ListViewGroup("Desconectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup22 = new System.Windows.Forms.ListViewGroup("Conectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup23 = new System.Windows.Forms.ListViewGroup("Desconectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup24 = new System.Windows.Forms.ListViewGroup("Conectados", System.Windows.Forms.HorizontalAlignment.Left);
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_notificacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obj_conversa = new TotalAtendimento.ObjConversa();
            this.obj_inf_cliente = new TotalAtendimento.ObjInfClientes();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lv_conexoes = new TotalAtendimento.lvConexao();
            this.bt_excluir_cliente = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Clientes";
            this.ch_nome.Width = 185;
            // 
            // ch_status
            // 
            this.ch_status.Text = "";
            this.ch_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_status.Width = 45;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "";
            this.ch_endereco.Width = 0;
            // 
            // ch_notificacoes
            // 
            this.ch_notificacoes.Text = "";
            this.ch_notificacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_notificacoes.Width = 30;
            // 
            // obj_conversa
            // 
            this.obj_conversa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obj_conversa.BackColor = System.Drawing.Color.White;
            this.obj_conversa.Location = new System.Drawing.Point(282, 269);
            this.obj_conversa.Name = "obj_conversa";
            this.obj_conversa.Size = new System.Drawing.Size(635, 281);
            this.obj_conversa.TabIndex = 5;
            // 
            // obj_inf_cliente
            // 
            this.obj_inf_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obj_inf_cliente.BackColor = System.Drawing.Color.White;
            this.obj_inf_cliente.Location = new System.Drawing.Point(282, 34);
            this.obj_inf_cliente.Name = "obj_inf_cliente";
            this.obj_inf_cliente.Size = new System.Drawing.Size(635, 229);
            this.obj_inf_cliente.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lv_conexoes
            // 
            this.lv_conexoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_conexoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_conexoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_conexoes.FullRowSelect = true;
            listViewGroup17.Header = "Desconectados";
            listViewGroup17.Name = "gp_desconectados";
            listViewGroup18.Header = "Conectados";
            listViewGroup18.Name = "gp_conectados";
            listViewGroup19.Header = "Desconectados";
            listViewGroup19.Name = "gp_desconectados";
            listViewGroup20.Header = "Conectados";
            listViewGroup20.Name = "gp_conectados";
            listViewGroup21.Header = "Desconectados";
            listViewGroup21.Name = "gp_desconectados";
            listViewGroup22.Header = "Conectados";
            listViewGroup22.Name = "gp_conectados";
            listViewGroup23.Header = "Desconectados";
            listViewGroup23.Name = "gp_desconectados";
            listViewGroup24.Header = "Conectados";
            listViewGroup24.Name = "gp_conectados";
            this.lv_conexoes.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup17,
            listViewGroup18,
            listViewGroup19,
            listViewGroup20,
            listViewGroup21,
            listViewGroup22,
            listViewGroup23,
            listViewGroup24});
            this.lv_conexoes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_conexoes.HideSelection = false;
            this.lv_conexoes.LabelWrap = false;
            this.lv_conexoes.Location = new System.Drawing.Point(12, 34);
            this.lv_conexoes.MultiSelect = false;
            this.lv_conexoes.Name = "lv_conexoes";
            this.lv_conexoes.OwnerDraw = true;
            this.lv_conexoes.Size = new System.Drawing.Size(264, 477);
            this.lv_conexoes.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lv_conexoes.Style = MetroFramework.MetroColorStyle.Teal;
            this.lv_conexoes.TabIndex = 2;
            this.lv_conexoes.UseCompatibleStateImageBehavior = false;
            this.lv_conexoes.UseCustomBackColor = true;
            this.lv_conexoes.UseCustomForeColor = true;
            this.lv_conexoes.UseSelectable = true;
            this.lv_conexoes.View = System.Windows.Forms.View.Details;
            this.lv_conexoes.ScrollPositionChanged += new MetroFramework.Controls.MetroListView.ScrollPositionChangedDelegate(this.lv_conexoes_ScrollPositionChanged);
            this.lv_conexoes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_conexoes_ItemSelectionChanged);
            this.lv_conexoes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lv_conexoes_MouseUp);
            // 
            // bt_excluir_cliente
            // 
            this.bt_excluir_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_excluir_cliente.Enabled = false;
            this.bt_excluir_cliente.Location = new System.Drawing.Point(12, 520);
            this.bt_excluir_cliente.Name = "bt_excluir_cliente";
            this.bt_excluir_cliente.Size = new System.Drawing.Size(264, 30);
            this.bt_excluir_cliente.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_excluir_cliente.TabIndex = 6;
            this.bt_excluir_cliente.Text = "Excluir Cliente";
            this.bt_excluir_cliente.UseSelectable = true;
            this.bt_excluir_cliente.UseStyleColors = true;
            this.bt_excluir_cliente.Click += new System.EventHandler(this.bt_excluir_cliente_Click);
            // 
            // form_clientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 562);
            this.Controls.Add(this.bt_excluir_cliente);
            this.Controls.Add(this.lv_conexoes);
            this.Controls.Add(this.obj_inf_cliente);
            this.Controls.Add(this.obj_conversa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(766, 562);
            this.Name = "form_clientes";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_clientes_FormClosing);
            this.Resize += new System.EventHandler(this.form_clientes_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_status;
        private System.Windows.Forms.ColumnHeader ch_endereco;
        private System.Windows.Forms.ColumnHeader ch_notificacoes;
        private ObjConversa obj_conversa;
        private ObjInfClientes obj_inf_cliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private lvConexao lv_conexoes;
        private MetroFramework.Controls.MetroButton bt_excluir_cliente;
    }
}

