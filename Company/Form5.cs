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
    public partial class Form5 : Form
    {
        public String Work { get; private set; }
        private OleDbConnection connection = new OleDbConnection();
        Form4 _f4;
        public Form5(Form4 f4_)
        {
            InitializeComponent();
            this._f4 = f4_;
            txt_Company_Name.Text = this._f4.Company_Name;
            txt_Address.Text = this._f4.Address;
            txt_City.Text = this._f4.City;
            txt_State.Text = this._f4.State;
            txt_WO_No.Text = this._f4.Work_O;
            txt_PO_No.Text = this._f4.P_O_No;
            txt_PO_Date.Text = this._f4.P_O_Date;
            txt_Capacity.Text = this._f4.Capacity;
            txt_HoistSize.Text = this._f4.Hoist_Size;
            txt_HeightLift.Text = this._f4.Hoist_Lift;
            txt_HoistType.Text = this._f4.Hoist_Type;
            txt_HoistCode.Text = this._f4.Hoist_Code;
            txt_Add_Fea.Text = this._f4.Add_F;
            txt_HoistingSpeed.Text = this._f4.Hoisting_Speed;
            txt_Fall.Text = this._f4.Fall;
            txt_WireRope.Text = this._f4.Wire_Rope;
            txt_CTSpeed.Text = this._f4.CT_Speed;
            txt_CTGearBox.Text = this._f4.CT_Gear_Box;
            txt_CTWheel.Text = this._f4.CT_Wheel;
            txt_CT_WheelType.Text = this._f4.CT_Wheel_Type;
            txt_FlangeWidth.Text = this._f4.Flange_Width;
            txt_Motor_MH_HP.Text = this._f4.Motor_MH_Hp;
            txt_Motor_MH_RPM.Text = this._f4.Motor_MH_Rpm;
            txt_Motor_CT_HP.Text = this._f4.Motor_CT_Hp;
            txt_Motor_CT_RPM.Text = this._f4.Motor_CT_Rpm;
            txt_Bake_MH_Type.Text = this._f4.Brake_MH_Type;
            txt_Bake_MH_Model.Text = this._f4.Brake_MH_Model;
            txt_Bake_CT_Type.Text = this._f4.Brake_CT_Type;
            txt_Bake_CT_Model.Text = this._f4.Brake_CT_Model;
            txt_Sales.Text = this._f4.Sales;
            txt_DeliveryDate.Text = this._f4.Delivery_date;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;
Persist Security Info=False;";

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Hoist_Info_Sheet (Sl_no,Company_Name,W_O_NO,Address,City,State,P_O,P_O_Date,Delivery_Date,Capacity,Hoist_Size,Height_of_lift,Fall,Hoist_Code,Hoist_Type,Additional_Feature,Hoisting_Speed,Motor_MH_HP,Motor_MH_RPM,Brake_MH_Model,Wire_Rope,CT_Speed,Motor_CT_HP,Motor_CT_RPM,Brake_CT_Model,CT_Gear_Box,CT_Wheel,Sales_Rep,Brake_MH_Type,Brake_CT_Type,CT_Wheel_Type,Gear_Box_Stages,Heat_Treatment,Rope_Length,Rope_Drum_Dia,Drum_Length,Drum_Pitch,Rope_Guide_ID,GuideThread_Pitch,GuideThreadDepth,No_of_Gear_Box,No_of_CT_Wheels,Sheave_Dia,No_of_Sheaves,Sheave_Covers,Idler_Sheave_Dia,No_of_Idler_sheave,Hook_Type,Motor_MH_Sl_No,Motor_MH_MAKE,Motor_CT_Sl_No,Motor_CT_MAKE,Brake_MH_Sl_No,Brake_MH_MAKE,Brake_CT_Sl_No,Brake_CT_MAKE,Hoisting_Type,Hoisting_Sl_No,Hoisting_Make,CT_Type,CT_Sl_No,CT_Make,Control_Panel_Type,Control_Panel_Make,Pendent_Type,Pendent_Make,VFD_Hoisting_Model,VFD_Hoisting_Type,VFD_Hoisting_Make,VFD_CT_Model,VFD_CT_Type,VFD_CT_Make,Fitters_Name,Engg_In_Charge,Flange_Width)" +
                    "values ('" + txt_Sl_No.Text + "','" + txt_Company_Name.Text + "','" + txt_WO_No.Text + "','" + txt_Address.Text + "','" + txt_City.Text + "','" + txt_State.Text + "','" + txt_PO_No.Text + "','" + txt_PO_Date.Text + "','" + txt_DeliveryDate.Text + "','" + txt_Capacity.Text + "','" + txt_HoistSize.Text + "','" + txt_HeightLift.Text + "','" + txt_Fall.Text + "','" + txt_HoistCode.Text + "','" + txt_HoistType.Text + "','" + txt_Add_Fea.Text + "','" + txt_HoistingSpeed.Text + "','" + txt_Motor_MH_HP.Text + "','" + txt_Motor_MH_RPM.Text + "','" + txt_Bake_MH_Model.Text + "','" + txt_WireRope.Text + "','" + txt_CTSpeed.Text + "','" + txt_Motor_CT_HP.Text + "','" + txt_Motor_CT_RPM.Text + "','" + txt_Bake_CT_Model.Text + "','" + txt_CTGearBox.Text + "','" + txt_CTWheel.Text + "','" + txt_Sales.Text + "','" + txt_Bake_MH_Type.Text + "','" + txt_Bake_CT_Type.Text + "','" + txt_CT_WheelType.Text + "','" + txt_GearBoxStages.Text + "' ,'" + txt_HeatTreatment.Text + "','" + txt_RopeLemght.Text + "','" + txt_RopeDrumDia.Text + "','" + txt_DrumLenght.Text + "','" + txt_DrumPitch.Text + "','" + txt_RopeGuideID.Text + "','" + txt_GuideThread_pitch.Text + "','" + txt_GuideThredDepth.Text + "','" + txt_NoOfGearBox.Text + "','" + txt_CTWheel.Text + "','" + txt_SheaveDia.Text + "','" + txt_NoOfSheaves.Text + "','" + txt_SheaveCovers.Text + "','" + txt_IderSheaveDia.Text + "','" + txt_NoOfIdlerSheave.Text + "','" + txt_HookType.Text + "','" + txt_Motor_MH_SlNo.Text + "','" + txt_Motor_MH_MAKE.Text + "','" + txt_Motor_CT_SlNo.Text + "','" + txt_Motor_CT_MAKE.Text + "','" + txt_Bake_MH_SlNo.Text + "','" + txt_Bake_MH_Make.Text + "','" + txt_Bake_CT_SlNo.Text + "','" + txt_Bake_CT_Make.Text + "','" + txt_HoistingType.Text + "','" + txt_Hoisting_SlNo.Text + "','" + txt_Hoisting_Make.Text + "','" + txt_CTType.Text + "','" + txt_CT_SlNo.Text + "','" + txt_CT_Make.Text + "','" + txt_ControlPanel.Text + "','" + txt_ControlPanelMake.Text + "','" + txt_Pendent_Type.Text + "','" + txt_PendentMake.Text + "','" + txt_HoistingType.Text + "','" + txt_HoistingType.Text + "','" + txt_HoistingMake.Text + "','" + txt_CTModel.Text + "','" + txt_CTType.Text + "','" + txt_CTMake.Text + "','" + txt_Fitter.Text + "','" + txt_Engg.Text + "','" + txt_FlangeWidth.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
                Work = txt_WO_No.Text;
                Form9 f9 = new Form9(this);
                f9.ShowDialog();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
