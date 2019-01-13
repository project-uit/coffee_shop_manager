﻿namespace COFFEE_SHOP_MANAGER.VIEW.Setting
{
    partial class SettingFrm
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
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbErrorName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbErrorAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbErrorPhone = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(151, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(341, 28);
            this.txtName.TabIndex = 63;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lbErrorName
            // 
            this.lbErrorName.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorName.Appearance.Options.UseForeColor = true;
            this.lbErrorName.Location = new System.Drawing.Point(151, 150);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(65, 16);
            this.lbErrorName.TabIndex = 62;
            this.lbErrorName.Text = "error name";
            this.lbErrorName.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 16);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Tên";
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(151, 172);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(341, 28);
            this.txtAddress.TabIndex = 66;
            this.txtAddress.TabStop = false;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // lbErrorAddress
            // 
            this.lbErrorAddress.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorAddress.Appearance.Options.UseForeColor = true;
            this.lbErrorAddress.Location = new System.Drawing.Point(151, 207);
            this.lbErrorAddress.Name = "lbErrorAddress";
            this.lbErrorAddress.Size = new System.Drawing.Size(78, 16);
            this.lbErrorAddress.TabIndex = 65;
            this.lbErrorAddress.Text = "error address";
            this.lbErrorAddress.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 17);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // txtPhone
            // 
            this.txtPhone.Depth = 0;
            this.txtPhone.Hint = "";
            this.txtPhone.Location = new System.Drawing.Point(151, 229);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(341, 28);
            this.txtPhone.TabIndex = 69;
            this.txtPhone.TabStop = false;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // lbErrorPhone
            // 
            this.lbErrorPhone.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPhone.Appearance.Options.UseForeColor = true;
            this.lbErrorPhone.Location = new System.Drawing.Point(151, 264);
            this.lbErrorPhone.Name = "lbErrorPhone";
            this.lbErrorPhone.Size = new System.Drawing.Size(68, 16);
            this.lbErrorPhone.TabIndex = 68;
            this.lbErrorPhone.Text = "error phone";
            this.lbErrorPhone.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(52, 234);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 17);
            this.labelControl5.TabIndex = 67;
            this.labelControl5.Text = "Số điện thoại";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(429, 294);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 369);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbErrorPhone);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbErrorAddress);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbErrorName);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private DevExpress.XtraEditors.LabelControl lbErrorName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private DevExpress.XtraEditors.LabelControl lbErrorAddress;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
        private DevExpress.XtraEditors.LabelControl lbErrorPhone;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
    }
}