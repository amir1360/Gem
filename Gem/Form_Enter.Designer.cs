namespace Gem
{
    partial class Form_Enter
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.c2 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.c3 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.c1,
            this.c2,
            this.c3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 453);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fullname";
            this.Column1.HeaderText = "لیست حاضران";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id";
            this.Column4.HeaderText = "id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "number_closet";
            this.Column5.HeaderText = "number";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "register_code";
            this.Column6.HeaderText = "idservuce";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "code_cart";
            this.Column7.HeaderText = "codecart";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "code_user";
            this.Column8.HeaderText = "code_user";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "date_re";
            this.Column9.HeaderText = "date_re";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // c1
            // 
            this.c1.HeaderText = "فاکتور";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Text = "فاکتور";
            this.c1.UseColumnTextForButtonValue = true;
            // 
            // c2
            // 
            this.c2.HeaderText = "ویرایش کمد";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Text = "ویرایش کمد";
            this.c2.UseColumnTextForButtonValue = true;
            this.c2.Width = 80;
            // 
            // c3
            // 
            this.c3.HeaderText = "خروج";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Text = "خروج";
            this.c3.UseColumnTextForButtonValue = true;
            this.c3.Width = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 453);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Enter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form_Enter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn c1;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn c2;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn c3;
    }
}