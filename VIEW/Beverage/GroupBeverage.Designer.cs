namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    partial class GroupBeverage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupBeverage));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdCtrNhomThucUong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_nhomthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhomthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_btnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_btnSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnLuu = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtTenThucUong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrNhomThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrNhomThucUong
            // 
            this.grdCtrNhomThucUong.DataSource = typeof(COFFEE_SHOP_MANAGER.nhomthucuong);
            this.grdCtrNhomThucUong.Location = new System.Drawing.Point(2, 115);
            this.grdCtrNhomThucUong.LookAndFeel.SkinName = "Office 2016 Black";
            this.grdCtrNhomThucUong.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.grdCtrNhomThucUong.MainView = this.gridView1;
            this.grdCtrNhomThucUong.Name = "grdCtrNhomThucUong";
            this.grdCtrNhomThucUong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa,
            this.btnSua});
            this.grdCtrNhomThucUong.Size = new System.Drawing.Size(482, 268);
            this.grdCtrNhomThucUong.TabIndex = 0;
            this.grdCtrNhomThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_nhomthucuong,
            this.coltennhomthucuong,
            this.col_btnXoa,
            this.col_btnSua});
            this.gridView1.GridControl = this.grdCtrNhomThucUong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // colid_nhomthucuong
            // 
            this.colid_nhomthucuong.Caption = "ID";
            this.colid_nhomthucuong.FieldName = "id_nhomthucuong";
            this.colid_nhomthucuong.Name = "colid_nhomthucuong";
            this.colid_nhomthucuong.Visible = true;
            this.colid_nhomthucuong.VisibleIndex = 0;
            this.colid_nhomthucuong.Width = 116;
            // 
            // coltennhomthucuong
            // 
            this.coltennhomthucuong.Caption = "Tên nhóm thức uống";
            this.coltennhomthucuong.FieldName = "tennhomthucuong";
            this.coltennhomthucuong.Name = "coltennhomthucuong";
            this.coltennhomthucuong.Visible = true;
            this.coltennhomthucuong.VisibleIndex = 1;
            this.coltennhomthucuong.Width = 287;
            // 
            // col_btnXoa
            // 
            this.col_btnXoa.ColumnEdit = this.btnXoa;
            this.col_btnXoa.Name = "col_btnXoa";
            this.col_btnXoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.col_btnXoa.Visible = true;
            this.col_btnXoa.VisibleIndex = 2;
            this.col_btnXoa.Width = 29;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // col_btnSua
            // 
            this.col_btnSua.ColumnEdit = this.btnSua;
            this.col_btnSua.Name = "col_btnSua";
            this.col_btnSua.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.col_btnSua.Visible = true;
            this.col_btnSua.VisibleIndex = 3;
            this.col_btnSua.Width = 32;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(426, 70);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = false;
            this.btnLuu.Size = new System.Drawing.Size(47, 36);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Depth = 0;
            this.txtTenThucUong.Hint = "";
            this.txtTenThucUong.Location = new System.Drawing.Point(12, 70);
            this.txtTenThucUong.MaxLength = 32767;
            this.txtTenThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.PasswordChar = '\0';
            this.txtTenThucUong.SelectedText = "";
            this.txtTenThucUong.SelectionLength = 0;
            this.txtTenThucUong.SelectionStart = 0;
            this.txtTenThucUong.Size = new System.Drawing.Size(242, 23);
            this.txtTenThucUong.TabIndex = 2;
            this.txtTenThucUong.TabStop = false;
            this.txtTenThucUong.UseSystemPasswordChar = false;
            // 
            // GroupBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grdCtrNhomThucUong);
            this.Name = "GroupBeverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhóm thức uống";
            this.Load += new System.EventHandler(this.GroupBeverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrNhomThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrNhomThucUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nhomthucuong;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhomthucuong;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenThucUong;
    }
}