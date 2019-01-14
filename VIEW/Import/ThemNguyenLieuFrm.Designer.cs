namespace COFFEE_SHOP_MANAGER.VIEW.Import
{
    partial class ThemNguyenLieuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNguyenLieuFrm));
            this.cbTenDonViDinhLuong = new System.Windows.Forms.ComboBox();
            this.btnLuu = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtLoiTenNguyenLieu = new MaterialSkin.Controls.MaterialLabel();
            this.txtLoiDinhLuong = new MaterialSkin.Controls.MaterialLabel();
            this.labelTenNguyenLieu = new System.Windows.Forms.Label();
            this.labelDinhLuong = new System.Windows.Forms.Label();
            this.labelTenDonViDinhLuong = new System.Windows.Forms.Label();
            this.btnHuy = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDinhLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenNguyenLieu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDinhLuongMin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDinhLuongMax = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTenDonViDinhLuong
            // 
            this.cbTenDonViDinhLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenDonViDinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenDonViDinhLuong.FormattingEnabled = true;
            this.cbTenDonViDinhLuong.ItemHeight = 17;
            this.cbTenDonViDinhLuong.Items.AddRange(new object[] {
            "gam",
            "mililit",
            "lit",
            "kilogam"});
            this.cbTenDonViDinhLuong.Location = new System.Drawing.Point(276, 106);
            this.cbTenDonViDinhLuong.Margin = new System.Windows.Forms.Padding(2);
            this.cbTenDonViDinhLuong.Name = "cbTenDonViDinhLuong";
            this.cbTenDonViDinhLuong.Size = new System.Drawing.Size(168, 25);
            this.cbTenDonViDinhLuong.TabIndex = 6;
            this.cbTenDonViDinhLuong.SelectedIndexChanged += new System.EventHandler(this.cbTenDonViDinhLuong_SelectedIndexChanged);
            this.cbTenDonViDinhLuong.Click += new System.EventHandler(this.cbTenDonViDinhLuong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(34, 262);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = false;
            this.btnLuu.Size = new System.Drawing.Size(47, 36);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtLoiTenNguyenLieu
            // 
            this.txtLoiTenNguyenLieu.AutoSize = true;
            this.txtLoiTenNguyenLieu.BackColor = System.Drawing.Color.White;
            this.txtLoiTenNguyenLieu.Depth = 0;
            this.txtLoiTenNguyenLieu.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtLoiTenNguyenLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLoiTenNguyenLieu.Location = new System.Drawing.Point(27, 128);
            this.txtLoiTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLoiTenNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoiTenNguyenLieu.Name = "txtLoiTenNguyenLieu";
            this.txtLoiTenNguyenLieu.Size = new System.Drawing.Size(0, 19);
            this.txtLoiTenNguyenLieu.TabIndex = 9;
            // 
            // txtLoiDinhLuong
            // 
            this.txtLoiDinhLuong.AutoSize = true;
            this.txtLoiDinhLuong.BackColor = System.Drawing.Color.White;
            this.txtLoiDinhLuong.Depth = 0;
            this.txtLoiDinhLuong.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtLoiDinhLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLoiDinhLuong.Location = new System.Drawing.Point(27, 210);
            this.txtLoiDinhLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLoiDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoiDinhLuong.Name = "txtLoiDinhLuong";
            this.txtLoiDinhLuong.Size = new System.Drawing.Size(0, 19);
            this.txtLoiDinhLuong.TabIndex = 10;
            // 
            // labelTenNguyenLieu
            // 
            this.labelTenNguyenLieu.AutoSize = true;
            this.labelTenNguyenLieu.BackColor = System.Drawing.Color.White;
            this.labelTenNguyenLieu.ForeColor = System.Drawing.Color.Red;
            this.labelTenNguyenLieu.Location = new System.Drawing.Point(31, 131);
            this.labelTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenNguyenLieu.Name = "labelTenNguyenLieu";
            this.labelTenNguyenLieu.Size = new System.Drawing.Size(191, 13);
            this.labelTenNguyenLieu.TabIndex = 11;
            this.labelTenNguyenLieu.Text = "*Tên nguyên liệu không được để trống";
            // 
            // labelDinhLuong
            // 
            this.labelDinhLuong.AutoSize = true;
            this.labelDinhLuong.BackColor = System.Drawing.Color.White;
            this.labelDinhLuong.ForeColor = System.Drawing.Color.Red;
            this.labelDinhLuong.Location = new System.Drawing.Point(27, 210);
            this.labelDinhLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDinhLuong.Name = "labelDinhLuong";
            this.labelDinhLuong.Size = new System.Drawing.Size(166, 13);
            this.labelDinhLuong.TabIndex = 12;
            this.labelDinhLuong.Text = "*Định lượng không được để trống";
            // 
            // labelTenDonViDinhLuong
            // 
            this.labelTenDonViDinhLuong.AutoSize = true;
            this.labelTenDonViDinhLuong.BackColor = System.Drawing.Color.White;
            this.labelTenDonViDinhLuong.ForeColor = System.Drawing.Color.Red;
            this.labelTenDonViDinhLuong.Location = new System.Drawing.Point(273, 133);
            this.labelTenDonViDinhLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenDonViDinhLuong.Name = "labelTenDonViDinhLuong";
            this.labelTenDonViDinhLuong.Size = new System.Drawing.Size(167, 13);
            this.labelTenDonViDinhLuong.TabIndex = 13;
            this.labelTenDonViDinhLuong.Text = "*Chưa chọn tên đơn vị định lượng";
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(176, 262);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = false;
            this.btnHuy.Size = new System.Drawing.Size(48, 36);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.Depth = 0;
            this.txtDinhLuong.Hint = "";
            this.txtDinhLuong.Location = new System.Drawing.Point(30, 185);
            this.txtDinhLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtDinhLuong.MaxLength = 32767;
            this.txtDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.PasswordChar = '\0';
            this.txtDinhLuong.SelectedText = "";
            this.txtDinhLuong.SelectionLength = 0;
            this.txtDinhLuong.SelectionStart = 0;
            this.txtDinhLuong.Size = new System.Drawing.Size(194, 23);
            this.txtDinhLuong.TabIndex = 15;
            this.txtDinhLuong.TabStop = false;
            this.txtDinhLuong.UseSystemPasswordChar = false;
            this.txtDinhLuong.Click += new System.EventHandler(this.txtDinhLuong_Click);
            this.txtDinhLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhLuong_KeyPress);
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Depth = 0;
            this.txtTenNguyenLieu.Hint = "";
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(30, 106);
            this.txtTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNguyenLieu.MaxLength = 32767;
            this.txtTenNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.PasswordChar = '\0';
            this.txtTenNguyenLieu.SelectedText = "";
            this.txtTenNguyenLieu.SelectionLength = 0;
            this.txtTenNguyenLieu.SelectionStart = 0;
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(194, 23);
            this.txtTenNguyenLieu.TabIndex = 16;
            this.txtTenNguyenLieu.TabStop = false;
            this.txtTenNguyenLieu.UseSystemPasswordChar = false;
            this.txtTenNguyenLieu.Click += new System.EventHandler(this.txtTenNguyenLieu_Click);
            // 
            // txtDinhLuongMin
            // 
            this.txtDinhLuongMin.Depth = 0;
            this.txtDinhLuongMin.Hint = "";
            this.txtDinhLuongMin.Location = new System.Drawing.Point(276, 185);
            this.txtDinhLuongMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtDinhLuongMin.MaxLength = 32767;
            this.txtDinhLuongMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuongMin.Name = "txtDinhLuongMin";
            this.txtDinhLuongMin.PasswordChar = '\0';
            this.txtDinhLuongMin.SelectedText = "";
            this.txtDinhLuongMin.SelectionLength = 0;
            this.txtDinhLuongMin.SelectionStart = 0;
            this.txtDinhLuongMin.Size = new System.Drawing.Size(168, 23);
            this.txtDinhLuongMin.TabIndex = 17;
            this.txtDinhLuongMin.TabStop = false;
            this.txtDinhLuongMin.UseSystemPasswordChar = false;
            this.txtDinhLuongMin.Click += new System.EventHandler(this.txtDinhLuongMin_Click);
            this.txtDinhLuongMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhLuongMin_KeyPress);
            // 
            // txtDinhLuongMax
            // 
            this.txtDinhLuongMax.Depth = 0;
            this.txtDinhLuongMax.Hint = "";
            this.txtDinhLuongMax.Location = new System.Drawing.Point(276, 262);
            this.txtDinhLuongMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtDinhLuongMax.MaxLength = 32767;
            this.txtDinhLuongMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuongMax.Name = "txtDinhLuongMax";
            this.txtDinhLuongMax.PasswordChar = '\0';
            this.txtDinhLuongMax.SelectedText = "";
            this.txtDinhLuongMax.SelectionLength = 0;
            this.txtDinhLuongMax.SelectionStart = 0;
            this.txtDinhLuongMax.Size = new System.Drawing.Size(168, 23);
            this.txtDinhLuongMax.TabIndex = 18;
            this.txtDinhLuongMax.TabStop = false;
            this.txtDinhLuongMax.UseSystemPasswordChar = false;
            this.txtDinhLuongMax.Click += new System.EventHandler(this.txtDinhLuongMax_Click);
            this.txtDinhLuongMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhLuongMax_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Định lượng tối thiểu không được để trống";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(273, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Định lượng tối đa không được để trống";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên nguyên liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Định lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên đơn vị định lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Định mức tối thiểu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Định mức tối đa";
            // 
            // ThemNguyenLieuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 330);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDinhLuongMax);
            this.Controls.Add(this.txtDinhLuongMin);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.txtDinhLuong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.labelTenDonViDinhLuong);
            this.Controls.Add(this.labelDinhLuong);
            this.Controls.Add(this.labelTenNguyenLieu);
            this.Controls.Add(this.txtLoiDinhLuong);
            this.Controls.Add(this.txtLoiTenNguyenLieu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbTenDonViDinhLuong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemNguyenLieuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nguyên Liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTenDonViDinhLuong;
        private MaterialSkin.Controls.MaterialFlatButton btnLuu;
        private MaterialSkin.Controls.MaterialLabel txtLoiTenNguyenLieu;
        private MaterialSkin.Controls.MaterialLabel txtLoiDinhLuong;
        private System.Windows.Forms.Label labelTenNguyenLieu;
        private System.Windows.Forms.Label labelDinhLuong;
        private System.Windows.Forms.Label labelTenDonViDinhLuong;
        private MaterialSkin.Controls.MaterialFlatButton btnHuy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuong;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenNguyenLieu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuongMin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuongMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}