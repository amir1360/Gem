using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.Form_2
{
    public partial class session : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
       int code_customer=0;
       string week = "";
       int servicetype = 0;
       bool tick = false;
       
        public session(string t, string b,int customer,int typeservice)
        {
            InitializeComponent();
            table = t;
            baner = b;
            code_customer = customer;
            servicetype = typeservice;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void datagrid()
        {
            string str="";
              if (servicetype == 1)//شرط برای جلسه
            {
                str = "select Register_service.*,( basis_DayMonthly.title) AS title_mon";
                str += ",(basis_Session.title) AS title_sess,( basis_Service.name_option) as name_option";
                str += " from Register_service,basis_Service,basis_DayMonthly,basis_Session ";
                str += "where Register_service.code_serivce= basis_Service.id and basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id  and Register_service.code_customer=" + code_customer;
         
                  str += " and type_service=1";
            }
            else if (servicetype == 2)//شرط برای کلاس
            {
                str = "select Register_service.*,( basis_Class.title) AS title_mon";
                str += ",( basis_Employee.name+'' +basis_Employee.lname) AS title_sess,( basis_Class.decs) as name_option";
                str += " from Register_service,basis_Class,basis_Employee ";
                str += "where Register_service.code_serivce= basis_Class.id and basis_Class.code_coch=basis_Employee.id and Register_service.code_customer=" + code_customer;
       
                str += " and type_service=2";
            }
              
            dataGridView1.DataSource = ClassTemp.redt( str);
                        

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            button2.Enabled = false;
            // tempid.Text = "";
            //  number.Text = "";
            // rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;
            button2.Enabled = true;


        }
        private void session_Load(object sender, EventArgs e)
        {
            datagrid();
            if (servicetype == 1)
            {
                label9.Text = "نام سرویس";
                code_service.DataSource = ClassTemp.redt("select basis_Service.id,(basis_DayMonthly.title+' '+basis_Session.title+ ' ' +basis_SErvice.name_option) as title from basis_Service,basis_DayMonthly,basis_Session where basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id  ");
          
            }
            else if (servicetype == 2)
            {
                label9.Text = "نام کلاس";
                code_service.DataSource = ClassTemp.redt("select basis_Class.id,('کلاس :'+basis_Class.title+' مربی :'+basis_Employee.name+' '+basis_Employee.lname) as title from basis_Class,basis_Employee where basis_Class.code_coch=basis_Employee.id ");
                button1.Visible = false;
            }
          
             // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            code_service.ValueMember = "id";
            code_service.DisplayMember = "title";
            DataTable tb = new DataTable();
            tb = ClassTemp.Search(code_customer.ToString(), "Customer", "id");
            customer.Text = tb.Rows[0]["name"].ToString()+" "+tb.Rows[0]["lname"].ToString();
            date_start.Text = Classmain.date_re;
            
//string dateInString = date_start.Text;
           // DateTime startDate = DateTime.Parse(dateInString);
           // string expiryDate = shamsidate.AddDaysToShamsiDate(dateInString, 30);

            string dateInString = date_start.Text;
            dateInString = shamsidate.ToGeorgianDateTime(dateInString).ToString();
            DateTime startDate = DateTime.Parse(dateInString);
            double dd = Convert.ToDouble(number.Text);
            if (dd < 30) { dd = 30; }
            DateTime expiryDate = startDate.AddDays(dd);
            //  string format = "yyyy/MM/dd";

            //expiryDate = expiryDate.ToString(format);
            date_end.Text = shamsidate.ToPersianDateString(expiryDate);
            
            
            // expiryDate = startDate.AddDays(30);
           // string format = "yyyy/MM/dd";
           // date_end.Text = expiryDate; //expiryDate.ToString(format);
            dataGridView1.Columns["Column4"].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView1.Columns["Column5"].DefaultCellStyle.Format = "yyyy/MM/dd";
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "type_service", "code_serivce", "date_first", "date_end", "number", "code_customer", "price", "discount", "c0", "c1", "c2", "c3", "c4", "c5", "c6" };
            string[] na = new string[15];
            na[0] = servicetype.ToString();
            na[1] = code_service.SelectedValue.ToString();
            na[2] = date_start.Text;
            na[3] = date_end.Text;
            na[4] = number.Text;
            na[5] = code_customer.ToString();
            
            
            na[6] = price.Text;
            na[6] = na[6].Replace(",", String.Empty);
            na[7] = discount.Text;
            if (na[7] == "") na[7] = "0";
            na[7] = na[7].Replace(",", String.Empty);
            if (servicetype == 2)
            {
                DataTable tb = new DataTable();
                tb = ClassTemp.Search(code_service.SelectedValue.ToString(), "basis_Class", "id");
                na[8] = tb.Rows[0]["c0"].ToString();
                na[9] = tb.Rows[0]["c1"].ToString();
                na[10] = tb.Rows[0]["c2"].ToString();
                na[11] = tb.Rows[0]["c3"].ToString();
                na[12] = tb.Rows[0]["c4"].ToString();
                na[13] = tb.Rows[0]["c5"].ToString();
                na[14] = tb.Rows[0]["c6"].ToString();
            }
            else
            {

                na[8] = ""; na[9] = ""; na[10] = ""; na[11] = ""; na[12] = ""; na[13] = ""; na[14] = "";
                string s1 = Classmain.week;
                int i = 0;
                char[] char1 = new char[] { ';' };
                string[] v1 = { "", "", "" };
                foreach (string substring in s1.Split(';'))
                {
                    //  MessageBox.Show(substring);
                    if (substring == "") break;
                    i = 0;
                    foreach (string substring2 in substring.Split(':'))
                    {
                        v1[i] = substring2;
                        i++;
                    }
                    if (v1[0] == "0") na[8] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "1") na[9] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "2") na[10] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "3") na[11] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "4") na[12] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "5") na[13] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "6") na[14] = (v1[1] + ":" + v1[2]);


                }
            }
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
            datagrid();
            setbut();
        }

        private void code_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            // try
                 {
                   string selectedText = ((DataRowView)code_service.SelectedItem)["id"].ToString();
               //  MessageBox.Show(selectedText);

              
                   DataTable tb = new DataTable();
                   if (servicetype == 1)
                   {
                       tb = ClassTemp.redt("select basis_Service.price AS price,basis_Session.dayes AS daye from basis_Service,basis_Session where  basis_Service.code_session=basis_Session.id and basis_Service.id=" + selectedText);
                   }
                   else if (servicetype == 2)
                   {
                       tb = ClassTemp.redt("select basis_Class.price AS price,basis_class.session AS daye from basis_Class where   basis_Class.id=" + selectedText);
                   }
                    
                   //  price.DataBindings.Add("Text", tb, "price");
                    // number.DataBindings.Add("Text", tb, "daye");
                    price.Text =tb.Rows[0]["price"].ToString();
                    number.Text = tb.Rows[0]["daye"].ToString();
                    

                 }
              //  catch 
                 { }

        }

        private void date_start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form_1.Fr_week fm = new Form_1.Fr_week("Register_service",int.Parse(tempid.Text));
            fm.MdiParent = this.ParentForm;
            fm.Show();
            tick = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (discount.Text == "") discount.Text = "0";
            double f=double.Parse(price.Text)-double.Parse(discount.Text);
            Form_1.Fr_pardakht fm = new Form_1.Fr_pardakht(int.Parse(tempid.Text),code_customer,code_service.Text,f.ToString());
            fm.MdiParent = this.ParentForm;
            fm.Show();
        }

        private void date_start_Leave(object sender, EventArgs e)
        {
            string dateInString = date_start.Text;
            dateInString = shamsidate.ToGeorgianDateTime(dateInString).ToString();
            DateTime startDate = DateTime.Parse(dateInString);
            double dd = Convert.ToDouble(number.Text);
            if (dd < 30) { dd = 30; }
            DateTime expiryDate = startDate.AddDays(dd);
          //  string format = "yyyy/MM/dd";

            //expiryDate = expiryDate.ToString(format);
            date_end.Text = shamsidate.ToPersianDateString(expiryDate);
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            if (discount.Text != string.Empty)
            {
                discount.Text = string.Format("{0:N0}", double.Parse(discount.Text.Replace(",", "")));
                discount.Select(discount.TextLength, 0);
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            if (price.Text != string.Empty)
            {
               // price.Text = price.Text.Substring(0, price.Text.Length - 5);
                price.Text = string.Format("{0:N0}", double.Parse(price.Text.Replace(",", "")));
                price.Select(price.TextLength, 0);
             //   if (price.Text != "")
                
            }
        }

        private void date_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                code_service.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString());
                // customer.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                date_start.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                // DateTime startDate = DateTime.Parse(date_start.Text);
                // string format = "yyyy/MM/dd";
                // date_start.Text = startDate.ToString(format);
                date_end.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                // startDate = DateTime.Parse(date_end.Text);
                //  date_end.Text = startDate.ToString(format);
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["Column8"].Value.ToString();
                discount.Text = dataGridView1.Rows[e.RowIndex].Cells["Column9"].Value.ToString();
                for (int i = 0; i < 7; i++)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[i + 9].Value.ToString() != "")
                        week += dataGridView1.Rows[e.RowIndex].Cells[i + 9].Value.ToString() + ";";

                }
                setbut2();
            }
            catch { }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string[] la = { "id","type_service", "code_serivce", "date_first", "date_end", "number", "code_customer", "price", "discount", "c0", "c1", "c2", "c3", "c4", "c5", "c6" };
            string[] na = new string[16];
            na[0] = tempid.Text;
            na[1] = servicetype.ToString();
            na[2] = code_service.SelectedValue.ToString();
            na[3] = date_start.Text;
            na[4] = date_end.Text;
            na[5] = number.Text;
            na[6] = code_customer.ToString();


            na[7] = price.Text;
            na[7] = na[7].Replace(",", String.Empty);
            na[8] = discount.Text;
            if (na[8] == "") na[8] = "0";
            na[8] = na[8].Replace(",", String.Empty);
            if (servicetype == 2)
            {
                DataTable tb = new DataTable();
                tb = ClassTemp.Search(code_service.SelectedValue.ToString(), "basis_Class", "id");
                na[9] = tb.Rows[0]["c0"].ToString();
                na[10] = tb.Rows[0]["c1"].ToString();
                na[11] = tb.Rows[0]["c2"].ToString();
                na[12] = tb.Rows[0]["c3"].ToString();
                na[13] = tb.Rows[0]["c4"].ToString();
                na[14] = tb.Rows[0]["c5"].ToString();
                na[15] = tb.Rows[0]["c6"].ToString();
            }
            else
            {
                na[9] = ""; na[10] = ""; na[11] = ""; na[12] = ""; na[13] = ""; na[14] = ""; na[15] = "";
                string s1 = Classmain.week;
                if (tick == false)
                    s1 = week;

                int i = 0;
                char[] char1 = new char[] { ';' };
                string[] v1 = { "", "", "" };
                foreach (string substring in s1.Split(';'))
                {
                    //  MessageBox.Show(substring);
                    if (substring == "") break;
                    i = 0;
                    foreach (string substring2 in substring.Split(':'))
                    {
                        v1[i] = substring2;
                        i++;
                    }
                    if (v1[0] == "0") na[9] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "1") na[10] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "2") na[11] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "3") na[12] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "4") na[13] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "5") na[14] = (v1[1] + ":" + v1[2]);
                    if (v1[0] == "6") na[15] = (v1[1] + ":" + v1[2]);


                }
                // Pass the array as an argument to PrintArray.

            } ClassTemp.up(table, na, la);
            datagrid();
            setbut();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del(table, tempid.Text);
                datagrid();
                setbut();
            }
            else if (dialogResult == DialogResult.No)
            {
                setbut();

            }
        }
    }
}
