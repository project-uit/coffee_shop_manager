﻿namespace COFFEE_SHOP_MANAGER
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
            this.btnPrintRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.chartRevenue = new DevExpress.XtraCharts.ChartControl();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrintBeverageRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.chartBeverage = new DevExpress.XtraCharts.ChartControl();
            this.cmbMonthTabBeverage = new System.Windows.Forms.ComboBox();
            this.cmbYearTabBeverage = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateThongKe = new DevExpress.XtraEditors.DateEdit();
            this.btnExportFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grdCtrThongKeNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.grdViThongKeNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltennguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluonglythuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluongthucte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhaohut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dateWeek = new DevExpress.XtraEditors.DateEdit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBeverage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrThongKeNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThongKeNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 52);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1327, 666);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrintRevenue);
            this.tabPage1.Controls.Add(this.chartRevenue);
            this.tabPage1.Controls.Add(this.cmbYear);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1319, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrintRevenue
            // 
            this.btnPrintRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRevenue.ImageOptions.Image")));
            this.btnPrintRevenue.Location = new System.Drawing.Point(147, 33);
            this.btnPrintRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintRevenue.Name = "btnPrintRevenue";
            this.btnPrintRevenue.Size = new System.Drawing.Size(100, 29);
            this.btnPrintRevenue.TabIndex = 7;
            this.btnPrintRevenue.Text = "In ";
            this.btnPrintRevenue.Click += new System.EventHandler(this.btnPrintRevenue_Click);
            // 
            // chartRevenue
            // 
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRevenue.Legend.Name = "Default Legend";
            this.chartRevenue.Location = new System.Drawing.Point(147, 107);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartRevenue.Size = new System.Drawing.Size(961, 452);
            this.chartRevenue.TabIndex = 5;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(1051, 33);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(183, 24);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(884, 29);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 24);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1319, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm thức uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrintBeverageRevenue
            // 
            this.btnPrintBeverageRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBeverageRevenue.ImageOptions.Image")));
            this.btnPrintBeverageRevenue.Location = new System.Drawing.Point(147, 33);
            this.btnPrintBeverageRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintBeverageRevenue.Name = "btnPrintBeverageRevenue";
            this.btnPrintBeverageRevenue.Size = new System.Drawing.Size(100, 29);
            this.btnPrintBeverageRevenue.TabIndex = 9;
            this.btnPrintBeverageRevenue.Text = "In ";
            this.btnPrintBeverageRevenue.Click += new System.EventHandler(this.btnPrintBeverageRevenue_Click);
            // 
            // chartBeverage
            // 
            this.chartBeverage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBeverage.Legend.Name = "Default Legend";
            this.chartBeverage.Location = new System.Drawing.Point(147, 107);
            this.chartBeverage.Margin = new System.Windows.Forms.Padding(2);
            this.chartBeverage.Name = "chartBeverage";
            this.chartBeverage.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartBeverage.Size = new System.Drawing.Size(1024, 492);
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
            this.cmbMonthTabBeverage.Location = new System.Drawing.Point(925, 29);
            this.cmbMonthTabBeverage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonthTabBeverage.Name = "cmbMonthTabBeverage";
            this.cmbMonthTabBeverage.Size = new System.Drawing.Size(92, 24);
            this.cmbMonthTabBeverage.TabIndex = 7;
            this.cmbMonthTabBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbMonthTabBeverage_SelectedIndexChanged);
            // 
            // cmbYearTabBeverage
            // 
            this.cmbYearTabBeverage.FormattingEnabled = true;
            this.cmbYearTabBeverage.Location = new System.Drawing.Point(1034, 29);
            this.cmbYearTabBeverage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYearTabBeverage.Name = "cmbYearTabBeverage";
            this.cmbYearTabBeverage.Size = new System.Drawing.Size(183, 24);
            this.cmbYearTabBeverage.TabIndex = 6;
            this.cmbYearTabBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbYearTabBeverage_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(772, 29);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Chọn thời gian";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateWeek);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dateThongKe);
            this.tabPage3.Controls.Add(this.btnExportFile);
            this.tabPage3.Controls.Add(this.grdCtrThongKeNguyenLieu);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1319, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê kho nguyên liệu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Theo tuần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Theo tháng";
            // 
            // dateThongKe
            // 
            this.dateThongKe.EditValue = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.dateThongKe.Location = new System.Drawing.Point(6, 31);
            this.dateThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateThongKe.Name = "dateThongKe";
            this.dateThongKe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThongKe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThongKe.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dateThongKe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateThongKe.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dateThongKe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateThongKe.Size = new System.Drawing.Size(157, 22);
            this.dateThongKe.TabIndex = 4;
            this.dateThongKe.EditValueChanged += new System.EventHandler(this.dateThongKe_EditValueChanged);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportFile.AutoSize = true;
            this.btnExportFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportFile.Depth = 0;
            this.btnExportFile.Icon = null;
            this.btnExportFile.Location = new System.Drawing.Point(1216, 2);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Primary = true;
            this.btnExportFile.Size = new System.Drawing.Size(103, 36);
            this.btnExportFile.TabIndex = 3;
            this.btnExportFile.Text = "Xuất file";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // grdCtrThongKeNguyenLieu
            // 
            this.grdCtrThongKeNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrThongKeNguyenLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCtrThongKeNguyenLieu.Location = new System.Drawing.Point(3, 99);
            this.grdCtrThongKeNguyenLieu.MainView = this.grdViThongKeNguyenLieu;
            this.grdCtrThongKeNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCtrThongKeNguyenLieu.Name = "grdCtrThongKeNguyenLieu";
            this.grdCtrThongKeNguyenLieu.Size = new System.Drawing.Size(1313, 533);
            this.grdCtrThongKeNguyenLieu.TabIndex = 2;
            this.grdCtrThongKeNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViThongKeNguyenLieu});
            // 
            // grdViThongKeNguyenLieu
            // 
            this.grdViThongKeNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltennguyenlieu,
            this.coldinhluonglythuyet,
            this.coldinhluongthucte,
            this.coldonvi,
            this.colhaohut});
            this.grdViThongKeNguyenLieu.GridControl = this.grdCtrThongKeNguyenLieu;
            this.grdViThongKeNguyenLieu.Name = "grdViThongKeNguyenLieu";
            this.grdViThongKeNguyenLieu.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThongKeNguyenLieu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThongKeNguyenLieu.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThongKeNguyenLieu.OptionsBehavior.ReadOnly = true;
            this.grdViThongKeNguyenLieu.OptionsView.ShowGroupPanel = false;
            // 
            // coltennguyenlieu
            // 
            this.coltennguyenlieu.Caption = "Tên nguyên liệu";
            this.coltennguyenlieu.FieldName = "tennguyenlieu";
            this.coltennguyenlieu.MinWidth = 25;
            this.coltennguyenlieu.Name = "coltennguyenlieu";
            this.coltennguyenlieu.Visible = true;
            this.coltennguyenlieu.VisibleIndex = 0;
            this.coltennguyenlieu.Width = 93;
            // 
            // coldinhluonglythuyet
            // 
            this.coldinhluonglythuyet.Caption = "Định lượng lý thuyết";
            this.coldinhluonglythuyet.FieldName = "dinhluonglythuyet";
            this.coldinhluonglythuyet.MinWidth = 25;
            this.coldinhluonglythuyet.Name = "coldinhluonglythuyet";
            this.coldinhluonglythuyet.Visible = true;
            this.coldinhluonglythuyet.VisibleIndex = 1;
            this.coldinhluonglythuyet.Width = 93;
            // 
            // coldinhluongthucte
            // 
            this.coldinhluongthucte.Caption = "Định lượng thực tế";
            this.coldinhluongthucte.FieldName = "dinhluongthucte";
            this.coldinhluongthucte.MinWidth = 25;
            this.coldinhluongthucte.Name = "coldinhluongthucte";
            this.coldinhluongthucte.Visible = true;
            this.coldinhluongthucte.VisibleIndex = 2;
            this.coldinhluongthucte.Width = 93;
            // 
            // coldonvi
            // 
            this.coldonvi.Caption = "Đơn vị";
            this.coldonvi.FieldName = "donvi";
            this.coldonvi.MinWidth = 25;
            this.coldonvi.Name = "coldonvi";
            this.coldonvi.Visible = true;
            this.coldonvi.VisibleIndex = 3;
            this.coldonvi.Width = 93;
            // 
            // colhaohut
            // 
            this.colhaohut.Caption = "Hao hụt";
            this.colhaohut.FieldName = "haohut";
            this.colhaohut.MinWidth = 25;
            this.colhaohut.Name = "colhaohut";
            this.colhaohut.Visible = true;
            this.colhaohut.VisibleIndex = 4;
            this.colhaohut.Width = 93;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(2, 10);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1329, 39);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // dateWeek
            // 
            this.dateWeek.EditValue = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.dateWeek.Location = new System.Drawing.Point(213, 31);
            this.dateWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateWeek.Name = "dateWeek";
            this.dateWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWeek.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWeek.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateWeek.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWeek.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateWeek.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWeek.Size = new System.Drawing.Size(157, 22);
            this.dateWeek.TabIndex = 8;
            this.dateWeek.EditValueChanged += new System.EventHandler(this.dateWeek_EditValueChanged);
            // 
            // tabStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabStatistics";
            this.Size = new System.Drawing.Size(1331, 720);
            this.Load += new System.EventHandler(this.tabStatistics_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBeverage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrThongKeNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThongKeNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton btnExportFile;
        private DevExpress.XtraGrid.GridControl grdCtrThongKeNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViThongKeNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn coltennguyenlieu;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluonglythuyet;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluongthucte;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvi;
        private DevExpress.XtraGrid.Columns.GridColumn colhaohut;
        private DevExpress.XtraEditors.DateEdit dateThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateWeek;
    }
}
