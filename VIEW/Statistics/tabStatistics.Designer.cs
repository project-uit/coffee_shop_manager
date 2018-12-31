namespace COFFEE_SHOP_MANAGER
{
    partial class tabStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabStatistics));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartRevenue = new DevExpress.XtraCharts.ChartControl();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartBeverage = new DevExpress.XtraCharts.ChartControl();
            this.cmbMonthTabBeverage = new System.Windows.Forms.ComboBox();
            this.cmbYearTabBeverage = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnPrintRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintBeverageRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBeverage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(42, 82);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1912, 1000);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrintRevenue);
            this.tabPage1.Controls.Add(this.chartRevenue);
            this.tabPage1.Controls.Add(this.cmbYear);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1896, 953);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRevenue.Legend.Name = "Default Legend";
            this.chartRevenue.Location = new System.Drawing.Point(220, 167);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartRevenue.Size = new System.Drawing.Size(1364, 666);
            this.chartRevenue.TabIndex = 5;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(1576, 51);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(272, 33);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1326, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(209, 36);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Chọn thời gian";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrintBeverageRevenue);
            this.tabPage2.Controls.Add(this.chartBeverage);
            this.tabPage2.Controls.Add(this.cmbMonthTabBeverage);
            this.tabPage2.Controls.Add(this.cmbYearTabBeverage);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1896, 953);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm thức uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartBeverage
            // 
            this.chartBeverage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBeverage.Legend.Name = "Default Legend";
            this.chartBeverage.Location = new System.Drawing.Point(220, 167);
            this.chartBeverage.Name = "chartBeverage";
            this.chartBeverage.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartBeverage.Size = new System.Drawing.Size(1458, 728);
            this.chartBeverage.TabIndex = 8;
            // 
            // cmbMonthTabBeverage
            // 
            this.cmbMonthTabBeverage.FormattingEnabled = true;
            this.cmbMonthTabBeverage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonthTabBeverage.Location = new System.Drawing.Point(1388, 46);
            this.cmbMonthTabBeverage.Name = "cmbMonthTabBeverage";
            this.cmbMonthTabBeverage.Size = new System.Drawing.Size(136, 33);
            this.cmbMonthTabBeverage.TabIndex = 7;
            this.cmbMonthTabBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbMonthTabBeverage_SelectedIndexChanged);
            // 
            // cmbYearTabBeverage
            // 
            this.cmbYearTabBeverage.FormattingEnabled = true;
            this.cmbYearTabBeverage.Location = new System.Drawing.Point(1551, 46);
            this.cmbYearTabBeverage.Name = "cmbYearTabBeverage";
            this.cmbYearTabBeverage.Size = new System.Drawing.Size(272, 33);
            this.cmbYearTabBeverage.TabIndex = 6;
            this.cmbYearTabBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbYearTabBeverage_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1158, 46);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(209, 36);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Chọn thời gian";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(42, 15);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1912, 61);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // btnPrintRevenue
            // 
            this.btnPrintRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRevenue.ImageOptions.Image")));
            this.btnPrintRevenue.Location = new System.Drawing.Point(220, 51);
            this.btnPrintRevenue.Name = "btnPrintRevenue";
            this.btnPrintRevenue.Size = new System.Drawing.Size(150, 46);
            this.btnPrintRevenue.TabIndex = 7;
            this.btnPrintRevenue.Text = "In ";
            this.btnPrintRevenue.Click += new System.EventHandler(this.btnPrintRevenue_Click);
            // 
            // btnPrintBeverageRevenue
            // 
            this.btnPrintBeverageRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBeverageRevenue.ImageOptions.Image")));
            this.btnPrintBeverageRevenue.Location = new System.Drawing.Point(220, 51);
            this.btnPrintBeverageRevenue.Name = "btnPrintBeverageRevenue";
            this.btnPrintBeverageRevenue.Size = new System.Drawing.Size(150, 46);
            this.btnPrintBeverageRevenue.TabIndex = 9;
            this.btnPrintBeverageRevenue.Text = "In ";
            this.btnPrintBeverageRevenue.Click += new System.EventHandler(this.btnPrintBeverageRevenue_Click);
            // 
            // tabStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "tabStatistics";
            this.Size = new System.Drawing.Size(1996, 1125);
            this.Load += new System.EventHandler(this.tabStatistics_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBeverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbYearTabBeverage;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cmbMonthTabBeverage;
        private DevExpress.XtraCharts.ChartControl chartBeverage;
        private DevExpress.XtraCharts.ChartControl chartRevenue;
        private DevExpress.XtraEditors.SimpleButton btnPrintRevenue;
        private DevExpress.XtraEditors.SimpleButton btnPrintBeverageRevenue;
    }
}
