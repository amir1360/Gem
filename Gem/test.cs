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
    public partial class test : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        DataTable ds1 = new DataTable();
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            
            ds1 = ClassTemp.redt("select (Customer.name+' '+Customer.lname+' '+CONVERT(varchar(10),Register_entry.time_enter)+'ش کمد :'+CONVERT(varchar(10),Register_entry.code_clost)) AS fullname ,temp_enter.*  from temp_enter,Customer,Register_entry where Register_entry.id=temp_enter.register_code and temp_enter.code_cart=Customer.codecart and temp_enter.code_cart!='000'");
           
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
