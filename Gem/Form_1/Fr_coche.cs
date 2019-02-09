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

namespace Gem.Form_1
{
    public partial class Fr_coche : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string table = "";
        string baner = "";
        string type_emplo = "";  //1 karmand  2  coch    3 dr
        int insertimage = 0;
        public Fr_coche(string t, string b,int code_type)
        {
            InitializeComponent();
             table = t;
            baner = b;
            type_emplo = code_type.ToString();
        }

        private void Fr_coche_Load(object sender, EventArgs e)
        {
            ribbonClientPanel1.Text = baner;
            type.Text = type_emplo;
            datagrid();
        }
        private void datagrid()
        {
            dataGridView1.DataSource = ClassTemp.redt("select *  from basis_Employee where type=" + type_emplo);
          
        }
        private void setbut()
        {
            Add.Enabled = true;
            Del.Enabled = false;
            Edit.Enabled = false;
            tempid.Text = "";
            name.Text = "";
            lname.Text = "";
            age.Text="";
            activity_history.Text="";
            records.Text = "";
            evidence.Text = "";
            codemeli.Text = "";
            email.Text = "";
            tell.Text = "";
            address.Text = "";
            insertimage = 0;
            pictureBox1.Image = Image.FromFile(@"images2\defult.jpg");
            // rfid.Text = "";

        }
        private void setbut2()
        {
            Add.Enabled = false;
            Del.Enabled = true;
            Edit.Enabled = true;
            insertimage = 0;


        }
        private void Add_Click(object sender, EventArgs e)
        {
            string[] la = { "name", "lname", "sex", "age", "activity_history", "records", "evidence", "code_meli", "type", "email", "tell", "address" };
            string[] na = new string[12];
            na[0] = name.Text;
            na[1] = lname.Text;
            na[2] = sex.SelectedIndex.ToString();
           
           
            na[3] = age.Text; 

            
            na[4] = activity_history.Text;
            na[5] = records.Text;
            na[6] = evidence.Text;
            na[7] = codemeli.Text;
            na[8] = type.Text;
            na[9] = email.Text;
            na[10] = tell.Text;
            na[11] = address.Text;
           
           
            // Pass the array as an argument to PrintArray.
            ClassTemp.ins(table, na, la);
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(Application.StartupPath + @"\Images2\" + codemeli.Text + ".jpg", ImageFormat.Jpeg);
            }
            datagrid();
            setbut();
            insertimage = 0;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //"name", "lname", "sex", "age", "activity_history", "records", "evidence", "code_meli", "type", "email", "tell", "address"
                tempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                sex.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                age.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                activity_history.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                records.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                evidence.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                codemeli.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                email.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                tell.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                address.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
              

                string path = @"images2\" + codemeli.Text + ".jpg";
                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"images2\defult.jpg");
                }
               
                setbut2();

            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            setbut();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (tempid.Text == "") return;
            string[] la = { "id", "name", "lname", "sex", "age", "activity_history", "records", "evidence", "code_meli", "type", "email", "tell", "address" };
            string[] na = new string[13];
            na[0] = tempid.Text;
            na[1] = name.Text;
            na[2] = lname.Text;
            na[3] = sex.SelectedIndex.ToString();
            na[4] = age.Text;
            na[5] = activity_history.Text;
            na[6] = records.Text;
            na[7] = evidence.Text;
            na[8] = codemeli.Text;
            na[9] = type.Text;
            na[10] = email.Text;
            na[11] = tell.Text;
            na[12] = address.Text;
            ClassTemp.up(table, na, la);
            if (insertimage == 1)
            {

                string filePath = Application.StartupPath + @"\Images2\" + codemeli.Text + ".jpg";
                if (System.IO.File.Exists(filePath))
                {


                    System.IO.File.Delete(filePath);


                }
                pictureBox1.Image.Save(Application.StartupPath + @"\Images2\" + codemeli.Text + ".jpg", ImageFormat.Jpeg);
            
            }
            datagrid();
            setbut();
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
    }
}
