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
            this.txtDinhLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grdCtrCongThuc = new DevExpress.XtraGrid.GridControl();
            this.grdViCongThuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.Depth = 0;
            this.txtDinhLuong.Hint = "Nhập định lượng";
            this.txtDinhLuong.Location = new System.Drawing.Point(12, 88);
            this.txtDinhLuong.MaxLength = 32767;
            this.txtDinhLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.PasswordChar = '\0';
            this.txtDinhLuong.SelectedText = "";
            this.txtDinhLuong.SelectionLength = 0;
            this.txtDinhLuong.SelectionStart = 0;
            this.txtDinhLuong.Size = new System.Drawing.Size(303, 28);
            this.txtDinhLuong.TabIndex = 0;
            this.txtDinhLuong.TabStop = false;
            this.txtDinhLuong.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(362, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // grdCtrCongThuc
            // 
            this.grdCtrCongThuc.Location = new System.Drawing.Point(12, 171);
            this.grdCtrCongThuc.MainView = this.grdViCongThuc;
            this.grdCtrCongThuc.Name = "grdCtrCongThuc";
            this.grdCtrCongThuc.Size = new System.Drawing.Size(689, 266);
            this.grdCtrCongThuc.TabIndex = 2;
            this.grdCtrCongThuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViCongThuc});
            // 
            // grdViCongThuc
            // 
            this.grdViCongThuc.GridControl = this.grdCtrCongThuc;
            this.grdViCongThuc.Name = "grdViCongThuc";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(633, 81);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(55, 36);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // FormulaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 442);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grdCtrCongThuc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDinhLuong);
            this.Name = "FormulaFrm";
            this.Text = "Lập công thức";
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViCongThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtDinhLuong;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraGrid.GridControl grdCtrCongThuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViCongThuc;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
    }
}