using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.OleDb;

namespace Company
{
    public partial class Form7 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private ReportDocument reportDocument = new ReportDocument();
        Form4 _f4;
        public Form7(Form4 f4_)
        {
            InitializeComponent();
            this._f4 = f4_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Hoist_Work_Order where W_O_NO = '" + this._f4.Work_Order+"'";
                
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dataSet = new DataSet();
                //DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataSet, "Hoist_Work_Order");
                reportDocument.Load(@"E:\Company\Company\Hoist_Work_Order_Report.rpt");
                reportDocument.SetDataSource(dataSet);
                crystalReportViewer1.ReportSource = reportDocument;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
