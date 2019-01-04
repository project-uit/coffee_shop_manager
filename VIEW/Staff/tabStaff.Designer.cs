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
            DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabStaff));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.coleDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsers
            // 
            this.gcUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcUsers.Location = new System.Drawing.Point(2, 97);
            this.gcUsers.MainView = this.gridViewTaiKhoan;
            this.gcUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.Size = new System.Drawing.Size(1272, 471);
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
            this.gridViewTaiKhoan.DetailHeight = 224;
            this.gridViewTaiKhoan.FixedLineWidth = 1;
            this.gridViewTaiKhoan.GridControl = this.gcUsers;
            this.gridViewTaiKhoan.GroupCount = 1;
            this.gridViewTaiKhoan.Name = "gridViewTaiKhoan";
            this.gridViewTaiKhoan.OptionsView.ShowFooter = true;
            this.gridViewTaiKhoan.OptionsView.ShowGroupPanel = false;
            this.gridViewTaiKhoan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnhanvien, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colnhanvien
            // 
            this.colnhanvien.Caption = "Họ tên";
            this.colnhanvien.FieldName = "hoten";
            this.colnhanvien.MinWidth = 27;
            this.colnhanvien.Name = "colnhanvien";
            this.colnhanvien.Visible = true;
            this.colnhanvien.VisibleIndex = 0;
            this.colnhanvien.Width = 100;
            // 
            // colnhanvien2
            // 
            this.colnhanvien2.Caption = "Ngày sinh";
            this.colnhanvien2.FieldName = "ngaysinh";
            this.colnhanvien2.MinWidth = 27;
            this.colnhanvien2.Name = "colnhanvien2";
            this.colnhanvien2.Visible = true;
            this.colnhanvien2.VisibleIndex = 0;
            this.colnhanvien2.Width = 177;
            // 
            // colnhanvien3
            // 
            this.colnhanvien3.Caption = "CMND";
            this.colnhanvien3.FieldName = "cmnd";
            this.colnhanvien3.MinWidth = 27;
            this.colnhanvien3.Name = "colnhanvien3";
            this.colnhanvien3.Visible = true;
            this.colnhanvien3.VisibleIndex = 1;
            this.colnhanvien3.Width = 177;
            // 
            // colnhanvien4
            // 
            this.colnhanvien4.Caption = "Địa chỉ";
            this.colnhanvien4.FieldName = "diachi";
            this.colnhanvien4.MinWidth = 27;
            this.colnhanvien4.Name = "colnhanvien4";
            this.colnhanvien4.Visible = true;
            this.colnhanvien4.VisibleIndex = 2;
            this.colnhanvien4.Width = 177;
            // 
            // colnhanvien5
            // 
            this.colnhanvien5.Caption = "Lương";
            this.colnhanvien5.FieldName = "luong";
            this.colnhanvien5.MinWidth = 27;
            this.colnhanvien5.Name = "colnhanvien5";
            this.colnhanvien5.Visible = true;
            this.colnhanvien5.VisibleIndex = 3;
            this.colnhanvien5.Width = 177;
            // 
            // coltentaikhoan
            // 
            this.coltentaikhoan.Caption = "Tên tài khoản";
            this.coltentaikhoan.FieldName = "tentaikhoan";
            this.coltentaikhoan.MinWidth = 27;
            this.coltentaikhoan.Name = "coltentaikhoan";
            this.coltentaikhoan.Visible = true;
            this.coltentaikhoan.VisibleIndex = 4;
            this.coltentaikhoan.Width = 237;
            // 
            // colid_taikhoan
            // 
            this.colid_taikhoan.FieldName = "id_taikhoan";
            this.colid_taikhoan.MinWidth = 27;
            this.colid_taikhoan.Name = "colid_taikhoan";
            this.colid_taikhoan.Width = 100;
            // 
            // colid_nhanvien
            // 
            this.colid_nhanvien.FieldName = "id_nhanvien";
            this.colid_nhanvien.MinWidth = 27;
            this.colid_nhanvien.Name = "colid_nhanvien";
            this.colid_nhanvien.Width = 100;
            // 
            // colquyen
            // 
            this.colquyen.Caption = "Quyền";
            this.colquyen.FieldName = "quyen";
            this.colquyen.MinWidth = 27;
            this.colquyen.Name = "colquyen";
            this.colquyen.Width = 100;
            // 
            // colEdit
            // 
            repositoryItemButtonEdit3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            repositoryItemButtonEdit3.Appearance.Options.UseImage = true;
            repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            repositoryItemButtonEdit3.Name = "btnEdit";
            repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.colEdit.ColumnEdit = repositoryItemButtonEdit3;
            this.colEdit.MinWidth = 27;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 6;
            this.colEdit.Width = 100;
            // 
            // coleDelete
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            repositoryItemButtonEdit1.Name = "btnDelete";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.coleDelete.ColumnEdit = repositoryItemButtonEdit1;
            this.coleDelete.MinWidth = 27;
            this.coleDelete.Name = "coleDelete";
            this.coleDelete.Visible = true;
            this.coleDelete.VisibleIndex = 5;
            this.coleDelete.Width = 119;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Thêm mới";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(25, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(156, 47);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gcUsers);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tabStaff";
            this.Size = new System.Drawing.Size(1276, 570);
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

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
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn coleDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
    }
}
