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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabImport));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThemNguyenLieu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNhapKho = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grdCtrlThemNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltennguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltendonvi_dinh_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldinh_luong_toi_da = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinh_luong_toi_thieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemNguyenLieuDaDung = new MaterialSkin.Controls.MaterialRaisedButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtTimKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbCheckKho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThemNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieu.AutoSize = true;
            this.btnThemNguyenLieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNguyenLieu.Depth = 0;
            this.btnThemNguyenLieu.Icon = null;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(926, 28);
            this.btnThemNguyenLieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Primary = true;
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(148, 36);
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
            this.btnNhapKho.Location = new System.Drawing.Point(1084, 28);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNhapKho.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Primary = true;
            this.btnNhapKho.Size = new System.Drawing.Size(90, 36);
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
            this.grdCtrlThemNguyenLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrlThemNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCtrlThemNguyenLieu.Location = new System.Drawing.Point(29, 87);
            this.grdCtrlThemNguyenLieu.LookAndFeel.SkinName = "Office 2016 Dark";
            this.grdCtrlThemNguyenLieu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.grdCtrlThemNguyenLieu.MainView = this.gridView1;
            this.grdCtrlThemNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrlThemNguyenLieu.Name = "grdCtrlThemNguyenLieu";
            this.grdCtrlThemNguyenLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.grdCtrlThemNguyenLieu.Size = new System.Drawing.Size(1145, 362);
            this.grdCtrlThemNguyenLieu.TabIndex = 9;
            this.grdCtrlThemNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltennguyenlieu,
            this.coldinhluong,
            this.coltendonvi_dinh_luong,
            this.edit,
            this.coldinh_luong_toi_da,
            this.coldinh_luong_toi_thieu});
            this.gridView1.DetailHeight = 190;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.grdCtrlThemNguyenLieu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coltennguyenlieu
            // 
            this.coltennguyenlieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.coltennguyenlieu.AppearanceCell.Options.UseFont = true;
            this.coltennguyenlieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.coltennguyenlieu.AppearanceHeader.Options.UseFont = true;
            this.coltennguyenlieu.Caption = "Tên Nguyên Liệu";
            this.coltennguyenlieu.FieldName = "tennguyenlieu";
            this.coltennguyenlieu.MinWidth = 19;
            this.coltennguyenlieu.Name = "coltennguyenlieu";
            this.coltennguyenlieu.OptionsColumn.AllowEdit = false;
            this.coltennguyenlieu.Visible = true;
            this.coltennguyenlieu.VisibleIndex = 1;
            this.coltennguyenlieu.Width = 268;
            // 
            // coldinhluong
            // 
            this.coldinhluong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.coldinhluong.AppearanceCell.Options.UseFont = true;
            this.coldinhluong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.coldinhluong.AppearanceHeader.Options.UseFont = true;
            this.coldinhluong.Caption = "Định Lượng";
            this.coldinhluong.DisplayFormat.FormatString = "{0:n}";
            this.coldinhluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldinhluong.FieldName = "dinhluong";
            this.coldinhluong.MinWidth = 19;
            this.coldinhluong.Name = "coldinhluong";
            this.coldinhluong.OptionsColumn.AllowEdit = false;
            this.coldinhluong.Visible = true;
            this.coldinhluong.VisibleIndex = 2;
            this.coldinhluong.Width = 200;
            // 
            // coltendonvi_dinh_luong
            // 
            this.coltendonvi_dinh_luong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.coltendonvi_dinh_luong.AppearanceCell.Options.UseFont = true;
            this.coltendonvi_dinh_luong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.coltendonvi_dinh_luong.AppearanceHeader.Options.UseFont = true;
            this.coltendonvi_dinh_luong.Caption = "Tên Đơn Vị Định Lượng";
            this.coltendonvi_dinh_luong.FieldName = "tendonvi_dinh_luong";
            this.coltendonvi_dinh_luong.MinWidth = 19;
            this.coltendonvi_dinh_luong.Name = "coltendonvi_dinh_luong";
            this.coltendonvi_dinh_luong.OptionsColumn.AllowEdit = false;
            this.coltendonvi_dinh_luong.Visible = true;
            this.coltendonvi_dinh_luong.VisibleIndex = 3;
            this.coltendonvi_dinh_luong.Width = 229;
            // 
            // edit
            // 
            this.edit.ColumnEdit = this.btnEdit;
            this.edit.MinWidth = 19;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 6;
            this.edit.Width = 43;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Sửa", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // coldinh_luong_toi_da
            // 
            this.coldinh_luong_toi_da.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinh_luong_toi_da.AppearanceCell.Options.UseFont = true;
            this.coldinh_luong_toi_da.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinh_luong_toi_da.AppearanceHeader.Options.UseFont = true;
            this.coldinh_luong_toi_da.Caption = "Định lượng tối đa";
            this.coldinh_luong_toi_da.FieldName = "dinh_luong_toi_da";
            this.coldinh_luong_toi_da.MinWidth = 19;
            this.coldinh_luong_toi_da.Name = "coldinh_luong_toi_da";
            this.coldinh_luong_toi_da.OptionsColumn.AllowEdit = false;
            this.coldinh_luong_toi_da.Visible = true;
            this.coldinh_luong_toi_da.VisibleIndex = 4;
            this.coldinh_luong_toi_da.Width = 205;
            // 
            // coldinh_luong_toi_thieu
            // 
            this.coldinh_luong_toi_thieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinh_luong_toi_thieu.AppearanceCell.Options.UseFont = true;
            this.coldinh_luong_toi_thieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinh_luong_toi_thieu.AppearanceHeader.Options.UseFont = true;
            this.coldinh_luong_toi_thieu.Caption = "Định lượng tối thiểu";
            this.coldinh_luong_toi_thieu.FieldName = "dinh_luong_toi_thieu";
            this.coldinh_luong_toi_thieu.MinWidth = 19;
            this.coldinh_luong_toi_thieu.Name = "coldinh_luong_toi_thieu";
            this.coldinh_luong_toi_thieu.OptionsColumn.AllowEdit = false;
            this.coldinh_luong_toi_thieu.Visible = true;
            this.coldinh_luong_toi_thieu.VisibleIndex = 5;
            this.coldinh_luong_toi_thieu.Width = 183;
            // 
            // btnThemNguyenLieuDaDung
            // 
            this.btnThemNguyenLieuDaDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieuDaDung.AutoSize = true;
            this.btnThemNguyenLieuDaDung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNguyenLieuDaDung.Depth = 0;
            this.btnThemNguyenLieuDaDung.Icon = null;
            this.btnThemNguyenLieuDaDung.Location = new System.Drawing.Point(711, 28);
            this.btnThemNguyenLieuDaDung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemNguyenLieuDaDung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNguyenLieuDaDung.Name = "btnThemNguyenLieuDaDung";
            this.btnThemNguyenLieuDaDung.Primary = true;
            this.btnThemNguyenLieuDaDung.Size = new System.Drawing.Size(209, 36);
            this.btnThemNguyenLieuDaDung.TabIndex = 10;
            this.btnThemNguyenLieuDaDung.Text = "NHẬP NGUYÊN LIỆU ĐÃ DÙNG";
            this.btnThemNguyenLieuDaDung.UseVisualStyleBackColor = true;
            this.btnThemNguyenLieuDaDung.Click += new System.EventHandler(this.btnThemNguyenLieuDaDung_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Hint = "Tìm kiếm tên nguyên liệu";
            this.txtTimKiem.Location = new System.Drawing.Point(29, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.Size = new System.Drawing.Size(306, 23);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cmbCheckKho
            // 
            this.cmbCheckKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheckKho.FormattingEnabled = true;
            this.cmbCheckKho.Items.AddRange(new object[] {
            "Tất cả",
            "Tồn kho",
            "Vượt định mức",
            "Sắp hết hàng"});
            this.cmbCheckKho.Location = new System.Drawing.Point(431, 34);
            this.cmbCheckKho.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCheckKho.Name = "cmbCheckKho";
            this.cmbCheckKho.Size = new System.Drawing.Size(167, 25);
            this.cmbCheckKho.TabIndex = 14;
            this.cmbCheckKho.SelectedIndexChanged += new System.EventHandler(this.cmbCheckKho_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tồn kho";
            // 
            // tabImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCheckKho);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThemNguyenLieuDaDung);
            this.Controls.Add(this.grdCtrlThemNguyenLieu);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "tabImport";
            this.Size = new System.Drawing.Size(1205, 476);
            this.Load += new System.EventHandler(this.tabImport_Load);
            this.Click += new System.EventHandler(this.tabImport_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThemNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnThemNguyenLieu;
        private MaterialSkin.Controls.MaterialRaisedButton btnNhapKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coltennguyenlieu;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluong;
        private DevExpress.XtraGrid.Columns.GridColumn coltendonvi_dinh_luong;
        public DevExpress.XtraGrid.GridControl grdCtrlThemNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemNguyenLieuDaDung;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTimKiem;
        private System.Windows.Forms.ComboBox cmbCheckKho;
        private DevExpress.XtraGrid.Columns.GridColumn coldinh_luong_toi_da;
        private DevExpress.XtraGrid.Columns.GridColumn coldinh_luong_toi_thieu;
        private System.Windows.Forms.Label label1;
    }
}
