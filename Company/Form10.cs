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
    public partial class Form10 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private ReportDocument reportDocument = new ReportDocument();
        Form2 _f2;
        public Form10(Form2 f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        Form17 _f17;
        public Form10(Form17 f17_)
        {
            InitializeComponent();
            this._f17 = f17_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Hoist_Work_Order where "+ this._f2.Search +" = '" + this._f2.Work_Order + "'"; //and Company_Name = '" + this._f2.Company_Name_I + "' and City = '" + this._f2.City_I + "' and Sl_no = '" + this._f2.Sl_No_I + "' and P_O = '" + this._f2.PO_No_I + "' and Sales_Rep = '" + this._f2.Sales_I + "' and Date BETWEEN '" + this._f2.Date_Start + "' AND '" + this._f2.Date_End + "' "
                
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
