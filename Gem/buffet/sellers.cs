using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.buffet
{
    public partial class sellers : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public sellers()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "name_seller", "name_shop", "tell", "mobile", "address", "fax", "email", "website", "telgram" };
            string[] na = new string[9];
            na[0] = name.Text;
            na[1] = shop.Text;
            na[2] = tell.Text;
            na[3] = mobile.Text;
            na[4] = address.Text;
            na[5] = fax.Text;
            na[6] = email.Text;
            na[7] = website.Text;
            na[8] = telgram.Text;
            ClassTemp.ins("buffet_seller", na, la);
            datagrid();
            setbut();
          
        }

        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select *  from buffet_seller");

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            name.Text = "";
            shop.Text = "";
            tell.Text = "";
            mobile.Text = "";
            address.Text = "";
            fax.Text = "";
            email.Text = "";
            website.Text = "";
            telgram.Text = "";
           
            // rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }
        private void sellers_Load(object sender, EventArgs e)
        {
            datagrid();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del("buffet_seller", tempid.Text);
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
            string[] la = {"id","name_seller", "name_shop", "tell", "mobile", "address", "fax", "email", "website", "telgram" };
            string[] na = new string[10];
            na[0] = tempid.Text;
            na[1] = name.Text;
            na[2] = shop.Text;
            na[3] = tell.Text;
            na[4] = mobile.Text;
            na[5] = address.Text;
            na[6] = fax.Text;
            na[7] = email.Text;
            na[8] = website.Text;
            na[9] = telgram.Text;
            ClassTemp.up("buffet_seller", na, la);
            datagrid();
            setbut();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        //    try
            {
                //"name", "lname", "sex", "age", "activity_history", "records", "evidence", "code_meli", "type", "email", "tell", "address"
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["c1"].Value.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells["c2"].Value.ToString();
                shop.Text = dataGridView1.Rows[e.RowIndex].Cells["c3"].Value.ToString();
                tell.Text = dataGridView1.Rows[e.RowIndex].Cells["c4"].Value.ToString();
                mobile.Text = dataGridView1.Rows[e.RowIndex].Cells["c5"].Value.ToString();
                address.Text = dataGridView1.Rows[e.RowIndex].Cells["c6"].Value.ToString();
                fax.Text = dataGridView1.Rows[e.RowIndex].Cells["c7"].Value.ToString();
                email.Text = dataGridView1.Rows[e.RowIndex].Cells["c8"].Value.ToString();
                website.Text = dataGridView1.Rows[e.RowIndex].Cells["c9"].Value.ToString();
                telgram.Text = dataGridView1.Rows[e.RowIndex].Cells["c10"].Value.ToString();
             
                setbut2();

            }
         //   catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
