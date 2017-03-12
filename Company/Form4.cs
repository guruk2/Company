using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
namespace Company
{
    public partial class Form4 : Form
    {
        public String Work_Order { get; private set; }
        public String Work_O { get; private set; }
        public String Company_Name { get; private set; }
        public String Address { get; private set; }
        public String City { get; private set; }
        public String State { get; private set; }
        public String P_O_No { get; private set; }
        public String P_O_Date { get; private set; }
        public String Delivery_date { get; private set; }
        public String Capacity { get; private set; }
        public String Hoist_Size { get; private set; }
        public String Hoist_Lift { get; private set; }
        public String Hoist_Code { get; private set; }
        public String Hoist_Type { get; private set; }
        public String Add_F { get; private set; }
        public String Hoisting_Speed { get; private set; }
        public String Fall { get; private set; }
        public String Wire_Rope { get; private set; }
        public String CT_Speed { get; private set; }
        public String CT_Gear_Box { get; private set; }
        public String CT_Wheel { get; private set; }
        public String Flange_Width { get; private set; }
        public String CT_Wheel_Type { get; private set; }
        public String  Motor_MH_Hp { get; private set; }
        public String Motor_CT_Hp { get; private set; }
        public String Motor_MH_Rpm { get; private set; }
        public String Motor_CT_Rpm { get; private set; }
        public String Brake_MH_Type { get; private set; }
        public String Brake_MH_Model { get; private set; }
        public String Brake_CT_Type { get; private set; }
        public String Brake_CT_Model { get; private set; }
        public String Sales { get; private set; }
        public Int32 Quantity { get; private set;  }
        public String path;



        private OleDbConnection connection = new OleDbConnection();
        
        public Form4()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;
Persist Security Info=False;";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                byte[] bt = null;
                FileStream fstream = new FileStream(this.path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                bt = br.ReadBytes((int)fstream.Length);
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Hoist_Work_Order (Company_Name,W_O_NO,[Date],Address,City,State,P_O,P_O_Date,Contact_Person,Phone,TIN,Delivery_Date,Capacity,Quality,Hoist_Size,Height_of_lift,Fall,Hoist_Code,Hoist_Type,Additional_Feature,Hoisting_Speed,Hoist_Motor,Hoist_Motor_RPM,Hoist_Brake,Rope_Drum_Code,Wire_Rope,CT_Speed,CT_Motor,CT_Motor_rpm,CT_Brake,CT_Gear_Box,CT_Wheel,Gravity_Type,CT_Limit_switch,Hoist_Creep,CT_Creep,Flange_Width,Out_door_cover,Packing,Transportation,Sales_Rep,Brake_MH_Type,Brake_CT_Type,CT_Wheel_Type,Pdf_File)" +
                                      "values ('" + txt_Company_Name.Text + "','" + txt_W_O_no.Text + "','" + txt_Date.Text + "','" + txt_Address.Text + "','" + txt_City.Text + "','" + txt_State.Text + "','" + txt_P_O_No.Text + "','" + txt_P_O_Date.Text + "','" + txt_Contact_Person.Text + "','" + txt_Phone.Text + "','" + txt_Tin.Text + "','" + txt_Delivery_Date.Text + "','" + txt_Capacity.Text + "','" + txt_Quality.Text + "','" + txt_Hoist_Size.Text + "','" + txt_Height_of_Lift.Text + "','" + txt_Fall.Text + "','" + txt_Hoist_Code.Text + "','" + txt_Hoist_type.Text + "','" + txt_AddF.Text + "','" + txt_Hoisting_Speed.Text + "','" + txt_Hoist_motor.Text + "','" + txt_Hoist_Motor_RPM.Text + "','" + txt_Hoist_Brake.Text + "','" + txt_Rope_Drum_Code.Text + "','" + txt_Wire_Rope.Text + "','" + txt_C_T_Speed.Text + "','" + txt_C_T_Motor.Text + "','" + txt_CTMotor_RPM.Text + "','" + txt_CTBrake.Text + "','" + txt_GearBox.Text + "','" + txt_CTWheel.Text + "','" + txt_GravityType.Text + "','" + txt_CTLimitSwitch.Text + "','" + txt_HoistCreep.Text + "','" + txt_CTCreep.Text + "','" + txt_FlangeWidth.Text + "','" + txt_OutDoorCover.Text + "','" + txt_Packing.Text + "','" + txt_Transportaion.Text + "','" + txt_SalesRep.Text + "','" + txt_Brake_MH_Type.Text + "','" + txt_Brake_CT_Type.Text + "','" + txt_Wheel_CT_Type.Text + "',@PDF)";
                command.Parameters.Add(new OleDbParameter("@PDF", bt));
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
                Work_Order = txt_W_O_no.Text;
                Form7 f7 = new Form7(this);
                f7.ShowDialog();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error" + ex);
            }


        }

        private void txt_GearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Work_O = txt_W_O_no.Text;
                Company_Name = txt_Company_Name.Text;
                Address = txt_Address.Text;
                City = txt_Date.Text;
                State = txt_State.Text;
                P_O_No = txt_P_O_No.Text;
                P_O_Date = txt_P_O_Date.Text;
                Capacity = txt_Capacity.Text;
                Hoist_Size = txt_Hoist_Size.Text;
                Hoist_Lift = txt_Height_of_Lift.Text;
                Hoist_Code = txt_Hoist_Code.Text;
                Hoist_Type = txt_Hoist_type.Text;
                Add_F = txt_AddF.Text;
                Hoisting_Speed = txt_Hoisting_Speed.Text;
                Fall = txt_Fall.Text;
                Wire_Rope = txt_Wire_Rope.Text;
                CT_Speed = txt_C_T_Speed.Text;
                CT_Gear_Box = txt_GearBox.Text;
                CT_Wheel = txt_CTWheel.Text;
                Flange_Width = txt_FlangeWidth.Text;
                CT_Wheel_Type = txt_Wheel_CT_Type.Text;
                Motor_MH_Hp = txt_Hoist_motor.Text;
                Motor_CT_Hp = txt_C_T_Motor.Text;
                Motor_MH_Rpm = txt_Hoist_Motor_RPM.Text;
                Motor_CT_Rpm = txt_CTMotor_RPM.Text;
                Brake_MH_Type = txt_Brake_MH_Type.Text;
                Brake_MH_Model = txt_Hoist_Brake.Text;
                Brake_CT_Type = txt_Brake_CT_Type.Text;
                Brake_CT_Model = txt_CTBrake.Text;
                Sales = txt_SalesRep.Text;
                Delivery_date = txt_Delivery_Date.Text;
                Quantity = Int32.Parse(txt_Quality.Text);
                Form5 f5;
                for (int i = 1; i <= Quantity; i++)
                {
                    f5 = new Form5(this);
                    f5.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            if(dig.ShowDialog() == DialogResult.OK) { path = dig.FileName.ToString(); }
        }
    }
}
