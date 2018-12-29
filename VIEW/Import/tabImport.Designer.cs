namespace COFFEE_SHOP_MANAGER
{
    partial class tabImport
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabImport));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThemNguyenLieu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNhapKho = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grdCtrlThemNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idkhonguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltendonvi_dinh_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThemNguyenLieuDaDung = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThemNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieu.AutoSize = true;
            this.btnThemNguyenLieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNguyenLieu.Depth = 0;
            this.btnThemNguyenLieu.Icon = null;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(1422, 48);
            this.btnThemNguyenLieu.Margin = new System.Windows.Forms.Padding(6);
            this.btnThemNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Primary = true;
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(246, 36);
            this.btnThemNguyenLieu.TabIndex = 7;
            this.btnThemNguyenLieu.Text = "THÊM NGUYÊN LIỆU";
            this.btnThemNguyenLieu.UseVisualStyleBackColor = true;
            this.btnThemNguyenLieu.Click += new System.EventHandler(this.btnThemNguyenLieu_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapKho.AutoSize = true;
            this.btnNhapKho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNhapKho.Depth = 0;
            this.btnNhapKho.Icon = null;
            this.btnNhapKho.Location = new System.Drawing.Point(1758, 48);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(6);
            this.btnNhapKho.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Primary = true;
            this.btnNhapKho.Size = new System.Drawing.Size(145, 36);
            this.btnNhapKho.TabIndex = 8;
            this.btnNhapKho.Text = "NHẬP KHO";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // grdCtrlThemNguyenLieu
            // 
            this.grdCtrlThemNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrlThemNguyenLieu.DataSource = typeof(COFFEE_SHOP_MANAGER.khonguyenlieu);
            this.grdCtrlThemNguyenLieu.Location = new System.Drawing.Point(3, 267);
            this.grdCtrlThemNguyenLieu.LookAndFeel.SkinName = "Office 2016 Dark";
            this.grdCtrlThemNguyenLieu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.grdCtrlThemNguyenLieu.MainView = this.gridView1;
            this.grdCtrlThemNguyenLieu.Name = "grdCtrlThemNguyenLieu";
            this.grdCtrlThemNguyenLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.grdCtrlThemNguyenLieu.Size = new System.Drawing.Size(2206, 578);
            this.grdCtrlThemNguyenLieu.TabIndex = 9;
            this.grdCtrlThemNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idkhonguyenlieu,
            this.coltennguyenlieu,
            this.coldinhluong,
            this.coltendonvi_dinh_luong,
            this.edit});
            this.gridView1.GridControl = this.grdCtrlThemNguyenLieu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // idkhonguyenlieu
            // 
            this.idkhonguyenlieu.Caption = "ID";
            this.idkhonguyenlieu.FieldName = "idkhonguyenlieu";
            this.idkhonguyenlieu.MinWidth = 35;
            this.idkhonguyenlieu.Name = "idkhonguyenlieu";
            this.idkhonguyenlieu.Visible = true;
            this.idkhonguyenlieu.VisibleIndex = 1;
            this.idkhonguyenlieu.Width = 191;
            // 
            // coltennguyenlieu
            // 
            this.coltennguyenlieu.Caption = "Tên Nguyên Liệu";
            this.coltennguyenlieu.FieldName = "tennguyenlieu";
            this.coltennguyenlieu.MinWidth = 35;
            this.coltennguyenlieu.Name = "coltennguyenlieu";
            this.coltennguyenlieu.Visible = true;
            this.coltennguyenlieu.VisibleIndex = 2;
            this.coltennguyenlieu.Width = 785;
            // 
            // coldinhluong
            // 
            this.coldinhluong.Caption = "Định Lượng";
            this.coldinhluong.FieldName = "dinhluong";
            this.coldinhluong.MinWidth = 35;
            this.coldinhluong.Name = "coldinhluong";
            this.coldinhluong.Visible = true;
            this.coldinhluong.VisibleIndex = 3;
            this.coldinhluong.Width = 547;
            // 
            // coltendonvi_dinh_luong
            // 
            this.coltendonvi_dinh_luong.Caption = "Tên đơn vị định lượng";
            this.coltendonvi_dinh_luong.FieldName = "tendonvi_dinh_luong";
            this.coltendonvi_dinh_luong.MinWidth = 35;
            this.coltendonvi_dinh_luong.Name = "coltendonvi_dinh_luong";
            this.coltendonvi_dinh_luong.Visible = true;
            this.coltendonvi_dinh_luong.VisibleIndex = 4;
            this.coltendonvi_dinh_luong.Width = 493;
            // 
            // edit
            // 
            this.edit.Caption = "Sửa";
            this.edit.ColumnEdit = this.btnEdit;
            this.edit.MinWidth = 35;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 5;
            this.edit.Width = 77;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnThemNguyenLieuDaDung
            // 
            this.btnThemNguyenLieuDaDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieuDaDung.AutoSize = true;
            this.btnThemNguyenLieuDaDung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNguyenLieuDaDung.Depth = 0;
            this.btnThemNguyenLieuDaDung.Icon = null;
            this.btnThemNguyenLieuDaDung.Location = new System.Drawing.Point(989, 48);
            this.btnThemNguyenLieuDaDung.Margin = new System.Windows.Forms.Padding(6);
            this.btnThemNguyenLieuDaDung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNguyenLieuDaDung.Name = "btnThemNguyenLieuDaDung";
            this.btnThemNguyenLieuDaDung.Primary = true;
            this.btnThemNguyenLieuDaDung.Size = new System.Drawing.Size(354, 36);
            this.btnThemNguyenLieuDaDung.TabIndex = 10;
            this.btnThemNguyenLieuDaDung.Text = "NHẬP NGUYÊN LIỆU ĐÃ DÙNG";
            this.btnThemNguyenLieuDaDung.UseVisualStyleBackColor = true;
            this.btnThemNguyenLieuDaDung.Click += new System.EventHandler(this.btnThemNguyenLieuDaDung_Click);
            // 
            // tabImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnThemNguyenLieuDaDung);
            this.Controls.Add(this.grdCtrlThemNguyenLieu);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "tabImport";
            this.Size = new System.Drawing.Size(2209, 879);
            this.Load += new System.EventHandler(this.tabImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThemNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnThemNguyenLieu;
        private MaterialSkin.Controls.MaterialRaisedButton btnNhapKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idkhonguyenlieu;
        private DevExpress.XtraGrid.Columns.GridColumn coltennguyenlieu;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluong;
        private DevExpress.XtraGrid.Columns.GridColumn coltendonvi_dinh_luong;
        public DevExpress.XtraGrid.GridControl grdCtrlThemNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemNguyenLieuDaDung;
    }
}
