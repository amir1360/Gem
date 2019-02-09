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
    public partial class Fr_class : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        string week = "";
        bool tick = false;
        public Fr_class(string t, string b)
        {
            InitializeComponent();
             table = t;
            baner = b;
        }

        private void dateTimeInput1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            //if (title.Text == "") return; if (decs.Text == "") return; if (price.Text == "") return;
            string[] la = { "code_coch", "title", "start_date", "c0", "c1", "c2", "c3", "c4", "c5", "c6", "decs", "price", "session", "fixed", "price_percent" };
            string[] na = new string[15];
            na[0] = coch.SelectedValue.ToString();
            na[1] = title.Text;
            na[2] = date_start.Text;
            na[3] = ""; na[4] = ""; na[5] = ""; na[6] = ""; na[7] = ""; na[8] = ""; na[9] = "";
            string s1 = Classmain.week;
            int i=0;
            char[] char1 = new char[] { ';' };
            string [] v1={"","",""};
            foreach (string substring in s1.Split(';'))
            {
              //  MessageBox.Show(substring);
                if (substring == "") break;
                i = 0;
                foreach (string substring2 in substring.Split(':'))
                {
                    v1[i] = substring2;
                   i++;
                   }
                if (v1[0] == "0") na[3] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "1") na[4] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "2") na[5] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "3") na[6] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "4") na[7] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "5") na[8] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "6") na[9] = (v1[1] + ":" + v1[2]);

                
            }
            na[10] = decs.Text;
            na[11] = price.Text;
            na[12] = number.Text;
            na[13] = fix.Text;
            na[14] = percent.Text;
            // Pass the array as an argument to PrintArray.
           ClassTemp.ins(table, na, la);
           datagrid();
           setbut();
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select basis_Class.*,(basis_Employee.name+' '+basis_Employee.lname) AS name from basis_Class,basis_Employee where basis_Class.code_coch=basis_Employee.id  ");
          
        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            title.Text = "";
            decs.Text = "";
            price.Text = "";
            fix.Text = "";
            percent.Text = "";
            tick = false;

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;
            tick = false;


        }
        private void Fr_class_Load(object sender, EventArgs e)
        {
            datagrid();
            coch.DataSource = ClassTemp.redt("select id,name+' '+lname AS title from  basis_Employee where type=2");
            // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            coch.ValueMember = "id";
            coch.DisplayMember = "title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fr_week fm;
            if (tempid.Text == "")
            { fm = new Fr_week(); }
            else { fm = new Fr_week("basis_class", int.Parse(tempid.Text)); tick = true; }
           
            fm.MdiParent = this.ParentForm;
            fm.Show();
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            if (price.Text != string.Empty)
            {
                price.Text = string.Format("{0:N0}", double.Parse(price.Text.Replace(",", "")));
                price.Select(price.TextLength, 0);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //if (title.Text == "") return; if (decs.Text == "") return; if (price.Text == "") return;
            string[] la = { "id","code_coch", "title", "start_date", "c0", "c1", "c2", "c3", "c4", "c5", "c6", "decs", "price", "session", "fixed", "price_percent" };
            string[] na = new string[16];
            na[0] = tempid.Text;
            na[1] = coch.SelectedValue.ToString();
            na[2] = title.Text;
            na[3] = date_start.Text;
            na[4] = ""; na[5] = ""; na[6] = ""; na[7] = ""; na[8] = ""; na[9] = ""; na[10] = "";
             string s1 = Classmain.week;
            if (tick == false)
                s1 = week;
            int i = 0;
            char[] char1 = new char[] { ';' };
            string[] v1 = { "", "", "" };
            foreach (string substring in s1.Split(';'))
            {
                //  MessageBox.Show(substring);
                if (substring == "") break;
                i = 0;
                foreach (string substring2 in substring.Split(':'))
                {
                    v1[i] = substring2;
                    i++;
                }
               
                if (v1[0] == "0") na[4] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "1") na[5] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "2") na[6] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "3") na[7] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "4") na[8] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "5") na[9] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "6") na[10] = (v1[1] + ":" + v1[2]);


            }
            na[11] = decs.Text;
            na[12] = price.Text;
            na[13] = number.Text;
            na[14] = fix.Text;
            na[15] = percent.Text;
            // Pass the array as an argument to PrintArray.
            ClassTemp.up(table, na, la);
            datagrid();
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                coch.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column17"].Value.ToString());
                // customer.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                date_start.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                //DateTime startDate = DateTime.Parse(date_start.Text);
                //string format = "yyyy/MM/dd";
                //date_start.Text = startDate.ToString(format);
                title.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
                decs.Text = dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
                number.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                fix.Text = dataGridView1.Rows[e.RowIndex].Cells["Column18"].Value.ToString();
                percent.Text = dataGridView1.Rows[e.RowIndex].Cells["Column19"].Value.ToString();

                for (int i = 0; i < 7; i++)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[i + 5].Value.ToString() != "")
                        week += i.ToString()+":"+dataGridView1.Rows[e.RowIndex].Cells[i +5].Value.ToString() + ";";

                }
                setbut2();
            }
            catch { }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            if (number.Text != string.Empty)
            {
                number.Text = string.Format("{0:N0}", double.Parse(number.Text.Replace(",", "")));
                number.Select(number.TextLength, 0);
            }
        }

        private void fix_TextChanged(object sender, EventArgs e)
        {
            if (fix.Text != string.Empty)
            {
                fix.Text = string.Format("{0:N0}", double.Parse(fix.Text.Replace(",", "")));
                fix.Select(fix.TextLength, 0);
            }
        }

        private void percent_TextChanged(object sender, EventArgs e)
        {
            if (percent.Text != string.Empty)
            {
                percent.Text = string.Format("{0:N0}", double.Parse(percent.Text.Replace(",", "")));
                percent.Select(percent.TextLength, 0);
            }
        }

        private void percent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fix_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Del_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            DialogResult dialogResult = MessageBox.Show("آیا مطمئن هستید!؟", "هشدار برای حذف اطالاعات", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassTemp.del(table, tempid.Text);
                datagrid();
                setbut();
            }
            else if (dialogResult == DialogResult.No)
            {
                setbut();

            }
        }
    }
}
