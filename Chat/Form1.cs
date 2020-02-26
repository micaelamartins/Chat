using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

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
          string conStr = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" +
         @"DBQ=C:\Users\Micaela\Desktop\BaseDados.xls;ReadOnly=0;";
            DataTable dt = new DataTable();
            

             OdbcConnection con = new OdbcConnection(conStr);
                con.Open();
            
            //string query
            string query = "";
            query = "select * from [Folha1$] ";
            //String query = "insert into [Folha1$] (Username, Mensagem, Data) values (?, ?, ?)";

            OdbcCommand cmd = new OdbcCommand(query, con);

            dt.Load(cmd.ExecuteReader());
            List<DataRow> drList = dt.AsEnumerable().ToList();
            foreach (DataRow str in drList)
            {
                // Mensagem mensagem = new Mensagem(Date, "Select Mensagem From [Folha1$]", "Select Username From [Folha1$]"); ;
                String msgem = "("+ str.ItemArray[3].ToString() + ") " + str.ItemArray[1].ToString() + ": " + str.ItemArray[2].ToString(); 
                lb_chat.Items.Add(msgem);
               

                
                
                
            }
            
            //lb_chat.DataSource = query.ToList();
            
            /*cmd.Parameters.AddWithValue("?", tb_mensagem.Text);
                cmd.Parameters.AddWithValue("?", tb_username.Text);
                cmd.Parameters.AddWithValue("?", DateTime.Now);
            //lb_chat.Items.Add(query);
            lb_chat.DataSource = query.ToList();
               
                */


            con.Close();

        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            string conStr = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" +
         @"DBQ=C:\Users\Micaela\Desktop\BaseDados.xls;ReadOnly=0;Header=True;";



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
                //tb_mensagem.Text = "";

                OdbcConnection con = new OdbcConnection(conStr);
                con.Open();

                //string query
                string query = "";
                query = "insert into [Folha1$] (Username, Mensagem, Data) values (?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.Parameters.AddWithValue("?", tb_username.Text);
                cmd.Parameters.AddWithValue("?", tb_mensagem.Text);
                cmd.Parameters.AddWithValue("?", DateTime.Now);
                cmd.ExecuteNonQuery();

                con.Close();

            }

            }
        }
        }

       
    }

