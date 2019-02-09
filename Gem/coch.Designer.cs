namespace Gem
{
    partial class coch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ribbonClientPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(726, 238);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id";
            this.Column3.HeaderText = "ردیف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "title";
            this.Column4.HeaderText = "عنوان";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(732, 50);
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
            this.ribbonClientPanel1.TabIndex = 0;
            this.ribbonClientPanel1.Text = "خدمات مربی";
            this.ribbonClientPanel1.Click += new System.EventHandler(this.ribbonClientPanel1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Edit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Del, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit.Enabled = false;
            this.Edit.Font = new System.Drawing.Font("MRT_Poster", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Edit.Image = global::Gem.Properties.Resources.UPDATE;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(186, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(175, 38);
            this.Edit.TabIndex = 66;
            this.Edit.Text = "ویرایش";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Font = new System.Drawing.Font("MRT_Poster", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.Image = global::Gem.Properties.Resources.CANCEL;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(3, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(177, 38);
            this.Cancel.TabIndex = 65;
            this.Cancel.Text = "لغو";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Upbutton_Click);
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Font = new System.Drawing.Font("MRT_Poster", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add.Image = global::Gem.Properties.Resources.ADD11;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(548, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(175, 38);
            this.Add.TabIndex = 64;
            this.Add.Text = "ثبت";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Del
            // 
            this.Del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Enabled = false;
            this.Del.Font = new System.Drawing.Font("MRT_Poster_10", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Del.Image = global::Gem.Properties.Resources.DELETE;
            this.Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del.Location = new System.Drawing.Point(367, 3);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(175, 38);
            this.Del.TabIndex = 1;
            this.Del.Text = "حذف";
            this.Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.06301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.937F));
            this.tableLayoutPanel3.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(726, 34);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.White;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 5);
            this.title.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(582, 27);
            this.title.TabIndex = 61;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(612, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "عنوان خدمات :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // coch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(732, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "coch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.coch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox title;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
    }
}