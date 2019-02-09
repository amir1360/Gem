namespace Gem.Form_2
{
    partial class record1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tempid = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.date_start = new HM_FarsiCalendar.HM_FarsiCalendar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ribbonClientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(338, 242);
            this.dataGridView1.TabIndex = 64;
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
            this.Column4.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "انتخاب";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "کمدها";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.tempid);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(344, 50);
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
            this.ribbonClientPanel1.Text = "معرفی حرکات ورزشی";
            // 
            // tempid
            // 
            this.tempid.BackColor = System.Drawing.Color.White;
            this.tempid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempid.Location = new System.Drawing.Point(0, 12);
            this.tempid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tempid.Name = "tempid";
            this.tempid.Size = new System.Drawing.Size(121, 27);
            this.tempid.TabIndex = 62;
            this.tempid.Visible = false;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 388);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(338, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edit.BackColor = System.Drawing.Color.Transparent;
            this.Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit.Enabled = false;
            this.Edit.Font = new System.Drawing.Font("MRT_Poster", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Edit.Image = global::Gem.Properties.Resources.UPDATE;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(89, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(78, 32);
            this.Edit.TabIndex = 66;
            this.Edit.Text = "ویرایش";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Font = new System.Drawing.Font("MRT_Poster", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.Image = global::Gem.Properties.Resources.CANCEL;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(3, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 32);
            this.Cancel.TabIndex = 65;
            this.Cancel.Text = "لغو";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Font = new System.Drawing.Font("MRT_Poster", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add.Image = global::Gem.Properties.Resources.ADD11;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(257, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(78, 32);
            this.Add.TabIndex = 64;
            this.Add.Text = "ثبت";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Del
            // 
            this.Del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Del.BackColor = System.Drawing.Color.Transparent;
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Enabled = false;
            this.Del.Font = new System.Drawing.Font("MRT_Poster_10", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Del.Image = global::Gem.Properties.Resources.DELETE;
            this.Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del.Location = new System.Drawing.Point(173, 3);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(78, 32);
            this.Del.TabIndex = 1;
            this.Del.Text = "حذف";
            this.Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Del.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.37673F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.62327F));
            this.tableLayoutPanel3.Controls.Add(this.date_start, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(338, 40);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // date_start
            // 
            this.date_start.BodyBackColor = System.Drawing.Color.White;
            this.date_start.BodyForeColor = System.Drawing.Color.Black;
            this.date_start.Dock = System.Windows.Forms.DockStyle.Left;
            this.date_start.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.date_start.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.date_start.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.date_start.HeaderForeColor = System.Drawing.Color.White;
            this.date_start.Location = new System.Drawing.Point(128, 4);
            this.date_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_start.Max_Date = "1400/12/30";
            this.date_start.Min_Date = "1350/01/01";
            this.date_start.Name = "date_start";
            this.date_start.SelectedBackColor = System.Drawing.Color.DodgerBlue;
            this.date_start.SelectedForeColor = System.Drawing.Color.Maroon;
            this.date_start.Size = new System.Drawing.Size(125, 32);
            this.date_start.TabIndex = 79;
            this.date_start.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(260, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "تاریخ رکورد :";
            // 
            // record1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 388);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "record1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.record1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.TextBox tempid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private HM_FarsiCalendar.HM_FarsiCalendar date_start;
    }
}