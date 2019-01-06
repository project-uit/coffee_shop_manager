namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    partial class BeverageFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNhomThucUong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbErrorTenThucUong = new System.Windows.Forms.Label();
            this.lbErrorGiaBan = new System.Windows.Forms.Label();
            this.btnLuu = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtTenThucUong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGiaBan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thức uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm thức uống";
            // 
            // cbbNhomThucUong
            // 
            this.cbbNhomThucUong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhomThucUong.Location = new System.Drawing.Point(135, 206);
            this.cbbNhomThucUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhomThucUong.Name = "cbbNhomThucUong";
            this.cbbNhomThucUong.Size = new System.Drawing.Size(213, 24);
            this.cbbNhomThucUong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá bán";
            // 
            // lbErrorTenThucUong
            // 
            this.lbErrorTenThucUong.AutoSize = true;
            this.lbErrorTenThucUong.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorTenThucUong.ForeColor = System.Drawing.Color.Red;
            this.lbErrorTenThucUong.Location = new System.Drawing.Point(131, 142);
            this.lbErrorTenThucUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorTenThucUong.Name = "lbErrorTenThucUong";
            this.lbErrorTenThucUong.Size = new System.Drawing.Size(46, 17);
            this.lbErrorTenThucUong.TabIndex = 9;
            this.lbErrorTenThucUong.Text = "label4";
            this.lbErrorTenThucUong.Visible = false;
            // 
            // lbErrorGiaBan
            // 
            this.lbErrorGiaBan.AutoSize = true;
            this.lbErrorGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lbErrorGiaBan.Location = new System.Drawing.Point(131, 324);
            this.lbErrorGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorGiaBan.Name = "lbErrorGiaBan";
            this.lbErrorGiaBan.Size = new System.Drawing.Size(46, 17);
            this.lbErrorGiaBan.TabIndex = 11;
            this.lbErrorGiaBan.Text = "label6";
            this.lbErrorGiaBan.Visible = false;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(150, 370);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = false;
            this.btnLuu.Size = new System.Drawing.Size(55, 36);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(256, 370);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = false;
            this.btnHuy.Size = new System.Drawing.Size(56, 36);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Depth = 0;
            this.txtTenThucUong.Hint = "";
            this.txtTenThucUong.Location = new System.Drawing.Point(135, 111);
            this.txtTenThucUong.MaxLength = 32767;
            this.txtTenThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.PasswordChar = '\0';
            this.txtTenThucUong.SelectedText = "";
            this.txtTenThucUong.SelectionLength = 0;
            this.txtTenThucUong.SelectionStart = 0;
            this.txtTenThucUong.Size = new System.Drawing.Size(214, 28);
            this.txtTenThucUong.TabIndex = 16;
            this.txtTenThucUong.TabStop = false;
            this.txtTenThucUong.UseSystemPasswordChar = false;
            this.txtTenThucUong.Click += new System.EventHandler(this.txtTenThucUong_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Depth = 0;
            this.txtGiaBan.Hint = "";
            this.txtGiaBan.Location = new System.Drawing.Point(134, 293);
            this.txtGiaBan.MaxLength = 32767;
            this.txtGiaBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.SelectionLength = 0;
            this.txtGiaBan.SelectionStart = 0;
            this.txtGiaBan.Size = new System.Drawing.Size(215, 28);
            this.txtGiaBan.TabIndex = 17;
            this.txtGiaBan.TabStop = false;
            this.txtGiaBan.UseSystemPasswordChar = false;
            this.txtGiaBan.Click += new System.EventHandler(this.txtGiaBan_Click);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // BeverageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 511);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbErrorGiaBan);
            this.Controls.Add(this.lbErrorTenThucUong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNhomThucUong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BeverageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thức uống";
            this.Load += new System.EventHandler(this.BeverageFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNhomThucUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbErrorGiaBan;
        private System.Windows.Forms.Label lbErrorTenThucUong;
        private MaterialSkin.Controls.MaterialFlatButton btnLuu;
        private MaterialSkin.Controls.MaterialFlatButton btnHuy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenThucUong;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiaBan;
    }
}