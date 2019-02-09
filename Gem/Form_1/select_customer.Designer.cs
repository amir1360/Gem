namespace Gem.Form_1
{
    partial class select_customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.fingerprint = new System.Windows.Forms.TextBox();
            this.codecart = new System.Windows.Forms.TextBox();
            this.tempid = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ribbonClientPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ccc1,
            this.ccc2,
            this.ccc5,
            this.ccc7,
            this.ccc9,
            this.ccc10,
            this.insurance,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(697, 233);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel8.ColumnCount = 7;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.button2, 6, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(699, 44);
            this.tableLayoutPanel8.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(602, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 69;
            this.label13.Text = "نام  خانوادگی :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(502, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 23);
            this.textBox1.TabIndex = 68;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(312, 10);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 23);
            this.textBox2.TabIndex = 71;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(152, 10);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 23);
            this.textBox3.TabIndex = 72;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(432, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "کد ملی :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(237, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 38);
            this.button1.TabIndex = 74;
            this.button1.Text = "کد کارت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.fingerprint);
            this.ribbonClientPanel1.Controls.Add(this.codecart);
            this.ribbonClientPanel1.Controls.Add(this.tempid);
            this.ribbonClientPanel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(705, 50);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ribbonClientPanel1.Style.BackColorGradientAngle = 90;
            this.ribbonClientPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ribbonClientPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderBottomWidth = 1;
            this.ribbonClientPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ribbonClientPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderLeftWidth = 1;
            this.ribbonClientPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderRightWidth = 1;
            this.ribbonClientPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonClientPanel1.Style.BorderTopWidth = 1;
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 3;
            this.ribbonClientPanel1.Text = "انتخاب مشتری";
            // 
            // fingerprint
            // 
            this.fingerprint.BackColor = System.Drawing.Color.White;
            this.fingerprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerprint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerprint.Location = new System.Drawing.Point(507, 11);
            this.fingerprint.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.fingerprint.Name = "fingerprint";
            this.fingerprint.Size = new System.Drawing.Size(189, 27);
            this.fingerprint.TabIndex = 65;
            this.fingerprint.Visible = false;
            // 
            // codecart
            // 
            this.codecart.BackColor = System.Drawing.Color.White;
            this.codecart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codecart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codecart.Location = new System.Drawing.Point(117, 6);
            this.codecart.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.codecart.Name = "codecart";
            this.codecart.Size = new System.Drawing.Size(118, 27);
            this.codecart.TabIndex = 64;
            this.codecart.Visible = false;
            // 
            // tempid
            // 
            this.tempid.BackColor = System.Drawing.Color.White;
            this.tempid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempid.Location = new System.Drawing.Point(4, 6);
            this.tempid.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.tempid.Name = "tempid";
            this.tempid.Size = new System.Drawing.Size(105, 27);
            this.tempid.TabIndex = 63;
            this.tempid.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(40, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 75;
            this.button2.Text = "اتمام بیمه ها";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ردیف";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ccc1
            // 
            this.ccc1.DataPropertyName = "name";
            this.ccc1.HeaderText = "نام";
            this.ccc1.Name = "ccc1";
            this.ccc1.ReadOnly = true;
            // 
            // ccc2
            // 
            this.ccc2.DataPropertyName = "lname";
            this.ccc2.HeaderText = "نام خانوادگی";
            this.ccc2.Name = "ccc2";
            this.ccc2.ReadOnly = true;
            this.ccc2.Width = 150;
            // 
            // ccc5
            // 
            this.ccc5.DataPropertyName = "codemeli";
            this.ccc5.HeaderText = "کد ملی";
            this.ccc5.Name = "ccc5";
            this.ccc5.ReadOnly = true;
            // 
            // ccc7
            // 
            this.ccc7.DataPropertyName = "mobile";
            this.ccc7.HeaderText = "تلفن";
            this.ccc7.Name = "ccc7";
            this.ccc7.ReadOnly = true;
            // 
            // ccc9
            // 
            this.ccc9.DataPropertyName = "codecart";
            this.ccc9.HeaderText = "codecart";
            this.ccc9.Name = "ccc9";
            this.ccc9.ReadOnly = true;
            this.ccc9.Visible = false;
            // 
            // ccc10
            // 
            this.ccc10.DataPropertyName = "fingerprint";
            this.ccc10.HeaderText = "fingerprint";
            this.ccc10.Name = "ccc10";
            this.ccc10.ReadOnly = true;
            this.ccc10.Visible = false;
            // 
            // insurance
            // 
            this.insurance.DataPropertyName = "insurance";
            this.insurance.HeaderText = "بیمه";
            this.insurance.Name = "insurance";
            this.insurance.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "انتخاب";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "انتخاب";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // select_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "select_customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.select_customer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.TextBox tempid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.TextBox codecart;
        private System.Windows.Forms.TextBox fingerprint;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc10;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}