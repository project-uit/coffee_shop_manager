namespace COFFEE_SHOP_MANAGER
{
    partial class tabStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabStaff));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhanvien2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhanvien3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhanvien4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhanvien5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltentaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_taikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_nhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coleDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsers
            // 
            this.gcUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcUsers.Location = new System.Drawing.Point(68, 173);
            this.gcUsers.MainView = this.gridViewTaiKhoan;
            this.gcUsers.Margin = new System.Windows.Forms.Padding(4);
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete,
            this.btnEdit});
            this.gcUsers.Size = new System.Drawing.Size(1778, 654);
            this.gcUsers.TabIndex = 5;
            this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiKhoan});
            // 
            // gridViewTaiKhoan
            // 
            this.gridViewTaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnhanvien,
            this.colnhanvien2,
            this.colnhanvien3,
            this.colnhanvien4,
            this.colnhanvien5,
            this.coltentaikhoan,
            this.colid_taikhoan,
            this.colid_nhanvien,
            this.colquyen,
            this.colEdit,
            this.coleDelete});
            this.gridViewTaiKhoan.GridControl = this.gcUsers;
            this.gridViewTaiKhoan.GroupCount = 1;
            this.gridViewTaiKhoan.LevelIndent = 0;
            this.gridViewTaiKhoan.Name = "gridViewTaiKhoan";
            this.gridViewTaiKhoan.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewTaiKhoan.OptionsView.RowAutoHeight = true;
            this.gridViewTaiKhoan.OptionsView.ShowFooter = true;
            this.gridViewTaiKhoan.OptionsView.ShowGroupPanel = false;
            this.gridViewTaiKhoan.PreviewIndent = 0;
            this.gridViewTaiKhoan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnhanvien, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colnhanvien
            // 
            this.colnhanvien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien.AppearanceCell.Options.UseFont = true;
            this.colnhanvien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien.AppearanceHeader.Options.UseFont = true;
            this.colnhanvien.Caption = "Họ tên";
            this.colnhanvien.FieldName = "hoten";
            this.colnhanvien.MinWidth = 40;
            this.colnhanvien.Name = "colnhanvien";
            this.colnhanvien.OptionsColumn.AllowEdit = false;
            this.colnhanvien.Visible = true;
            this.colnhanvien.VisibleIndex = 0;
            this.colnhanvien.Width = 150;
            // 
            // colnhanvien2
            // 
            this.colnhanvien2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien2.AppearanceCell.Options.UseFont = true;
            this.colnhanvien2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien2.AppearanceHeader.Options.UseFont = true;
            this.colnhanvien2.Caption = "Ngày sinh";
            this.colnhanvien2.FieldName = "ngaysinh";
            this.colnhanvien2.MinWidth = 40;
            this.colnhanvien2.Name = "colnhanvien2";
            this.colnhanvien2.OptionsColumn.AllowEdit = false;
            this.colnhanvien2.Visible = true;
            this.colnhanvien2.VisibleIndex = 0;
            this.colnhanvien2.Width = 264;
            // 
            // colnhanvien3
            // 
            this.colnhanvien3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien3.AppearanceCell.Options.UseFont = true;
            this.colnhanvien3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien3.AppearanceHeader.Options.UseFont = true;
            this.colnhanvien3.Caption = "CMND";
            this.colnhanvien3.FieldName = "cmnd";
            this.colnhanvien3.MinWidth = 40;
            this.colnhanvien3.Name = "colnhanvien3";
            this.colnhanvien3.OptionsColumn.AllowEdit = false;
            this.colnhanvien3.Visible = true;
            this.colnhanvien3.VisibleIndex = 1;
            this.colnhanvien3.Width = 264;
            // 
            // colnhanvien4
            // 
            this.colnhanvien4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien4.AppearanceCell.Options.UseFont = true;
            this.colnhanvien4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien4.AppearanceHeader.Options.UseFont = true;
            this.colnhanvien4.Caption = "Địa chỉ";
            this.colnhanvien4.FieldName = "diachi";
            this.colnhanvien4.MinWidth = 40;
            this.colnhanvien4.Name = "colnhanvien4";
            this.colnhanvien4.OptionsColumn.AllowEdit = false;
            this.colnhanvien4.Visible = true;
            this.colnhanvien4.VisibleIndex = 2;
            this.colnhanvien4.Width = 264;
            // 
            // colnhanvien5
            // 
            this.colnhanvien5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien5.AppearanceCell.Options.UseFont = true;
            this.colnhanvien5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnhanvien5.AppearanceHeader.Options.UseFont = true;
            this.colnhanvien5.Caption = "Lương";
            this.colnhanvien5.DisplayFormat.FormatString = "{0:C3}";
            this.colnhanvien5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colnhanvien5.FieldName = "luong";
            this.colnhanvien5.MinWidth = 40;
            this.colnhanvien5.Name = "colnhanvien5";
            this.colnhanvien5.OptionsColumn.AllowEdit = false;
            this.colnhanvien5.Visible = true;
            this.colnhanvien5.VisibleIndex = 3;
            this.colnhanvien5.Width = 264;
            // 
            // coltentaikhoan
            // 
            this.coltentaikhoan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltentaikhoan.AppearanceCell.Options.UseFont = true;
            this.coltentaikhoan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltentaikhoan.AppearanceHeader.Options.UseFont = true;
            this.coltentaikhoan.Caption = "Tên tài khoản";
            this.coltentaikhoan.FieldName = "tentaikhoan";
            this.coltentaikhoan.MinWidth = 40;
            this.coltentaikhoan.Name = "coltentaikhoan";
            this.coltentaikhoan.OptionsColumn.AllowEdit = false;
            this.coltentaikhoan.Visible = true;
            this.coltentaikhoan.VisibleIndex = 4;
            this.coltentaikhoan.Width = 354;
            // 
            // colid_taikhoan
            // 
            this.colid_taikhoan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid_taikhoan.AppearanceCell.Options.UseFont = true;
            this.colid_taikhoan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid_taikhoan.AppearanceHeader.Options.UseFont = true;
            this.colid_taikhoan.FieldName = "id_taikhoan";
            this.colid_taikhoan.MinWidth = 40;
            this.colid_taikhoan.Name = "colid_taikhoan";
            this.colid_taikhoan.OptionsColumn.AllowEdit = false;
            this.colid_taikhoan.Width = 150;
            // 
            // colid_nhanvien
            // 
            this.colid_nhanvien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid_nhanvien.AppearanceCell.Options.UseFont = true;
            this.colid_nhanvien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid_nhanvien.AppearanceHeader.Options.UseFont = true;
            this.colid_nhanvien.FieldName = "id_nhanvien";
            this.colid_nhanvien.MinWidth = 40;
            this.colid_nhanvien.Name = "colid_nhanvien";
            this.colid_nhanvien.OptionsColumn.AllowEdit = false;
            this.colid_nhanvien.Width = 150;
            // 
            // colquyen
            // 
            this.colquyen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colquyen.AppearanceCell.Options.UseFont = true;
            this.colquyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colquyen.AppearanceHeader.Options.UseFont = true;
            this.colquyen.Caption = "Quyền";
            this.colquyen.FieldName = "quyen";
            this.colquyen.MinWidth = 40;
            this.colquyen.Name = "colquyen";
            this.colquyen.OptionsColumn.AllowEdit = false;
            this.colquyen.Width = 150;
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.btnEdit;
            this.colEdit.MinWidth = 40;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 6;
            this.colEdit.Width = 150;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Appearance.Image")));
            this.btnEdit.Appearance.Options.UseImage = true;
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // coleDelete
            // 
            this.coleDelete.ColumnEdit = this.btnDelete;
            this.coleDelete.MinWidth = 40;
            this.coleDelete.Name = "coleDelete";
            this.coleDelete.Visible = true;
            this.coleDelete.VisibleIndex = 5;
            this.coleDelete.Width = 178;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(68, 104);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(159, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gcUsers);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "tabStaff";
            this.Size = new System.Drawing.Size(1914, 890);
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colnhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colnhanvien2;
        private DevExpress.XtraGrid.Columns.GridColumn colnhanvien3;
        private DevExpress.XtraGrid.Columns.GridColumn colnhanvien4;
        private DevExpress.XtraGrid.Columns.GridColumn colnhanvien5;
        private DevExpress.XtraGrid.Columns.GridColumn coltentaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colid_taikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colquyen;
        private DevExpress.XtraGrid.Columns.GridColumn coleDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
    }
}