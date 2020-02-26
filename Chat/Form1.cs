using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        public string conStr = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + @"DBQ=\\LAPTOP-DD74SLHJ\baseDados\BaseDados.xls;ReadOnly=0;";
        public string conStr2 = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + @"DBQ=\\DESKTOP-EJB4FV8\SharedDatabase\BaseDados.xls;ReadOnly=0;";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            OdbcConnection con = new OdbcConnection(conStr);
            con.Open();
            //string query
            string query = "select * from [Folha1$] ";

            OdbcCommand cmd = new OdbcCommand(query, con);

            dt.Load(cmd.ExecuteReader());
            List<DataRow> drList = dt.AsEnumerable().ToList();
            foreach (DataRow str in drList)
            {
                // Mensagem mensagem = new Mensagem(Date, "Select Mensagem From [Folha1$]", "Select Username From [Folha1$]"); ;
                String msgem = "(" + str.ItemArray[3].ToString() + ") " + str.ItemArray[1].ToString() + ": " + str.ItemArray[2].ToString();
                lb_chat.Items.Add(msgem);
            }
            con.Close();
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            //Checks if Enter key is pressed on the Textbox
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                //if shift is pressed, enter will paragraph
                if (e.Shift)
                {
                    tb_mensagem.AppendText(Environment.NewLine);
                }
                //if there is no username available enter will warn that it needs a username
                else if (tb_username.Text.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                //if message textbox is empty it wont do anything
                else if (string.IsNullOrWhiteSpace(tb_mensagem.Text));
                //if everything is ok successfully send message and save in database
                else
                {
                    Mensagem mensagem = new Mensagem(DateTime.Now, tb_mensagem.Text, tb_username.Text);
                    lb_chat.Items.Add(mensagem);
                    string username = tb_username.Text;
                    string message_text = tb_mensagem.Text;
                    lb_username.Text = username;
                    tb_mensagem.Text = "";

                    OdbcConnection con = new OdbcConnection(conStr);
                    OdbcConnection con2 = new OdbcConnection(conStr2);
                    con.Open();
                    con2.Open();

                    //string query
                    string query = "insert into [Folha1$] (Username, Mensagem, Data) values (?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(query, con);
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", message_text);
                    cmd.Parameters.AddWithValue("?", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    con2.Close();
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

