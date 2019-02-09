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
    public partial class setting : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public setting()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            string[] la = { "id", "port1", "port2", "port3", "port4", "port5" };
            string[] na = new string[6];
            na[0] = "1";
            na[1] = p1.Text;
            na[2] = p2.Text;
            na[3] = p3.Text;
            na[4] = p4.Text;
            na[5] = p5.Text;

            ClassTemp.up("setting_port", na, la);
                      
            Classmain.port1 = p1.Text;
            Classmain.port2 = p2.Text;
            Classmain.port3 = p3.Text;
            Classmain.port4 = p4.Text;
            Classmain.port5 = p5.Text;
        }

        private void setting_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = ClassTemp.Search("1", "setting_port", "id");
            p1.DataBindings.Add("Text", tb, "port1");
            p2.DataBindings.Add("Text", tb, "port2");
            p3.DataBindings.Add("Text", tb, "port3");
            p4.DataBindings.Add("Text", tb, "port4");
            p5.DataBindings.Add("Text", tb, "port5");

            Classmain.port1 = p1.Text;
            Classmain.port2 = p2.Text;
            Classmain.port3 = p3.Text;
            Classmain.port4 = p4.Text;
            Classmain.port5 = p5.Text;
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
