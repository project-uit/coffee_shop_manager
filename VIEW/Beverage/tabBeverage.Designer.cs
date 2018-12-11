namespace COFFEE_SHOP_MANAGER
{
    partial class tabBeverage
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabBeverage));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grdViThucUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_thucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhomthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_btnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_btnSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_btnCongThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCongThuc = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdCtrlThucUong = new DevExpress.XtraGrid.GridControl();
            this.txtTenThucUong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnThemThucUong = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNhomThucUong = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnGiamGia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExportExcel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grdViThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViThucUong
            // 
            this.grdViThucUong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_thucuong,
            this.coltenthucuong,
            this.colgiaban,
            this.colnhomthucuong,
            this.col_btnXoa,
            this.col_btnSua,
            this.col_btnCongThuc});
            this.grdViThucUong.DetailHeight = 431;
            this.grdViThucUong.GridControl = this.grdCtrlThucUong;
            this.grdViThucUong.Name = "grdViThucUong";
            this.grdViThucUong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThucUong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViThucUong.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.grdViThucUong.OptionsBehavior.ReadOnly = true;
            this.grdViThucUong.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.grdViThucUong.OptionsView.ShowGroupPanel = false;
            // 
            // colid_thucuong
            // 
            this.colid_thucuong.FieldName = "id_thucuong";
            this.colid_thucuong.MinWidth = 27;
            this.colid_thucuong.Name = "colid_thucuong";
            this.colid_thucuong.Width = 100;
            // 
            // coltenthucuong
            // 
            this.coltenthucuong.Caption = "Tên thức uống";
            this.coltenthucuong.FieldName = "tenthucuong";
            this.coltenthucuong.MinWidth = 27;
            this.coltenthucuong.Name = "coltenthucuong";
            this.coltenthucuong.Visible = true;
            this.coltenthucuong.VisibleIndex = 0;
            this.coltenthucuong.Width = 242;
            // 
            // colgiaban
            // 
            this.colgiaban.Caption = "Giá bán";
            this.colgiaban.DisplayFormat.FormatString = "{0:C}";
            this.colgiaban.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colgiaban.FieldName = "giaban";
            this.colgiaban.MinWidth = 27;
            this.colgiaban.Name = "colgiaban";
            this.colgiaban.Visible = true;
            this.colgiaban.VisibleIndex = 2;
            this.colgiaban.Width = 242;
            // 
            // colnhomthucuong
            // 
            this.colnhomthucuong.Caption = "Nhóm thức uống";
            this.colnhomthucuong.FieldName = "nhomthucuong.tennhomthucuong";
            this.colnhomthucuong.MinWidth = 27;
            this.colnhomthucuong.Name = "colnhomthucuong";
            this.colnhomthucuong.Visible = true;
            this.colnhomthucuong.VisibleIndex = 1;
            this.colnhomthucuong.Width = 647;
            // 
            // col_btnXoa
            // 
            this.col_btnXoa.ColumnEdit = this.btnXoa;
            this.col_btnXoa.MinWidth = 25;
            this.col_btnXoa.Name = "col_btnXoa";
            this.col_btnXoa.Visible = true;
            this.col_btnXoa.VisibleIndex = 3;
            this.col_btnXoa.Width = 46;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Xóa", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // col_btnSua
            // 
            this.col_btnSua.ColumnEdit = this.btnSua;
            this.col_btnSua.MinWidth = 25;
            this.col_btnSua.Name = "col_btnSua";
            this.col_btnSua.Visible = true;
            this.col_btnSua.VisibleIndex = 4;
            this.col_btnSua.Width = 48;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Sửa", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // col_btnCongThuc
            // 
            this.col_btnCongThuc.ColumnEdit = this.btnCongThuc;
            this.col_btnCongThuc.MinWidth = 25;
            this.col_btnCongThuc.Name = "col_btnCongThuc";
            this.col_btnCongThuc.Visible = true;
            this.col_btnCongThuc.VisibleIndex = 5;
            this.col_btnCongThuc.Width = 44;
            // 
            // btnCongThuc
            // 
            this.btnCongThuc.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnCongThuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Lập công thức", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnCongThuc.Name = "btnCongThuc";
            this.btnCongThuc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnCongThuc.Click += new System.EventHandler(this.btnCongThuc_Click);
            // 
            // grdCtrlThucUong
            // 
            this.grdCtrlThucUong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrlThucUong.DataSource = typeof(COFFEE_SHOP_MANAGER.thucuong);
            this.grdCtrlThucUong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdCtrlThucUong.Location = new System.Drawing.Point(4, 84);
            this.grdCtrlThucUong.MainView = this.grdViThucUong;
            this.grdCtrlThucUong.Margin = new System.Windows.Forms.Padding(4);
            this.grdCtrlThucUong.Name = "grdCtrlThucUong";
            this.grdCtrlThucUong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa,
            this.btnSua,
            this.btnCongThuc});
            this.grdCtrlThucUong.Size = new System.Drawing.Size(1559, 484);
            this.grdCtrlThucUong.TabIndex = 2;
            this.grdCtrlThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViThucUong});
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Depth = 0;
            this.txtTenThucUong.Hint = "Tìm kiếm tên/nhóm thức uống";
            this.txtTenThucUong.Location = new System.Drawing.Point(4, 25);
            this.txtTenThucUong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThucUong.MaxLength = 32767;
            this.txtTenThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.PasswordChar = '\0';
            this.txtTenThucUong.SelectedText = "";
            this.txtTenThucUong.SelectionLength = 0;
            this.txtTenThucUong.SelectionStart = 0;
            this.txtTenThucUong.Size = new System.Drawing.Size(349, 28);
            this.txtTenThucUong.TabIndex = 3;
            this.txtTenThucUong.TabStop = false;
            this.txtTenThucUong.UseSystemPasswordChar = false;
            this.txtTenThucUong.TextChanged += new System.EventHandler(this.txtTenThucUong_TextChanged);
            // 
            // btnThemThucUong
            // 
            this.btnThemThucUong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemThucUong.AutoSize = true;
            this.btnThemThucUong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemThucUong.Depth = 0;
            this.btnThemThucUong.Icon = null;
            this.btnThemThucUong.Location = new System.Drawing.Point(1418, 25);
            this.btnThemThucUong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemThucUong.Name = "btnThemThucUong";
            this.btnThemThucUong.Primary = true;
            this.btnThemThucUong.Size = new System.Drawing.Size(171, 36);
            this.btnThemThucUong.TabIndex = 5;
            this.btnThemThucUong.Text = "Thêm thức uống";
            this.btnThemThucUong.UseVisualStyleBackColor = true;
            this.btnThemThucUong.Click += new System.EventHandler(this.btnThemThucUong_Click);
            // 
            // btnNhomThucUong
            // 
            this.btnNhomThucUong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhomThucUong.AutoSize = true;
            this.btnNhomThucUong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNhomThucUong.Depth = 0;
            this.btnNhomThucUong.Icon = null;
            this.btnNhomThucUong.Location = new System.Drawing.Point(1223, 25);
            this.btnNhomThucUong.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhomThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhomThucUong.Name = "btnNhomThucUong";
            this.btnNhomThucUong.Primary = true;
            this.btnNhomThucUong.Size = new System.Drawing.Size(175, 36);
            this.btnNhomThucUong.TabIndex = 6;
            this.btnNhomThucUong.Text = "Nhóm thức uống";
            this.btnNhomThucUong.UseVisualStyleBackColor = true;
            this.btnNhomThucUong.Click += new System.EventHandler(this.btnNhomThucUong_Click);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanel1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.flyoutPanel1.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.flyoutPanel1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.flyoutPanel1.Appearance.Options.UseBackColor = true;
            this.flyoutPanel1.Appearance.Options.UseBorderColor = true;
            this.flyoutPanel1.Controls.Add(this.lbMessage);
            this.flyoutPanel1.Location = new System.Drawing.Point(26, 452);
            this.flyoutPanel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.flyoutPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanel1.OwnerControl = this.grdCtrlThucUong;
            this.flyoutPanel1.Size = new System.Drawing.Size(267, 95);
            this.flyoutPanel1.TabIndex = 7;
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(267, 95);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Lưu thành công";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.AutoSize = true;
            this.btnGiamGia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGiamGia.Depth = 0;
            this.btnGiamGia.Icon = null;
            this.btnGiamGia.Location = new System.Drawing.Point(1085, 25);
            this.btnGiamGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Primary = true;
            this.btnGiamGia.Size = new System.Drawing.Size(97, 36);
            this.btnGiamGia.TabIndex = 8;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AutoSize = true;
            this.btnExportExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportExcel.Depth = 0;
            this.btnExportExcel.Icon = null;
            this.btnExportExcel.Location = new System.Drawing.Point(756, 25);
            this.btnExportExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Primary = true;
            this.btnExportExcel.Size = new System.Drawing.Size(124, 36);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Export file";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(346, 247);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(613, 300);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // tabBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnGiamGia);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.btnNhomThucUong);
            this.Controls.Add(this.btnThemThucUong);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.grdCtrlThucUong);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabBeverage";
            this.Size = new System.Drawing.Size(1567, 567);
            ((System.ComponentModel.ISupportInitialize)(this.grdViThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView grdViThucUong;
        private DevExpress.XtraGrid.GridControl grdCtrlThucUong;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenThucUong;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemThucUong;
        private DevExpress.XtraGrid.Columns.GridColumn colid_thucuong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenthucuong;
        private DevExpress.XtraGrid.Columns.GridColumn colgiaban;
        private DevExpress.XtraGrid.Columns.GridColumn colnhomthucuong;
        private MaterialSkin.Controls.MaterialRaisedButton btnNhomThucUong;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnCongThuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnCongThuc;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private System.Windows.Forms.Label lbMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnGiamGia;
        private MaterialSkin.Controls.MaterialRaisedButton btnExportExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
