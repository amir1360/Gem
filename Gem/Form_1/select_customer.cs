using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Gem.Form_1
{
    public partial class select_customer : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string resultcodecart;
        int nm = 0;
        public select_customer()
        {
            InitializeComponent();
        }
        public select_customer(int n)
        {
            InitializeComponent();
            nm = n;//بررسی مدارک و وضعیت مشتری
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = ClassTemp.redt("select id,name,lname,codecart,fingerprint,codemeli,mobile,insurance  from Customer where lname " + " like N'%" + textBox1.Text + "%'");
        }

        private void select_customer_Load(object sender, EventArgs e)
        {
            datagrid();
            serialPort1.PortName = Classmain.port2;

        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select id,name,lname,codecart,fingerprint,codemeli,mobile,insurance  from Customer ");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                codecart.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc9"].Value.ToString();
                main_customer n;
                if (nm == 0)
                {
                   n = new main_customer(codecart.Text);
                }
                else {  n = new main_customer(codecart.Text,nm); }
                if (!n.Visible)
                {
                    n.MdiParent = this.MdiParent;
                    n.Show(); // Add the message
                }
                this.Close();


            }
            else
            {

                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                // textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                // textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                codecart.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc9"].Value.ToString();
                fingerprint.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc10"].Value.ToString();
            }
             catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                datagrid(); 
            }else
            {
                dataGridView1.DataSource = ClassTemp.redt("select id,name,lname,codecart,fingerprint,codemeli,mobile,insurance  from Customer where codemeli " + " like N'%" + textBox2.Text + "%'");
              //  dataGridView1.DataSource = ClassTemp.Search(textBox2.Text, "customer", "codemeli"); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                char code1;

                // System.Text.Encoding enc = System.Text.Encoding.GetEncoding("windows-1252");
                //   byte[] buffer = new byte[] { 0xff };
                code1 = Convert.ToChar(98);          //b
                serialPort1.Write(code1.ToString());
                code1 = Convert.ToChar(115);        //s
                serialPort1.Write(code1.ToString());
                code1 = Convert.ToChar(116);        //t
                serialPort1.Write(code1.ToString());
                code1 = Convert.ToChar(115);        //s
                serialPort1.Write(code1.ToString());
                code1 = Convert.ToChar(126);        //~
                serialPort1.Write(code1.ToString());
                timer1.Enabled = true;
                //System.Threading.Thread.Sleep(1000);

                // codecart.Text = resultcodecart;
                //  codecart_Click(sender, e);
                //resultcodecart = "";
                // serialPort1.Close();
            }
            catch
            {
                serialPort1.Close();
                MessageBox.Show("خطا کارت خوان را بررسی کنید");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string input;
            input = serialPort1.ReadLine();
            // MessageBox.Show(input, " کارت");
            input = input.Substring(0, input.Length - 3);
            //  textBox1.Text = input;
            // byte [] buffer;
            input = Regex.Replace(input, @"\s", "");
            int decValue = Convert.ToInt32(input, 16);
            Int64 x;
            x = decValue + 2265576825;
            resultcodecart = x.ToString();
            serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (resultcodecart != "")
            {
                textBox3.Text = resultcodecart;
                resultcodecart = "";
                timer1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                datagrid();
            }
            else
            {
                dataGridView1.DataSource = ClassTemp.redt("select id,name,lname,codecart,fingerprint,codemeli,mobile,insurance  from Customer where codecart ='" + textBox3.Text + "'");
                //  dataGridView1.DataSource = ClassTemp.Search(textBox2.Text, "customer", "codemeli"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClassTemp.redt("select id,name,lname,codecart,fingerprint,codemeli,mobile,insurance  from Customer where insurance <'" + Classmain.date_re + "' or insurance IS NULL");
                //  dataGridView1.DataSource = ClassTemp.Search(textBox2.Text, "customer", "codemeli"); 
           
        }
    }
}
