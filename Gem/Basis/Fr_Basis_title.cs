using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem
{
    public partial class Fr_Basis_title : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        public Fr_Basis_title(string t,string b)
        {
            InitializeComponent();
            table = t;
            baner = b;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (title.Text == "") return;
            string[] la = { "title" };
            string[] na = new string[1];
            na[0] = title.Text;
          
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
            datagrid();
            setbut();
            
        }

        private void Fr_Basis_Sports_movement_Load(object sender, EventArgs e)
        {
            datagrid();
            ribbonClientPanel1.Text = baner;
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.namayesh("id,title", table);
        
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                title.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                setbut2();

            }
            catch
            { }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            string[] la = { "id", "title" };
            string[] na = new string[2];
            na[0] = tempid.Text;
            na[1] = title.Text;
            ClassTemp.up(table, na, la);
            datagrid();
            setbut();
        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tempid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       
    }
}
