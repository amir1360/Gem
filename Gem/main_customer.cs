using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;

using System.Windows.Forms;

namespace Gem
{
    public partial class main_customer : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        double diff;
        bool close = false;
        string code = "";
        int door = 1;
        int doorclass= 1;
        int mn = 0;
        string codeservice, idservice;
        string[] codeservice2={"","",""};
        string[] idservice2 = { "", "", "" };
        float[] cc1={0,0,0,0,0,0,0}; //ساعت شروع برای طول هفته
        float[] cc2={0,0,0,0,0,0,0};  // ساعت پایان
        float[] ccc1 = { 0, 0, 0, 0, 0, 0, 0 }; //کلاسهاساعت شروع برای طول هفته
        float[] ccc2 = { 0, 0, 0, 0, 0, 0, 0 };  // ساعت پایان
        public main_customer(string c)
        {
            code = c;
            InitializeComponent();
        }
        public main_customer(string c, int m)
        {
            code = c;
            mn = m;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            Form_2.session n = new Form_2.session("Register_service", "تمدید ", int.Parse(tempid.Text),1);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;
                n.Show(); // Add the message
            }
        }

        private void main_customer_Load(object sender, EventArgs e)
        {
         //try
            {
                if (mn == 0)
                {
                    DataTable tb_bargasht = new DataTable();
                    tb_bargasht = ClassTemp.Search(code, "temp_enter", "code_cart");
                    if (tb_bargasht.Rows.Count > 0)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("شماره کارت در داخل است");
                        timer1.Enabled = true;
                        close = true;
                        return;
                    }
                }
                    DataTable tb = new DataTable();
                    tb = ClassTemp.Search(code, "Customer", "codecart");
                    if (tb.Rows.Count == 0)
                    {
                        MessageBox.Show("کارت نامعتبر است");
                        close = true;
                    }
                    else
                    {

                        name.DataBindings.Add("Text", tb, "name");
                        lname.DataBindings.Add("Text", tb, "lname");
                        codemeli.Text = tb.Rows[0]["codemeli"].ToString();
                        type.DataBindings.Add("Text", tb, "typesport");
                        date.DataBindings.Add("Text", tb, "date_re");
                        tempid.DataBindings.Add("Text", tb, "id");
                        string path = @"images\" + codemeli.Text + ".jpg";
                        if (File.Exists(path))
                        {
                            pictureBox1.Image = Image.FromFile(path);
                        }
                        else
                        {
                            pictureBox1.Image = Image.FromFile(@"images\defult.jpg");
                        }
                        DataTable cb2 = new DataTable();  // پیدا کردن کلاس
                        //tb2 = ClassTemp.Search(tempid.Text, "register_service", "code_customer");
                        cb2 = ClassTemp.redt("select * from Register_service where code_customer=" + tempid.Text + " and type_service=2 ORDER BY id DESC");

                        string stemp = "0"; int i = 0;
                        
                        TextBox[] ar_codeclass = new TextBox[] { code_class,code_class1,code_class2};
                        TextBox[] ar_number = new TextBox[] { number2, number3,number4 };
                        TextBox[] ar_datafirst = new TextBox[] { datefirst2,datefirst3,datefirst4 };  
                         TextBox[] ar_dateend = new TextBox[] { dateend2,dateend3,dateend4 };  
                         TextBox[] ar_enter = new TextBox[] { enter2,enter3,enter4 };  
                         TextBox[] ar_remaind = new TextBox[] {  remaind2,remaind3,remaind4 };  
                         TextBox[] ar_lastdate = new TextBox[] {lastdate2,lastdate3,lastdate4 };

                         for (int h=0; h < cb2.Rows.Count;h++ )//if (cb2.Rows.Count > 0)
                         {


                             codeservice2[i] = cb2.Rows[h]["code_serivce"].ToString();
                             if (stemp != "0") 
                             { stemp = codeservice2[i]; }
                             var results = Array.FindAll(codeservice2, s => s.Equals(stemp));
          
                             if (results.Length<=1 && i < 3)
                             {
                                 stemp = codeservice2[i];
                                 idservice2[i] = cb2.Rows[h]["id"].ToString();
                                // ar_number[i].DataBindings.Add("Text", cb2, "number");
                                 ar_number[i].Text = cb2.Rows[h]["number"].ToString();
                                 ar_datafirst[i].Text = cb2.Rows[h]["date_first"].ToString();
                                 ar_dateend[i].Text = cb2.Rows[h]["date_end"].ToString();

                                 string[] tt1 = new string[7];
                                 string[] tt2 = new string[] { "c0", "c1", "c2", "c3", "c4", "c5", "c6" };
                                 for (int m = 0; m < 7; m++)
                                 {
                                     tt1[m] = cb2.Rows[h][tt2[m]].ToString();

                                     int f = 0;
                                     if (tt1[m] != "")
                                     {
                                         foreach (string substring2 in tt1[m].Split(':'))
                                         {
                                             if (f == 1)
                                             {
                                                 ccc2[m] = float.Parse(substring2);
                                             }
                                             else
                                             {
                                                 ccc1[m] = float.Parse(substring2);
                                             }
                                             f++;
                                         }
                                     }
                                 }
                                 /////////////////////////////////////////////////////////
                                 //enter.DataBindings.Add("Text", tb2, "id");
                                 DataTable cb2_2 = new DataTable();
                                 cb2_2 = ClassTemp.redt("select basis_Class.id,(basis_Employee.lname+' '+basis_Employee.name+ ' ' +basis_Class.title+' '+CONVERT(varchar(10), basis_Class.session) ) as title from basis_Employee,basis_Class where basis_Class.code_coch=basis_Employee.id and basis_Class.id=" + codeservice2[i]);
                                 ar_codeclass[i].DataBindings.Add("Text", cb2_2, "title");
                                 ///////////////////////////////////////////////////////////////
                                 DataTable cb3 = new DataTable();
                                 cb3 = ClassTemp.sum(idservice2[i], "Register_entry", "code_register");
                                 ar_enter[i].DataBindings.Add("Text", cb3, "all");
                                 ar_remaind[i].Text = (int.Parse(number2.Text) - int.Parse(enter2.Text)).ToString();
                                 ar_lastdate[i].Text = cb3.Rows[0]["maxdate"].ToString();
                                 i++;


                             }

                         }
                        DataTable tb2 = new DataTable();  // پیدا کردن سرویس
                        //tb2 = ClassTemp.Search(tempid.Text, "register_service", "code_customer");
                        tb2 = ClassTemp.redt("select * from Register_service where code_customer=" + tempid.Text + " and type_service=1 ORDER BY id DESC");
                        if (tb2.Rows.Count > 0)
                        {//

                            codeservice = tb2.Rows[0]["code_serivce"].ToString();
                            idservice = tb2.Rows[0]["id"].ToString();
                            number.DataBindings.Add("Text", tb2, "number");
                            //datefirst.DataBindings.Add("Text", tb2, "date_first");
                            ////////////////////////////////////////////////////////////////////////
                            datefirst.Text = tb2.Rows[0]["date_first"].ToString();
                            //DateTime startDate = DateTime.Parse(datefirst.Text);
                            // string format = "yyyy/MM/dd";
                            //datefirst.Text = startDate.ToString(format);
                            /////////////////////////////////////////////////////////////
                            dateend.Text = tb2.Rows[0]["date_end"].ToString();
                            //DateTime endDate = DateTime.Parse(dateend.Text);
                            //dateend.Text = endDate.ToString(format);
                            string[] tt1 = new string[7];
                            string[] tt2 = new string[] { "c0", "c1", "c2", "c3", "c4", "c5", "c6" };
                            for (int m = 0; m < 7; m++)
                            {
                                tt1[m] = tb2.Rows[0][tt2[m]].ToString();

                                int d = 0;
                                if (tt1[m] != "")
                                {
                                    foreach (string substring2 in tt1[m].Split(':'))
                                    {
                                        if (d == 1)
                                        {
                                            cc2[m] = float.Parse(substring2);
                                        }
                                        else
                                        {
                                            cc1[m] = float.Parse(substring2);
                                        }
                                        d++;
                                    }
                                }
                            }
                            /////////////////////////////////////////////////////////
                            //enter.DataBindings.Add("Text", tb2, "id");
                            DataTable tb2_2 = new DataTable();
                            tb2_2 = ClassTemp.redt("select basis_Service.id,(basis_DayMonthly.title+' '+basis_Session.title+ ' ' +basis_SErvice.name_option) as title from basis_Service,basis_DayMonthly,basis_Session where basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id and basis_Service.id=" + codeservice);
                            code_service.DataBindings.Add("Text", tb2_2, "title");
                            ///////////////////////////////////////////////////////////////
                            DataTable tb3 = new DataTable();
                            tb3 = ClassTemp.sum(idservice, "Register_entry", "code_register");
                            enter.DataBindings.Add("Text", tb3, "all");
                            remaind.Text = (int.Parse(number.Text) - int.Parse(enter.Text)).ToString();
                            lastdate.Text = tb3.Rows[0]["maxdate"].ToString();
                            if (lastdate.Text != "")
                            {
                                // DateTime last2 = DateTime.Parse(lastdate.Text);
                                //lastdate.Text = last2.ToString(format);
                            }
                            ////////////////////////////////////////////////////////////////////////
                        }//else
                        //////////////////////////////////////////////////
                    }

                      
                 timer1.Enabled = true;
            }
           
    //   catch { }


        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = ClassTemp.redt("select max(id) AS ID from Register_entry where code_register=" + enter.Text);
            string id_enter = tb.Rows[0]["ID"].ToString();
            string[] la = { "id", "date_end", "time_end" };
            string[] na = new string[3];
            na[0] = id_enter;
            na[1] = Classmain.date_re;
            na[2] = DateTime.Now.ToString("HH:mm");
            ClassTemp.up("Register_entry", na, la);
        }

        private void main_customer_Activated(object sender, EventArgs e)
        {
          //  if (sex.Text == "0") { sex.Text = "مرد"; } else { sex.Text = "زن"; }
            if (type.Text == "0") { type.Text = "عادی"; } else if(type.Text == "1") { type.Text = "قهرمان ملی"; }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_2.regust_coch n = new Form_2.regust_coch(tempid.Text);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form_2.session n = new Form_2.session("Register_service", "تمدید ", int.Parse(tempid.Text), 1);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (close == true) { this.Close(); }
            //////////////////////////////////////////////////////محاسبه بدهکار بستانکار مشتری
            ////////////////////////////////محاسبه پرداخت
            if (tempid.Text != "")
            {
                mandeh1.Text = "";
                string pardakht = "0";
                DataTable tb11 = new DataTable();
                tb11 = ClassTemp.redt("select sum(price) AS price from pardakht where code_customer=" + tempid.Text);
                if (tb11.Rows.Count > 0)
                { pardakht = tb11.Rows[0]["price"].ToString(); }
                if (pardakht == "") pardakht = "0";
                ////////////////////////////////محاسبه مبلغ سرویس و کلاس
                string p1 = "0", p2 = "0";
                DataTable tb21 = new DataTable();
                tb21 = ClassTemp.redt("select sum(price) AS price,sum(discount) AS discount from Register_service where code_customer=" + tempid.Text);
                if (tb21.Rows.Count > 0)
                {
                    p1 = tb21.Rows[0]["price"].ToString();
                    p2 = tb21.Rows[0]["discount"].ToString();
                }
                /////////////////////////محاسبه مربی خصوصی
                string r = "0";
                DataTable tb31 = new DataTable();
                tb31 = ClassTemp.redt("select sum(price) AS price from regust_coach where code_customer=" + tempid.Text);
                if (tb31.Rows.Count > 0)
                { r = tb31.Rows[0]["price"].ToString(); }
                if (r == "") r = "0";
                double mandeh = 0; string sts = "تسویه";
                mandeh = double.Parse(pardakht) - (double.Parse(p1) - double.Parse(p2) + double.Parse(r));
                if (mandeh < 0) { mandeh1.Text = mandeh.ToString(sts = "بدهکار"); }
                if (mandeh > 0) { mandeh1.Text = mandeh.ToString(sts = "بستانکار"); }
                mandeh1.Text = mandeh.ToString();
                mandeh1.Text = string.Format("{0:N0}", double.Parse(mandeh1.Text.Replace(",", "")));
                mandeh1.Text += "   " + sts;
            }
            ////////////////////////////////////////////////////بررسی کلاس
            TextBox[] ar_codeclass = new TextBox[] { code_class, code_class1, code_class2 };
            TextBox[] ar_number = new TextBox[] { number2, number3, number4 };
            TextBox[] ar_datafirst = new TextBox[] { datefirst2, datefirst3, datefirst4 };
            TextBox[] ar_dateend = new TextBox[] { dateend2, dateend3, dateend4 };
            TextBox[] ar_enter = new TextBox[] { enter2, enter3, enter4 };
            TextBox[] ar_remaind = new TextBox[] { remaind2, remaind3, remaind4 };
            TextBox[] ar_lastdate = new TextBox[] { lastdate2, lastdate3, lastdate4 };
            Label[] ar_label=new Label[] {label11,label29,label30};

            for (int k = 0; k < 3; k++)
            {
                doorclass = 1;
                if (ar_codeclass[k].Text == "")
                {
                    doorclass = 0;
                    ar_label[k].Text = "کلاسی موجود نیست";

                }
                else
                {

                    diff = (Convert.ToDateTime(shamsidate.ToGeorgianDateTime(ar_dateend[k].Text)) - Convert.ToDateTime(shamsidate.ToGeorgianDateTime(Classmain.date_re))).TotalDays;

                    if (diff < 0)
                    {
                        ar_label[k].Text = "تاریخ گذشته";
                        doorclass = 0;
                    }
                    diff = (Convert.ToDateTime(shamsidate.ToGeorgianDateTime(ar_datafirst[k].Text)) - Convert.ToDateTime(shamsidate.ToGeorgianDateTime(Classmain.date_re))).TotalDays;

                    if (diff > 0)
                    {
                        ar_label[k].Text = "هنوز شروع نشده";
                        doorclass = 0;
                    }
                    if (int.Parse(ar_remaind[k].Text) <= 0)
                    {
                        doorclass = 0;
                        ar_label[k].Text = " تعداد جلسه تمام شده است";
                    }
                    float w1, w2, n1, n2, n3;
                    DateTime now = DateTime.Now;
                    n1 = now.Hour;
                    n2 = now.Minute;
                    n3 = n1 * 60 + n2;
                    string nameday = System.DateTime.Now.DayOfWeek.ToString();
                    switch (nameday)
                    {
                        case "Saturday":
                            w1 = ccc1[0] * 60;
                            w2 = ccc2[0] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;
                        case "Sunday":
                            w1 = ccc1[1] * 60;
                            w2 = ccc2[1] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;
                        case "Monday":
                            w1 = ccc1[2] * 60;
                            w2 = ccc2[2] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;
                        case "Tuesday":
                            w1 = ccc1[3] * 60;
                            w2 = ccc2[3] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;
                        case "Wednesday":
                            w1 = ccc1[4] * 60;
                            w2 = ccc2[4] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;
                        case "Thursday":
                            w1 = ccc1[5] * 60;
                            w2 = ccc2[5] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;
                        case "Friday":
                            w1 = ccc1[6] * 60;
                            w2 = ccc2[6] * 60;
                            if (n3 >= w1 && n3 < w2) { } else { doorclass = 0; ar_label[k].Text = " مغایر با ساعت رزو شده"; }
                            break;

                    }


                }


                if (doorclass == 1 && mn == 0)
                {
                    try
                    {
                        DataTable tb2 = new DataTable();
                        tb2 = ClassTemp.redt("select id,number,code_customer from basis_Closet where code_customer=0");
                        string number, code_customer, idcloset;
                        if (tb2.Rows.Count > 0)
                        {
                            idcloset = tb2.Rows[0]["id"].ToString();
                            code_customer = tb2.Rows[0]["code_customer"].ToString();
                            number = tb2.Rows[0]["number"].ToString();
                            // label8.Text = number +"   "+ idcloset +"  c:"+ code_customer;
                            string[] la = { "code_register", "date_first", "time_enter", "code_clost" };
                            string[] na = new string[4];
                            na[0] = idservice2[k];
                            na[1] = Classmain.date_re;
                            na[2] = DateTime.Now.ToString("HH:mm");
                            na[3] = number;
                            // MessageBox.Show( DateTime.Now.ToString("HH:mm:ss tt"));
                            // Pass the array as an argument to PrintArray.
                            ClassTemp.ins("Register_entry", na, la);
                            string[] la2 = { "id", "code_customer" };
                            string[] na2 = new string[2];
                            na2[0] = idcloset;
                            na2[1] = idservice2[k];
                            ClassTemp.up("basis_Closet", na2, la2);

                            DataTable tb = new DataTable();
                            tb = ClassTemp.redt("select max(id) AS ID from Register_entry where code_register=" + idservice2);
                            string id_enter = tb.Rows[0]["ID"].ToString();

                            string[] la3 = { "register_code", "code_cart", "number_closet" };
                            string[] na3 = new string[3];
                            na3[0] = id_enter;
                            na3[1] = code;
                            na3[2] = number;
                            ClassTemp.ins("temp_enter", na3, la3);
                            timer1.Enabled = false;
                            /////////////////////////////////////////////////////
                            SerialPort ss = new SerialPort(Classmain.port5, 2400);
                            ss.Open();
                            int i = 1;
                            byte[] buffer = BitConverter.GetBytes(i);
                            ss.Write("1");
                            System.Threading.Thread.Sleep(500);
                            ss.Write("2");
                            //textBox1.Text= ss.ReadLine("RUD");
                            //ss.WriteLine("RUX\r\n");
                            //textBox1.Text = ss.ReadLine();
                            ss.Close();
                            /////////////////////////////////////////////////////
                            return;

                        }
                        else
                        {
                            label8.Text += " کمدی وجود ندارد";

                        }
                    }
                    catch
                    {
                        MessageBox.Show("شماره کارت در داخل است");
                        timer1.Enabled = false;
                    }
                }
            }

            ////////////////////////////////////////////////////بررسی سرویس
            
            
            
            if (code_service.Text == "")
            {
                door = 0;
                label8.Text += " سرویس اختصاص نگرفته است";
            
            } else {
           
            diff = (Convert.ToDateTime(shamsidate.ToGeorgianDateTime(dateend.Text)) - Convert.ToDateTime(shamsidate.ToGeorgianDateTime(Classmain.date_re))).TotalDays;

            if (diff < 0)
            {
                label8.Text = "تاریخ گذشته";
                door = 0;
            }
            diff = (Convert.ToDateTime(shamsidate.ToGeorgianDateTime(datefirst.Text)) - Convert.ToDateTime(shamsidate.ToGeorgianDateTime(Classmain.date_re))).TotalDays;

            if (diff > 0)
            {
                label8.Text = "هنوز شروع نشده";
                door = 0;
            }
            if (int.Parse(remaind.Text) <= 0 )
            {
                door = 0;
                label8.Text += " تعداد جلسه تمام شده است";
            }
                float w1,w2,n1,n2,n3;
                DateTime now = DateTime.Now;
                n1=now.Hour;
                n2=now.Minute;
                n3=n1*60+n2;
                string nameday=System.DateTime.Now.DayOfWeek.ToString();
                switch (nameday)
                {
                    case "Saturday": 
                        w1 = cc1[0] * 60;
                        w2 = cc2[0] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                    case "Sunday":
                        w1 = cc1[1] * 60;
                        w2 = cc2[1] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                    case "Monday":
                          w1 = cc1[2] * 60;
                        w2 = cc2[2] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                    case "Tuesday":
                          w1 = cc1[3] * 60;
                        w2 = cc2[3] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                    case "Wednesday": 
                          w1 = cc1[4] * 60;
                        w2 = cc2[4] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                    case "Thursday": 
                          w1 = cc1[5] * 60;
                        w2 = cc2[5] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                    case "Friday": 
                          w1 = cc1[6] * 60;
                        w2 = cc2[6] * 60;
                        if (n3 >= w1 && n3 < w2) { } else { door = 0; label8.Text += " مغایر با ساعت رزو شده"; }
                        break;
                
                }


                }



            if (door == 1 && mn == 0)
            {
              try
                {
                    DataTable tb2 = new DataTable();
                    tb2 = ClassTemp.redt("select id,number,code_customer from basis_Closet where code_customer=0");
                    string number, code_customer, idcloset;
                    if (tb2.Rows.Count > 0)
                    {
                        idcloset = tb2.Rows[0]["id"].ToString();
                        code_customer = tb2.Rows[0]["code_customer"].ToString();
                        number = tb2.Rows[0]["number"].ToString();
                        // label8.Text = number +"   "+ idcloset +"  c:"+ code_customer;
                        string[] la = { "code_register", "date_first", "time_enter", "code_clost" };
                        string[] na = new string[4];
                        na[0] = idservice;
                        na[1] = Classmain.date_re;
                        na[2] = DateTime.Now.ToString("HH:mm");
                        na[3] = number;
                        // MessageBox.Show( DateTime.Now.ToString("HH:mm:ss tt"));
                        // Pass the array as an argument to PrintArray.
                        ClassTemp.ins("Register_entry", na, la);
                        string[] la2 = { "id", "code_customer" };
                        string[] na2 = new string[2];
                        na2[0] = idcloset;
                        na2[1] = idservice;
                        ClassTemp.up("basis_Closet", na2, la2);

                        DataTable tb = new DataTable();
                        tb = ClassTemp.redt("select max(id) AS ID from Register_entry where code_register=" + idservice);
                        string id_enter = tb.Rows[0]["ID"].ToString();

                        string[] la3 = { "register_code", "code_cart", "number_closet" };
                        string[] na3 = new string[3];
                        na3[0] = id_enter;
                        na3[1] = code;
                        na3[2] = number;
                        ClassTemp.ins("temp_enter", na3, la3);
                        //  MessageBox.Show("123");
                        SerialPort cc = new SerialPort(Classmain.port5, 2400);
                      cc.Open();
                    int i = 1;
                      byte[] buffer = BitConverter.GetBytes(i);
                     cc.Write("1");
                       System.Threading.Thread.Sleep(1000);
                      cc.Write("2");
                    }
                    else
                    {
                        label8.Text += " کمدی وجود ندارد";

                    }
                }
               catch 
                { MessageBox.Show("مشکل در ارتباط با پورت ها"); timer1.Enabled = false; }
            }

           
            timer1.Enabled = false;
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form_1.Fr_history_enter n = new Form_1.Fr_history_enter("Register_entry", "سابقه ورود و خروج ", int.Parse(idservice));
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_2.session n = new Form_2.session("Register_service", "تمدید ", int.Parse(tempid.Text),2);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void main_customer_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form_2.insurance n = new Form_2.insurance(int.Parse(tempid.Text),name.Text+ ' ' +lname.Text);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
