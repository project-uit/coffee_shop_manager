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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
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
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(519, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(197, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Tên đơn vị định lượng:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Tên nguyên liệu:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(27, 200);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Định lượng:";
            // 
            // cbTenDonViDinhLuong
            // 
            this.cbTenDonViDinhLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenDonViDinhLuong.FormattingEnabled = true;
            this.cbTenDonViDinhLuong.ItemHeight = 16;
            this.cbTenDonViDinhLuong.Items.AddRange(new object[] {
            "gam",
            "mililit",
            "lit",
            "kilogam"});
            this.cbTenDonViDinhLuong.Location = new System.Drawing.Point(524, 136);
            this.cbTenDonViDinhLuong.Name = "cbTenDonViDinhLuong";
            this.cbTenDonViDinhLuong.Size = new System.Drawing.Size(223, 24);
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
            this.btnLuu.Location = new System.Drawing.Point(323, 308);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = false;
            this.btnLuu.Size = new System.Drawing.Size(55, 36);
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
            this.txtLoiTenNguyenLieu.Location = new System.Drawing.Point(27, 159);
            this.txtLoiTenNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoiTenNguyenLieu.Name = "txtLoiTenNguyenLieu";
            this.txtLoiTenNguyenLieu.Size = new System.Drawing.Size(0, 24);
            this.txtLoiTenNguyenLieu.TabIndex = 9;
            // 
            // txtLoiDinhLuong
            // 
            this.txtLoiDinhLuong.AutoSize = true;
            this.txtLoiDinhLuong.BackColor = System.Drawing.Color.White;
            this.txtLoiDinhLuong.Depth = 0;
            this.txtLoiDinhLuong.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtLoiDinhLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLoiDinhLuong.Location = new System.Drawing.Point(27, 260);
            this.txtLoiDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoiDinhLuong.Name = "txtLoiDinhLuong";
            this.txtLoiDinhLuong.Size = new System.Drawing.Size(0, 24);
            this.txtLoiDinhLuong.TabIndex = 10;
            // 
            // labelTenNguyenLieu
            // 
            this.labelTenNguyenLieu.AutoSize = true;
            this.labelTenNguyenLieu.BackColor = System.Drawing.Color.White;
            this.labelTenNguyenLieu.ForeColor = System.Drawing.Color.Red;
            this.labelTenNguyenLieu.Location = new System.Drawing.Point(31, 159);
            this.labelTenNguyenLieu.Name = "labelTenNguyenLieu";
            this.labelTenNguyenLieu.Size = new System.Drawing.Size(250, 17);
            this.labelTenNguyenLieu.TabIndex = 11;
            this.labelTenNguyenLieu.Text = "*Tên nguyên liệu không được để trống";
            // 
            // labelDinhLuong
            // 
            this.labelDinhLuong.AutoSize = true;
            this.labelDinhLuong.BackColor = System.Drawing.Color.White;
            this.labelDinhLuong.ForeColor = System.Drawing.Color.Red;
            this.labelDinhLuong.Location = new System.Drawing.Point(28, 260);
            this.labelDinhLuong.Name = "labelDinhLuong";
            this.labelDinhLuong.Size = new System.Drawing.Size(216, 17);
            this.labelDinhLuong.TabIndex = 12;
            this.labelDinhLuong.Text = "*Định lượng không được để trống";
            // 
            // labelTenDonViDinhLuong
            // 
            this.labelTenDonViDinhLuong.AutoSize = true;
            this.labelTenDonViDinhLuong.BackColor = System.Drawing.Color.White;
            this.labelTenDonViDinhLuong.ForeColor = System.Drawing.Color.Red;
            this.labelTenDonViDinhLuong.Location = new System.Drawing.Point(520, 159);
            this.labelTenDonViDinhLuong.Name = "labelTenDonViDinhLuong";
            this.labelTenDonViDinhLuong.Size = new System.Drawing.Size(217, 17);
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
            this.btnHuy.Location = new System.Drawing.Point(412, 308);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = false;
            this.btnHuy.Size = new System.Drawing.Size(56, 36);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.Depth = 0;
            this.txtDinhLuong.Hint = "";
            this.txtDinhLuong.Location = new System.Drawing.Point(31, 229);
            this.txtDinhLuong.MaxLength = 32767;
            this.txtDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.PasswordChar = '\0';
            this.txtDinhLuong.SelectedText = "";
            this.txtDinhLuong.SelectionLength = 0;
            this.txtDinhLuong.SelectionStart = 0;
            this.txtDinhLuong.Size = new System.Drawing.Size(341, 28);
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
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(31, 132);
            this.txtTenNguyenLieu.MaxLength = 32767;
            this.txtTenNguyenLieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.PasswordChar = '\0';
            this.txtTenNguyenLieu.SelectedText = "";
            this.txtTenNguyenLieu.SelectionLength = 0;
            this.txtTenNguyenLieu.SelectionStart = 0;
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(341, 28);
            this.txtTenNguyenLieu.TabIndex = 16;
            this.txtTenNguyenLieu.TabStop = false;
            this.txtTenNguyenLieu.UseSystemPasswordChar = false;
            this.txtTenNguyenLieu.Click += new System.EventHandler(this.txtTenNguyenLieu_Click);
            // 
            // ThemNguyenLieuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 369);
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
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "ThemNguyenLieuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nguyên Liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
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
    }
}