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
    public partial class Fr_sevice_coche : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        public Fr_sevice_coche(string t, string b)
        {
            InitializeComponent();
            table = t;
            baner = b;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.namayesh("id,title,decs,price", table);

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            title.Text = "";
            decs.Text = "";
            price.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }
        private void Fr_sevice_coche_Load(object sender, EventArgs e)
        {
            datagrid();
            ribbonClientPanel1.Text = baner;
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
            string[] la = { "id", "title", "decs" ,"price"};
            string[] na = new string[4];
            na[0] = tempid.Text;
            na[1] = title.Text;
            na[2] = decs.Text;
            na[3] = price.Text;
            ClassTemp.up(table, na, la);
            datagrid();
            setbut();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (title.Text == "") return; if (decs.Text == "") return; if (price.Text == "") return;
            string[] la = { "title", "decs", "price" };
            string[] na = new string[3];
            na[0] = title.Text;
            na[1] = decs.Text;
            na[2] = price.Text;
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
            datagrid();
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                title.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                decs.Text =dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                price.Text =dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                setbut2();

            }
            catch
            { }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            if (price.Text != string.Empty)
            {
                price.Text = string.Format("{0:N0}", double.Parse(price.Text.Replace(",", "")));
                price.Select(price.TextLength, 0);
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
