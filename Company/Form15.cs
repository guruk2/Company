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
    public partial class Form15 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private ReportDocument reportDocument = new ReportDocument();
        Form6 _f6;
        public Form15(Form6 f6_)
        {
            InitializeComponent();
            this._f6 = f6_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Detail_Work where W_O_NO = '" + this._f6.Work_Order + "'";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dataSet = new DataSet();
                //DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataSet, "Spare_Work_Order");
                reportDocument.Load(@"E:\Company\Company\Spare_Work_Order.rpt");
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
