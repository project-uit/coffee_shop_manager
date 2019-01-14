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
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatKhauComfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenTaiKhoan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorMatKhauComfirm = new DevExpress.XtraEditors.LabelControl();
            this.errorMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.errorTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCMND = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorLuong = new DevExpress.XtraEditors.LabelControl();
            this.errorCMND = new DevExpress.XtraEditors.LabelControl();
            this.errorDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.errorHoTen = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(818, 382);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(47, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMatKhauComfirm);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox2.Controls.Add(this.errorMatKhauComfirm);
            this.groupBox2.Controls.Add(this.errorMatKhau);
            this.groupBox2.Controls.Add(this.errorTenTaiKhoan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(461, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(404, 265);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Xác nhận mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Tên tài khoản";
            // 
            // txtMatKhauComfirm
            // 
            this.txtMatKhauComfirm.Depth = 0;
            this.txtMatKhauComfirm.Hint = "";
            this.txtMatKhauComfirm.Location = new System.Drawing.Point(26, 195);
            this.txtMatKhauComfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauComfirm.MaxLength = 32767;
            this.txtMatKhauComfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhauComfirm.Name = "txtMatKhauComfirm";
            this.txtMatKhauComfirm.PasswordChar = '*';
            this.txtMatKhauComfirm.SelectedText = "";
            this.txtMatKhauComfirm.SelectionLength = 0;
            this.txtMatKhauComfirm.SelectionStart = 0;
            this.txtMatKhauComfirm.Size = new System.Drawing.Size(166, 23);
            this.txtMatKhauComfirm.TabIndex = 6;
            this.txtMatKhauComfirm.TabStop = false;
            this.txtMatKhauComfirm.UseSystemPasswordChar = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Depth = 0;
            this.txtMatKhau.Hint = "";
            this.txtMatKhau.Location = new System.Drawing.Point(26, 123);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.Size = new System.Drawing.Size(166, 23);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.TabStop = false;
            this.txtMatKhau.UseSystemPasswordChar = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Depth = 0;
            this.txtTenTaiKhoan.Enabled = false;
            this.txtTenTaiKhoan.Hint = "";
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(26, 52);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTaiKhoan.MaxLength = 32767;
            this.txtTenTaiKhoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.SelectionLength = 0;
            this.txtTenTaiKhoan.SelectionStart = 0;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(166, 23);
            this.txtTenTaiKhoan.TabIndex = 4;
            this.txtTenTaiKhoan.TabStop = false;
            this.txtTenTaiKhoan.UseSystemPasswordChar = false;
            // 
            // errorMatKhauComfirm
            // 
            this.errorMatKhauComfirm.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorMatKhauComfirm.Appearance.Options.UseForeColor = true;
            this.errorMatKhauComfirm.Location = new System.Drawing.Point(26, 222);
            this.errorMatKhauComfirm.Margin = new System.Windows.Forms.Padding(2);
            this.errorMatKhauComfirm.Name = "errorMatKhauComfirm";
            this.errorMatKhauComfirm.Size = new System.Drawing.Size(69, 13);
            this.errorMatKhauComfirm.TabIndex = 56;
            this.errorMatKhauComfirm.Text = "labelControl15";
            // 
            // errorMatKhau
            // 
            this.errorMatKhau.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorMatKhau.Appearance.Options.UseForeColor = true;
            this.errorMatKhau.Location = new System.Drawing.Point(26, 150);
            this.errorMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.errorMatKhau.Name = "errorMatKhau";
            this.errorMatKhau.Size = new System.Drawing.Size(69, 13);
            this.errorMatKhau.TabIndex = 55;
            this.errorMatKhau.Text = "labelControl14";
            // 
            // errorTenTaiKhoan
            // 
            this.errorTenTaiKhoan.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorTenTaiKhoan.Appearance.Options.UseForeColor = true;
            this.errorTenTaiKhoan.Location = new System.Drawing.Point(26, 79);
            this.errorTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.errorTenTaiKhoan.Name = "errorTenTaiKhoan";
            this.errorTenTaiKhoan.Size = new System.Drawing.Size(69, 13);
            this.errorTenTaiKhoan.TabIndex = 54;
            this.errorTenTaiKhoan.Text = "labelControl13";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNhanVien);
            this.groupBox3.Controls.Add(this.rdbQuanLy);
            this.groupBox3.Location = new System.Drawing.Point(247, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(114, 73);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền";
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Checked = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(11, 21);
            this.rdbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(89, 19);
            this.rdbNhanVien.TabIndex = 50;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.Location = new System.Drawing.Point(11, 48);
            this.rdbQuanLy.Margin = new System.Windows.Forms.Padding(2);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(73, 19);
            this.rdbQuanLy.TabIndex = 51;
            this.rdbQuanLy.Text = "Quản lý";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.errorNgaySinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.errorLuong);
            this.groupBox1.Controls.Add(this.errorCMND);
            this.groupBox1.Controls.Add(this.errorDiaChi);
            this.groupBox1.Controls.Add(this.errorHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(404, 265);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.EditValue = new System.DateTime(2019, 1, 14, 20, 53, 24, 0);
            this.txtNgaySinh.Location = new System.Drawing.Point(213, 54);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgaySinh.Size = new System.Drawing.Size(164, 20);
            this.txtNgaySinh.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Depth = 0;
            this.txtHoTen.Hint = "";
            this.txtHoTen.Location = new System.Drawing.Point(23, 52);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.Size = new System.Drawing.Size(166, 23);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.TabStop = false;
            this.txtHoTen.UseSystemPasswordChar = false;
            // 
            // txtCMND
            // 
            this.txtCMND.Depth = 0;
            this.txtCMND.Hint = "";
            this.txtCMND.Location = new System.Drawing.Point(23, 193);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.MaxLength = 32767;
            this.txtCMND.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.SelectedText = "";
            this.txtCMND.SelectionLength = 0;
            this.txtCMND.SelectionStart = 0;
            this.txtCMND.Size = new System.Drawing.Size(166, 23);
            this.txtCMND.TabIndex = 3;
            this.txtCMND.TabStop = false;
            this.txtCMND.UseSystemPasswordChar = false;
            // 
            // txtLuong
            // 
            this.txtLuong.Depth = 0;
            this.txtLuong.Hint = "";
            this.txtLuong.Location = new System.Drawing.Point(213, 123);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuong.MaxLength = 32767;
            this.txtLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.SelectedText = "";
            this.txtLuong.SelectionLength = 0;
            this.txtLuong.SelectionStart = 0;
            this.txtLuong.Size = new System.Drawing.Size(166, 23);
            this.txtLuong.TabIndex = 2;
            this.txtLuong.TabStop = false;
            this.txtLuong.UseSystemPasswordChar = false;
            // 
            // errorNgaySinh
            // 
            this.errorNgaySinh.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorNgaySinh.Appearance.Options.UseForeColor = true;
            this.errorNgaySinh.Location = new System.Drawing.Point(214, 78);
            this.errorNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.errorNgaySinh.Name = "errorNgaySinh";
            this.errorNgaySinh.Size = new System.Drawing.Size(69, 13);
            this.errorNgaySinh.TabIndex = 57;
            this.errorNgaySinh.Text = "labelControl15";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Hint = "";
            this.txtDiaChi.Location = new System.Drawing.Point(23, 123);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(166, 23);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TabStop = false;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // errorLuong
            // 
            this.errorLuong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorLuong.Appearance.Options.UseForeColor = true;
            this.errorLuong.Location = new System.Drawing.Point(214, 150);
            this.errorLuong.Margin = new System.Windows.Forms.Padding(2);
            this.errorLuong.Name = "errorLuong";
            this.errorLuong.Size = new System.Drawing.Size(69, 13);
            this.errorLuong.TabIndex = 51;
            this.errorLuong.Text = "labelControl12";
            // 
            // errorCMND
            // 
            this.errorCMND.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorCMND.Appearance.Options.UseForeColor = true;
            this.errorCMND.Location = new System.Drawing.Point(23, 222);
            this.errorCMND.Margin = new System.Windows.Forms.Padding(2);
            this.errorCMND.Name = "errorCMND";
            this.errorCMND.Size = new System.Drawing.Size(69, 13);
            this.errorCMND.TabIndex = 50;
            this.errorCMND.Text = "labelControl11";
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorDiaChi.Appearance.Options.UseForeColor = true;
            this.errorDiaChi.Location = new System.Drawing.Point(23, 150);
            this.errorDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.errorDiaChi.Name = "errorDiaChi";
            this.errorDiaChi.Size = new System.Drawing.Size(69, 13);
            this.errorDiaChi.TabIndex = 49;
            this.errorDiaChi.Text = "labelControl10";
            // 
            // errorHoTen
            // 
            this.errorHoTen.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorHoTen.Appearance.Options.UseForeColor = true;
            this.errorHoTen.Location = new System.Drawing.Point(23, 79);
            this.errorHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.errorHoTen.Name = "errorHoTen";
            this.errorHoTen.Size = new System.Drawing.Size(63, 13);
            this.errorHoTen.TabIndex = 48;
            this.errorHoTen.Text = "labelControl8";
            // 
            // EditStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 449);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStaffFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa nhân viên";
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
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhauComfirm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhau;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl errorMatKhauComfirm;
        private DevExpress.XtraEditors.LabelControl errorMatKhau;
        private DevExpress.XtraEditors.LabelControl errorTenTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHoTen;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCMND;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLuong;
        private DevExpress.XtraEditors.LabelControl errorNgaySinh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiaChi;
        private DevExpress.XtraEditors.LabelControl errorLuong;
        private DevExpress.XtraEditors.LabelControl errorCMND;
        private DevExpress.XtraEditors.LabelControl errorDiaChi;
        private DevExpress.XtraEditors.LabelControl errorHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
    }
}