using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.Report
{
    public partial class selectbank : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public selectbank()
        {
            InitializeComponent();
        }

        private void selectbank_Load(object sender, EventArgs e)
        {
            number_bank.DataSource = ClassTemp.redt("select id,name_bank+' '+number_bank AS title from  Bank");
            number_bank.ValueMember = "id";
            number_bank.DisplayMember = "title";
        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Report.carsh fm = new Report.carsh(number_bank.SelectedValue.ToString(),"بانک "+number_bank.Text);
            fm.MdiParent = this.ParentForm;
            fm.Show();
            
        }
    }
}
