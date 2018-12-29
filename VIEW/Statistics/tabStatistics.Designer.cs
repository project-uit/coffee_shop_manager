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
            this.components = new System.ComponentModel.Container();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.btnExportFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grdCtrThongKeNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.thongKeNguyenLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdViThongKeNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltennguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluonglythuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluongthucte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhaohut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateThongKe = new DevExpress.XtraEditors.DateEdit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrThongKeNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeNguyenLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThongKeNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1028, 28);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            this.materialTabControl1.Location = new System.Drawing.Point(2, 32);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1026, 425);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1018, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "doanh thu";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1018, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê nhóm thức uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhóm thức uống";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateNgayBatDau);
            this.tabPage3.Controls.Add(this.btnExportFile);
            this.tabPage3.Controls.Add(this.grdCtrThongKeNguyenLieu);
            this.tabPage3.Controls.Add(this.dateThongKe);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1018, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê kho nguyên liệu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.EditValue = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.dateNgayBatDau.Location = new System.Drawing.Point(150, 5);
            this.dateNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBatDau.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateNgayBatDau.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayBatDau.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayBatDau.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayBatDau.Size = new System.Drawing.Size(102, 20);
            this.dateNgayBatDau.TabIndex = 3;
            this.dateNgayBatDau.ToolTip = "Ngày bắt đầu";
            // 
            // btnExportFile
            // 
            this.btnExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportFile.AutoSize = true;
            this.btnExportFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportFile.Depth = 0;
            this.btnExportFile.Icon = null;
            this.btnExportFile.Location = new System.Drawing.Point(916, 5);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Primary = true;
            this.btnExportFile.Size = new System.Drawing.Size(86, 36);
            this.btnExportFile.TabIndex = 2;
            this.btnExportFile.Text = "Xuất file";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // grdCtrThongKeNguyenLieu
            // 
            this.grdCtrThongKeNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrThongKeNguyenLieu.DataSource = this.thongKeNguyenLieuBindingSource;
            this.grdCtrThongKeNguyenLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrThongKeNguyenLieu.Location = new System.Drawing.Point(0, 62);
            this.grdCtrThongKeNguyenLieu.MainView = this.grdViThongKeNguyenLieu;
            this.grdCtrThongKeNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrThongKeNguyenLieu.Name = "grdCtrThongKeNguyenLieu";
            this.grdCtrThongKeNguyenLieu.Size = new System.Drawing.Size(1018, 340);
            this.grdCtrThongKeNguyenLieu.TabIndex = 1;
            this.grdCtrThongKeNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViThongKeNguyenLieu});
            // 
            // thongKeNguyenLieuBindingSource
            // 
            this.thongKeNguyenLieuBindingSource.DataSource = typeof(COFFEE_SHOP_MANAGER.DTO.ThongKeNguyenLieu);
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
            this.grdViThongKeNguyenLieu.OptionsView.ShowGroupPanel = false;
            // 
            // coltennguyenlieu
            // 
            this.coltennguyenlieu.Caption = "Tên nguyên liệu";
            this.coltennguyenlieu.FieldName = "tennguyenlieu";
            this.coltennguyenlieu.MinWidth = 19;
            this.coltennguyenlieu.Name = "coltennguyenlieu";
            this.coltennguyenlieu.Visible = true;
            this.coltennguyenlieu.VisibleIndex = 0;
            this.coltennguyenlieu.Width = 70;
            // 
            // coldinhluonglythuyet
            // 
            this.coldinhluonglythuyet.Caption = "Định lượng lý thuyết";
            this.coldinhluonglythuyet.FieldName = "dinhluonglythuyet";
            this.coldinhluonglythuyet.MinWidth = 19;
            this.coldinhluonglythuyet.Name = "coldinhluonglythuyet";
            this.coldinhluonglythuyet.Visible = true;
            this.coldinhluonglythuyet.VisibleIndex = 1;
            this.coldinhluonglythuyet.Width = 70;
            // 
            // coldinhluongthucte
            // 
            this.coldinhluongthucte.Caption = "Định lượng thực tế";
            this.coldinhluongthucte.FieldName = "dinhluongthucte";
            this.coldinhluongthucte.MinWidth = 19;
            this.coldinhluongthucte.Name = "coldinhluongthucte";
            this.coldinhluongthucte.Visible = true;
            this.coldinhluongthucte.VisibleIndex = 2;
            this.coldinhluongthucte.Width = 70;
            // 
            // coldonvi
            // 
            this.coldonvi.Caption = "Đơn vị";
            this.coldonvi.FieldName = "donvi";
            this.coldonvi.MinWidth = 19;
            this.coldonvi.Name = "coldonvi";
            this.coldonvi.Visible = true;
            this.coldonvi.VisibleIndex = 3;
            this.coldonvi.Width = 70;
            // 
            // colhaohut
            // 
            this.colhaohut.Caption = "Hao hụt";
            this.colhaohut.FieldName = "haohut";
            this.colhaohut.MinWidth = 19;
            this.colhaohut.Name = "colhaohut";
            this.colhaohut.Visible = true;
            this.colhaohut.VisibleIndex = 4;
            this.colhaohut.Width = 70;
            // 
            // dateThongKe
            // 
            this.dateThongKe.EditValue = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.dateThongKe.Location = new System.Drawing.Point(4, 5);
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
            this.dateThongKe.TabIndex = 0;
            this.dateThongKe.EditValueChanged += new System.EventHandler(this.dateThongKe_EditValueChanged);
            // 
            // tabStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "tabStatistics";
            this.Size = new System.Drawing.Size(1028, 460);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrThongKeNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeNguyenLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThongKeNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThongKe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateThongKe;
        private MaterialSkin.Controls.MaterialRaisedButton btnExportFile;
        private DevExpress.XtraGrid.GridControl grdCtrThongKeNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViThongKeNguyenLieu;
        private System.Windows.Forms.BindingSource thongKeNguyenLieuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltennguyenlieu;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluonglythuyet;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluongthucte;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvi;
        private DevExpress.XtraGrid.Columns.GridColumn colhaohut;
        private DevExpress.XtraEditors.DateEdit dateNgayBatDau;
    }
}
