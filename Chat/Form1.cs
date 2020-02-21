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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_mensagem.Text.Length == 0 || tb_username.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
               {
                Mensagem mensagem = new Mensagem(DateTime.Now, tb_mensagem.Text, tb_username.Text);
                lb_chat.Items.Add(mensagem);
                lb_username.Text = tb_username.Text;
                tb_mensagem.Text = "";
            }
            }
        
    }
}
