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
    public partial class carsh : Form
    {
         OperationtblPart ClassTemp = new OperationtblPart();
         string s1 = "";
         string name = "";//bank or crash
        string stringservice="";
        string stringclass = "";
        string stringcoach = "";
        string stringother = "";
        string stringinsurance = "";
        string str="";
        double sum = 0, sumservice = 0, sumclass = 0, sumcoach = 0, sumother = 0;
        public carsh(string t,string name1)
        {
            InitializeComponent();
            ////////////////////////////////////////////// انتخاب صندوق یا بانک
            s1 = " and pardakht.code_pardakht=" + t;
            if(t=="") s1 = "";
            ///////////////////////////////////////////////////
            name=name1;
            ////////////////////////////////////////////////////
            stringservice = "select pardakht.title_pardakht,(Register_service.price) AS cost ,('1') as code,('سرویس : ' + basis_DayMonthly.title+' ' +basis_Session.title+' '+basis_Service.name_option) AS title";
            stringservice += ",(Customer.name+' '+Customer.lname) AS customer,(pardakht.code_factor) AS code_factor,(pardakht.price) AS price,(pardakht.date_pardakht) AS date_1 from Customer,pardakht,Register_service,basis_Service,basis_DayMonthly,basis_Session ";
            stringservice += "where Customer.id=pardakht.code_customer and Register_service.code_serivce= basis_Service.id and basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id  ";
            stringservice += "and pardakht.code_factor=Register_service.id and Register_service.type_service=1 and pardakht.type_gesmat=0 " + s1;
          ////////////////////////////////////////////////////////////
            stringclass = " select pardakht.title_pardakht,(Register_service.price) AS cost,('2') as code,('کلاس : ' +basis_Class.title+' '+basis_Employee.name+' ' +basis_Employee.lname) AS title";
            stringclass += ",(Customer.name+' '+Customer.lname) AS customer,(pardakht.code_factor) AS code_factor,(pardakht.price) AS price,(pardakht.date_pardakht) AS date_1  ";
            stringclass += " from Customer,pardakht,Register_service,basis_Class,basis_Employee ";
            stringclass += "where Customer.id=pardakht.code_customer and Register_service.code_serivce= basis_Class.id and basis_Class.code_coch=basis_Employee.id ";
            stringclass += "and  pardakht.code_factor=Register_service.id and Register_service.type_service=2 and pardakht.type_gesmat=0 " + s1;
      //////////////////////////////////////////////////////////////////////////////
            stringinsurance = " select pardakht.title_pardakht,(insurance.price) AS cost,('5') as code,('هزینه بیمه :'+insurance.date_end) AS title";
            stringinsurance += ",(Customer.name+' '+Customer.lname) AS customer,(pardakht.code_factor) AS code_factor,(pardakht.price) AS price,(pardakht.date_pardakht) AS date_1  ";
            stringinsurance += " from Customer,insurance,pardakht ";
            stringinsurance += "where  Customer.id=pardakht.code_customer ";
            stringinsurance += "and pardakht.code_factor=insurance.id  and pardakht.type_gesmat=500 " + s1;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            stringcoach = " select pardakht.title_pardakht,(pardakht.price) AS cost,('3') as code,('مربی خصوصی :'+basis_service_coach.title+' '+basis_Employee.name+' ' +basis_Employee.lname) AS title";
            stringcoach += ",(Customer.name+' '+Customer.lname) AS customer,(pardakht.code_factor) AS code_factor,(pardakht.price) AS price,(pardakht.date_pardakht) AS date_1  ";
            stringcoach += " from Customer,regust_coach,basis_service_coach,basis_Employee,pardakht ";
            stringcoach += "where  Customer.id=pardakht.code_customer and regust_coach.code_service_coach= basis_service_coach.id and regust_coach.code_coach=basis_Employee.id ";
            stringcoach += "and pardakht.code_factor=regust_coach.id  and pardakht.type_gesmat=4 " + s1;
       ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            stringother = " select pardakht.title_pardakht,(pardakht.price) AS cost,('4') as code,('ورودی متفرقه ') AS title";
            stringother += ",(enter_other.name+' '+enter_other.lname) AS customer,(pardakht.code_factor) AS code_factor,(pardakht.price) AS price,(pardakht.date_pardakht) AS date_1  ";
            stringother += " from pardakht,enter_other ";
            stringother += "where pardakht.code_factor=enter_other.id ";
            stringother += " and  pardakht.type_gesmat=201 " + s1;
         //////////////////////////////////////////////////////////////////////////////  
        }
        private void datagrid(string st)
        {
           
            ///////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////
          
            str = stringservice;
            str += st;
            str += "UNION ALL";
            str += stringclass;
            str += st;
            str += "UNION ALL";
            str += stringcoach;
            str += st;
            str += "UNION ALL";
            str += stringinsurance;
            str += st;
            str += "UNION ALL";
            str += stringother;
            str += st;
            str += " ORDER BY pardakht.date_pardakht";

            dataGridView1.DataSource = ClassTemp.redt(str);
            sum = 0; sumservice = 0; sumclass = 0; sumcoach = 0; sumother = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                string temp = dataGridView1.Rows[i].Cells["c66"].Value.ToString();
                if (temp=="1") sumservice+= Convert.ToDouble(dataGridView1.Rows[i].Cells["c8"].Value);
                if (temp == "2") sumclass += Convert.ToDouble(dataGridView1.Rows[i].Cells["c8"].Value);
                if (temp=="3") sumcoach += Convert.ToDouble(dataGridView1.Rows[i].Cells["c8"].Value);
                if (temp == "4") sumother += Convert.ToDouble(dataGridView1.Rows[i].Cells["c8"].Value);
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells["c8"].Value);
            }
            pricep.Text = sum.ToString();
            pricese.Text = sumservice.ToString();
            pricecl.Text = sumclass.ToString();
            priceco.Text = sumcoach.ToString();
            pricemo.Text = sumother.ToString();
            if (pricep.Text != string.Empty)
            {
                // price.Text = price.Text.Substring(0, price.Text.Length - 5);
                pricep.Text = string.Format("{0:N0}", double.Parse(pricep.Text.Replace(",", "")));
                pricep.Text += " ریال";
                pricese.Text = string.Format("{0:N0}", double.Parse(pricese.Text.Replace(",", "")));
                pricese.Text += " ریال";
                pricecl.Text = string.Format("{0:N0}", double.Parse(pricecl.Text.Replace(",", "")));
                pricecl.Text += " ریال";
                priceco.Text = string.Format("{0:N0}", double.Parse(priceco.Text.Replace(",", "")));
                priceco.Text += " ریال";
                pricemo.Text = string.Format("{0:N0}", double.Parse(pricemo.Text.Replace(",", "")));
                pricemo.Text += " ریال";
                // pricep.Select(pricep..TextLength, 0);
                //   if (price.Text != "")

            }

        }
        private void carsh_Load(object sender, EventArgs e)
        {
             datagrid("");
             banner.Text ="گزارش  "+ name;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (date1.Text == "" || date2.Text == "") { datagrid(""); }
            else
            {

                string s1, s2;
                s1 = date1.Text;
                s2 = date2.Text;
                string searchdate = " and pardakht.date_pardakht>='" + s1 + "' and pardakht.date_pardakht <='" + s2+"'";
                datagrid(searchdate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Report.previwe3 n = new Report.previwe3(str, sum.ToString(), sumservice.ToString(), sumclass.ToString(), sumcoach.ToString(), sumother.ToString());
            if (!n.Visible)
            {

                //n.MdiParent = this;
                n.Show(); // Add the message
                // n.TopMost = true;
            }
        }
    }
}
