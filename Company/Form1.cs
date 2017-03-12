using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Company
{
    public partial class Form1 : Form
    {
       // public String Adm { get; private set; }
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            label2.Text = "Connection Succesfull";
            connection.Close();

        }

       
        private void button_Admin_Login_Click(object sender, EventArgs e)
        {
           
            
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Admin_User_Detail where UserName = '" + text_username.Text + "' and Password = '" + text_password.Text + "' and Identity LIKE '%Admin%' ";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    connection.Close();
                    connection.Dispose();
                    this.Hide();

                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Details");
                }

                connection.Close();
            
            
          
        }

        private void button_User_Login_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Admin_User_Detail where UserName = '" + text_username.Text + "' and Password = '" + text_password.Text + "' and Identity LIKE '%User%' ";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    connection.Close();
                    connection.Dispose();
                    this.Hide();

                    Form11 f11 = new Form11();
                    f11.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect Details");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            
        }
    }
}
