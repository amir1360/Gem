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
    public partial class Fr_week : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        int code = 0;
        string[] v1 = { "", "", "" };
        public Fr_week()
        {
            InitializeComponent();
            
        }
        public Fr_week(string t,int c)
        {
            InitializeComponent();
            table = t;
            code = c;
        }

        private void getdate(string s)//string s=7:8
        {
            int i = 0;
            foreach (string substring2 in s.Split(':'))
            {
                v1[i] = substring2;
                i++;
            }
            //v1=[7,8]
        }
        private void Fr_week_Load(object sender, EventArgs e)
        {
            CheckBox[] ccc = new CheckBox[] { c0, c1, c2, c3, c4, c5, c6 };
            ComboBox[] taa = new ComboBox[] { ta0, ta1, ta2, ta3, ta4, ta5, ta6 };
            ComboBox[] azz = new ComboBox[] { az0, az1, az2, az3, az4, az5, az6 };
            if (table != "")
            {
                DataTable t = new DataTable();
                t = ClassTemp.Searchweek(table, code);
                int m = 0;
                foreach (DataRow inRow in t.Rows)
                {
                    for (m = 0; m < 7; m++) //c0 ... c6
                    {
                        string ss = inRow[m].ToString();
                        if (ss != "")
                        {

                            ccc[m].Checked = true;
                            getdate(ss);
                            azz[m].Text = v1[0]; taa[m].Text = v1[1];
                        }
                    }
                  
                }

            }
            string ss1 = "";
            if (c0.Checked == true) { ss1 += "0:" + az0.Text + ":" + ta0.Text + ";"; }
            if (c1.Checked == true) { ss1 += "1:" + az1.Text + ":" + ta1.Text + ";"; }
            if (c2.Checked == true) { ss1 += "2:" + az2.Text + ":" + ta2.Text + ";"; }
            if (c3.Checked == true) { ss1 += "3:" + az3.Text + ":" + ta3.Text + ";"; }
            if (c4.Checked == true) { ss1 += "4:" + az4.Text + ":" + ta4.Text + ";"; }
            if (c5.Checked == true) { ss1 += "5:" + az5.Text + ":" + ta5.Text + ";"; }
            if (c6.Checked == true) { ss1 += "6:" + az6.Text + ":" + ta6.Text + ";"; }
            // MessageBox.Show(ss);
            Classmain.week = ss1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss="";
            if (c0.Checked == true) { ss += "0:" + az0.Text + ":" + ta0.Text + ";"; }
            if (c1.Checked == true) { ss += "1:" + az1.Text + ":" + ta1.Text + ";"; }
            if (c2.Checked == true) { ss += "2:" + az2.Text + ":" + ta2.Text + ";"; }
            if (c3.Checked == true) { ss += "3:" + az3.Text + ":" + ta3.Text + ";"; }
            if (c4.Checked == true) { ss += "4:" + az4.Text + ":" + ta4.Text + ";"; }
            if (c5.Checked == true) { ss += "5:" + az5.Text + ":" + ta5.Text + ";"; }
            if (c6.Checked == true) { ss += "6:" + az6.Text + ":" + ta6.Text + ";"; }
           // MessageBox.Show(ss);
            Classmain.week = ss;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
