namespace COFFEE_SHOP_MANAGER.VIEW.Staff
{
    partial class EditStaffFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStaffFrm));
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCMND = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTaiKhoan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMatKhauComfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMatKhau = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(428, 104);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.txtNgaySinh.Properties.Appearance.Options.UseBackColor = true;
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(276, 40);
            this.txtNgaySinh.TabIndex = 47;
            // 
            // txtLuong
            // 
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txtLuong.HintText = "";
            this.txtLuong.isPassword = false;
            this.txtLuong.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLuong.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLuong.LineThickness = 3;
            this.txtLuong.Location = new System.Drawing.Point(428, 183);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(276, 49);
            this.txtLuong.TabIndex = 46;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiaChi.HintText = "";
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiaChi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiaChi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiaChi.LineThickness = 3;
            this.txtDiaChi.Location = new System.Drawing.Point(46, 183);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(332, 49);
            this.txtDiaChi.TabIndex = 45;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCMND
            // 
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCMND.HintForeColor = System.Drawing.Color.Empty;
            this.txtCMND.HintText = "";
            this.txtCMND.isPassword = false;
            this.txtCMND.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCMND.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCMND.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCMND.LineThickness = 3;
            this.txtCMND.Location = new System.Drawing.Point(46, 271);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(332, 49);
            this.txtCMND.TabIndex = 44;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.HintText = "";
            this.txtHoTen.isPassword = false;
            this.txtHoTen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHoTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHoTen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHoTen.LineThickness = 3;
            this.txtHoTen.Location = new System.Drawing.Point(46, 95);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(332, 49);
            this.txtHoTen.TabIndex = 43;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(34, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 420);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 25);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 239);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 25);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "CMND";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 25);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Họ và tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(428, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 25);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Ngày sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(428, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 25);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Lương";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(51, 133);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 25);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Mật khẩu";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.Enabled = false;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenTaiKhoan.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenTaiKhoan.HintText = "";
            this.txtTenTaiKhoan.isPassword = false;
            this.txtTenTaiKhoan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTenTaiKhoan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenTaiKhoan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTenTaiKhoan.LineThickness = 3;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(51, 73);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(332, 49);
            this.txtTenTaiKhoan.TabIndex = 47;
            this.txtTenTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMatKhauComfirm
            // 
            this.txtMatKhauComfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauComfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMatKhauComfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhauComfirm.HintForeColor = System.Drawing.Color.Empty;
            this.txtMatKhauComfirm.HintText = "";
            this.txtMatKhauComfirm.isPassword = true;
            this.txtMatKhauComfirm.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMatKhauComfirm.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMatKhauComfirm.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMatKhauComfirm.LineThickness = 3;
            this.txtMatKhauComfirm.Location = new System.Drawing.Point(51, 267);
            this.txtMatKhauComfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhauComfirm.Name = "txtMatKhauComfirm";
            this.txtMatKhauComfirm.Size = new System.Drawing.Size(332, 49);
            this.txtMatKhauComfirm.TabIndex = 49;
            this.txtMatKhauComfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.HintForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.HintText = "";
            this.txtMatKhau.isPassword = true;
            this.txtMatKhau.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMatKhau.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMatKhau.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMatKhau.LineThickness = 3;
            this.txtMatKhau.Location = new System.Drawing.Point(51, 165);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(332, 49);
            this.txtMatKhau.TabIndex = 48;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Checked = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(23, 40);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(140, 29);
            this.rdbNhanVien.TabIndex = 50;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.Location = new System.Drawing.Point(23, 92);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(117, 29);
            this.rdbQuanLy.TabIndex = 51;
            this.rdbQuanLy.Text = "Quản lý";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNhanVien);
            this.groupBox3.Controls.Add(this.rdbQuanLy);
            this.groupBox3.Location = new System.Drawing.Point(496, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 141);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtMatKhauComfirm);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Location = new System.Drawing.Point(34, 548);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 356);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(51, 235);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(182, 25);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Xác nhận mật khẩu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(128, 25);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Tên tài khoản";
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(578, 950);
            this.btnSave.Margin = new System.Windows.Forms.Padding(12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(221, 73);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 1052);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditStaffFrm";
            this.Text = "EditStaffFrm";
            this.Load += new System.EventHandler(this.EditStaffFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLuong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCMND;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenTaiKhoan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMatKhauComfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMatKhau;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}