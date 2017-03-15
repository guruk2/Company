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
using System.Globalization;


namespace Company
{
    public partial class Form13 : Form
    {
        public String Work_Order { get; private set; }
        private OleDbConnection connection = new OleDbConnection();
        Form2 _f2;
        public Form13(Form2 f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Company\Database1.mdb;
Persist Security Info=False;";
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Hoist_Work_Order where " + this._f2.Search + " = '" + this._f2.Work_Order + "'";
            Console.WriteLine(this._f2.Search);
            OleDbDataReader data = command.ExecuteReader();

            while (data.Read())
            {

                string ti = Convert.ToDateTime(data["Date"]).ToString("dd/MM/yyyy");
                string ti1 = Convert.ToDateTime(data["P_O_Date"]).ToString("dd/MM/yyyy");
                string ti2 = Convert.ToDateTime(data["Delivery_Date"]).ToString("dd/MM/yyyy");


                txt_Date.Text = DateTime.ParseExact(ti, "dd/MM/yyyy", null).ToString();
                string company = data.GetString(1); txt_Company_Name.Text = company;
                string address = data.GetString(2); txt_Address.Text = address;
                string city = data.GetString(3); txt_City.Text = city;
                string state = data.GetString(4); txt_State.Text = state;
                string po = data.GetString(5); txt_P_O_No.Text = po;
                string capacity = data.GetInt32(6).ToString(); txt_Capacity.Text = capacity;
                string hoistsize = data.GetString(7); txt_Hoist_Size.Text = hoistsize;
                string hoisttype = data.GetString(8); txt_Hoist_type.Text = hoisttype;
                string additionalfeature = data.GetString(9); txt_AddF.Text = additionalfeature;
                string heightoflift = data.GetString(10); txt_Height_of_Lift.Text = heightoflift;
                string sales = data.GetString(11); txt_SalesRep.Text = sales;

                txt_Delivery_Date.Text = DateTime.ParseExact(ti2, "dd/MM/yyyy", null).ToString();
                string wono = data.GetString(13); txt_W_O_no.Text = wono;
                string tin = data.GetString(14); txt_Tin.Text = tin;
                string hoistspeed = data.GetString(15); txt_Hoisting_Speed.Text = hoistspeed;
                string hoistmotor = data.GetString(16); txt_Hoist_motor.Text = hoistmotor;
                string hoistmotorrpm = data.GetString(17); txt_Hoist_Motor_RPM.Text = hoistmotorrpm;
                string hoistbrake = data.GetString(18); txt_Hoist_Brake.Text = hoistbrake;
                string ropedrumcode = data.GetString(19); txt_Rope_Drum_Code.Text = ropedrumcode;
                string wirerope = data.GetString(20); txt_Wire_Rope.Text = wirerope;
                string gravitytype = data.GetString(21); txt_GravityType.Text = gravitytype;
                string ctspeed = data.GetString(22); txt_C_T_Speed.Text = ctspeed;
                string ctmotor = data.GetString(23); txt_C_T_Motor.Text = ctmotor;
                string ctmotorrpm = data.GetString(24); txt_CTMotor_RPM.Text = ctmotorrpm;
                string ctbrake = data.GetString(25); txt_CTBrake.Text = ctbrake;
                string ctgearbox = data.GetString(26); txt_GearBox.Text = ctgearbox;
                string ctwheel = data.GetString(27); txt_CTWheel.Text = ctwheel;
                string ctlimitswitch = data.GetString(28); txt_CTLimitSwitch.Text = ctlimitswitch;
                string hoistcreep = data.GetString(29); txt_HoistCreep.Text = hoistcreep;
                string ctcreep = data.GetString(30); txt_CTCreep.Text = ctcreep;
                string flagewidth = data.GetString(31); txt_FlangeWidth.Text = flagewidth;
                string outdoorcover = data.GetString(32); txt_OutDoorCover.Text = outdoorcover;
                // string hoistcreep = data.GetString(33); txt_HoistCreep.Text = hoistcreep;
                string packing = data.GetString(34); txt_Packing.Text = packing;
                string transportation = data.GetString(35); txt_Transportaion.Text = transportation;

                txt_P_O_Date.Text = DateTime.ParseExact(ti1, "dd/MM/yyyy", null).ToString();
                string contactperson = data.GetString(37); txt_Contact_Person.Text = contactperson;
                string phone = data.GetString(38); txt_Phone.Text = phone;
                string quality = data.GetString(39); txt_Quality.Text = quality;
                string fall = data.GetString(40); txt_Fall.Text = fall;
                string hoistcode = data.GetString(41); txt_Hoist_Code.Text = hoistcode;
                string brakemhtype = data.GetString(42); txt_Brake_MH_Type.Text = brakemhtype;
                string brakecttype = data.GetString(43); txt_Brake_CT_Type.Text = brakecttype;
                string ctwheeltype = data.GetString(35); txt_Wheel_CT_Type.Text = ctwheeltype;
            } connection.Close();

        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Hoist_Work_Order SET  [Company_Name] = ?,[Date]  = ?,[Address ] = ?,[City ] = ?,[State ] = ?,[P_O ] = ?,[Capacity ] = ?,[Hoist_Size ] = ?,[Hoist_Type ] = ?,[Additional_Feature ] = ?,[Height_of_lift ] = ?,[Sales_Rep ] = ?,[Delivery_Date ] = ?,[TIN ] = ?,[Hoisting_Speed ] = ?,[Hoist_Motor ] = ?,[Hoist_Motor_RPM ] = ?,[Hoist_Brake ] = ?,[Rope_Drum_Code ] = ?,[Wire_Rope ] = ?,[Gravity_Type ] = ?,[CT_Speed ] = ?,[CT_Motor ] = ?,[CT_Motor_rpm ] = ?,[CT_Brake ] = ?,[CT_Gear_Box ] = ?,[CT_Wheel ] = ?,[CT_Limit_switch ] = ?,[Hoist_Creep ] = ?,[CT_Creep ] = ?,[Flange_Width ] = ?,[Out_door_cover ] = ?,[Packing ] = ?,[Transportation ] = ?,[P_O_Date ] = ?,[Contact_Person ] = ?,[Phone ] = ?,[Quality ] = ?,[Fall ] = ?,[Hoist_Code ] = ?,[Brake_MH_Type ] = ?,[Brake_CT_Type ] = ?,[CT_Wheel_Type ] = ? WHERE ([W_O_NO] = ?)";

 command.Parameters.AddWithValue("@Company_Name",txt_Company_Name.Text);
command.Parameters.AddWithValue("@Date", txt_Date.Text );
command.Parameters.AddWithValue("@Address", txt_Address.Text );
command.Parameters.AddWithValue("@City",txt_City.Text );
command.Parameters.AddWithValue("@State",txt_State.Text );
command.Parameters.AddWithValue("@P_O", txt_P_O_No.Text);
command.Parameters.AddWithValue("@Capacity", txt_Capacity.Text);
command.Parameters.AddWithValue("@Hoist_Size",txt_Hoist_Size.Text );
command.Parameters.AddWithValue("@Hoist_Type", txt_Hoist_type.Text);
command.Parameters.AddWithValue("@Additional_Feature", txt_AddF.Text);
command.Parameters.AddWithValue("@Height_of_lift", txt_Height_of_Lift.Text);
command.Parameters.AddWithValue("@Sales_Rep",  txt_SalesRep.Text);
command.Parameters.AddWithValue("@Delivery_Date", txt_Delivery_Date.Text);
command.Parameters.AddWithValue("@TIN", txt_Tin.Text);
command.Parameters.AddWithValue("@Hoisting_Speed", txt_Hoisting_Speed.Text);
command.Parameters.AddWithValue("@Hoist_Motor", txt_Hoist_motor.Text);
command.Parameters.AddWithValue("@Hoist_Motor_RPM", txt_Hoist_Motor_RPM.Text);
command.Parameters.AddWithValue("@Hoist_Brake",  txt_Hoist_Brake.Text);
command.Parameters.AddWithValue("@Rope_Drum_Code", txt_Rope_Drum_Code.Text);
command.Parameters.AddWithValue("@Wire_Rope", txt_Wire_Rope.Text);
command.Parameters.AddWithValue("@Gravity_Type", txt_GravityType.Text );
command.Parameters.AddWithValue("@CT_Speed", txt_C_T_Speed.Text);
command.Parameters.AddWithValue("@CT_Motor", txt_C_T_Motor.Text);
command.Parameters.AddWithValue("@CT_Motor_rpm", txt_CTMotor_RPM.Text);
command.Parameters.AddWithValue("@CT_Brake", txt_CTBrake.Text);
command.Parameters.AddWithValue("@CT_Gear_Box", txt_GearBox.Text);
command.Parameters.AddWithValue("@CT_Wheel", txt_CTWheel.Text);
command.Parameters.AddWithValue("@CT_Limit_switch", txt_CTLimitSwitch.Text);
command.Parameters.AddWithValue("@Hoist_Creep", txt_HoistCreep.Text);
command.Parameters.AddWithValue("@CT_Creep", txt_CTCreep.Text);
command.Parameters.AddWithValue("@Flange_Width", txt_FlangeWidth.Text);
command.Parameters.AddWithValue("@Out_door_cover", txt_OutDoorCover.Text);
command.Parameters.AddWithValue("@Packing", txt_Packing.Text);
command.Parameters.AddWithValue("@Transportation", txt_Transportaion.Text);
command.Parameters.AddWithValue("@P_O_Date",txt_P_O_Date.Text );
command.Parameters.AddWithValue("@Contact_Person", txt_Contact_Person.Text);
command.Parameters.AddWithValue("@Phone", txt_Phone.Text);
command.Parameters.AddWithValue("@Quality", txt_Quality.Text);
command.Parameters.AddWithValue("@Fall", txt_Fall.Text);
command.Parameters.AddWithValue("@Hoist_Code", txt_Hoist_Code.Text);
command.Parameters.AddWithValue("@Brake_MH_Type", txt_Brake_MH_Type.Text);
command.Parameters.AddWithValue("@Brake_CT_Type", txt_Brake_CT_Type.Text);
command.Parameters.AddWithValue("@CT_Wheel_Type",txt_Wheel_CT_Type.Text);
command.Parameters.AddWithValue("@W_O_NO", txt_W_O_no.Text);
                //  command.Parameters.AddWithValue("@Company_Name", "guru");
     
                int a = command.ExecuteNonQuery();
                connection.Close();
                if (a == 0)
                {
                    //Not updated. 
                    MessageBox.Show("Error");
                }

                else
                {
                    MessageBox.Show("Data Saved");
                    Work_Order = txt_W_O_no.Text;
                    Form14 f14 = new Form14(this);
                    f14.Show();
                }
            }
            //Updated.
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }


       
    

