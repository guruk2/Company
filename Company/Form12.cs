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
    public partial class Form12 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private ReportDocument reportDocument = new ReportDocument();
        Form2 _f2;
        public Form12(Form2 f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Company\Database1.mdb";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Hoist_Info_Sheet where " + this._f2.Search + " = '" + this._f2.Work_Order + "'";           //W_O_NO = '" + this._f2.Work_Order_S + "' and Company_Name = '" + this._f2.Company_Name_S + "' and City = '" + this._f2.City_S + "' and P_O = '" + this._f2.PO_No_S + "' and Sales_Rep = '" + this._f2.Sales_S + "' and Date BETWEEN '" + this._f2.Date_Start_S+ "' AND '" + this._f2.Date_End_S + "' "

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dataSet = new DataSet();
                //DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataSet, "Detail_Work");
                reportDocument.Load(@"E:\Company-master\Company\Hoist_Information_Sheet.rpt");
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
