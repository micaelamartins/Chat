using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_username.Text = "";

        }
        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        tb_mensagem.AppendText(Environment.NewLine);
                    }
                }
                else if (tb_username.Text.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                if (string.IsNullOrWhiteSpace(tb_mensagem.Text))
                {
                }
                else
                {
                    Mensagem mensagem = new Mensagem(DateTime.Now, tb_mensagem.Text, tb_username.Text);
                    lb_chat.Items.Add(mensagem);
                    lb_username.Text = tb_username.Text;
                    tb_mensagem.Clear();
                }
            }
        }
        private void lb_chat_DoubleClick(object sender, EventArgs e)
        {
            //Check if message was sent by user
            //Allows to delete
        }
    }
}
