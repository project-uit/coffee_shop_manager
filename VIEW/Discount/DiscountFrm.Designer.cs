﻿namespace COFFEE_SHOP_MANAGER.VIEW.Discount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbErrorGiamGia = new System.Windows.Forms.Label();
            this.lbErrorDate = new System.Windows.Forms.Label();
            this.lbErrorNgayKetThuc = new System.Windows.Forms.Label();
            this.btnLuu = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Depth = 0;
            this.txtGiamGia.Hint = "";
            this.txtGiamGia.Location = new System.Drawing.Point(17, 128);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamGia.MaxLength = 5;
            this.txtGiamGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.PasswordChar = '\0';
            this.txtGiamGia.SelectedText = "";
            this.txtGiamGia.SelectionLength = 0;
            this.txtGiamGia.SelectionStart = 0;
            this.txtGiamGia.Size = new System.Drawing.Size(211, 28);
            this.txtGiamGia.TabIndex = 0;
            this.txtGiamGia.TabStop = false;
            this.txtGiamGia.UseSystemPasswordChar = false;
            this.txtGiamGia.Click += new System.EventHandler(this.txtGiamGia_Click);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.EditValue = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.dateNgayBatDau.Location = new System.Drawing.Point(332, 128);
            this.dateNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBatDau.Properties.Appearance.Options.UseFont = true;
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
            this.dateNgayBatDau.Size = new System.Drawing.Size(136, 24);
            this.dateNgayBatDau.TabIndex = 2;
            this.dateNgayBatDau.ToolTip = "Ngày bắt đầu";
            this.dateNgayBatDau.EditValueChanged += new System.EventHandler(this.dateNgayBatDau_EditValueChanged);
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.EditValue = new System.DateTime(2018, 12, 12, 0, 0, 0, 0);
            this.dateNgayKetThuc.Location = new System.Drawing.Point(603, 128);
            this.dateNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKetThuc.Properties.Appearance.Options.UseFont = true;
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
            this.dateNgayKetThuc.Size = new System.Drawing.Size(139, 24);
            this.dateNgayKetThuc.TabIndex = 3;
            this.dateNgayKetThuc.ToolTip = "Ngày kết thúc";
            this.dateNgayKetThuc.EditValueChanged += new System.EventHandler(this.dateNgayKetThuc_EditValueChanged);
            // 
            // grdCtrGiamGia
            // 
            this.grdCtrGiamGia.DataSource = typeof(COFFEE_SHOP_MANAGER.giamgia);
            this.grdCtrGiamGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCtrGiamGia.Location = new System.Drawing.Point(3, 234);
            this.grdCtrGiamGia.MainView = this.grdViGiamGia;
            this.grdCtrGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCtrGiamGia.Name = "grdCtrGiamGia";
            this.grdCtrGiamGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.grdCtrGiamGia.Size = new System.Drawing.Size(920, 256);
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
            this.grdViGiamGia.OptionsView.ShowGroupPanel = false;
            // 
            // colhesogiamgia
            // 
            this.colhesogiamgia.Caption = "Giảm giá (%)";
            this.colhesogiamgia.FieldName = "hesogiamgia";
            this.colhesogiamgia.MinWidth = 25;
            this.colhesogiamgia.Name = "colhesogiamgia";
            this.colhesogiamgia.Visible = true;
            this.colhesogiamgia.VisibleIndex = 0;
            this.colhesogiamgia.Width = 93;
            // 
            // colngaybatdau
            // 
            this.colngaybatdau.Caption = "Ngày bắt đầu";
            this.colngaybatdau.FieldName = "ngaybatdau";
            this.colngaybatdau.MinWidth = 25;
            this.colngaybatdau.Name = "colngaybatdau";
            this.colngaybatdau.Visible = true;
            this.colngaybatdau.VisibleIndex = 1;
            this.colngaybatdau.Width = 93;
            // 
            // colngayketthuc
            // 
            this.colngayketthuc.Caption = "Ngày kết thúc";
            this.colngayketthuc.FieldName = "ngayketthuc";
            this.colngayketthuc.MinWidth = 25;
            this.colngayketthuc.Name = "colngayketthuc";
            this.colngayketthuc.Visible = true;
            this.colngayketthuc.VisibleIndex = 2;
            this.colngayketthuc.Width = 93;
            // 
            // col_btnXoa
            // 
            this.col_btnXoa.ColumnEdit = this.btnXoa;
            this.col_btnXoa.MinWidth = 25;
            this.col_btnXoa.Name = "col_btnXoa";
            this.col_btnXoa.Visible = true;
            this.col_btnXoa.VisibleIndex = 3;
            this.col_btnXoa.Width = 93;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giảm giá (%)";
            // 
            // lbErrorGiamGia
            // 
            this.lbErrorGiamGia.AutoSize = true;
            this.lbErrorGiamGia.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorGiamGia.ForeColor = System.Drawing.Color.Red;
            this.lbErrorGiamGia.Location = new System.Drawing.Point(16, 159);
            this.lbErrorGiamGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorGiamGia.Name = "lbErrorGiamGia";
            this.lbErrorGiamGia.Size = new System.Drawing.Size(46, 17);
            this.lbErrorGiamGia.TabIndex = 10;
            this.lbErrorGiamGia.Text = "label4";
            this.lbErrorGiamGia.Visible = false;
            // 
            // lbErrorDate
            // 
            this.lbErrorDate.AutoSize = true;
            this.lbErrorDate.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDate.Location = new System.Drawing.Point(328, 158);
            this.lbErrorDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorDate.Name = "lbErrorDate";
            this.lbErrorDate.Size = new System.Drawing.Size(46, 17);
            this.lbErrorDate.TabIndex = 11;
            this.lbErrorDate.Text = "label4";
            this.lbErrorDate.Visible = false;
            // 
            // lbErrorNgayKetThuc
            // 
            this.lbErrorNgayKetThuc.AutoSize = true;
            this.lbErrorNgayKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorNgayKetThuc.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNgayKetThuc.Location = new System.Drawing.Point(599, 158);
            this.lbErrorNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorNgayKetThuc.Name = "lbErrorNgayKetThuc";
            this.lbErrorNgayKetThuc.Size = new System.Drawing.Size(46, 17);
            this.lbErrorNgayKetThuc.TabIndex = 12;
            this.lbErrorNgayKetThuc.Text = "label4";
            this.lbErrorNgayKetThuc.Visible = false;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(859, 116);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = false;
            this.btnLuu.Size = new System.Drawing.Size(55, 36);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // DiscountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 497);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbErrorNgayKetThuc);
            this.Controls.Add(this.lbErrorDate);
            this.Controls.Add(this.lbErrorGiamGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdCtrGiamGia);
            this.Controls.Add(this.dateNgayKetThuc);
            this.Controls.Add(this.dateNgayBatDau);
            this.Controls.Add(this.txtGiamGia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiamGia;
        private DevExpress.XtraEditors.DateEdit dateNgayBatDau;
        private DevExpress.XtraEditors.DateEdit dateNgayKetThuc;
        private DevExpress.XtraGrid.GridControl grdCtrGiamGia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colhesogiamgia;
        private DevExpress.XtraGrid.Columns.GridColumn colngaybatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colngayketthuc;
        private DevExpress.XtraGrid.Columns.GridColumn col_btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbErrorGiamGia;
        private System.Windows.Forms.Label lbErrorDate;
        private System.Windows.Forms.Label lbErrorNgayKetThuc;
        private MaterialSkin.Controls.MaterialFlatButton btnLuu;
    }
}