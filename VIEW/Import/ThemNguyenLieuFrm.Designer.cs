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
            this.txtDinhLuongMin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDinhLuongMax = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(462, 96);
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
            this.cbTenDonViDinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenDonViDinhLuong.FormattingEnabled = true;
            this.cbTenDonViDinhLuong.ItemHeight = 20;
            this.cbTenDonViDinhLuong.Items.AddRange(new object[] {
            "gam",
            "mililit",
            "lit",
            "kilogam"});
            this.cbTenDonViDinhLuong.Location = new System.Drawing.Point(467, 132);
            this.cbTenDonViDinhLuong.Name = "cbTenDonViDinhLuong";
            this.cbTenDonViDinhLuong.Size = new System.Drawing.Size(223, 28);
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
            this.btnLuu.Location = new System.Drawing.Point(136, 324);
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
            this.labelTenDonViDinhLuong.Location = new System.Drawing.Point(463, 166);
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
            this.btnHuy.Location = new System.Drawing.Point(225, 324);
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
            this.txtDinhLuong.Size = new System.Drawing.Size(250, 28);
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
            // txtDinhLuongMin
            // 
            this.txtDinhLuongMin.Depth = 0;
            this.txtDinhLuongMin.Hint = "";
            this.txtDinhLuongMin.Location = new System.Drawing.Point(466, 229);
            this.txtDinhLuongMin.MaxLength = 32767;
            this.txtDinhLuongMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuongMin.Name = "txtDinhLuongMin";
            this.txtDinhLuongMin.PasswordChar = '\0';
            this.txtDinhLuongMin.SelectedText = "";
            this.txtDinhLuongMin.SelectionLength = 0;
            this.txtDinhLuongMin.SelectionStart = 0;
            this.txtDinhLuongMin.Size = new System.Drawing.Size(187, 28);
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
            this.txtDinhLuongMax.Location = new System.Drawing.Point(466, 324);
            this.txtDinhLuongMax.MaxLength = 32767;
            this.txtDinhLuongMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuongMax.Name = "txtDinhLuongMax";
            this.txtDinhLuongMax.PasswordChar = '\0';
            this.txtDinhLuongMax.SelectedText = "";
            this.txtDinhLuongMax.SelectionLength = 0;
            this.txtDinhLuongMax.SelectionStart = 0;
            this.txtDinhLuongMax.Size = new System.Drawing.Size(187, 28);
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
            this.label1.Location = new System.Drawing.Point(463, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Định lượng tối thiểu không được để trống";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(463, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Định lượng tối đa không được để trống";
            this.label2.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(463, 200);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(165, 24);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Định mức tối thiểu";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(463, 297);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(145, 24);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Định mức tối đa";
            // 
            // ThemNguyenLieuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 398);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuongMin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuongMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}