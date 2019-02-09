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
    public partial class users : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public users()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
           
            if (name.Text == "") return; if (lname.Text == "") return;
            string[] la = { "name", "lname", "username", "password" };
            string[] na = new string[4];
            na[0] = name.Text;
            na[1] = lname.Text;
            na[2] = username.Text;
            na[3] = password.Text;
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins("users", na, la);
            datagrid();
            setbut();
        }

        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select * from users where id>0");
        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            name.Text = "";
            lname.Text = "";
            username.Text = "";
            password.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }
        private void users_Load(object sender, EventArgs e)
        {
            datagrid();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del("users", tempid.Text);
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
            string[] la = { "id","name", "lname", "username", "password" };
            string[] na = new string[5];
            na[0] = tempid.Text;
            na[1] = name.Text;
            na[2] = lname.Text;
            na[3] = username.Text;
            na[4] = password.Text;
            ClassTemp.up("users", na, la);
            datagrid();
            setbut();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                Basis.access n = new Basis.access(tempid.Text);
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


                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells["c1"].Value.ToString();
                lname.Text = dataGridView1.Rows[e.RowIndex].Cells["c2"].Value.ToString();
                username.Text = dataGridView1.Rows[e.RowIndex].Cells["c3"].Value.ToString();
                password.Text = dataGridView1.Rows[e.RowIndex].Cells["c4"].Value.ToString();

                setbut2();



            }
            catch { }
        }
    }
}
