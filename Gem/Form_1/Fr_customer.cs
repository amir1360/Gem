using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;



namespace Gem.Form_1
{
    public partial class Fr_customer : Form
    {
         OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        string resultcodecart = "";
        int insertimage = 0;
       
        public Fr_customer(string t, string b)
        {
            InitializeComponent();
              table = t;
            baner = b;
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select *  from Customer ");

        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            rigister.Enabled = false;
            button2.Enabled = false;
            tempid.Text = "";
            name.Text = "";
            lname.Text = "";
            burn.Text = "";
            date_register.Text = "";
            codemeli.Text = "";
            codecart.Text = "";
            mobile.Text = "";
            insurance.Text = "";
            insertimage = 0;
            // rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;
            rigister.Enabled = true;
            button2.Enabled = true;
            insertimage = 0;


        }
        private void Fr_customer_Load(object sender, EventArgs e)
        {
            ribbonClientPanel1.Text = baner;
            datagrid();
            this.Width = Screen.PrimaryScreen.Bounds.Width-100;
            //this.Height = Screen.PrimaryScreen.Bounds.Height - 170;
            this.Left = (Screen.PrimaryScreen.Bounds.Width -  this.Width) / 2;
            serialPort1.PortName = Classmain.port2;
           // serialPort1.Open();
        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (name.Text == "") { MessageBox.Show("نام وارد نشده است"); name.Focus(); return; }
            if (lname.Text == "") { MessageBox.Show("نام خانوادگی وارد نشده است"); lname.Focus(); return; }
            if (codemeli.Text == "") { MessageBox.Show("کد ملی وارد نشده است"); codemeli.Focus(); return; }
            if (mobile.Text == "") { MessageBox.Show("تلفن وارد نشده است"); mobile.Focus(); return; }
          //  if (burn.Text == "") { MessageBox.Show("تاریخ تولد وارد نشده است"); burn.Focus(); return; }
            if (codecart.Text == "") { MessageBox.Show("کد کارت وارد نشده است"); codecart.Focus(); return; }
          //  if (fingerprint.Text == "") { MessageBox.Show("اثر انگشت وارد نشده است"); fingerprint.Focus(); return; }
            if (date_register.Text == "") { MessageBox.Show("تاریخ ثبت وارد نشده است"); date_register.Focus(); return; }

            try
            {
                string[] la = { "codemeli", "name", "lname", "sex", "mobile", "burn", "typesport", "bloud", "codecart", "insurance", "address", "date_register", "comment" };
                string[] na = new string[13];
                na[0] = codemeli.Text;
                na[1] = name.Text;
                na[2] = lname.Text;
                na[3] = sex.SelectedIndex.ToString();
                na[4] = mobile.Text;
                na[5] = burn.Text;
                na[6] = typesport.SelectedIndex.ToString();
                na[7] = bloud.SelectedIndex.ToString();
                na[8] = codecart.Text;
                na[9] = insurance.Text;
                na[10] = address.Text;
                na[11] = date_register.Text;
                na[12] = command.Text;

                // Pass the array as an argument to PrintArray.
                ClassTemp.ins(table, na, la);
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(Application.StartupPath + @"\Images1\" + codemeli.Text + ".jpg", ImageFormat.Jpeg);
                }
                datagrid();
                setbut();
                insertimage = 0;
            }
            catch {

                MessageBox.Show("اطلاعات وارده ثبت نشد");
            
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            if (tempid.Text == "") return;
            string[] la = { "id", "codemeli", "name", "lname", "sex", "mobile", "burn", "typesport", "bloud", "codecart", "insurance", "address", "date_register", "comment" };
            string[] na = new string[14];
            na[0] = tempid.Text;
            na[1] = codemeli.Text;
            na[2] = name.Text;
            na[3] = lname.Text;
            na[4] = sex.SelectedIndex.ToString();
            na[5] = mobile.Text;
            na[6] = burn.Text;
            na[7] = typesport.SelectedIndex.ToString();
            na[8] = bloud.SelectedIndex.ToString();
            na[9] = codecart.Text;
            na[10] = insurance.Text;
            na[11] = address.Text;
            na[12] = date_register.Text;
            na[13] = command.Text;
            ClassTemp.up(table, na, la);
            if (insertimage == 1)
            {

                string filePath = Application.StartupPath + @"\Images\" + codemeli.Text + ".jpg";
                if (System.IO.File.Exists(filePath))
                {


                    
                    System.IO.File.Delete(filePath);


                }
                pictureBox1.Image.Save(Application.StartupPath + @"\Images\" + codemeli.Text + ".jpg", ImageFormat.Jpeg);

            }
            datagrid();
            setbut();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                insertimage = 1;
                // image file path
                // pic.Text = open.FileName;
            } 
        }

        private void label12_Click(object sender, EventArgs e)
        {
            


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
           // codecart_Click(sender, e);
            // MessageBox.Show(x.ToString(), " کارت");
         
          /*  try
            {
                string input;
                input = serialPort1.ReadLine();
                //    MessageBox.Show(input, " کارت");
                input = input.Substring(0, input.Length - 3);
                if (input.Length == 9)
                    input = input.Substring(1, 8);
                if (input.Length == 10)
                    input = input.Substring(2, 8);
                int decValue = Convert.ToInt32(input, 16);
                Int64 x;
                x = decValue + 2265576825;
                //  textBox1.Text = input;
                // byte [] buffer;
                //  input = Regex.Replace(input, @"\s", "");
                // input = input.Substring(1);
                // 
                resultcodecart = x.ToString();
                serialPort1.Close();
                //   MessageBox.Show(resultcodecart);
            }
            catch
            {
                serialPort1.Close();
            }*/
        }
       
        private void codecart_TextChanged(object sender, EventArgs e)
        {
           // codecart.Text = resultcodecart;
        }

        private void codecart_Click(object sender, EventArgs e)
        {
            codecart.Text = resultcodecart;
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
               try
            {
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc1"].Value.ToString();
                lname.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc2"].Value.ToString();
                sex.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ccc3"].Value.ToString());
                //DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
               // if (dataGridView1.Rows[e.RowIndex].Cells["ccc4"].Value.ToString() != "")
             //   {
                  //  date1 = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["ccc4"].Value.ToString());

             //   }
                codemeli.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc5"].Value.ToString();
                typesport.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ccc6"].Value.ToString());
                mobile.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc7"].Value.ToString();
                address.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc8"].Value.ToString();
                burn.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc4"].Value.ToString(); //date1.Date.ToString("yyyy/MM/dd");
                codecart.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc9"].Value.ToString();
                insurance.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc10"].Value.ToString();

                bloud.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ccc11"].Value.ToString());
                //DateTime date2 = new DateTime(2008, 6, 1, 7, 47, 0);
               // if (dataGridView1.Rows[e.RowIndex].Cells["ccc12"].Value.ToString() != "")
                //{
                  //  date2 = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["ccc12"].Value.ToString());

             //   }

                date_register.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc12"].Value.ToString();//date2.Date.ToString("yyy/MM/dd");
                command.Text = dataGridView1.Rows[e.RowIndex].Cells["ccc15"].Value.ToString();


                string path = @"images\" + codemeli.Text + ".jpg";
                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"images\defult.jpg");
                }

                setbut2();

            }
              catch { }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = ClassTemp.Search(textBox1.Text, "customer", "lname");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_2.session n = new Form_2.session("Register_service", "تمدید ", int.Parse(tempid.Text),1);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form_2.session n = new Form_2.session("Register_service", "کلاس ", int.Parse(tempid.Text),2);
            if (!n.Visible)
            {
                n.MdiParent = this.MdiParent;

                n.Show(); // Add the message

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
          catch{
              serialPort1.Close();
              MessageBox.Show("خطا کارت خوان را بررسی کنید");
           }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (resultcodecart != "")
            {
                codecart.Text = resultcodecart;
                resultcodecart = "";
                timer1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  Form2 n = new Form2(tempid.Text);
          //  n.Show();
        }
    }
}
