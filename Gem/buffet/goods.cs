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
    public partial class goods : Form
    {
         OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        int group_code = 0;
             
        
        public goods(string t,string b,int group)
        {
            InitializeComponent();
            table = t;
            baner = b;
            group_code = group;
        }

        private void goods_Load(object sender, EventArgs e)
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
          
        
        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;
         

        }
    }
}
