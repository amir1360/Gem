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
    public partial class group_goods : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "buffet_groupgoods";
        public group_goods()
        {
            InitializeComponent();
        }

        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.namayesh("id,name", table);

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            title.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }

        private void group_goods_Load(object sender, EventArgs e)
        {
            datagrid();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (title.Text == "") return;
            string[] la = { "name" };
            string[] na = new string[1];
            na[0] = title.Text;

            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
            datagrid();
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            string[] la = { "id", "name" };
            string[] na = new string[2];
            na[0] = tempid.Text;
            na[1] = title.Text;
            ClassTemp.up(table, na, la);
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

                MessageBox.Show(e.ColumnIndex.ToString());
                  if (e.ColumnIndex == 0)
                 {

                     tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                     Fr_basis_Closet n = new Fr_basis_Closet("basis_Closet", " کمدهای  " + title.Text, int.Parse(tempid.Text));
                     if (!n.Visible)
                     {
                         n.MdiParent = this.MdiParent;
                         n.Show(); // Add the message
                     }
                     this.Close();
                  }
             


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
                title.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                setbut2();



            }
            catch { }
        }
    }
}
