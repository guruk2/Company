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
    public partial class Form6 : Form
    {
        public String Work_Order { get; private set; }
        private OleDbConnection connection = new OleDbConnection();

        public Form6()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;
Persist Security Info=False;";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Spare_Work_Order (Company_Name,W_O_NO,[Date],Address,City,State,P_O,P_O_Date,Contact_Person,Phone,TIN,Delivery_Date,Packing,Transportation,Sales_Rep,Despatch_Through,Delivery)" +
                    "values('" + txt_Company_Name.Text + "','" + txt_W_O_no.Text + "','" + txt_Date.Text + "','" + txt_Address.Text + "','" + txt_City.Text + "','" + txt_State.Text + "','" + txt_P_O_No.Text + "','" + txt_P_O_Date.Text + "','" + txt_Contact_Person.Text + "','" + txt_Phone.Text + "','" + txt_Tin.Text + "','" + txt_Delivery_Date.Text + "','" + comboBox24.Text + "','" + comboBox25.Text + "','" + comboBox26.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
                Work_Order = txt_W_O_no.Text;
                Form15 f15 = new Form15(this);
                f15.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
