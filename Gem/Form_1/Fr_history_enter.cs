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
    public partial class Fr_history_enter : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        int code_register;
     
        
        public Fr_history_enter(string t, string b,int code)
        {
            InitializeComponent();
             table = t;
            baner = b;
            code_register = code;
        }

        private void Fr_history_enter_Load(object sender, EventArgs e)
        {
            ribbonClientPanel1.Text = baner;
            datagrid();
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select id,date_first,date_end,time_enter,time_end  from Register_entry where code_register=" + code_register);

        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
