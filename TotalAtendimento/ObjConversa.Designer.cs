namespace TotalAtendimento
{
    partial class ObjConversa
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
            this.et_mensagem = new MetroFramework.Controls.MetroTextBox();
            this.bt_enviar = new MetroFramework.Controls.MetroButton();
            this.lb_conversa = new MetroFramework.Controls.MetroLabel();
            this.tb_fundo = new MetroFramework.Controls.MetroTextBox();
            this.rtb_conversa = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // et_mensagem
            // 
            this.et_mensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.et_mensagem.CustomButton.Image = null;
            this.et_mensagem.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.et_mensagem.CustomButton.Name = "";
            this.et_mensagem.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.et_mensagem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.et_mensagem.CustomButton.TabIndex = 1;
            this.et_mensagem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.et_mensagem.CustomButton.UseSelectable = true;
            this.et_mensagem.CustomButton.Visible = false;
            this.et_mensagem.Enabled = false;
            this.et_mensagem.Lines = new string[0];
            this.et_mensagem.Location = new System.Drawing.Point(0, 295);
            this.et_mensagem.MaxLength = 32767;
            this.et_mensagem.Multiline = true;
            this.et_mensagem.Name = "et_mensagem";
            this.et_mensagem.PasswordChar = '\0';
            this.et_mensagem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.et_mensagem.SelectedText = "";
            this.et_mensagem.SelectionLength = 0;
            this.et_mensagem.SelectionStart = 0;
            this.et_mensagem.ShortcutsEnabled = true;
            this.et_mensagem.Size = new System.Drawing.Size(474, 63);
            this.et_mensagem.Style = MetroFramework.MetroColorStyle.Teal;
            this.et_mensagem.TabIndex = 4;
            this.et_mensagem.UseSelectable = true;
            this.et_mensagem.UseStyleColors = true;
            this.et_mensagem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.et_mensagem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.et_mensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.et_mensagem_KeyPress);
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_enviar.Enabled = false;
            this.bt_enviar.Location = new System.Drawing.Point(480, 295);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(68, 63);
            this.bt_enviar.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_enviar.TabIndex = 2;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseSelectable = true;
            this.bt_enviar.UseStyleColors = true;
            // 
            // lb_conversa
            // 
            this.lb_conversa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_conversa.BackColor = System.Drawing.SystemColors.Control;
            this.lb_conversa.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_conversa.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_conversa.Location = new System.Drawing.Point(1, 1);
            this.lb_conversa.Name = "lb_conversa";
            this.lb_conversa.Size = new System.Drawing.Size(545, 26);
            this.lb_conversa.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_conversa.TabIndex = 4;
            this.lb_conversa.Text = "Conversa";
            this.lb_conversa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_conversa.UseCustomBackColor = true;
            this.lb_conversa.UseStyleColors = true;
            // 
            // tb_fundo
            // 
            this.tb_fundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_fundo.CustomButton.Image = null;
            this.tb_fundo.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.tb_fundo.CustomButton.Name = "";
            this.tb_fundo.CustomButton.Size = new System.Drawing.Size(287, 287);
            this.tb_fundo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fundo.CustomButton.TabIndex = 1;
            this.tb_fundo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fundo.CustomButton.UseSelectable = true;
            this.tb_fundo.CustomButton.Visible = false;
            this.tb_fundo.Enabled = false;
            this.tb_fundo.Lines = new string[0];
            this.tb_fundo.Location = new System.Drawing.Point(0, 0);
            this.tb_fundo.MaxLength = 32767;
            this.tb_fundo.Multiline = true;
            this.tb_fundo.Name = "tb_fundo";
            this.tb_fundo.PasswordChar = '\0';
            this.tb_fundo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fundo.SelectedText = "";
            this.tb_fundo.SelectionLength = 0;
            this.tb_fundo.SelectionStart = 0;
            this.tb_fundo.ShortcutsEnabled = true;
            this.tb_fundo.Size = new System.Drawing.Size(548, 289);
            this.tb_fundo.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_fundo.TabIndex = 4;
            this.tb_fundo.UseSelectable = true;
            this.tb_fundo.UseStyleColors = true;
            this.tb_fundo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fundo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rtb_conversa
            // 
            this.rtb_conversa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_conversa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_conversa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_conversa.Location = new System.Drawing.Point(1, 30);
            this.rtb_conversa.Name = "rtb_conversa";
            this.rtb_conversa.ReadOnly = true;
            this.rtb_conversa.Size = new System.Drawing.Size(545, 258);
            this.rtb_conversa.TabIndex = 3;
            this.rtb_conversa.Text = "";
            // 
            // ObjConversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtb_conversa);
            this.Controls.Add(this.lb_conversa);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.et_mensagem);
            this.Controls.Add(this.tb_fundo);
            this.Name = "ObjConversa";
            this.Size = new System.Drawing.Size(548, 358);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox et_mensagem;
        private MetroFramework.Controls.MetroButton bt_enviar;
        private MetroFramework.Controls.MetroLabel lb_conversa;
        private MetroFramework.Controls.MetroTextBox tb_fundo;
        private System.Windows.Forms.RichTextBox rtb_conversa;
    }
}
