using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Form17 : Form
    {
        public String Work_Order { get; private set; }
        public String Search { get; private set; }
         private string seleced;
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // TODO: This line of code loads data into the 'dataSet1.Hoist_Work_Order' table. You can move, or remove it, as needed.
            this.hoist_Work_OrderTableAdapter.Fill(this.dataSet1.Hoist_Work_Order);


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

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = dataGridView1.SelectedCells[0].Value.ToString();
            Search = seleced;
            Work_Order = value;
            Form10 f10 = new Form10(this);
            f10.ShowDialog();
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
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
               seleced = (string)comboBox1.SelectedValue;
                
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

    }
}
