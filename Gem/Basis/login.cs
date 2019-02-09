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
    public partial class login : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public login()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = ClassTemp.Searchuser(user.Text,pass.Text);
           
            if (tb.Rows.Count == 1)
            {
                string id_user = tb.Rows[0]["id"].ToString();
                string name = tb.Rows[0]["name"].ToString();
                string lname = tb.Rows[0]["lname"].ToString();
                MDIParentmain f = new MDIParentmain(id_user,name,lname);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("کلمه عبور یا رمز عبور اشتباه است");
            }
            
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
