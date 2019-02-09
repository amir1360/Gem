using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.Basis
{
    public partial class Fr_Basis_title_dayes : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        public Fr_Basis_title_dayes(string t, string b)
        {
            InitializeComponent();
            table = t;
            baner = b;

        }

        private void Fr_Basis_title_dayes_Load(object sender, EventArgs e)
        {
            datagrid();
            ribbonClientPanel1.Text = baner;
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.namayesh("id,title,dayes", table);

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            title.Text = "";
            dayes.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (title.Text == "") return;
            if (dayes.Text == "") return;
            string[] la = { "title","dayes" };
            string[] na = new string[2];
            na[0] = title.Text;
            na[1] = dayes.Text;
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
            string[] la = { "id", "title","dayes" };
            string[] na = new string[3];
            na[0] = tempid.Text;
            na[1] = title.Text;
            na[2] = dayes.Text;
            ClassTemp.up(table, na, la);
            datagrid();
            setbut();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                title.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dayes.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
                setbut2();

            }
            catch
            { }
        }

        private void dayes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
