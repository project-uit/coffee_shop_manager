namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    partial class FormulaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaFrm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtDinhLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.grdCtrCongThuc = new DevExpress.XtraGrid.GridControl();
            this.grdViCongThuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkhonguyenlieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldinhluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkhonguyenlieu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrorDinhLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.Depth = 0;
            this.txtDinhLuong.Hint = "Nhập định lượng";
            this.txtDinhLuong.Location = new System.Drawing.Point(9, 92);
            this.txtDinhLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtDinhLuong.MaxLength = 32767;
            this.txtDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.PasswordChar = '\0';
            this.txtDinhLuong.SelectedText = "";
            this.txtDinhLuong.SelectionLength = 0;
            this.txtDinhLuong.SelectionStart = 0;
            this.txtDinhLuong.Size = new System.Drawing.Size(227, 23);
            this.txtDinhLuong.TabIndex = 0;
            this.txtDinhLuong.TabStop = false;
            this.txtDinhLuong.UseSystemPasswordChar = false;
            this.txtDinhLuong.Click += new System.EventHandler(this.txtDinhLuong_Click);
            this.txtDinhLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhLuong_KeyPress);
            // 
            // cbbNguyenLieu
            // 
            this.cbbNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNguyenLieu.FormattingEnabled = true;
            this.cbbNguyenLieu.Location = new System.Drawing.Point(272, 92);
            this.cbbNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNguyenLieu.Name = "cbbNguyenLieu";
            this.cbbNguyenLieu.Size = new System.Drawing.Size(168, 21);
            this.cbbNguyenLieu.TabIndex = 1;
            // 
            // grdCtrCongThuc
            // 
            this.grdCtrCongThuc.DataSource = typeof(COFFEE_SHOP_MANAGER.chitietcongthuc);
            this.grdCtrCongThuc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrCongThuc.Location = new System.Drawing.Point(0, 157);
            this.grdCtrCongThuc.MainView = this.grdViCongThuc;
            this.grdCtrCongThuc.Margin = new System.Windows.Forms.Padding(2);
            this.grdCtrCongThuc.Name = "grdCtrCongThuc";
            this.grdCtrCongThuc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.grdCtrCongThuc.Size = new System.Drawing.Size(532, 216);
            this.grdCtrCongThuc.TabIndex = 2;
            this.grdCtrCongThuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViCongThuc});
            // 
            // grdViCongThuc
            // 
            this.grdViCongThuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkhonguyenlieu,
            this.coldinhluong,
            this.colkhonguyenlieu1,
            this.gridColumn1});
            this.grdViCongThuc.DetailHeight = 284;
            this.grdViCongThuc.GridControl = this.grdCtrCongThuc;
            this.grdViCongThuc.Name = "grdViCongThuc";
            this.grdViCongThuc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViCongThuc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViCongThuc.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.grdViCongThuc.OptionsBehavior.ReadOnly = true;
            this.grdViCongThuc.OptionsView.ShowGroupPanel = false;
            // 
            // colkhonguyenlieu
            // 
            this.colkhonguyenlieu.Caption = "Tên nguyên liệu";
            this.colkhonguyenlieu.FieldName = "khonguyenlieu.tennguyenlieu";
            this.colkhonguyenlieu.MinWidth = 19;
            this.colkhonguyenlieu.Name = "colkhonguyenlieu";
            this.colkhonguyenlieu.Visible = true;
            this.colkhonguyenlieu.VisibleIndex = 0;
            this.colkhonguyenlieu.Width = 124;
            // 
            // coldinhluong
            // 
            this.coldinhluong.Caption = "Định lượng";
            this.coldinhluong.FieldName = "dinhluong";
            this.coldinhluong.MinWidth = 19;
            this.coldinhluong.Name = "coldinhluong";
            this.coldinhluong.Visible = true;
            this.coldinhluong.VisibleIndex = 1;
            this.coldinhluong.Width = 124;
            // 
            // colkhonguyenlieu1
            // 
            this.colkhonguyenlieu1.Caption = "Đơn vị";
            this.colkhonguyenlieu1.FieldName = "khonguyenlieu.tendonvi_dinh_luong";
            this.colkhonguyenlieu1.MinWidth = 19;
            this.colkhonguyenlieu1.Name = "colkhonguyenlieu1";
            this.colkhonguyenlieu1.Visible = true;
            this.colkhonguyenlieu1.VisibleIndex = 2;
            this.colkhonguyenlieu1.Width = 220;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.btnXoa;
            this.gridColumn1.MinWidth = 19;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 30;
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
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(475, 86);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(47, 36);
            this.btnLuu.TabIndex = 3;
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
            this.flyoutPanel1.Location = new System.Drawing.Point(16, 272);
            this.flyoutPanel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.flyoutPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.flyoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelHeight = 24;
            this.flyoutPanel1.OwnerControl = this.grdCtrCongThuc;
            this.flyoutPanel1.Size = new System.Drawing.Size(200, 77);
            this.flyoutPanel1.TabIndex = 9;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(34, 29);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(133, 20);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Lưu thành công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Định lượng";
            // 
            // lbErrorDinhLuong
            // 
            this.lbErrorDinhLuong.AutoSize = true;
            this.lbErrorDinhLuong.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorDinhLuong.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDinhLuong.Location = new System.Drawing.Point(6, 117);
            this.lbErrorDinhLuong.Name = "lbErrorDinhLuong";
            this.lbErrorDinhLuong.Size = new System.Drawing.Size(35, 13);
            this.lbErrorDinhLuong.TabIndex = 13;
            this.lbErrorDinhLuong.Text = "label4";
            this.lbErrorDinhLuong.Visible = false;
            // 
            // FormulaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 374);
            this.Controls.Add(this.lbErrorDinhLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grdCtrCongThuc);
            this.Controls.Add(this.cbbNguyenLieu);
            this.Controls.Add(this.txtDinhLuong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormulaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập công thức";
            this.Load += new System.EventHandler(this.FormulaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            this.flyoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuong;
        private System.Windows.Forms.ComboBox cbbNguyenLieu;
        private DevExpress.XtraGrid.GridControl grdCtrCongThuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViCongThuc;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn colkhonguyenlieu;
        private DevExpress.XtraGrid.Columns.GridColumn coldinhluong;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private System.Windows.Forms.Label lbMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colkhonguyenlieu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private System.Windows.Forms.Label lbErrorDinhLuong;
    }
}