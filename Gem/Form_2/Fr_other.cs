using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Gem.Form_2
{
    public partial class Fr_other : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public Fr_other()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "name", "lname","mobile" ,"codemeli","date_start", "time_start" };
            string[] na = new string[6];
            na[0] = name.Text;
            na[1] = lname.Text;
            na[2] = mobile.Text;
            na[3] = codemeli.Text;
            na[4] = Classmain.date_re;
            na[5] = DateTime.Now.ToString("HH:mm");
                       
            // Pass the array as an argument to PrintArray.
           int cc=ClassTemp.ins2("enter_other", na, la);
           //MessageBox.Show(c.ToString());
           ////////////////////////////////////////////////////////////////////
           string[] la2 = { "code_customer", "code_factor", "price", "code_pardakht", "title_pardakht", "date_pardakht", "number_decs", "type_gesmat" };
            string[] na2 = new string[8];
           
            na2[0] = "101";//.SelectedIndex.ToString();
            na2[1] = cc.ToString();
            na2[2] = price.Text;
            if (type_pardakht.SelectedIndex == 0)
            {
                na2[4] = "نقدی";
                na2[3] = "0";
                na2[6] = "";
            }
            else
            {
                na2[3] = number_bank.SelectedValue.ToString();
                na2[4] = number_bank.Text;
                na2[6] = sanad.Text;
            }
            na2[5] = date_start.Text;
            na2[7] = "201";
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins("pardakht", na2, la2);

            ///////////////////////////////////////////////////
            DataTable tb2 = new DataTable();
            tb2 = ClassTemp.redt("select id,number,code_customer from basis_Closet where code_customer=0");
            string number, code_customer, idcloset;
            if (tb2.Rows.Count > 0)
            {
                idcloset = tb2.Rows[0]["id"].ToString();
                code_customer = tb2.Rows[0]["code_customer"].ToString();
                number = tb2.Rows[0]["number"].ToString();
                // label8.Text = number +"   "+ idcloset +"  c:"+ code_customer;
                string[] la3 = { "id", "code_customer" };
                string[] na3 = new string[2];
                na3[0] = idcloset;
                na3[1] = cc.ToString();
                ClassTemp.up("basis_Closet", na3, la3);

              
                string[] la4 = { "register_code", "code_cart", "number_closet" };
                string[] na4 = new string[3];
                na4[0] = cc.ToString();
                na4[1] = "000"+codemeli;
                na4[2] = number;
                ClassTemp.ins("temp_enter", na4, la4);
                this.Close();
                /////////////////////////////////////////////////////
                
            }
            else
            {
                label8.Text += " کمدی وجود ندارد";

            }
       
           
        }

        private void Fr_other_Load(object sender, EventArgs e)
        {
            number_bank.DataSource = ClassTemp.redt("select id,name_bank+' '+number_bank AS title from  Bank");
            // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            number_bank.ValueMember = "id";
            number_bank.DisplayMember = "title";
            date_start.Text = Classmain.date_re;
        }

        private void type_pardakht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_pardakht.SelectedIndex == 0)
            {
                number_bank.Enabled = false;
                sanad.Enabled = false;

            }
            if (type_pardakht.SelectedIndex == 1)
            {
                number_bank.Enabled = true;
                sanad.Enabled = true;

            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void sanad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
