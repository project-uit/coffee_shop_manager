namespace COFFEE_SHOP_MANAGER.VIEW.Discount
{
    partial class DiscountFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountFrm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtGiamGia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.grdCtrGiamGia = new DevExpress.XtraGrid.GridControl();
            this.grdViGiamGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colhesogiamgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaybatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayketthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_btnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.lbMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Depth = 0;
            this.txtGiamGia.Hint = "";
            this.txtGiamGia.Location = new System.Drawing.Point(12, 103);
            this.txtGiamGia.MaxLength = 5;
            this.txtGiamGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.PasswordChar = '\0';
            this.txtGiamGia.SelectedText = "";
            this.txtGiamGia.SelectionLength = 0;
            this.txtGiamGia.SelectionStart = 0;
            this.txtGiamGia.Size = new System.Drawing.Size(210, 28);
            this.txtGiamGia.TabIndex = 0;
            this.txtGiamGia.TabStop = false;
            this.txtGiamGia.UseSystemPasswordChar = false;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.EditValue = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.dateNgayBatDau.Location = new System.Drawing.Point(257, 100);
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
            this.dateNgayBatDau.Size = new System.Drawing.Size(136, 22);
            this.dateNgayBatDau.TabIndex = 2;
            this.dateNgayBatDau.ToolTip = "Ngày bắt đầu";
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.EditValue = new System.DateTime(2018, 12, 12, 0, 0, 0, 0);
            this.dateNgayKetThuc.Location = new System.Drawing.Point(426, 100);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayKetThuc.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateNgayKetThuc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayKetThuc.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayKetThuc.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayKetThuc.Size = new System.Drawing.Size(138, 22);
            this.dateNgayKetThuc.TabIndex = 3;
            this.dateNgayKetThuc.ToolTip = "Ngày kết thúc";
            // 
            // grdCtrGiamGia
            // 
            this.grdCtrGiamGia.DataSource = typeof(COFFEE_SHOP_MANAGER.giamgia);
            this.grdCtrGiamGia.Location = new System.Drawing.Point(12, 185);
            this.grdCtrGiamGia.MainView = this.grdViGiamGia;
            this.grdCtrGiamGia.Name = "grdCtrGiamGia";
            this.grdCtrGiamGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.grdCtrGiamGia.Size = new System.Drawing.Size(653, 256);
            this.grdCtrGiamGia.TabIndex = 4;
            this.grdCtrGiamGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViGiamGia});
            // 
            // grdViGiamGia
            // 
            this.grdViGiamGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colhesogiamgia,
            this.colngaybatdau,
            this.colngayketthuc,
            this.col_btnXoa});
            this.grdViGiamGia.GridControl = this.grdCtrGiamGia;
            this.grdViGiamGia.Name = "grdViGiamGia";
            this.grdViGiamGia.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViGiamGia.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViGiamGia.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.grdViGiamGia.OptionsBehavior.ReadOnly = true;
            this.grdViGiamGia.OptionsCustomization.AllowColumnMoving = false;
            this.grdViGiamGia.OptionsCustomization.AllowColumnResizing = false;
            this.grdViGiamGia.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // colhesogiamgia
            // 
            this.colhesogiamgia.Caption = "Giảm giá (%)";
            this.colhesogiamgia.FieldName = "hesogiamgia";
            this.colhesogiamgia.MinWidth = 25;
            this.colhesogiamgia.Name = "colhesogiamgia";
            this.colhesogiamgia.Visible = true;
            this.colhesogiamgia.VisibleIndex = 0;
            this.colhesogiamgia.Width = 94;
            // 
            // colngaybatdau
            // 
            this.colngaybatdau.Caption = "Ngày bắt đầu";
            this.colngaybatdau.FieldName = "ngaybatdau";
            this.colngaybatdau.MinWidth = 25;
            this.colngaybatdau.Name = "colngaybatdau";
            this.colngaybatdau.Visible = true;
            this.colngaybatdau.VisibleIndex = 1;
            this.colngaybatdau.Width = 94;
            // 
            // colngayketthuc
            // 
            this.colngayketthuc.Caption = "Ngày kết thúc";
            this.colngayketthuc.FieldName = "ngayketthuc";
            this.colngayketthuc.MinWidth = 25;
            this.colngayketthuc.Name = "colngayketthuc";
            this.colngayketthuc.Visible = true;
            this.colngayketthuc.VisibleIndex = 2;
            this.colngayketthuc.Width = 94;
            // 
            // col_btnXoa
            // 
            this.col_btnXoa.ColumnEdit = this.btnXoa;
            this.col_btnXoa.MinWidth = 25;
            this.col_btnXoa.Name = "col_btnXoa";
            this.col_btnXoa.Visible = true;
            this.col_btnXoa.VisibleIndex = 3;
            this.col_btnXoa.Width = 94;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giảm giá (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(254, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(423, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày kết thúc";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(589, 93);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(55, 36);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.flyoutPanel1.Location = new System.Drawing.Point(15, 346);
            this.flyoutPanel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.flyoutPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanel1.Size = new System.Drawing.Size(267, 95);
            this.flyoutPanel1.TabIndex = 9;
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
            // DiscountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCtrGiamGia);
            this.Controls.Add(this.dateNgayKetThuc);
            this.Controls.Add(this.dateNgayBatDau);
            this.Controls.Add(this.txtGiamGia);
            this.MaximizeBox = false;
            this.Name = "DiscountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giảm giá";
            this.Load += new System.EventHandler(this.DiscountFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiamGia;
        private DevExpress.XtraEditors.DateEdit dateNgayBatDau;
        private DevExpress.XtraEditors.DateEdit dateNgayKetThuc;
        private DevExpress.XtraGrid.GridControl grdCtrGiamGia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViGiamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colhesogiamgia;
        private DevExpress.XtraGrid.Columns.GridColumn colngaybatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colngayketthuc;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private System.Windows.Forms.Label lbMessage;
    }
}