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
    public partial class Form_Enter : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        public Form_Enter()
        {
            InitializeComponent();
        }

        private void Form_Enter_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setonlinecustomer();
        }
        private void setonlinecustomer()
        {
            //  DataTable tb = new DataTable();
            DataTable ds1 = new DataTable();
            DataTable ds2 = new DataTable();
            ds1 = ClassTemp.redt("select (Customer.name+' '+Customer.lname+' '+CONVERT(varchar(10),Register_entry.time_enter)+'ش کمد :'+CONVERT(varchar(10),Register_entry.code_clost)) AS fullname ,temp_enter.*  from temp_enter,Customer,Register_entry where Register_entry.id=temp_enter.register_code and temp_enter.code_cart=Customer.codecart and temp_enter.code_cart!='000'");
            ds2 = ClassTemp.redt("select ('متفرقه '+enter_other.name+' '+enter_other.lname+' '+CONVERT(varchar(10),enter_other.time_start)+'ش کمد :'+CONVERT(varchar(10),temp_enter.number_closet)) AS fullname,temp_enter.* from temp_enter,enter_other where enter_other.id=temp_enter.register_code and temp_enter.code_cart like '000%_%'");
            ds1.Merge(ds2);
            dataGridView1.DataSource = ds1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            var senderGrid = (DataGridView)sender;
             if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
             {

              //   MessageBox.Show(e.ColumnIndex.ToString());
                 if (e.ColumnIndex == 2)
                 {
                     //////////////////////////////////////////////////////////////آزادسازی کمد
                     string closet = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                     //DataTable tb2 = new DataTable();
                    // tb2 = ClassTemp.Search(closet, "basis_Closet", "number");
                     //string number, idcloset;
                     //idcloset = tb2.Rows[0]["id"].ToString();
                     //number = tb2.Rows[0]["number"].ToString();
                     string[] la2 = { "number", "code_customer" };
                     string[] na2 = new string[2];
                     na2[0] = closet;
                     na2[1] = "0";
                     ClassTemp.up2("basis_Closet", na2, la2);
                     ////////////////////////////////////////////////////////////// اضافه کردن اطلاعات خروج به جدول ورود
                     string code_cart = dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
                     string code_register = dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
                     string id_temp = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                     if ((code_cart).IndexOf("000") >-1 )//////متفرقه
                     {

                         //DataTable tb3 = new DataTable();
                         //tb2 = ClassTemp.Search(code_register, "enter_other", "id");
                         string[] la = { "id", "time_end" };
                         string[] na = new string[2];
                         na[0] = code_register;
                         na[1] = DateTime.Now.ToString("HH:mm");
                         ClassTemp.up("enter_other", na, la);
                     }
                     else////عضو
                     {
                       
                         //DataTable tb3 = new DataTable();
                         //tb2 = ClassTemp.Search(code_register, "Register_entry", "id");
                         string[] la = { "id", "date_end", "time_end" };
                         string[] na = new string[3];
                         na[0] = code_register;
                         na[1] = Classmain.date_re;
                         na[2] = DateTime.Now.ToString("HH:mm");
                         ClassTemp.up("Register_entry", na, la);
                     }
                     ///////////////////////////////////////////////////////////////////////  حذف از جدول تم‍پ
                     ClassTemp.del("temp_enter", id_temp);
                     /////////////////////////////////////////////////////////////////باز کردن گیت خروج و بستن
                   /*  SerialPort cc = new SerialPort(Classmain.port5, 2400);
                     cc.Open();
                     int i = 1;
                     byte[] buffer = BitConverter.GetBytes(i);
                     cc.Write("3");
                     System.Threading.Thread.Sleep(1000);
                     cc.Write("4");*/
                     //close = true;
                 
                 }

             
             }
            
            /* var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

            

            }
            else
            {

                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                // textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                // textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            {/*
                //////////////////////////////////////////////////////////////آزادسازی کمد
                DataTable tb2 = new DataTable();
                tb2 = ClassTemp.Search(closet, "basis_Closet", "number");
                string number, idcloset;
                idcloset = tb2.Rows[0]["id"].ToString();
                number = tb2.Rows[0]["number"].ToString();
                string[] la2 = { "id", "code_customer" };
                string[] na2 = new string[2];
                na2[0] = idcloset;
                na2[1] = "0";
                ClassTemp.up("basis_Closet", na2, la2);
                ////////////////////////////////////////////////////////////// اضافه کردن اطلاعات خروج به جدول ورود
                DataTable tb3 = new DataTable();
                tb2 = ClassTemp.Search(code_register, "Register_entry", "id");
                string[] la = { "id", "date_end", "time_end" };
                string[] na = new string[3];
                na[0] = code_register;
                na[1] = Classmain.date_re;
                na[2] = DateTime.Now.ToString("HH:mm");
                ClassTemp.up("Register_entry", na, la);
                ///////////////////////////////////////////////////////////////////////  حذف از جدول تم‍پ
                ClassTemp.del("temp_enter", id_temp);
                /////////////////////////////////////////////////////////////////باز کردن گیت خروج و بستن
                SerialPort cc = new SerialPort(Classmain.port5, 2400);
                cc.Open();
                int i = 1;
                byte[] buffer = BitConverter.GetBytes(i);
                cc.Write("3");
                System.Threading.Thread.Sleep(1000);
                cc.Write("4");
                close = true;
                /////////////////////////////////////////////////////////////////////////////////
          */  
        }

        }
    }

