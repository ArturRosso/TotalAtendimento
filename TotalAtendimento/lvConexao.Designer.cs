namespace TotalAtendimento
{
    partial class lvConexao
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Desconectados", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Conectados", System.Windows.Forms.HorizontalAlignment.Left);
            this.ch_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_notificacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_mesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ch_nome
            // 
            this.ch_nome.Text = "Clientes";
            this.ch_nome.Width = 216;
            // 
            // ch_status
            // 
            this.ch_status.Text = "";
            this.ch_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_status.Width = 0;
            // 
            // ch_notificacoes
            // 
            this.ch_notificacoes.Text = "";
            this.ch_notificacoes.Width = 30;
            // 
            // ch_endereco
            // 
            this.ch_endereco.Text = "";
            this.ch_endereco.Width = 0;
            // 
            // ch_mesa
            // 
            this.ch_mesa.Text = "";
            this.ch_mesa.Width = 0;
            // 
            // lvConexao
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_nome,
            this.ch_status,
            this.ch_notificacoes,
            this.ch_endereco,
            this.ch_mesa});
            listViewGroup1.Header = "Desconectados";
            listViewGroup1.Name = "gp_desconectados";
            listViewGroup2.Header = "Conectados";
            listViewGroup2.Name = "gp_conectados";
            this.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HideSelection = false;
            this.LabelWrap = false;
            this.MultiSelect = false;
            this.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.View = System.Windows.Forms.View.Details;
            this.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvConexao_ColumnWidthChanging);
            this.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvConexao_ItemSelectionChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ch_nome;
        private System.Windows.Forms.ColumnHeader ch_status;
        private System.Windows.Forms.ColumnHeader ch_notificacoes;
        private System.Windows.Forms.ColumnHeader ch_endereco;
        private System.Windows.Forms.ColumnHeader ch_mesa;
    }
}
