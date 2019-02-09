using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO.Ports;

using System.Windows.Forms;

namespace Gem
{
    public partial class MDIParentmain : Form
    {

        OperationtblPart ClassTemp = new OperationtblPart();
        //string input="";
        string resultcodecart = "";
        string resultcodecart_exit = "";
        string tempcode = "";
        string lname_user= "";
        string name_user = "";
        public MDIParentmain(string user_id,string name,string lname)
        {
            InitializeComponent();
            Classmain.user_id = int.Parse(user_id);
            name_user = name;
            lname_user = lname;
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            groupcloset n = new groupcloset("basis_GroupCloset","گروه بندی کمدها");
           // if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void accsessuser()
        {
            DevComponents.DotNetBar.ButtonItem[] ccc = new DevComponents.DotNetBar.ButtonItem[] { ke1,ke1, ke2, ke3, ke4, ke5, ke6, ke7, ke8, ke9,ke10,ke11,ke12,ke13, ke14, ke15, ke16 };

            DataTable tb = new DataTable();
          string s="";
            switch(Classmain.user_id)
           {
               case 1: s = "select id,user1 AS kayes from X_access2 "; break;
               case 2: s = "select id,user2 AS keyes from X_access2 "; break;
               case 3: s = "select id,user3 AS keyes from X_access2 "; break;
               case 4: s = "select id,user4 AS keyes from X_access2 "; break;
               case 5: s = "select id,user5 AS keyes from X_access2 "; break;
           
           }
            tb = ClassTemp.redt(s);
            for (int i = 0; i < ccc.Length; i++)
            {
                ccc[i].Visible = false;
                //Classmain.port1 = tb.Rows[0]["port1"].ToString();

            }
            for (int i = 0; i < 16; i++)
            {
                ccc[int.Parse(tb.Rows[i]["id"].ToString())].Visible =Convert.ToBoolean(tb.Rows[i][1].ToString());
                //Classmain.port1 = tb.Rows[0]["port1"].ToString();
            
            }
        
        }
        private void MDIParentmain_Load(object sender, EventArgs e)
        {
         
            //////
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            string Date = pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            Classmain.date_re = Date;
            DataTable tb = new DataTable();
            tb = ClassTemp.Search("1", "setting_port", "id");
            Classmain.port1 = tb.Rows[0]["port1"].ToString();
            Classmain.port2 = tb.Rows[0]["port2"].ToString();
            Classmain.port3 = tb.Rows[0]["port3"].ToString();
            Classmain.port4 = tb.Rows[0]["port4"].ToString();
            Classmain.port5 = tb.Rows[0]["port5"].ToString();

            
            accsessuser();
        //   serialPort1.Open();
        
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
          /*  service n = new service();
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }*/
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            Form_1.Fr_coche n = new Form_1.Fr_coche("basis_Employee","مربیان",2);
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Form_1.Fr_customer n = new Form_1.Fr_customer("Customer", "مشتریان");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
          //  string send;
            // serialPort1.Write("b s t s ~");
            //کد سریال آی دی کارت
          
         //   timer1.Enabled = false;

            buttonItem1.Text ="برنامه مدیریت باشگاه"+ "   تاریخ:"+ Classmain.date_re+" "+"   ساعت:"+DateTime.Now.ToString("h:mm")+ "     کاربر سیستم :"+name_user+"  "+lname_user;
           
        }

        private void ribbonTabItem5_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            Fr_Basis_title n = new Fr_Basis_title("basis_Sports_movement_titles","حرکات ورزشی");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            Basis.cash n = new Basis.cash();
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            Form_2.session n = new Form_2.session("Register_service", "تمدید ",112,1);
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            Form_1.Fr_coche n = new Form_1.Fr_coche("basis_Employee", "پزشکان", 3);
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            Fr_Basis_title n = new Fr_Basis_title("basis_Food_titles", "مواد غذایی");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            Fr_Basis_title n = new Fr_Basis_title("basis_Physical_characteristics", "حرکات ورزشی");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            Fr_Basis_title n = new Fr_Basis_title("basis_Option", "آپشن های باشگاه");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            Basis.Fr_Basis_title_dayes n = new Basis.Fr_Basis_title_dayes("basis_DayMonthly", "حق عضویت");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            Basis.Fr_Basis_title_dayes n = new Basis.Fr_Basis_title_dayes("basis_Session", "تعداد جلسه");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem31_Click(object sender, EventArgs e)
        {
            Form_1.Fr_package n = new Form_1.Fr_package("basis_Service", "بسته های باشگاه");
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            Form_1.Fr_sevice_coche n = new Form_1.Fr_sevice_coche("basis_service_coach", "بسته های مربیان");
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Show(); // Add the message

            }
        }

        private void buttonItem16_Click_1(object sender, EventArgs e)
        {
            Form_1.Fr_class n = new Form_1.Fr_class("basis_Class","کلاسها");
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Show(); // Add the message

            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string input;
                input = serialPort1.ReadLine();
            //    MessageBox.Show(input, " کارت");
               input = input.Substring(0, input.Length - 3);
               if(input.Length==9)
               input = input.Substring(1,8);
               if (input.Length == 10)
                input = input.Substring(2, 8);
               int decValue = Convert.ToInt32(input, 16);
               Int64 x;
                x = decValue + 2265576825;
               //  textBox1.Text = input;
                // byte [] buffer;
              //  input = Regex.Replace(input, @"\s", "");
               // input = input.Substring(1);
               // 
                resultcodecart = x.ToString();
             //   MessageBox.Show(resultcodecart);
            }
           catch {
               serialPort1.Close();
           }
        }
        

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            Form_1.Fr_coche n = new Form_1.Fr_coche("basis_Employee", "کارمندان", 1);
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            Form_1.select_customer n = new Form_1.select_customer();
            if (!n.Visible)
            {
              
                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true; 
            }
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Form_2.Fr_enter_other n = new Form_2.Fr_enter_other();
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Show(); // Add the message
            }

        }
       

        private void timer2_Tick(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////خروج
            if (resultcodecart_exit != "")
            {
                DataTable tb_bargasht = new DataTable();
                tb_bargasht = ClassTemp.Search(resultcodecart_exit, "temp_enter", "code_cart");
                string check_code = "", code_register = "", closet = "", id_temp = "";
                if (tb_bargasht.Rows.Count > 0)
                {
                    check_code = tb_bargasht.Rows[0]["code_cart"].ToString();
                    code_register = tb_bargasht.Rows[0]["register_code"].ToString();
                    closet = tb_bargasht.Rows[0]["number_closet"].ToString();
                    id_temp = tb_bargasht.Rows[0]["id"].ToString();
                }
             if (check_code != "")//کارت برگشت
                {
                    //////////////////////////////////////////////////////////////آزادسازی کمد
                    //DataTable tb2 = new DataTable();
                    //tb2 = ClassTemp.Search(closet, "basis_Closet", "number");
                    //string number, idcloset;
                    //idcloset = tb2.Rows[0]["id"].ToString();
                    //number = tb2.Rows[0]["number"].ToString();
                    string[] la2 = { "number", "code_customer" };
                    string[] na2 = new string[2];
                    na2[0] = closet;
                    na2[1] = "0";
                    ClassTemp.up2("basis_Closet", na2, la2);
                    ////////////////////////////////////////////////////////////// اضافه کردن اطلاعات خروج به جدول ورود
                    //DataTable tb3 = new DataTable();
                    //tb2 = ClassTemp.Search(code_register, "Register_entry", "id");
                    string[] la = { "id", "date_end", "time_end" };
                    string[] na = new string[3];
                    na[0] = code_register;
                    na[1] = Classmain.date_re;
                    na[2] = DateTime.Now.ToString("HH:mm");
                    ClassTemp.up("Register_entry", na, la);
                    ///////////////////////////////////////////////////////////////////////  حذف از جدول تم‍پ
                    ClassTemp.del("temp_enter", id_temp);
                    /////////////////////////////////////////////////////////////////باز کردن گیت خروج و بستن
                    SerialPort cc = new SerialPort(Classmain.port5, 2400);
                    cc.Open();
                    int i = 1;
                    byte[] buffer = BitConverter.GetBytes(i);
                    cc.Write("3");
                    System.Threading.Thread.Sleep(1000);
                    cc.Write("4");
                    //close = true;
                }
                else
                {
                    //MessageBox.Show("شماره کارت موجود نیست");
                    resultcodecart_exit = "";
                }
                resultcodecart_exit = "";
            }

            /////////////////////////////////////////////////////////ورود
          
            if (resultcodecart != "" &&  tempcode!=resultcodecart)
            {
                tempcode = resultcodecart;
                main_customer n = new main_customer(tempcode);
                resultcodecart = "";
                tempcode = "1";
                if (!n.Visible)
                {
                    n.MdiParent = this;

                    n.Show(); // Add the message

                }

            }

        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            setting n = new setting();
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Show(); // Add the message
            }
        }

        private void buttonItem20_Click_1(object sender, EventArgs e)
        {
            Basis.Fr_Basis_bank n = new Basis.Fr_Basis_bank();
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = Classmain.port3;
            serialPort1.Open();
            char code1;
            code1 = Convert.ToChar(98);          //b
            serialPort1.Write(code1.ToString());
            code1 = Convert.ToChar(115);        //s
            serialPort1.Write(code1.ToString());
            code1 = Convert.ToChar(116);        //t
            serialPort1.Write(code1.ToString());
            code1 = Convert.ToChar(115);        //s
            serialPort1.Write(code1.ToString());
            code1 = Convert.ToChar(126);        //~
            serialPort1.Write(code1.ToString());
            /////////////////////////////////////////////
            serialPortexit.PortName = Classmain.port4;
            serialPortexit.Open();
            char code2;
            code2 = Convert.ToChar(98);          //b
            serialPortexit.Write(code2.ToString());
            code2 = Convert.ToChar(115);        //s
            serialPortexit.Write(code2.ToString());
            code2 = Convert.ToChar(116);        //t
            serialPortexit.Write(code2.ToString());
            code2 = Convert.ToChar(115);        //s
            serialPortexit.Write(code2.ToString());
            code2 = Convert.ToChar(126);        //~
            serialPortexit.Write(code2.ToString());

        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            //Basis.access n = new Basis.access();
            Form_2.users n = new Form_2.users();
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void MDIParentmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                serialPort1.Close();
                Application.Exit();
            }
            catch { }
        }

        private void MDIParentmain_Activated(object sender, EventArgs e)
        {
            
        }

        private void MDIParentmain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonItem4_Click_1(object sender, EventArgs e)
        {
          
        }

        private void buttonItem37_Click(object sender, EventArgs e)
        {
            
           
        }

        private void buttonItem5_Click_1(object sender, EventArgs e)
        {
            Form_Enter n = new Form_Enter();
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Dock = DockStyle.Right;
                n.Show(); // Add the message

            }
            
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            buffet.sellers n = new buffet.sellers();
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Show(); // Add the message
            }
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            buffet.group_goods n = new buffet.group_goods();
            if (!n.Visible)
            {
                n.MdiParent = this;
                n.Show(); // Add the message
            }
        }

        private void buttonItem38_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem4_Click_2(object sender, EventArgs e)
        {
            Form_2.Fr_other n = new Form_2.Fr_other();
            if (!n.Visible)
            {
                n.MdiParent = this;

                n.Show(); // Add the message

            }
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            Form_1.select_customer n = new Form_1.select_customer(1);
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }
        }

        private void serialPortexit_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string input;
                input = serialPortexit.ReadLine();
                //    MessageBox.Show(input, " کارت");
                input = input.Substring(0, input.Length - 3);
                if (input.Length == 9)
                    input = input.Substring(1, 8);
                if (input.Length == 10)
                    input = input.Substring(2, 8);
                int decValue = Convert.ToInt32(input, 16);
                Int64 x;
                x = decValue + 2265576825;
                //  textBox1.Text = input;
                // byte [] buffer;
                //  input = Regex.Replace(input, @"\s", "");
                // input = input.Substring(1);
                // 
                resultcodecart_exit = x.ToString();
                //   MessageBox.Show(resultcodecart);
            }
            catch
            {
                serialPort1.Close();
            }
        }

        private void buttonItem39_Click(object sender, EventArgs e)
        {
            Report.daily n = new Report.daily(1);
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }

        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            Report.daily n = new Report.daily(2);
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }
        }

        private void buttonItem10_Click_1(object sender, EventArgs e)
        {
            Form_2.Form1 n = new Form_2.Form1();
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }

        }

        private void buttonItem9_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            Report.daily n = new Report.daily(3);
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem41_Click(object sender, EventArgs e)
        {
            Report.carsh n = new Report.carsh("0","صندوق");
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }
        }

        private void comboBoxItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem42_Click(object sender, EventArgs e)
        {
            Report.selectbank n = new Report.selectbank();
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }
        }

        private void buttonItem40_Click(object sender, EventArgs e)
        {
            Report.carsh n = new Report.carsh("", "گزارش روزانه ");
            if (!n.Visible)
            {

                n.MdiParent = this;
                n.Show(); // Add the message
                n.TopMost = true;
            }
        }


        private void buttonItem28_Click(object sender, EventArgs e)
        {
        }


        private void buttonItem25_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem28_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        
    }
}
