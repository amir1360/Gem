using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Gem
{
    public partial class Fr_basis_Closet : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        int group_code = 0;
        public Fr_basis_Closet(string t,string b,int group)
        {
            InitializeComponent();
            table = t;
            baner = b;
            group_code = group;
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if (number.Text == "") return; if (rfid.Text == "") return;
            string[] la = { "number", "rfid", "code_group" ,"code_customer"};
            string[] na = new string[4];
            na[0] = number.Text;
            na[1] = rfid.Text;
            na[2] = group_code.ToString();
            na[3] = status.SelectedIndex.ToString();
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
            datagrid();
            setbut();

        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.namayesh("id,number,rfid,code_customer", table, group_code);

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            number.Text = "";
            rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


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

        private void Edit_Click(object sender, EventArgs e)
        {
                      
            if (tempid.Text == "") return;
            string[] la = { "id", "number", "rfid", "code_customer" };
            string[] na = new string[4];
            na[0] = tempid.Text;
            na[1] = number.Text;
            na[2] = rfid.Text;
            na[3] = status.SelectedIndex.ToString();
            ClassTemp.up(table, na, la);
            datagrid();
            setbut();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                number.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                rfid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                status.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["code_customer"].Value.ToString());
                setbut2();

            }
            catch
            { }
        }

        private void Fr_basis_Closet_Load(object sender, EventArgs e)
        {
            datagrid();
            ribbonClientPanel1.Text = baner;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort ss = new SerialPort(Classmain.port1);
                ss.Open();
                rfid.Text = ss.ReadLine();
                ss.Close();
            }
            catch {
                MessageBox.Show("پورت وصل نیست " + Classmain.port1);
            }
        }
    }
}
