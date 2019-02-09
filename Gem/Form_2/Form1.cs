using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; 

namespace Gem.Form_2
{
    public partial class Form1 : Form
    {
        static DateTime EPOCH = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
        OperationtblPart ClassTemp = new OperationtblPart();
        DataTable tb_burn = new DataTable();
        DataTable tb_register = new DataTable();
        DataTable tb_insurance = new DataTable();
        string dec_burn;
        string dec_insurance;
        string dec_register;
        string username;
        string password;
        string mobilesender;
       
        public Form1()
        {
            InitializeComponent();
        }
       

        public static double ConvertDatetimeToUnixTimeStamp(DateTime date, int Time_Zone = 0)
        {
            TimeSpan The_Date = (date - EPOCH);
            return Math.Floor(The_Date.TotalSeconds) - (Time_Zone * 3600);
        }


        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           ///////////////////////////////////burn
            DataTable tb = new DataTable();
            tb = ClassTemp.redt("select *  from sms_setting");
            string tburn=tb.Rows[0]["tick_burn"].ToString();
            string tregister = tb.Rows[0]["tick_register"].ToString();
            string tinsurance = tb.Rows[0]["tick_insurance"].ToString();
            string day_insurance = tb.Rows[0]["day_insurance"].ToString();
            string day_register = tb.Rows[0]["day_register"].ToString();
            dec_burn = tb.Rows[0]["dec_burn"].ToString();
            dec_insurance = tb.Rows[0]["dec_insurance"].ToString();
            dec_register = tb.Rows[0]["dec_register"].ToString();
            username = tb.Rows[0]["username_sms"].ToString();
            password = tb.Rows[0]["password_sms"].ToString();
            mobilesender = tb.Rows[0]["mobilesender"].ToString();
            //dec_burn = dec_burn.Replace("xm", "امیر بابایی");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            string dateburn = Classmain.date_re;
            dateburn =dateburn.Remove(0, 4);
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime MyNewDateValue = DateTime.Now.AddDays(0);
            string Date = pc.GetYear(MyNewDateValue) + "/" + pc.GetMonth(MyNewDateValue).ToString("00") + "/" + pc.GetDayOfMonth(MyNewDateValue).ToString("00");
            string Date1 = Date;
            if(tburn=="yes")
                tb_burn = ClassTemp.redt("select * from Customer where burn like '%" + dateburn + "%'");
           else
                tb_burn = ClassTemp.redt("select Customer.* from Customer,Register_service where (Register_service.date_end > '" + Date + "' and  Register_service.date_first < '" + Date + "')  and Customer.burn like '%" + dateburn + "%' and Customer.id=Register_service.code_customer");
           // MessageBox.Show(tb.Rows.Count.ToString());
            
           //////////////////////////////////////insurance

            MyNewDateValue = DateTime.Now.AddDays(int.Parse(day_insurance));
            Date = pc.GetYear(MyNewDateValue) + "/" + pc.GetMonth(MyNewDateValue).ToString("00") + "/" + pc.GetDayOfMonth(MyNewDateValue).ToString("00");
            if (tinsurance == "yes")
                tb_insurance = ClassTemp.redt("select * from Customer where insurance like '%" + Date + "%'");
            else
                tb_insurance = ClassTemp.redt("select Customer.* from Customer,Register_service where (Register_service.date_end > '" + Date1 + "' and  Register_service.date_first < '" + Date1 + "')  and Customer.insurance like '%" + Date + "%' and Customer.id=Register_service.code_customer");
         /////////////////////////////////////////////////////////////////////////////////////////////
            MyNewDateValue = DateTime.Now.AddDays(int.Parse(day_register));
            Date = pc.GetYear(MyNewDateValue) + "/" + pc.GetMonth(MyNewDateValue).ToString("00") + "/" + pc.GetDayOfMonth(MyNewDateValue).ToString("00");
            tb_register = ClassTemp.redt("select Customer.* from Customer,Register_service where Register_service.date_end = '" + Date + "'  and Customer.id=Register_service.code_customer");
            MessageBox.Show(tb_register.Rows.Count.ToString()+tb_burn.Rows.Count.ToString());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmsSeting n = new SmsSeting();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          bool s=IsPrime(6757687681);
          MessageBox.Show(s.ToString());
            
        }
        private void sendsmsburn()
        {
            string name, lname, mobile;
            DateTime date;
            for (int i = 0; i < tb_burn.Rows.Count; i++)
            {
                name=tb_burn.Rows[0]["name"].ToString();
                lname = tb_burn.Rows[0]["lname"].ToString();
                mobile = tb_burn.Rows[0]["mobile"].ToString();
                dec_burn = dec_burn.Replace("xm",name+" "+lname );//
                string[] senderNumbers = { mobilesender };
                string[] recipientNumbers = { mobile };
                string[] messageBodies = { dec_burn };
                date = DateTime.Now;
                //date = DateTime.Now.AddMinutes(5);
                string[] senddate = { Convert.ToString(ConvertDatetimeToUnixTimeStamp(date)) };
                int[] messageClasses = { };
                long[] MessageIDs = { };
                ir.smsapp.v2 ws = new ir.smsapp.v2();
                MessageIDs = ws.SendSMS(username, password, senderNumbers, recipientNumbers, messageBodies, senddate, null, null);
                MessageBox.Show("MessageID : " + MessageIDs[0] + "");
                insertdata(name, lname, mobile, MessageIDs[0].ToString(), "تولد");
            
            }
        
        }
        private void sendsmsregister()
        {
            string name, lname, mobile;
            DateTime date;
            for (int i = 0; i < tb_register.Rows.Count; i++)
            {
                name = tb_register.Rows[0]["name"].ToString();
                lname = tb_register.Rows[0]["lname"].ToString();
                mobile = tb_register.Rows[0]["mobile"].ToString();
                dec_register= dec_register.Replace("xm", name + " " + lname);//
                string[] senderNumbers = { mobilesender };
                string[] recipientNumbers = { mobile };
                string[] messageBodies = { dec_register };
                date = DateTime.Now;
                //date = DateTime.Now.AddMinutes(5);
                string[] senddate = { Convert.ToString(ConvertDatetimeToUnixTimeStamp(date)) };
                int[] messageClasses = { };
                long[] MessageIDs = { };
                ir.smsapp.v2 ws = new ir.smsapp.v2();
                MessageIDs = ws.SendSMS(username, password, senderNumbers, recipientNumbers, messageBodies, senddate, null, null);
                MessageBox.Show("MessageID : " + MessageIDs[0] + "");
                insertdata(name, lname, mobile, MessageIDs[0].ToString(), "تمدید");
            }

        }
        private void sendsmsinsurance()
        {
            string name, lname, mobile;
            DateTime date;
            for (int i = 0; i < tb_insurance.Rows.Count; i++)
            {
                name = tb_insurance.Rows[0]["name"].ToString();
                lname = tb_insurance.Rows[0]["lname"].ToString();
                mobile = tb_insurance.Rows[0]["mobile"].ToString();
                dec_insurance = dec_insurance.Replace("xm", name + " " + lname);//
                string[] senderNumbers = { mobilesender };
                string[] recipientNumbers = { mobile };
                string[] messageBodies = { dec_register };
                date = DateTime.Now;
                //date = DateTime.Now.AddMinutes(5);
                string[] senddate = { Convert.ToString(ConvertDatetimeToUnixTimeStamp(date)) };
                int[] messageClasses = { };
                long[] MessageIDs = { };
                ir.smsapp.v2 ws = new ir.smsapp.v2();
                MessageIDs = ws.SendSMS(username, password, senderNumbers, recipientNumbers, messageBodies, senddate, null, null);
                MessageBox.Show("MessageID : " + MessageIDs[0] + "");
                insertdata(name, lname, mobile, MessageIDs[0].ToString(), "بیمه");

            }

        }
        private void insertdata(string n,string ln,string mo ,string idmass,string typesend)
        {
            string[] la = { "name", "lname", "mobile", "type_send", "idmessage" };
            string[] na = new string[5];
            na[0] = n;
            na[1] = ln;
            na[2] = mo;
            na[3] = typesend;
            na[4] = idmass;
            ClassTemp.ins("sms_save", na, la);
        
        }
        bool IsPrime(long number)
        {

            if (number == 2 || number == 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0 || number % 5==0)
                return false;

            int divisor = 6;
            int x = 0;
            while (divisor * divisor - 2 * divisor + 1 <= number)
            {
                 x = divisor * divisor - 2 * divisor + 1;
                if (number % (divisor - 1) == 0)
                    return false;

                if (number % (+divisor + 1) == 0)
                    return false;

                divisor += 6;

            }

            return true;

        }

        long NextPrime(long a)
        {

            while (!IsPrime(++a))
            { }
            return a;

        }
    }
}
