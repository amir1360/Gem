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
    public partial class regust_coch : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string code_custmer;
        public regust_coch(string code)
        {
            InitializeComponent();
            code_custmer = code;
        }

        private void regust_coch_Load(object sender, EventArgs e)
        {
            code_service.DataSource = ClassTemp.redt("select id,title from basis_Service_coach");
            code_service.ValueMember = "id";
            code_service.DisplayMember = "title";
            code_coch.DataSource = ClassTemp.redt("select id,(name+' '+lname) AS title from basis_Employee where type=2");
            code_coch.ValueMember = "id";
            code_coch.DisplayMember = "title";
           
          
            datagrid();
        }
        private void datagrid()
        {

            
                string str;
                str = "select regust_coach.*,( basis_Employee.name+' '+ basis_Employee.lname) AS name_coach";
                str += ",( basis_service_coach.title) AS title";
                str += " from regust_coach,basis_service_coach,basis_Employee ";
                str += "where regust_coach.code_service_coach= basis_service_coach.id and regust_coach.code_coach=basis_Employee.id and regust_coach.code_customer=" + code_custmer + " ORDER BY regust_coach.id DESC; ";
              //  str += " and pardakht.code_factor=regust_coach.id";
               
            
           
            dataGridView1.DataSource = ClassTemp.redt(str);


        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
           
            // tempid.Text = "";
            //  number.Text = "";
            // rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;
          


        }
        private void code_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = ((DataRowView)code_service.SelectedItem)["id"].ToString();
            //  MessageBox.Show(selectedText);


            DataTable tb = new DataTable();


            tb = ClassTemp.redt("select price from basis_Service_coach where   id=" + selectedText);
           

            //  price.DataBindings.Add("Text", tb, "price");
            // number.DataBindings.Add("Text", tb, "daye");
            price.Text = tb.Rows[0]["price"].ToString();
           
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                MessageBox.Show("مبلغ خالی است");
                price.Select();
                return;
            
            }
            string[] la = { "code_customer","code_service_coach", "code_coach", "date_regust", "decs","price"};
            string[] na = new string[6];
            na[0] = code_custmer;
            na[1] = code_service.SelectedValue.ToString();
            na[2] = code_coch.SelectedValue.ToString();
            na[3] = date2.Text;
            na[4] = decs.Text;
            na[5] = price.Text;
            // Pass the array as an argument to PrintArray.
            int cc = ClassTemp.ins2("regust_coach", na, la);
           // MessageBox.Show(c.ToString());
            ////////////////////////////////////////////////////////////////////
            

            ///////////////////////////////////////////////////
            datagrid();
          
       
        }

        private void type_pardakht_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del("regust_coach", tempid.Text);
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                int id_set =int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                int c1 =int.Parse(dataGridView1.Rows[e.RowIndex].Cells["code_customer"].Value.ToString());
                string decs2 = dataGridView1.Rows[e.RowIndex].Cells["decs1"].Value.ToString();
                string price = dataGridView1.Rows[e.RowIndex].Cells["pprice"].Value.ToString();
               
                Form_1.Fr_pardakht n;

                n = new Form_1.Fr_pardakht(id_set, c1, decs2, price, 4);
                
                if (!n.Visible)
                {
                    n.MdiParent = this.MdiParent;
                    n.Show(); // Add the message
                }
                this.Close();


            }
            else
            {

                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                // textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                // textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                MessageBox.Show("مبلغ خالی است");
                price.Select();
                return;

            }
            string[] la = { "id","code_customer", "code_service_coach", "code_coach", "date_regust", "decs", "price" };
            string[] na = new string[7];
            na[0] = tempid.Text;
            na[1] = code_custmer;
            na[2] = code_service.SelectedValue.ToString();
            na[3] = code_coch.SelectedValue.ToString();
            na[4] = date2.Text;
            na[5] = decs.Text;
            na[6] = price.Text;
            // Pass the array as an argument to PrintArray.
            ClassTemp.up("regust_coach", na, la);
            // MessageBox.Show(c.ToString());
            ////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////
            datagrid();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["pprice"].Value.ToString();
                date2.Text = dataGridView1.Rows[e.RowIndex].Cells["date_regust1"].Value.ToString();
                code_service.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["code_service_coach"].Value.ToString());
                code_coch.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["code_coach"].Value.ToString());
 
                //listoption.Items.Clear();
                setbut2();
            }
            catch { }
        }

        private void date2_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
