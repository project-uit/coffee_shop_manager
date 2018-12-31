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
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorMatKhauComfirm = new DevExpress.XtraEditors.LabelControl();
            this.errorMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.errorTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.txtMatKhauComfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMatKhau = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTenTaiKhoan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.errorLuong = new DevExpress.XtraEditors.LabelControl();
            this.errorCMND = new DevExpress.XtraEditors.LabelControl();
            this.errorDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.errorHoTen = new DevExpress.XtraEditors.LabelControl();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCMND = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(1437, 662);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorMatKhauComfirm);
            this.groupBox2.Controls.Add(this.errorMatKhau);
            this.groupBox2.Controls.Add(this.errorTenTaiKhoan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtMatKhauComfirm);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Location = new System.Drawing.Point(850, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 510);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản";
            // 
            // errorMatKhauComfirm
            // 
            this.errorMatKhauComfirm.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorMatKhauComfirm.Appearance.Options.UseForeColor = true;
            this.errorMatKhauComfirm.Location = new System.Drawing.Point(51, 426);
            this.errorMatKhauComfirm.Name = "errorMatKhauComfirm";
            this.errorMatKhauComfirm.Size = new System.Drawing.Size(133, 25);
            this.errorMatKhauComfirm.TabIndex = 56;
            this.errorMatKhauComfirm.Text = "labelControl15";
            // 
            // errorMatKhau
            // 
            this.errorMatKhau.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorMatKhau.Appearance.Options.UseForeColor = true;
            this.errorMatKhau.Location = new System.Drawing.Point(51, 287);
            this.errorMatKhau.Name = "errorMatKhau";
            this.errorMatKhau.Size = new System.Drawing.Size(133, 25);
            this.errorMatKhau.TabIndex = 55;
            this.errorMatKhau.Text = "labelControl14";
            // 
            // errorTenTaiKhoan
            // 
            this.errorTenTaiKhoan.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorTenTaiKhoan.Appearance.Options.UseForeColor = true;
            this.errorTenTaiKhoan.Location = new System.Drawing.Point(51, 151);
            this.errorTenTaiKhoan.Name = "errorTenTaiKhoan";
            this.errorTenTaiKhoan.Size = new System.Drawing.Size(133, 25);
            this.errorTenTaiKhoan.TabIndex = 54;
            this.errorTenTaiKhoan.Text = "labelControl13";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNhanVien);
            this.groupBox3.Controls.Add(this.rdbQuanLy);
            this.groupBox3.Location = new System.Drawing.Point(494, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 141);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền";
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
            this.txtMatKhauComfirm.Location = new System.Drawing.Point(51, 370);
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
            this.txtMatKhau.Location = new System.Drawing.Point(51, 231);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(332, 49);
            this.txtMatKhau.TabIndex = 48;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenTaiKhoan.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenTaiKhoan.HintText = "";
            this.txtTenTaiKhoan.isPassword = false;
            this.txtTenTaiKhoan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTenTaiKhoan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenTaiKhoan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTenTaiKhoan.LineThickness = 3;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(51, 95);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(332, 49);
            this.txtTenTaiKhoan.TabIndex = 47;
            this.txtTenTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(51, 338);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 25);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Mật khẩu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(128, 25);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Tên tài khoản";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(51, 199);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 25);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorNgaySinh);
            this.groupBox1.Controls.Add(this.errorLuong);
            this.groupBox1.Controls.Add(this.errorCMND);
            this.groupBox1.Controls.Add(this.errorDiaChi);
            this.groupBox1.Controls.Add(this.errorHoTen);
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
            this.groupBox1.Location = new System.Drawing.Point(50, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 510);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // errorNgaySinh
            // 
            this.errorNgaySinh.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorNgaySinh.Appearance.Options.UseForeColor = true;
            this.errorNgaySinh.Location = new System.Drawing.Point(428, 150);
            this.errorNgaySinh.Name = "errorNgaySinh";
            this.errorNgaySinh.Size = new System.Drawing.Size(133, 25);
            this.errorNgaySinh.TabIndex = 57;
            this.errorNgaySinh.Text = "labelControl15";
            // 
            // errorLuong
            // 
            this.errorLuong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorLuong.Appearance.Options.UseForeColor = true;
            this.errorLuong.Location = new System.Drawing.Point(428, 287);
            this.errorLuong.Name = "errorLuong";
            this.errorLuong.Size = new System.Drawing.Size(133, 25);
            this.errorLuong.TabIndex = 51;
            this.errorLuong.Text = "labelControl12";
            // 
            // errorCMND
            // 
            this.errorCMND.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorCMND.Appearance.Options.UseForeColor = true;
            this.errorCMND.Location = new System.Drawing.Point(46, 426);
            this.errorCMND.Name = "errorCMND";
            this.errorCMND.Size = new System.Drawing.Size(133, 25);
            this.errorCMND.TabIndex = 50;
            this.errorCMND.Text = "labelControl11";
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorDiaChi.Appearance.Options.UseForeColor = true;
            this.errorDiaChi.Location = new System.Drawing.Point(46, 287);
            this.errorDiaChi.Name = "errorDiaChi";
            this.errorDiaChi.Size = new System.Drawing.Size(133, 25);
            this.errorDiaChi.TabIndex = 49;
            this.errorDiaChi.Text = "labelControl10";
            // 
            // errorHoTen
            // 
            this.errorHoTen.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorHoTen.Appearance.Options.UseForeColor = true;
            this.errorHoTen.Location = new System.Drawing.Point(46, 151);
            this.errorHoTen.Name = "errorHoTen";
            this.errorHoTen.Size = new System.Drawing.Size(122, 25);
            this.errorHoTen.TabIndex = 48;
            this.errorHoTen.Text = "labelControl8";
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
            this.txtLuong.Location = new System.Drawing.Point(428, 231);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(276, 49);
            this.txtLuong.TabIndex = 46;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtDiaChi.Location = new System.Drawing.Point(46, 231);
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
            this.txtCMND.Location = new System.Drawing.Point(46, 370);
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
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 199);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 25);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 338);
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
            this.labelControl2.Location = new System.Drawing.Point(428, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 25);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Lương";
            // 
            // EditStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 774);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "EditStaffFrm";
            this.Text = "EditStaffFrm";
            this.Load += new System.EventHandler(this.EditStaffFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl errorMatKhauComfirm;
        private DevExpress.XtraEditors.LabelControl errorMatKhau;
        private DevExpress.XtraEditors.LabelControl errorTenTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMatKhauComfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMatKhau;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl errorNgaySinh;
        private DevExpress.XtraEditors.LabelControl errorLuong;
        private DevExpress.XtraEditors.LabelControl errorCMND;
        private DevExpress.XtraEditors.LabelControl errorDiaChi;
        private DevExpress.XtraEditors.LabelControl errorHoTen;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLuong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCMND;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}