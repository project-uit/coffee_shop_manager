namespace COFFEE_SHOP_MANAGER.VIEW.Import
{
    partial class ThemNguyenLieuDaDungFrm
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
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbTenNguyenLieu = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.labelTenNguyenLieu = new System.Windows.Forms.Label();
            this.labelDinhLuong = new System.Windows.Forms.Label();
            this.btnHuy = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDinhLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(237, 129);
            this.dateEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(127, 22);
            this.dateEdit.TabIndex = 9;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(56, 129);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Ngày nhập: ";
            // 
            // cbTenNguyenLieu
            // 
            this.cbTenNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNguyenLieu.FormattingEnabled = true;
            this.cbTenNguyenLieu.ItemHeight = 16;
            this.cbTenNguyenLieu.Location = new System.Drawing.Point(237, 186);
            this.cbTenNguyenLieu.Name = "cbTenNguyenLieu";
            this.cbTenNguyenLieu.Size = new System.Drawing.Size(343, 24);
            this.cbTenNguyenLieu.TabIndex = 17;
            this.cbTenNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cbTenNguyenLieu_SelectedIndexChanged);
            this.cbTenNguyenLieu.Click += new System.EventHandler(this.cbTenNguyenLieu_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(56, 183);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 24);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Tên nguyên liệu:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(56, 261);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 24);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Định lượng:";
            // 
            // labelTenNguyenLieu
            // 
            this.labelTenNguyenLieu.AutoSize = true;
            this.labelTenNguyenLieu.BackColor = System.Drawing.Color.White;
            this.labelTenNguyenLieu.ForeColor = System.Drawing.Color.Red;
            this.labelTenNguyenLieu.Location = new System.Drawing.Point(233, 209);
            this.labelTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenNguyenLieu.Name = "labelTenNguyenLieu";
            this.labelTenNguyenLieu.Size = new System.Drawing.Size(250, 17);
            this.labelTenNguyenLieu.TabIndex = 22;
            this.labelTenNguyenLieu.Text = "*Tên nguyên liệu không được để trống";
            // 
            // labelDinhLuong
            // 
            this.labelDinhLuong.AutoSize = true;
            this.labelDinhLuong.BackColor = System.Drawing.Color.White;
            this.labelDinhLuong.ForeColor = System.Drawing.Color.Red;
            this.labelDinhLuong.Location = new System.Drawing.Point(233, 288);
            this.labelDinhLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDinhLuong.Name = "labelDinhLuong";
            this.labelDinhLuong.Size = new System.Drawing.Size(216, 17);
            this.labelDinhLuong.TabIndex = 26;
            this.labelDinhLuong.Text = "*Định lượng không được để trống";
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(363, 363);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = false;
            this.btnHuy.Size = new System.Drawing.Size(56, 36);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(236, 363);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = false;
            this.btnLuu.Size = new System.Drawing.Size(55, 36);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.Depth = 0;
            this.txtDinhLuong.Hint = "Nhập định lượng";
            this.txtDinhLuong.Location = new System.Drawing.Point(236, 261);
            this.txtDinhLuong.MaxLength = 32767;
            this.txtDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.PasswordChar = '\0';
            this.txtDinhLuong.SelectedText = "";
            this.txtDinhLuong.SelectionLength = 0;
            this.txtDinhLuong.SelectionStart = 0;
            this.txtDinhLuong.Size = new System.Drawing.Size(343, 28);
            this.txtDinhLuong.TabIndex = 29;
            this.txtDinhLuong.TabStop = false;
            this.txtDinhLuong.UseSystemPasswordChar = false;
            this.txtDinhLuong.Click += new System.EventHandler(this.txtDinhLuong_Click);
            this.txtDinhLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhLuong_KeyPress);
            // 
            // ThemNguyenLieuDaDungFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 524);
            this.Controls.Add(this.txtDinhLuong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelDinhLuong);
            this.Controls.Add(this.labelTenNguyenLieu);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.cbTenNguyenLieu);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.materialLabel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ThemNguyenLieuDaDungFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nguyên Liệu Đã Dùng";
            this.Load += new System.EventHandler(this.ThemNguyenLieuDaDungFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.ComboBox cbTenNguyenLieu;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label labelTenNguyenLieu;
        private System.Windows.Forms.Label labelDinhLuong;
        private MaterialSkin.Controls.MaterialFlatButton btnHuy;
        private MaterialSkin.Controls.MaterialFlatButton btnLuu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuong;
    }
}