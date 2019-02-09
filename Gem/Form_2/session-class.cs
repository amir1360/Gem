using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gem.Form_2
{
    public partial class session_class : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        int code_customer = 0;
       
        public session_class(string t, string b, int customer)
        {
            InitializeComponent();
            table = t;
            baner = b;
            code_customer = customer;
        }

        private void session_class_Load(object sender, EventArgs e)
        {
            code_service.DataSource = ClassTemp.redt("select basis_Class.id,(basis_Employee.name+' '+basis_Employee.lname+ ' ' +basis_Class.title) as title from basis_Class,basis_Employee where basis_Class.code_coch=basis_Employee.id ");
            code_service.ValueMember = "id";
            code_service.DisplayMember = "title";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "type_service", "code_serivce", "date_first", "date_end", "number", "code_customer", "price", "discount", "c0", "c1", "c2", "c3", "c4", "c5", "c6" };
            string[] na = new string[15];
            na[0] = "2";
            na[1] = code_service.SelectedValue.ToString();
            na[2] = date_start.Text;
            na[3] = date_end.Text;
            na[4] = number.Text;
            na[5] = code_customer.ToString();


            na[6] = price.Text;
            na[6] = na[6].Replace(",", String.Empty);
            na[7] = discount.Text;
            if (na[7] == "") na[7] = "0";
            na[7] = na[7].Replace(",", String.Empty);
            na[8] = ""; na[9] = ""; na[10] = ""; na[11] = ""; na[12] = ""; na[13] = ""; na[14] = "";
            string s1 = Classmain.week;
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
                if (v1[0] == "0") na[8] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "1") na[9] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "2") na[10] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "3") na[11] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "4") na[12] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "5") na[13] = (v1[1] + ":" + v1[2]);
                if (v1[0] == "6") na[14] = (v1[1] + ":" + v1[2]);


            }
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
           // datagrid();
           // setbut();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
