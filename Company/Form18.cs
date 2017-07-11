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
    public partial class Form18 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form18()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pass.Text == cpass.Text)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Admin_User_Detail (UserName, [Password],Designation) VALUES ('" + Name.Text + "','" + pass.Text + "','" + degis.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registered Succesfull");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
