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
    public partial class Fr_Basis_bank : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public Fr_Basis_bank()
        {
            InitializeComponent();
        }

       

        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.namayesh("*", "Bank");
            dataGridView1.Columns[3].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            name_bank.Text = "";
            numberbank.Text = "";
            cashfirst.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }
        private void Fr_Basis_bank_Load(object sender, EventArgs e)
        {
            datagrid();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name_bank.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                numberbank.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cashfirst.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                setbut2();

            }
            catch
            { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            if (name_bank.Text == "") return;
            if (numberbank.Text == "") return;
            if (cashfirst.Text == "") cashfirst.Text = "0";
            string[] la = {"id", "name_bank", "number_bank", "cashfirst" };
            string[] na = new string[4];
            na[0] = tempid.Text;
            na[1] = name_bank.Text;
            na[2] = numberbank.Text;
            na[3] = cashfirst.Text;
            ClassTemp.up("Bank", na, la);
            datagrid();
            setbut();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (name_bank.Text == "") return;
            if (numberbank.Text == "") return;
            if (cashfirst.Text == "") cashfirst.Text="0";
            string[] la = { "name_bank","number_bank","cashfirst"};
            string[] na = new string[3];
            na[0] = name_bank.Text;
            na[1] = numberbank.Text;
            na[2] = cashfirst.Text;
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins("Bank", na, la);
            datagrid();
            setbut();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del("Bank", tempid.Text);
                datagrid();
                setbut();
            }
            else if (dialogResult == DialogResult.No)
            {
                setbut();

            }
           
        }

        private void cashfirst_TextChanged(object sender, EventArgs e)
        {
            if (cashfirst.Text != string.Empty)
            {
                cashfirst.Text = string.Format("{0:N0}", double.Parse(cashfirst.Text.Replace(",", "")));
                cashfirst.Select(cashfirst.TextLength, 0);
            }
        }

        private void cashfirst_KeyPress(object sender, KeyPressEventArgs e)
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
