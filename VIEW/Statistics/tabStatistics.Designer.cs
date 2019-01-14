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
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrintRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.chartRevenue = new DevExpress.XtraCharts.ChartControl();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintBeverageRevenue = new DevExpress.XtraEditors.SimpleButton();
            this.chartBeverage = new DevExpress.XtraCharts.ChartControl();
            this.cmbMonthTabBeverage = new System.Windows.Forms.ComboBox();
            this.cmbYearTabBeverage = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateWeek = new DevExpress.XtraEditors.DateEdit();
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
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBeverage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrThongKeNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThongKeNguyenLieu)).BeginInit();
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
            this.materialTabControl1.Location = new System.Drawing.Point(2, 42);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(995, 541);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnPrintRevenue);
            this.tabPage1.Controls.Add(this.chartRevenue);
            this.tabPage1.Controls.Add(this.cmbYear);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(987, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(803, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm";
            // 
            // btnPrintRevenue
            // 
            this.btnPrintRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRevenue.ImageOptions.Image")));
            this.btnPrintRevenue.Location = new System.Drawing.Point(40, 32);
            this.btnPrintRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintRevenue.Name = "btnPrintRevenue";
            this.btnPrintRevenue.Size = new System.Drawing.Size(82, 32);
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
            this.chartRevenue.Location = new System.Drawing.Point(40, 87);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartRevenue.Size = new System.Drawing.Size(904, 389);
            this.chartRevenue.TabIndex = 5;
            // 
            // cmbYear
            // 
            this.cmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(806, 43);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(138, 21);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnPrintBeverageRevenue);
            this.tabPage2.Controls.Add(this.chartBeverage);
            this.tabPage2.Controls.Add(this.cmbMonthTabBeverage);
            this.tabPage2.Controls.Add(this.cmbYearTabBeverage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(987, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm thức uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(803, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Năm";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tháng";
            // 
            // btnPrintBeverageRevenue
            // 
            this.btnPrintBeverageRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBeverageRevenue.ImageOptions.Image")));
            this.btnPrintBeverageRevenue.Location = new System.Drawing.Point(40, 32);
            this.btnPrintBeverageRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintBeverageRevenue.Name = "btnPrintBeverageRevenue";
            this.btnPrintBeverageRevenue.Size = new System.Drawing.Size(82, 32);
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
            this.chartBeverage.Location = new System.Drawing.Point(40, 87);
            this.chartBeverage.Margin = new System.Windows.Forms.Padding(2);
            this.chartBeverage.Name = "chartBeverage";
            this.chartBeverage.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartBeverage.Size = new System.Drawing.Size(904, 389);
            this.chartBeverage.TabIndex = 8;
            // 
            // cmbMonthTabBeverage
            // 
            this.cmbMonthTabBeverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cmbMonthTabBeverage.Location = new System.Drawing.Point(732, 43);
            this.cmbMonthTabBeverage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonthTabBeverage.Name = "cmbMonthTabBeverage";
            this.cmbMonthTabBeverage.Size = new System.Drawing.Size(70, 21);
            this.cmbMonthTabBeverage.TabIndex = 7;
            this.cmbMonthTabBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbMonthTabBeverage_SelectedIndexChanged);
            // 
            // cmbYearTabBeverage
            // 
            this.cmbYearTabBeverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYearTabBeverage.FormattingEnabled = true;
            this.cmbYearTabBeverage.Location = new System.Drawing.Point(806, 43);
            this.cmbYearTabBeverage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYearTabBeverage.Name = "cmbYearTabBeverage";
            this.cmbYearTabBeverage.Size = new System.Drawing.Size(138, 21);
            this.cmbYearTabBeverage.TabIndex = 6;
            this.cmbYearTabBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbYearTabBeverage_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateWeek);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dateThongKe);
            this.tabPage3.Controls.Add(this.btnExportFile);
            this.tabPage3.Controls.Add(this.grdCtrThongKeNguyenLieu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(987, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê kho nguyên liệu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateWeek
            // 
            this.dateWeek.EditValue = new System.DateTime(2019, 1, 14, 0, 0, 0, 0);
            this.dateWeek.Location = new System.Drawing.Point(179, 38);
            this.dateWeek.Margin = new System.Windows.Forms.Padding(2);
            this.dateWeek.Name = "dateWeek";
            this.dateWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWeek.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateWeek.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateWeek.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWeek.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateWeek.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateWeek.Size = new System.Drawing.Size(118, 20);
            this.dateWeek.TabIndex = 8;
            this.dateWeek.EditValueChanged += new System.EventHandler(this.dateWeek_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Theo tuần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Theo tháng";
            // 
            // dateThongKe
            // 
            this.dateThongKe.EditValue = new System.DateTime(2019, 1, 14, 0, 0, 0, 0);
            this.dateThongKe.Location = new System.Drawing.Point(26, 38);
            this.dateThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dateThongKe.Name = "dateThongKe";
            this.dateThongKe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThongKe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThongKe.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dateThongKe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateThongKe.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dateThongKe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateThongKe.Size = new System.Drawing.Size(118, 20);
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
            this.btnExportFile.Location = new System.Drawing.Point(874, 22);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Primary = true;
            this.btnExportFile.Size = new System.Drawing.Size(86, 36);
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
            this.grdCtrThongKeNguyenLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrThongKeNguyenLieu.Location = new System.Drawing.Point(25, 80);
            this.grdCtrThongKeNguyenLieu.MainView = this.grdViThongKeNguyenLieu;
            this.grdCtrThongKeNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrThongKeNguyenLieu.Name = "grdCtrThongKeNguyenLieu";
            this.grdCtrThongKeNguyenLieu.Size = new System.Drawing.Size(935, 410);
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
            this.grdViThongKeNguyenLieu.DetailHeight = 284;
            this.grdViThongKeNguyenLieu.GridControl = this.grdCtrThongKeNguyenLieu;
            this.grdViThongKeNguyenLieu.Name = "grdViThongKeNguyenLieu";
            this.grdViThongKeNguyenLieu.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThongKeNguyenLieu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThongKeNguyenLieu.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThongKeNguyenLieu.OptionsBehavior.ReadOnly = true;
            this.grdViThongKeNguyenLieu.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdViThongKeNguyenLieu.OptionsView.RowAutoHeight = true;
            this.grdViThongKeNguyenLieu.OptionsView.ShowGroupPanel = false;
            // 
            // coltennguyenlieu
            // 
            this.coltennguyenlieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltennguyenlieu.AppearanceCell.Options.UseFont = true;
            this.coltennguyenlieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltennguyenlieu.AppearanceHeader.Options.UseFont = true;
            this.coltennguyenlieu.Caption = "Tên nguyên liệu";
            this.coltennguyenlieu.FieldName = "tennguyenlieu";
            this.coltennguyenlieu.MinWidth = 19;
            this.coltennguyenlieu.Name = "coltennguyenlieu";
            this.coltennguyenlieu.OptionsColumn.AllowEdit = false;
            this.coltennguyenlieu.Visible = true;
            this.coltennguyenlieu.VisibleIndex = 0;
            this.coltennguyenlieu.Width = 70;
            // 
            // coldinhluonglythuyet
            // 
            this.coldinhluonglythuyet.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinhluonglythuyet.AppearanceCell.Options.UseFont = true;
            this.coldinhluonglythuyet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinhluonglythuyet.AppearanceHeader.Options.UseFont = true;
            this.coldinhluonglythuyet.Caption = "Định lượng lý thuyết";
            this.coldinhluonglythuyet.FieldName = "dinhluonglythuyet";
            this.coldinhluonglythuyet.MinWidth = 19;
            this.coldinhluonglythuyet.Name = "coldinhluonglythuyet";
            this.coldinhluonglythuyet.OptionsColumn.AllowEdit = false;
            this.coldinhluonglythuyet.Visible = true;
            this.coldinhluonglythuyet.VisibleIndex = 1;
            this.coldinhluonglythuyet.Width = 70;
            // 
            // coldinhluongthucte
            // 
            this.coldinhluongthucte.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinhluongthucte.AppearanceCell.Options.UseFont = true;
            this.coldinhluongthucte.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinhluongthucte.AppearanceHeader.Options.UseFont = true;
            this.coldinhluongthucte.Caption = "Định lượng thực tế";
            this.coldinhluongthucte.FieldName = "dinhluongthucte";
            this.coldinhluongthucte.MinWidth = 19;
            this.coldinhluongthucte.Name = "coldinhluongthucte";
            this.coldinhluongthucte.OptionsColumn.AllowEdit = false;
            this.coldinhluongthucte.Visible = true;
            this.coldinhluongthucte.VisibleIndex = 2;
            this.coldinhluongthucte.Width = 70;
            // 
            // coldonvi
            // 
            this.coldonvi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldonvi.AppearanceCell.Options.UseFont = true;
            this.coldonvi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldonvi.AppearanceHeader.Options.UseFont = true;
            this.coldonvi.Caption = "Đơn vị";
            this.coldonvi.FieldName = "donvi";
            this.coldonvi.MinWidth = 19;
            this.coldonvi.Name = "coldonvi";
            this.coldonvi.OptionsColumn.AllowEdit = false;
            this.coldonvi.Visible = true;
            this.coldonvi.VisibleIndex = 3;
            this.coldonvi.Width = 70;
            // 
            // colhaohut
            // 
            this.colhaohut.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colhaohut.AppearanceCell.Options.UseFont = true;
            this.colhaohut.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colhaohut.AppearanceHeader.Options.UseFont = true;
            this.colhaohut.Caption = "Hao hụt";
            this.colhaohut.FieldName = "haohut";
            this.colhaohut.MinWidth = 19;
            this.colhaohut.Name = "colhaohut";
            this.colhaohut.OptionsColumn.AllowEdit = false;
            this.colhaohut.Visible = true;
            this.colhaohut.VisibleIndex = 4;
            this.colhaohut.Width = 70;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(2, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(997, 38);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "tabStatistics";
            this.Size = new System.Drawing.Size(998, 585);
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
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrThongKeNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThongKeNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbYearTabBeverage;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dateWeek;
    }
}
