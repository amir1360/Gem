namespace Gem.Report
{
    partial class selectbank
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.number_bank = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ribbonClientPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.70588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29412F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.39344F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.60656F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Controls.Add(this.Add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.number_bank, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(342, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // number_bank
            // 
            this.number_bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number_bank.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.number_bank.FormattingEnabled = true;
            this.number_bank.Items.AddRange(new object[] {
            "نقدی",
            "حواله بانکی"});
            this.number_bank.Location = new System.Drawing.Point(111, 3);
            this.number_bank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.number_bank.Name = "number_bank";
            this.number_bank.Size = new System.Drawing.Size(180, 26);
            this.number_bank.TabIndex = 74;
            this.number_bank.Text = "نقدی";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(305, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "بانک";
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
            this.Add.Location = new System.Drawing.Point(4, 5);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 28);
            this.Add.TabIndex = 76;
            this.Add.Text = "انتخاب";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(348, 35);
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
            this.ribbonClientPanel1.TabIndex = 73;
            this.ribbonClientPanel1.Text = "دریافت";
            this.ribbonClientPanel1.Click += new System.EventHandler(this.ribbonClientPanel1_Click);
            // 
            // selectbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 79);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "selectbank";
            this.RightToLeftLayout = true;
            this.Text = "selectbank";
            this.Load += new System.EventHandler(this.selectbank_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox number_bank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Add;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
    }
}