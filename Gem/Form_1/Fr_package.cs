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
    public partial class Fr_package : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        public Fr_package(string t, string b)
        {
            InitializeComponent();
            table = t;
            baner = b;
         //   this.price.TextChanged += new System.EventHandler(this.CurrencyFormat);
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select basis_Service.*,(basis_DayMonthly.title) AS mon,(basis_Session.title) as ses from basis_Service,basis_DayMonthly,basis_Session where basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id  ");
            dataGridView1.Columns[5].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
           tempid.Text = "";
          //  number.Text = "";
          price.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;


        }
        private void Fr_package_Load(object sender, EventArgs e)
        {
            ribbonClientPanel1.Text = baner;
            daymontly.DataSource = ClassTemp.redt("select * from  basis_DayMonthly");
            // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            daymontly.ValueMember = "id";
            daymontly.DisplayMember = "title";
            session.DataSource = ClassTemp.redt("select * from  basis_Session");
            // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            session.ValueMember = "id";
            session.DisplayMember = "title";
            listoption.DataSource = ClassTemp.redt("select * from  basis_Option");
            // code_service.DataSource = dt;
            //select Service_table.id,basis_Service.title+'-روز:'+CONVERT(varchar,Service_table.dayes) AS name from  Service_table,basis_Service where  Service_table.code_service=basis_Service.id
            listoption.ValueMember = "id";
            listoption.DisplayMember = "title";
            datagrid();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "code_daymon", "code_session", "codes_option", "name_option", "price" };
            string[] na = new string[5];
            
            na[0] = daymontly.SelectedValue.ToString();//.SelectedIndex.ToString();
            na[1] = session.SelectedValue.ToString();
           
            
            string s1,n1;
           
            s1 = "";
            n1 = "";
            foreach (object itemChecked in listoption.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                s1 += castedItem["title"].ToString()+"-";
                n1 += castedItem["id"].ToString() + ";";
            }
            na[2] = n1;
            na[3] = s1;
           // MessageBox.Show(s1+n1);
            na[4] = price.Text;
            
            // Pass the array as an argument to PrintArray.
           ClassTemp.ins("basis_Service", na, la);
            // dataGridView1.DataSource = customer1.namayesh(4, "customer");
           datagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

       
        private void price_TextChanged(object sender, EventArgs e)
        {
            if (price.Text != string.Empty)
            {
                price.Text = string.Format("{0:N0}", double.Parse(price.Text.Replace(",", "")));
                price.Select(price.TextLength, 0);
            }
        }

        private void price_Leave(object sender, EventArgs e)
        {
           // var value = GetValueFromTextBox(price.Text);

           // price.Text = value.ToString("c");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string[] la = { "id","code_daymon", "code_session", "codes_option", "name_option", "price" };
            string[] na = new string[6];

            na[0] = tempid.Text.ToString();
            na[1] = daymontly.SelectedValue.ToString();//.SelectedIndex.ToString();
            na[2] = session.SelectedValue.ToString();


            string s1, n1;

            s1 = "";
            n1 = "";
            foreach (object itemChecked in listoption.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                s1 += castedItem["title"].ToString() + "-";
                n1 += castedItem["id"].ToString() + ";";
            }
            na[3] = n1;
            na[4] = s1;
            // MessageBox.Show(s1+n1);
            na[5] = price.Text;

            // Pass the array as an argument to PrintArray.
            ClassTemp.up("basis_Service", na, la);
            // dataGridView1.DataSource = customer1.namayesh(4, "customer");
            datagrid();
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                daymontly.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
                session.SelectedValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString());
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
                //listoption.Items.Clear();
                setbut2();
            }
            catch { }
        }

        private void Del_Click(object sender, EventArgs e)
        {

        }
        



    }
       
    }

