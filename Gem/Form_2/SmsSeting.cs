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
    public partial class SmsSeting : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string smsaddress = "";
        string usrsms = "";
        string passsms = "";
        public SmsSeting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SmsSeting_Load(object sender, EventArgs e)
        {
            
              DataTable tb = new DataTable();
              tb = ClassTemp.redt("select * from sms_setting");
           string t1 = tb.Rows[0]["tick_burn"].ToString(); if (t1 == "True") burn1.Checked = true; else burn2.Checked = true;
           string t2 = tb.Rows[0]["tick_register"].ToString(); if (t2 == "True") register1.Checked = true; else register2.Checked = true;
           string t3 = tb.Rows[0]["tick_insurance"].ToString(); if (t3 == "True") insurance1.Checked = true; else insurance2.Checked = true;
           dec_burn.Text = tb.Rows[0]["dec_burn"].ToString();
           dec_register.Text = tb.Rows[0]["day_register"].ToString();
           dec_insurance.Text = tb.Rows[0]["day_insurance"].ToString();
           day_register.Text = tb.Rows[0]["day_register"].ToString();
           day_insurance.Text = tb.Rows[0]["day_insurance"].ToString();
           smsaddress = tb.Rows[0]["address_sms"].ToString();
           usrsms = tb.Rows[0]["username_sms"].ToString();
           passsms = tb.Rows[0]["password_sms"].ToString();
           string f = tb.Rows[0]["flag"].ToString(); if (t1 == "True") switchButton1.Value = true; else switchButton1.Value = false;
           string t4 = tb.Rows[0]["group_sms"].ToString(); if (t4 == "True") group1.Checked = true; else group2.Checked = true;
           dec_group.Text = tb.Rows[0]["dec_group"].ToString(); 
        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = usrsms;
            string password = passsms;
            double resCredit = 0;
            ir.smsapp.v2 ws = new ir.smsapp.v2();
            // SMSService.v2 ws = new SMSService.v2();
            resCredit = ws.GetCredit(username, password);
            MessageBox.Show("Credit : " + resCredit + "");
        }
    }
}
