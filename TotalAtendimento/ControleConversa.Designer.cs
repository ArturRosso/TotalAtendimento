namespace TotalAtendimento
{
    partial class ControleConversa
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
            this.lb_conversa = new System.Windows.Forms.Label();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.et_mensagem = new System.Windows.Forms.TextBox();
            this.rtb_conversa = new TotalAtendimento.rctbConversa();
            this.SuspendLayout();
            // 
            // lb_conversa
            // 
            this.lb_conversa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_conversa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_conversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conversa.Location = new System.Drawing.Point(0, 0);
            this.lb_conversa.Name = "lb_conversa";
            this.lb_conversa.Size = new System.Drawing.Size(727, 26);
            this.lb_conversa.TabIndex = 17;
            this.lb_conversa.Text = "Conversa";
            this.lb_conversa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_enviar.Enabled = false;
            this.bt_enviar.Location = new System.Drawing.Point(668, 224);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(60, 60);
            this.bt_enviar.TabIndex = 15;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            // 
            // et_mensagem
            // 
            this.et_mensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.et_mensagem.Enabled = false;
            this.et_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.et_mensagem.Location = new System.Drawing.Point(3, 224);
            this.et_mensagem.Multiline = true;
            this.et_mensagem.Name = "et_mensagem";
            this.et_mensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.et_mensagem.Size = new System.Drawing.Size(662, 60);
            this.et_mensagem.TabIndex = 14;
            // 
            // rtb_conversa
            // 
            this.rtb_conversa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_conversa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtb_conversa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_conversa.Location = new System.Drawing.Point(0, 26);
            this.rtb_conversa.Name = "rtb_conversa";
            this.rtb_conversa.ReadOnly = true;
            this.rtb_conversa.Size = new System.Drawing.Size(727, 191);
            this.rtb_conversa.TabIndex = 16;
            this.rtb_conversa.Text = "";
            // 
            // ControleConversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_conversa);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.et_mensagem);
            this.Controls.Add(this.rtb_conversa);
            this.Name = "ControleConversa";
            this.Size = new System.Drawing.Size(727, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_conversa;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.TextBox et_mensagem;
        private rctbConversa rtb_conversa;
    }
}
