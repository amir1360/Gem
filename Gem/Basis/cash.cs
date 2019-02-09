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
    public partial class cash : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public cash()
        {
            InitializeComponent();
        }

        private void p1_TextChanged(object sender, EventArgs e)
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            string[] la = { "id", "cashfirst" };
            string[] na = new string[2];
            na[0] = "1";
            na[1] = cashfirst.Text;


            ClassTemp.up("basis_Cash", na, la);

        
        }

        private void cash_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = ClassTemp.Search("1", "basis_Cash", "id");
            cashfirst.DataBindings.Add("Text", tb, "cashfirst");
        }
    }
}
