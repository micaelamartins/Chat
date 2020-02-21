namespace Chat
{
    partial class Form1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lb_chat = new System.Windows.Forms.ListBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_mensagem = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_logged_as = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 430);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 45);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.ItemHeight = 16;
            this.lb_chat.Location = new System.Drawing.Point(12, 62);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(519, 356);
            this.lb_chat.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 6);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(171, 53);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "The Chat";
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.Location = new System.Drawing.Point(103, 430);
            this.tb_mensagem.Multiline = true;
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(428, 45);
            this.tb_mensagem.TabIndex = 3;
            // 
            // lb_username
            // 
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(329, 33);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(187, 26);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "username";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_logged_as
            // 
            this.lb_logged_as.AutoSize = true;
            this.lb_logged_as.Location = new System.Drawing.Point(382, 9);
            this.lb_logged_as.Name = "lb_logged_as";
            this.lb_logged_as.Size = new System.Drawing.Size(134, 17);
            this.lb_logged_as.TabIndex = 5;
            this.lb_logged_as.Text = "You\'re logged in as:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 487);
            this.Controls.Add(this.lb_logged_as);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_mensagem);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lb_chat;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox tb_mensagem;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_logged_as;
    }
}

