namespace Gem.buffet
{
    partial class goods
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.group = new System.Windows.Forms.TextBox();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tempid = new System.Windows.Forms.TextBox();
            this.code_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(254, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "واحد :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(250, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "عنوان :";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.White;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(3, 9);
            this.number.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(223, 27);
            this.number.TabIndex = 61;
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "گرم",
            "عدد"});
            this.status.Location = new System.Drawing.Point(3, 61);
            this.status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(223, 24);
            this.status.TabIndex = 68;
            this.status.Text = "گرم";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.26603F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.73397F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.number, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.status, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 100);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(319, 93);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(319, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.White;
            this.group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(0, 53);
            this.group.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(191, 27);
            this.group.TabIndex = 63;
            this.group.Visible = false;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.group);
            this.ribbonClientPanel1.Controls.Add(this.tempid);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(325, 94);
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
            this.tempid.Location = new System.Drawing.Point(0, 22);
            this.tempid.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.tempid.Name = "tempid";
            this.tempid.Size = new System.Drawing.Size(191, 27);
            this.tempid.TabIndex = 62;
            this.tempid.Visible = false;
            // 
            // code_customer
            // 
            this.code_customer.DataPropertyName = "code_customer";
            this.code_customer.HeaderText = "code_customer";
            this.code_customer.Name = "code_customer";
            this.code_customer.ReadOnly = true;
            this.code_customer.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "rfid";
            this.Column1.HeaderText = "کد الکترونیکی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "number";
            this.Column4.HeaderText = "شماره کمد";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id";
            this.Column3.HeaderText = "ردیف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.code_customer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 264);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(319, 226);
            this.dataGridView1.TabIndex = 64;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 496);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.Edit.Location = new System.Drawing.Point(85, 6);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(73, 35);
            this.Edit.TabIndex = 66;
            this.Edit.Text = "ویرایش";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = false;
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
            this.Cancel.Location = new System.Drawing.Point(3, 6);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(76, 35);
            this.Cancel.TabIndex = 65;
            this.Cancel.Text = "لغو";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = false;
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
            this.Add.Location = new System.Drawing.Point(243, 6);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(73, 35);
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
            this.Del.Location = new System.Drawing.Point(164, 6);
            this.Del.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(73, 35);
            this.Del.TabIndex = 1;
            this.Del.Text = "حذف";
            this.Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Del.UseVisualStyleBackColor = false;
            // 
            // goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "goods";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.goods_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.TextBox group;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.TextBox tempid;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}