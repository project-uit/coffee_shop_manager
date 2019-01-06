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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabImport));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThemNguyenLieu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNhapKho = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grdCtrlThemNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltennguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltendonvi_dinh_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThemNguyenLieuDaDung = new MaterialSkin.Controls.MaterialRaisedButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
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
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(1848, 25);
            this.btnThemNguyenLieu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThemNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Primary = true;
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(279, 36);
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
            this.btnNhapKho.Location = new System.Drawing.Point(2225, 25);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnNhapKho.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Primary = true;
            this.btnNhapKho.Size = new System.Drawing.Size(163, 36);
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
            this.grdCtrlThemNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCtrlThemNguyenLieu.Location = new System.Drawing.Point(-19, 595);
            this.grdCtrlThemNguyenLieu.LookAndFeel.SkinName = "Office 2016 Dark";
            this.grdCtrlThemNguyenLieu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.grdCtrlThemNguyenLieu.MainView = this.gridView1;
            this.grdCtrlThemNguyenLieu.Name = "grdCtrlThemNguyenLieu";
            this.grdCtrlThemNguyenLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.grdCtrlThemNguyenLieu.Size = new System.Drawing.Size(2407, 797);
            this.grdCtrlThemNguyenLieu.TabIndex = 9;
            this.grdCtrlThemNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdCtrlThemNguyenLieu.Click += new System.EventHandler(this.grdCtrlThemNguyenLieu_Click);
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltennguyenlieu,
            this.coldinhluong,
            this.coltendonvi_dinh_luong,
            this.edit});
            this.gridView1.DetailHeight = 365;
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
            this.coltennguyenlieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltennguyenlieu.AppearanceCell.Options.UseFont = true;
            this.coltennguyenlieu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltennguyenlieu.AppearanceHeader.Options.UseFont = true;
            this.coltennguyenlieu.Caption = "Tên Nguyên Liệu";
            this.coltennguyenlieu.FieldName = "tennguyenlieu";
            this.coltennguyenlieu.MinWidth = 38;
            this.coltennguyenlieu.Name = "coltennguyenlieu";
            this.coltennguyenlieu.Visible = true;
            this.coltennguyenlieu.VisibleIndex = 1;
            this.coltennguyenlieu.Width = 858;
            // 
            // coldinhluong
            // 
            this.coldinhluong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinhluong.AppearanceCell.Options.UseFont = true;
            this.coldinhluong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldinhluong.AppearanceHeader.Options.UseFont = true;
            this.coldinhluong.Caption = "Định Lượng";
            this.coldinhluong.DisplayFormat.FormatString = "{0:n}";
            this.coldinhluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldinhluong.FieldName = "dinhluong";
            this.coldinhluong.MinWidth = 38;
            this.coldinhluong.Name = "coldinhluong";
            this.coldinhluong.Visible = true;
            this.coldinhluong.VisibleIndex = 2;
            this.coldinhluong.Width = 598;
            // 
            // coltendonvi_dinh_luong
            // 
            this.coltendonvi_dinh_luong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltendonvi_dinh_luong.AppearanceCell.Options.UseFont = true;
            this.coltendonvi_dinh_luong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltendonvi_dinh_luong.AppearanceHeader.Options.UseFont = true;
            this.coltendonvi_dinh_luong.Caption = "Tên Đơn Vị Định Lượng";
            this.coltendonvi_dinh_luong.FieldName = "tendonvi_dinh_luong";
            this.coltendonvi_dinh_luong.MinWidth = 38;
            this.coltendonvi_dinh_luong.Name = "coltendonvi_dinh_luong";
            this.coltendonvi_dinh_luong.Visible = true;
            this.coltendonvi_dinh_luong.VisibleIndex = 3;
            this.coltendonvi_dinh_luong.Width = 557;
            // 
            // edit
            // 
            this.edit.ColumnEdit = this.btnEdit;
            this.edit.MinWidth = 38;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 4;
            this.edit.Width = 69;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "Sửa", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.btnThemNguyenLieuDaDung.Location = new System.Drawing.Point(1354, 25);
            this.btnThemNguyenLieuDaDung.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThemNguyenLieuDaDung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNguyenLieuDaDung.Name = "btnThemNguyenLieuDaDung";
            this.btnThemNguyenLieuDaDung.Primary = true;
            this.btnThemNguyenLieuDaDung.Size = new System.Drawing.Size(402, 36);
            this.btnThemNguyenLieuDaDung.TabIndex = 10;
            this.btnThemNguyenLieuDaDung.Text = "NHẬP NGUYÊN LIỆU ĐÃ DÙNG";
            this.btnThemNguyenLieuDaDung.UseVisualStyleBackColor = true;
            this.btnThemNguyenLieuDaDung.Click += new System.EventHandler(this.btnThemNguyenLieuDaDung_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(568, 1);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(15, 14);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PromptText = "Tìm kiếm nguyên liêu";
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(638, 71);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMark = "Tìm kiếm nguyên liêu";
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // tabImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThemNguyenLieuDaDung);
            this.Controls.Add(this.grdCtrlThemNguyenLieu);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "tabImport";
            this.Size = new System.Drawing.Size(2410, 916);
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
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
    }
}
