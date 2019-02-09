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
    public partial class access : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        int codeuser;
        public access(string s)
        {
            InitializeComponent();
            codeuser = int.Parse(s);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
               
                
            
        }

        private void access_Load(object sender, EventArgs e)
        {
              Label[] ccc = new Label[] { l1, l2, l3, l4, l5, l6 };
              CheckedListBox [] sss = new CheckedListBox[] { s1, s2, s3, s4, s5, s6 };
              DataTable tb = new DataTable();
              tb = ClassTemp.redt("select * from X_access");
              for (int i = 0; i < 6; i++)
              {
                  ccc[i].Text = tb.Rows[i]["name"].ToString();
                  int t = int.Parse(tb.Rows[i]["id"].ToString());
                  DataTable tb2 = new DataTable();
                  string s = "";
                  switch (codeuser)
                  {
                      case 1: s = "select id,name,user1 AS kayes from X_access2 "; break;
                      case 2: s = "select id,name,user2 AS keyes from X_access2 "; break;
                      case 3: s = "select id,,name user3 AS keyes from X_access2 "; break;
                      case 4: s = "select id,name,user4 AS keyes from X_access2 "; break;
                      case 5: s = "select id,name,user5 AS keyes from X_access2 "; break;

                  }
                  tb2 = ClassTemp.redt(s+" where id_group=" + t.ToString() + " order by id_group DESC");
                  for (int j = 0; j < tb2.Rows.Count; j++)

                  { sss[i].Items.Add(tb2.Rows[j]["name"].ToString());
                  sss[i].SetItemChecked(j, Convert.ToBoolean(tb2.Rows[j][2].ToString()));
                  }
                      
              }
           

           
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//id accsess
            string[] la = { "id", "user"+codeuser.ToString()};
            string[] na = new string[2];
            int i = 0;
            foreach (object item in s1.Items)
            {
                if (!s1.CheckedItems.Contains(item))
                {

                    na[0] = x[i].ToString();
                    na[1] = "0";
                  //  MessageBox.Show(item.ToString());
                }
                else
                {
                    na[0] = x[i].ToString();
                    na[1] = "1";
                
                }
                ClassTemp.up("X_access2", na, la);
                i++;
            }
           
        }
    }
}
