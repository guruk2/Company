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
    public partial class Form2 : Form
    {
        public String Work_Order { get; private set;    }
        public String Company_Name { get; private set; }
        public String City1 { get; private set; }
        public String Capacity1 { get; private set; }
        public String PO_No { get; private set; }
        public String Sales { get; private set; }
        public String Date_H_Start { get; private set; }
        public String Date_H_End { get; private set; }
        public String Work_Order_I { get; private set; }
        public String Company_Name_I { get; private set; }
        public String City_I { get; private set; }
        public String Sl_No_I { get; private set; }
        public String PO_No_I { get; private set; }
        public String Sales_I { get; private set; }
        public String Date_Start { get; private set; }
        public String Date_End { get; private set; }
        public String Work_Order_S { get; private set; }
        public String Company_Name_S { get; private set; }
        public String City_S { get; private set; }
        public String PO_No_S { get; private set; }
        public String Sales_S { get; private set; }
        public String Date_Start_S { get; private set; }
        public String Date_End_S { get; private set; }
        public String Search { get; private set; }
       
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb");
  
        private string seleced;
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

              
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_I_SL_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            this.dataGridView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDown);
            // TODO: This line of code loads data into the 'dataSet1.Hoist_Info_Sheet' table. You can move, or remove it, as needed.
            this.hoist_Info_SheetTableAdapter.Fill(this.dataSet1.Hoist_Info_Sheet);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
           // this.deleToolStripMenuItem.Click += new System.EventHandler(this.DeleteRow_Click);
            // TODO: This line of code loads data into the 'dataSet1.Detail_Work' table. You can move, or remove it, as needed.
             this.Hoist_Work_OrderTableAdapter.Fill(this.dataSet1.Hoist_Work_Order);
            
            connection.Open();
 
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Company_Name", "Company Name");
            test.Add("City", "City");
            test.Add("State", "State");
            test.Add("W_O_NO", "Work order No");
            test.Add("P_O", "P.O No");
            test.Add("Dispatched_Status", "Dispatch status");

            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            Dictionary<string, string> test1 = new Dictionary<string, string>();
            test1.Add("Company_Name", "Company Name");
            test1.Add("City", "City");
            test1.Add("W_O_NO", "Work order No");
            test1.Add("P_O", "P.O No");
            test1.Add("Sl_no", "Sl No");

            comboBox2.DataSource = new BindingSource(test1, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DataView DV = new DataView(this.dataSet1.Hoist_Work_Order);
                DV.RowFilter = string.Format(seleced + " LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error textbox1");
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                 if (comboBox1.SelectedIndex == 0)
                 {
                     seleced = "Company_Name";
                 }
                 else
                 {
                     seleced = (string)comboBox1.SelectedValue;
                 }
               
            }
            catch (Exception ex)
            {
               
            }
        }
       
       

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hti.RowIndex].Selected = true;
        
                DataGridViewRow clickedRow = (sender as DataGridView).Rows[hti.RowIndex]; 
                if (!clickedRow.Selected)
                    dataGridView1.CurrentCell = clickedRow.Cells[hti.ColumnIndex];

                var mousePosition = dataGridView1.PointToClient(Cursor.Position);

                contextMenuStrip1.Show(dataGridView1, mousePosition);
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            dataGridView1.Rows.RemoveAt(rowToDelete);
            dataGridView1.ClearSelection();
        }

        private void deleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            dataGridView1.Rows.RemoveAt(rowToDelete);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value;
            Form13 f13 = new Form13(this);
            Search = seleced;
            value = dataGridView1.SelectedCells[comboBox1.SelectedIndex].Value.ToString();
            Work_Order = value;
            f13.Show();
        }


     

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value;
            Form10 f10 = new Form10(this);
            Search = seleced;
            value = dataGridView1.SelectedCells[comboBox1.SelectedIndex].Value.ToString();
            Work_Order = value;
            f10.Show();          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(this.dataSet1.Hoist_Info_Sheet);
                DV.RowFilter = string.Format(seleced + " LIKE '%{0}%'", textBox2.Text);
                dataGridView2.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error textbox2");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    seleced = "Company_Name";
                }
                else
                {
                    seleced = (string)comboBox2.SelectedValue;
                }
               ;
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView2.HitTest(e.X, e.Y);
                dataGridView2.ClearSelection();
                dataGridView2.Rows[hti.RowIndex].Selected = true;

                DataGridViewRow clickedRow = (sender as DataGridView).Rows[hti.RowIndex];
                if (!clickedRow.Selected)
                    dataGridView2.CurrentCell = clickedRow.Cells[hti.ColumnIndex];

                var mousePosition = dataGridView2.PointToClient(Cursor.Position);

                contextMenuStrip2.Show(dataGridView2, mousePosition);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            dataGridView2.Rows.RemoveAt(rowToDelete);
            dataGridView2.ClearSelection();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = dataGridView2.SelectedCells[0].Value.ToString();
            Search = seleced;
            Work_Order = value;
            Form12 f12 = new Form12(this);
            f12.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value;
            Form16 f16 = new Form16(this);
            Search = seleced;
            value = dataGridView2.SelectedCells[comboBox2.SelectedIndex].Value.ToString();
            Work_Order = value;
            f16.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
