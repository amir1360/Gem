using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.Form_1
{
    public partial class Fr_pardakht : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        int code_factor;
        int customer1;
        string dec_factor;
        string priced;
        int type_gesmat1;
        public Fr_pardakht(int code_fac, int code_customer,string decs,string p,int typegesmat=0)
        {
            InitializeComponent();
            code_factor = code_fac;
            customer1 = code_customer;
            dec_factor = decs;
            priced = p;
            type_gesmat1 = typegesmat;
        }
        private void datagrid()
        {
            dataGridViewX1.DataSource = ClassTemp.redt("select * from pardakht  where code_factor=" + code_factor.ToString() + " and type_gesmat=" + type_gesmat1.ToString());
            dataGridViewX1.Columns["C4"].DefaultCellStyle.Format = "c";
            dataGridViewX1.Columns["C4"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable tb_bargasht = new DataTable();
            tb_bargasht = ClassTemp.redt("select sum(price) as price from pardakht  where code_factor=" + code_factor.ToString() + " and type_gesmat=" + type_gesmat1.ToString());
            if (tb_bargasht.Rows.Count > 0)
            {
                pricep.Text = tb_bargasht.Rows[0]["price"].ToString();
                if (pricep.Text != string.Empty)
                {
                    // price.Text = price.Text.Substring(0, price.Text.Length - 5);
                    pricep.Text = string.Format("{0:N0}", double.Parse(pricep.Text.Replace(",", "")));
                    // pricep.Select(pricep..TextLength, 0);
                    //   if (price.Text != "")

                }
            }
            else { pricep.Text = "0"; }
           
        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            //  number.Text = "";
            // rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }
        private void Fr_pardakht_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = ClassTemp.Search(customer1.ToString(), "Customer", "id");
            customer.Text = tb.Rows[0]["name"].ToString() + " " + tb.Rows[0]["lname"].ToString(); 
            factor.Text=code_factor.ToString();
            tb = ClassTemp.Search(customer1.ToString(), "Customer", "id");
            customer.Text = tb.Rows[0]["name"].ToString() + " " + tb.Rows[0]["lname"].ToString();
            factor.Text = dec_factor;

            number_bank.DataSource = ClassTemp.redt("select id,name_bank+' '+number_bank AS title from  Bank");
            // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            number_bank.ValueMember = "id";
            number_bank.DisplayMember = "title";
            price.Text = priced;
            date_pardakht.Text = Classmain.date_re;
            dataGridViewX1.Columns["C6"].DefaultCellStyle.Format = "yyyy/MM/dd";
            priceg.Text = price.Text;//مبلغ قابل پرداخت
            datagrid();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "code_customer", "code_factor", "price", "code_pardakht", "title_pardakht", "date_pardakht", "number_decs", "type_gesmat" };
            string[] na = new string[8];
            na[0] = customer1.ToString();//.SelectedIndex.ToString();
            na[1] = code_factor.ToString();
            na[2] = price.Text;
            if (type_pardakht.SelectedIndex == 0)
            {
                na[4] = "نقدی";
                na[3] = "0";
                na[6] = "";
            }
            else { 
             na[3] = number_bank.SelectedValue.ToString();
             na[4] = number_bank.Text; 
             na[6] = number_snad.Text;
            }
            na[5] = date_pardakht.Text;
            na[7] = type_gesmat1.ToString();
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins("pardakht", na, la);
            // dataGridView1.DataSource = customer1.namayesh(4, "customer");
            datagrid();
        }

        private void type_pardakht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_pardakht.SelectedIndex == 0)
            {
                number_bank.Enabled = false;
                number_snad.Enabled = false;

            }
            if (type_pardakht.SelectedIndex == 1)
            {
                number_bank.Enabled = true;
                number_snad.Enabled = true;

            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del("pardakht", tempid.Text);
                datagrid();
                setbut();
            }
            else if (dialogResult == DialogResult.No)
            {
                setbut();

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

        private void Edit_Click(object sender, EventArgs e)
        {
            string[] la = { "id", "code_factor", "price", "code_pardakht", "title_pardakht", "date_pardakht", "number_decs" };
            string[] na = new string[8];
            na[0] = tempid.Text.ToString();//.SelectedIndex.ToString();
            na[1] = code_factor.ToString();
            na[2] = price.Text;
            if (type_pardakht.SelectedIndex == 0)
            {
                na[4] = "نقدی";
                na[3] = "0";
                na[6] = "";
            }
            else
            {
                na[3] = number_bank.SelectedValue.ToString();
                na[4] = number_bank.Text;
                na[6] = number_snad.Text;
            }
            na[5] = date_pardakht.Text;

            // Pass the array as an argument to PrintArray.
            ClassTemp.up("pardakht", na, la);
            // dataGridView1.DataSource = customer1.namayesh(4, "customer");
            datagrid();
            setbut();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          try
            {
                //tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                // daymontly.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
                //   session.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString());
                price.Text = dataGridViewX1.Rows[e.RowIndex].Cells["C4"].Value.ToString();
                date_pardakht.Text = dataGridViewX1.Rows[e.RowIndex].Cells["C6"].Value.ToString();
                number_snad.Text = dataGridViewX1.Rows[e.RowIndex].Cells["C7"].Value.ToString();
                string s = dataGridViewX1.Rows[e.RowIndex].Cells["C1"].Value.ToString();
                if (s == "نقدی")
                {
                    type_pardakht.Text = "نقدی";
                }
                else
                {
                    type_pardakht.Text = "حواله بانکی";
                    number_bank.Text = s;
                }

                tempid.Text = dataGridViewX1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //listoption.Items.Clear();
                setbut2();
            }
        catch
            {
            
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void date_pardakht_Load(object sender, EventArgs e)
        {

        }

        private void priceg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pricep_Click(object sender, EventArgs e)
        {

        }
    }
}
