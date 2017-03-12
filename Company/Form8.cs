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
    public partial class Form8 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private ReportDocument reportDocument = new ReportDocument();
        Form2 _f2;
        public Form8(Form2 f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Hoist_Work_Order where W_O_NO = '" + this._f2.Work_Order + "' and Company_Name = '" + this._f2.Company_Name + "' and City = '" + this._f2.City1 + "' and Capacity = '" + this._f2.Capacity1 + "' and P_O = '" + this._f2.PO_No + "' and Sales_Rep = '" + this._f2.Sales + "' and Date BETWEEN '" + this._f2.Date_H_Start + "' AND '" + this._f2.Date_H_End + "' ";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dataSet = new DataSet();
                //DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataSet, "Hoist_Work_Order");
                reportDocument.Load(@"E:\Company\Company\CrystalReport1.rpt");
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
