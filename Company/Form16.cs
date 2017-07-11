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
    public partial class Form16 : Form
    {
        public String Work_Order { get; private set; }
        private OleDbConnection connection = new OleDbConnection();
        Form2 _f2;
        public Form16(Form2 f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;Persist Security Info=False;";
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Hoist_Info_Sheet where " + this._f2.Search + " = '" + this._f2.Work_Order + "'";
            Console.WriteLine(this._f2.Search);
            OleDbDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                string ti1 = Convert.ToDateTime(data["P_O_Date"]).ToString("dd/MM/yyyy");
                string ti2 = Convert.ToDateTime(data["Delivery_Date"]).ToString("dd/MM/yyyy");
                txt_Delivery_Date.Text = DateTime.ParseExact(ti2, "dd/MM/yyyy", null).ToString();
                txt_P_O_Date.Text = DateTime.ParseExact(ti1, "dd/MM/yyyy", null).ToString();

                string company = data.GetString(0); txt_Company_Name.Text = company;
                string address = data.GetString(1); txt_Address.Text = address;
                string city = data.GetString(2); txt_City.Text = city;
                string state = data.GetString(3); txt_State.Text = state;
                string po = data.GetString(4); txt_PO_No.Text = po;
                string capacity = data.GetInt32(5).ToString(); txt_Capacity.Text = capacity;
                string hoistsize = data.GetString(6); txt_HoistSize.Text = hoistsize;
                string hoisttype = data.GetString(7); txt_HoistType.Text = hoisttype;
                string additionalfeature = data.GetString(8); txt_Add_Fea.Text = additionalfeature;
                string heightoflift = data.GetValue(9).ToString(); txt_HeightLift.Text = heightoflift;
                string hoistcode = data.GetString(10); txt_HoistCode.Text = hoistcode;
       
                string slno = data.GetValue(11).ToString(); txt_Sl_No.Text = slno;
                string wono = data.GetString(13); txt_WO_No.Text = wono;
                string hoistspeed = data.GetString(15); txt_HoistingSpeed.Text = hoistspeed;
                string gareboxstage = data.GetString(16); txt_GearBoxStages.Text = gareboxstage;
                string heatreatment = data.GetString(17); txt_HeatTreatment.Text = heatreatment;
                string fall = data.GetString(18); txt_Fall.Text = fall;
                string wirerope = data.GetString(19); txt_WireRope.Text = wirerope;
                string ropelength = data.GetString(20); txt_RopeLemght.Text = ropelength;
                string ropedrumdia = data.GetString(21); txt_RopeDrumDia.Text = ropedrumdia;
                string drumlenght = data.GetString(22); txt_DrumLenght.Text = drumlenght;
                string drumpitch = data.GetString(23); txt_DrumPitch.Text = drumpitch;
                string ropeguideid = data.GetString(24); txt_RopeGuideID.Text = ropeguideid;   
                string guidethreadpitch = data.GetString(25); txt_GuideThread_pitch.Text = guidethreadpitch;
                string guidethreadepth = data.GetString(26); txt_GuideThredDepth.Text = guidethreadepth;
                string ctspeed = data.GetString(27); txt_CTSpeed.Text = ctspeed;
                string ctgearbox = data.GetString(28); txt_CTGearBox.Text = ctgearbox;
                string nfgearbox = data.GetString(29); txt_NoOfGearBox.Text = nfgearbox;
                string ctwheel = data.GetString(30); txt_CTWheel.Text = ctwheel;
                string ctwheeltype = data.GetString(31); txt_CT_WheelType.Text = ctwheeltype;
                string nfctwheels = data.GetString(32); txt_NoOfCTWheel.Text = nfctwheels;
                string flagewidth = data.GetString(33); txt_FlangeWidth.Text = flagewidth;
                string sheavedia = data.GetValue(34).ToString(); txt_SheaveDia.Text = sheavedia;
                string nfsheave = data.GetValue(35).ToString(); txt_NoOfSheaves.Text = nfsheave;
                string sheavecover = data.GetValue(36).ToString(); txt_SheaveCovers.Text = sheavecover;
                string idlersheave = data.GetValue(37).ToString(); txt_IderSheaveDia.Text = idlersheave;
                string nfidlrsheave = data.GetValue(38).ToString(); txt_NoOfIdlerSheave.Text = nfidlrsheave;
                string hooktype = data.GetValue(39).ToString(); txt_HookType.Text = hooktype;
                string motormhsn = data.GetValue(40).ToString(); txt_Motor_MH_SlNo.Text = motormhsn;
                string motormhmake = data.GetValue(41).ToString(); txt_Motor_MH_MAKE.Text = motormhmake;
                string motorclsn = data.GetValue(42).ToString(); txt_Motor_CT_SlNo.Text = motorclsn;
                string motorclmake = data.GetValue(43).ToString(); txt_Motor_CT_MAKE.Text = motorclmake;
                string brakemhsn = data.GetValue(44).ToString(); txt_Bake_MH_SlNo.Text = brakemhsn;
                string brakemhmake = data.GetValue(45).ToString(); txt_Bake_MH_Make.Text = brakemhmake;
                string brakectsn = data.GetValue(46).ToString(); txt_Bake_CT_SlNo.Text = brakectsn;
                string brakectmake = data.GetValue(47).ToString(); txt_Bake_CT_Make.Text = brakectmake;
                string hostingtype = data.GetValue(48).ToString(); txt_Hoisting_Type.Text = hostingtype;
                string hoistingsn = data.GetValue(49).ToString(); txt_Hoisting_SlNo.Text = hoistingsn;
                string hoistingmake = data.GetValue(50).ToString(); txt_Hoisting_Make.Text = hoistingmake;
                string cttype = data.GetValue(51).ToString(); txt_CT_Type.Text = cttype;
                string ctslno = data.GetValue(52).ToString(); txt_CT_SlNo.Text = ctslno;
                string ctmake = data.GetValue(53).ToString(); txt_CT_Make.Text = ctmake;
                string controlpaneltype = data.GetValue(54).ToString(); txt_ControlPanel.Text = controlpaneltype;
                string controlpanelmake = data.GetValue(55).ToString(); txt_ControlPanelMake.Text = controlpanelmake;
                string pendenttype = data.GetValue(56).ToString(); txt_Pendent_Type.Text = pendenttype;
                string pendentmake = data.GetValue(57).ToString(); txt_PendentMake.Text = pendentmake;
                string vfdht = data.GetValue(58).ToString(); txt_HoistingType.Text = vfdht;
                string vfdhm = data.GetValue(59).ToString();txt_Hoisting_Model.Text = vfdhm;
                string vfdhmake = data.GetValue(60).ToString(); txt_HoistingMake.Text = vfdhmake;
                string vfdcttype = data.GetValue(61).ToString(); txt_CTModel.Text = vfdcttype;
                string vfdctmodel = data.GetValue(62).ToString(); txt_CTType.Text = vfdctmodel;
                string vfdctmake = data.GetValue(63).ToString(); txt_CTMake.Text = vfdctmake;
                string sales = data.GetValue(64).ToString(); txt_Sales.Text = sales;
                string fitter = data.GetValue(65).ToString(); txt_Fitter.Text = fitter;
                string engg = data.GetValue(66).ToString(); txt_Engg.Text = engg;
                string brakemhmodel = data.GetValue(67).ToString(); txt_Bake_MH_Model.Text = brakemhmodel;
                string brakemhtype = data.GetValue(68).ToString(); txt_Bake_MH_Type.Text = brakemhtype;
                string breakecttype = data.GetValue(69).ToString(); txt_Bake_CT_Type.Text = breakecttype;
                string breakectm = data.GetValue(70).ToString(); txt_Bake_CT_Model.Text = breakectm;
                string motorcthp = data.GetValue(71).ToString(); txt_Motor_CT_HP.Text = motorcthp;
                string motorctrpm = data.GetValue(72).ToString(); txt_Motor_CT_RPM.Text = motorctrpm;
                string motormhhp = data.GetValue(73).ToString(); txt_Motor_MH_HP.Text = motormhhp;
                string motormhrpm = data.GetValue(74).ToString(); txt_Motor_MH_RPM.Text = motormhrpm;


            }
            connection.Close();
        }

        private void txt_Delivery_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_Delivery_Date_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}