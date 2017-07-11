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
    public partial class Form9 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private ReportDocument reportDocument = new ReportDocument();
        Form5 _f5;
        public Form9(Form5 f5_)
        {
            InitializeComponent();
            this._f5 = f5_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Hoist_Info_Sheet where W_O_NO = '" + this._f5.Work + "'";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dataSet = new DataSet();
                //DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataSet, "Detail_Work");
                reportDocument.Load(@"E:\Company\Company\Hoist_Information_Sheet.rpt");
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
