﻿namespace Chat
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(9, 349);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(56, 37);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.Location = new System.Drawing.Point(9, 50);
            this.lb_chat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(390, 290);
            this.lb_chat.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(9, 5);
            this.lb_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(139, 43);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "The Chat";
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.Location = new System.Drawing.Point(77, 349);
            this.tb_mensagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mensagem.Multiline = true;
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(322, 37);
            this.tb_mensagem.TabIndex = 3;
            // 
            // lb_username
            // 
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(247, 27);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(140, 21);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "username";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_logged_as
            // 
            this.lb_logged_as.AutoSize = true;
            this.lb_logged_as.Location = new System.Drawing.Point(286, 7);
            this.lb_logged_as.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_logged_as.Name = "lb_logged_as";
            this.lb_logged_as.Size = new System.Drawing.Size(100, 13);
            this.lb_logged_as.TabIndex = 5;
            this.lb_logged_as.Text = "You\'re logged in as:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(179, 27);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 396);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_logged_as);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_mensagem);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.btnEnviar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox tb_username;
    }
}

