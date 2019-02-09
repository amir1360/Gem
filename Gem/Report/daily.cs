using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.Report
{
    public partial class daily : Form
    {
        int servicetype = 1;
        OperationtblPart ClassTemp = new OperationtblPart();
        
        public daily(int x)
        {
            InitializeComponent();
            servicetype = x;
        }
     

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void datagrid(string st)
        {
            string str = "";
            ///////////////////////////////////////////////////////////////////////
        
            /////////////////////////////////////////////////////////////////////////
            if (servicetype == 1)//شرط برای جلسه
            {
                str = "select Customer.name,Customer.lname,Customer.mobile,Customer.sex,Register_service.date_first,Register_service.date_end,Register_service.price,Register_service.discount,( basis_DayMonthly.title) AS title_mon";
                str += ",(basis_Session.title) AS title_sess,( basis_Service.name_option) as name_option";
                str += ",(pardakht.price) AS price2,pardakht.title_pardakht from pardakht,Customer,Register_service,basis_Service,basis_DayMonthly,basis_Session ";
                str += "where Register_service.code_customer=Customer.id and Register_service.code_serivce= basis_Service.id and basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id  ";
                
                str += st + "and pardakht.code_factor=Register_service.id and type_service=1";
            }
            else if (servicetype == 2)//شرط برای کلاس
            {
                str = "select Customer.name,Customer.lname,Customer.mobile,Customer.sex,Register_service.*,( basis_Class.title) AS title_mon";
                str += ",( basis_Employee.name+' ' +basis_Employee.lname) AS title_sess,( basis_Class.decs) as name_option";
                str += " from Customer,Register_service,basis_Class,basis_Employee ";
                str += "where Register_service.code_customer=Customer.id and Register_service.code_serivce= basis_Class.id and basis_Class.code_coch=basis_Employee.id ";

                str += st+ " and type_service=2";
            }
            else if (servicetype == 3)//شرط برای برنامه های مربیان خصوصی
            {
                str = "select Customer.name,Customer.lname,Customer.mobile,Customer.sex,(basis_service_coach.title) AS title_mon,(basis_Employee.name+' ' +basis_Employee.lname) AS title_sess";
                str += ",(regust_coach.date_regust) AS date_first ,(pardakht.price) AS price2 ";
                str += " from Customer,regust_coach,basis_service_coach,basis_Employee,pardakht ";
                str += "where regust_coach.code_customer=Customer.id and regust_coach.code_service_coach= basis_service_coach.id and regust_coach.code_coach=basis_Employee.id ";
                str += st + "and pardakht.code_factor=regust_coach.id ";
            }
           
            dataGridView1.DataSource = ClassTemp.redt(str);
            

        }

        private void daily_Load(object sender, EventArgs e)
        {
          
            code_service.DataSource = ClassTemp.redt("select * from basis_Option  ");
            code_service.ValueMember = "id";
            code_service.DisplayMember = "title";
           
            date1.Text = Classmain.date_re.AddDaysToShamsiDate(-30);
            date2.Text = Classmain.date_re;
            datagrid("");
            ComboboxItem item = new ComboboxItem();
            item.Text = "مرد";
            item.Value = 0;
            sex.Items.Add(item);
            item.Text = "زن";
            item.Value = 1;
            sex.Items.Add(item);
            item.Text = "همه";
            item.Value = 2;
            sex.Items.Add(item);
            sex.SelectedIndex = 0;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (servicetype == 3)
            {
                string s1, s2;
                s1 = date1.Text;
                s2 = date2.Text;
                string searchdate = " and regust_coach.date_regust>='" + s1;
                datagrid(searchdate );

            }
            else
            {
                string searchsex = "";// sex.SelectedValue.ToString();
                if (sex.SelectedIndex.ToString() == "0") { searchsex = " and Customer.sex=0 "; }
                else if (sex.SelectedIndex.ToString() == "1") { searchsex = " and Customer.sex=1 "; }
                else { searchsex = " and (Customer.sex=0 or Customer.sex=1)"; }
                string s1, s2, s3;
                string searchoption = "";
                if (code_service.SelectedValue.ToString() != "1002")
                {
                    s3 = code_service.SelectedValue.ToString();
                    searchoption = " and basis_Service.codes_option LIKE '%" + s3 + "%'";
                }
                s1 = date1.Text;
                s2 = date2.Text;
                string searchdate = " and Register_service.date_first>='" + s1 + "' and  Register_service.date_first<='" + s2 + "'";
                datagrid(searchdate + searchoption + searchsex);
            }
        //    string s1, s2, s3;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchsex = "";// sex.SelectedValue.ToString();
            if (sex.SelectedIndex.ToString() == "0") { searchsex = " and Customer.sex=0 "; }
            else if (sex.SelectedIndex.ToString() == "1") { searchsex = " and Customer.sex=1 "; }
            else { searchsex = " and (Customer.sex=0 or Customer.sex=1)"; }
            string s1, s2, s3;
            string searchoption = "";
            if (code_service.SelectedValue.ToString() != "1002")
            {
                s3 = code_service.SelectedValue.ToString();
                searchoption = " and basis_Service.codes_option LIKE '%" + s3 + "%'";
            }
            s1 = date1.Text;
            s2 = date2.Text;
            string searchdate = " and Register_service.date_first>='" + s1 + "' and  Register_service.date_first<='" + s2 + "'";

            Report.prewiwe n = new Report.prewiwe(searchdate + searchoption + searchsex,1);
            if (!n.Visible)
            {

                //n.MdiParent = this;
                n.Show(); // Add the message
               // n.TopMost = true;
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchsex = "";// sex.SelectedValue.ToString();
            if (sex.SelectedIndex.ToString() == "0") { searchsex = " and Customer.sex=0 "; }
            else if (sex.SelectedIndex.ToString() == "1") { searchsex = " and Customer.sex=1 "; }
            else { searchsex = " and (Customer.sex=0 or Customer.sex=1)"; }
            string s1, s2, s3;
            string searchoption = "";
            if (code_service.SelectedValue.ToString() != "1002")
            {
                s3 = code_service.SelectedValue.ToString();
                searchoption = " and basis_Service.codes_option LIKE '%" + s3 + "%'";
            }
            s1 = date1.Text;
            s2 = date2.Text;
            string searchdate = " and Register_service.date_first>='" + s1 + "' and  Register_service.date_first<='" + s2 + "'";

            Report.previwe2 n = new Report.previwe2(searchdate + searchsex, 2);
            if (!n.Visible)
            {

                //n.MdiParent = this;
                n.Show(); // Add the message
                // n.TopMost = true;
            }
        }

        private void code_service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void daily_Activated(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
