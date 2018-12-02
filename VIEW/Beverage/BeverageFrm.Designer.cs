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
            this.txtTenThucUong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNhomThucUong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaBan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.BackColor = System.Drawing.Color.White;
            this.txtTenThucUong.Depth = 0;
            this.txtTenThucUong.Hint = "";
            this.txtTenThucUong.Location = new System.Drawing.Point(101, 111);
            this.txtTenThucUong.MaxLength = 32767;
            this.txtTenThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.PasswordChar = '\0';
            this.txtTenThucUong.SelectedText = "";
            this.txtTenThucUong.SelectionLength = 0;
            this.txtTenThucUong.SelectionStart = 0;
            this.txtTenThucUong.Size = new System.Drawing.Size(161, 23);
            this.txtTenThucUong.TabIndex = 0;
            this.txtTenThucUong.TabStop = false;
            this.txtTenThucUong.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thức uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm thức uống";
            // 
            // cbbNhomThucUong
            // 
            this.cbbNhomThucUong.FormattingEnabled = true;
            this.cbbNhomThucUong.Location = new System.Drawing.Point(101, 183);
            this.cbbNhomThucUong.Name = "cbbNhomThucUong";
            this.cbbNhomThucUong.Size = new System.Drawing.Size(161, 21);
            this.cbbNhomThucUong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.White;
            this.txtGiaBan.Depth = 0;
            this.txtGiaBan.Hint = "";
            this.txtGiaBan.Location = new System.Drawing.Point(101, 249);
            this.txtGiaBan.MaxLength = 32767;
            this.txtGiaBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.SelectionLength = 0;
            this.txtGiaBan.SelectionStart = 0;
            this.txtGiaBan.Size = new System.Drawing.Size(161, 23);
            this.txtGiaBan.TabIndex = 5;
            this.txtGiaBan.TabStop = false;
            this.txtGiaBan.UseSystemPasswordChar = false;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(117, 298);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(47, 36);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(194, 298);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = true;
            this.btnHuy.Size = new System.Drawing.Size(48, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // BeverageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 415);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNhomThucUong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenThucUong);
            this.MaximizeBox = false;
            this.Name = "BeverageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm thức uống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenThucUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNhomThucUong;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiaBan;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
        private MaterialSkin.Controls.MaterialRaisedButton btnHuy;
    }
}