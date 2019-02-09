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
   
    public partial class insurance : Form
    { 
        OperationtblPart ClassTemp = new OperationtblPart();
        int code_customer ;
        string allname = "";
        public insurance(int code,string namelname)
        {
            InitializeComponent();
            code_customer = code;
            allname = namelname;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void datagrid()
        {

            string str;
            str = "select * from insurance where  code_customer=" + code_customer + " ORDER BY id DESC; ";
            name.Text = allname;
            lname.Text = code_customer.ToString();
            dataGridView1.DataSource = ClassTemp.redt(str);


        }
        private void insurance_Load(object sender, EventArgs e)
        {
            datagrid();

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
        private void Add_Click(object sender, EventArgs e)
        {

            if (price.Text == "")
            {
                MessageBox.Show("مبلغ خالی است");
                price.Select();
                return;

            }
            if (date_end.Text == "")
            {
                MessageBox.Show("تاریخ خالی است");
                date_end.Select();
                return;

            }
            string[] la = { "code_customer", "price", "date_end" };
            string[] na = new string[3];
            na[0] = code_customer.ToString();
            na[1] = price.Text;
            na[2] = date_end.Text;
           
            // Pass the array as an argument to PrintArray.
            int cc = ClassTemp.ins2("insurance", na, la);
            // MessageBox.Show(c.ToString());
            ////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////
            datagrid();
          
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del("insurance", tempid.Text);
                datagrid();
                setbut();
            }
            else if (dialogResult == DialogResult.No)
            {
                setbut();

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            string[] la = {"id", "code_customer", "price", "date_end" };
            string[] na = new string[4];
            na[0] = tempid.Text;
            na[1] = code_customer.ToString();
            na[2] = price.Text;
            na[3] = date_end.Text;
            ClassTemp.up("insurance", na, la);
            datagrid();
            setbut();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                int id_set = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["c0"].Value.ToString());
                int c1 = code_customer;
                string date2 = dataGridView1.Rows[e.RowIndex].Cells["c1"].Value.ToString();
                string price = dataGridView1.Rows[e.RowIndex].Cells["c2"].Value.ToString();
                Form_1.Fr_pardakht n;

                n = new Form_1.Fr_pardakht(id_set, c1,date2 , price,500);

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["c0"].Value.ToString();
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["c2"].Value.ToString();
                date_end.Text = dataGridView1.Rows[e.RowIndex].Cells["c1"].Value.ToString();
                //listoption.Items.Clear();
                setbut2();
            }
            catch { }
        }
    }
}
