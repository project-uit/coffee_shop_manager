namespace COFFEE_SHOP_MANAGER.VIEW.Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingFrm));
            this.txtSeverName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbErrorName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPathFileRestore = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbErrorPathRestore = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRestore = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPathFileBackup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbErrorPathBackup = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeverName
            // 
            this.txtSeverName.Depth = 0;
            this.txtSeverName.Hint = "";
            this.txtSeverName.Location = new System.Drawing.Point(143, 94);
            this.txtSeverName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSeverName.MaxLength = 32767;
            this.txtSeverName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSeverName.Name = "txtSeverName";
            this.txtSeverName.PasswordChar = '\0';
            this.txtSeverName.SelectedText = "";
            this.txtSeverName.SelectionLength = 0;
            this.txtSeverName.SelectionStart = 0;
            this.txtSeverName.Size = new System.Drawing.Size(226, 23);
            this.txtSeverName.TabIndex = 63;
            this.txtSeverName.TabStop = false;
            this.txtSeverName.Text = "SQLEXPRESS";
            this.txtSeverName.UseSystemPasswordChar = false;
            // 
            // lbErrorName
            // 
            this.lbErrorName.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorName.Appearance.Options.UseForeColor = true;
            this.lbErrorName.Location = new System.Drawing.Point(143, 122);
            this.lbErrorName.Margin = new System.Windows.Forms.Padding(2);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(87, 13);
            this.lbErrorName.TabIndex = 62;
            this.lbErrorName.Text = "error server name";
            this.lbErrorName.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 98);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Server";
            // 
            // txtPathFileRestore
            // 
            this.txtPathFileRestore.Depth = 0;
            this.txtPathFileRestore.Hint = "";
            this.txtPathFileRestore.Location = new System.Drawing.Point(143, 185);
            this.txtPathFileRestore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPathFileRestore.MaxLength = 32767;
            this.txtPathFileRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPathFileRestore.Name = "txtPathFileRestore";
            this.txtPathFileRestore.PasswordChar = '\0';
            this.txtPathFileRestore.SelectedText = "";
            this.txtPathFileRestore.SelectionLength = 0;
            this.txtPathFileRestore.SelectionStart = 0;
            this.txtPathFileRestore.Size = new System.Drawing.Size(226, 23);
            this.txtPathFileRestore.TabIndex = 66;
            this.txtPathFileRestore.TabStop = false;
            this.txtPathFileRestore.UseSystemPasswordChar = false;
            this.txtPathFileRestore.Click += new System.EventHandler(this.txtPathFileRestore_Click);
            // 
            // lbErrorPathRestore
            // 
            this.lbErrorPathRestore.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPathRestore.Appearance.Options.UseForeColor = true;
            this.lbErrorPathRestore.Location = new System.Drawing.Point(143, 213);
            this.lbErrorPathRestore.Margin = new System.Windows.Forms.Padding(2);
            this.lbErrorPathRestore.Name = "lbErrorPathRestore";
            this.lbErrorPathRestore.Size = new System.Drawing.Size(64, 13);
            this.lbErrorPathRestore.TabIndex = 65;
            this.lbErrorPathRestore.Text = "error location";
            this.lbErrorPathRestore.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 189);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Chọn file restore";
            // 
            // btnRestore
            // 
            this.btnRestore.AutoSize = true;
            this.btnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestore.Depth = 0;
            this.btnRestore.Icon = null;
            this.btnRestore.Location = new System.Drawing.Point(289, 231);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Primary = true;
            this.btnRestore.Size = new System.Drawing.Size(80, 36);
            this.btnRestore.TabIndex = 70;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.AutoSize = true;
            this.btnBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackup.Depth = 0;
            this.btnBackup.Icon = null;
            this.btnBackup.Location = new System.Drawing.Point(295, 363);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Primary = true;
            this.btnBackup.Size = new System.Drawing.Size(74, 36);
            this.btnBackup.TabIndex = 74;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtPathFileBackup
            // 
            this.txtPathFileBackup.Depth = 0;
            this.txtPathFileBackup.Hint = "";
            this.txtPathFileBackup.Location = new System.Drawing.Point(143, 317);
            this.txtPathFileBackup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPathFileBackup.MaxLength = 32767;
            this.txtPathFileBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPathFileBackup.Name = "txtPathFileBackup";
            this.txtPathFileBackup.PasswordChar = '\0';
            this.txtPathFileBackup.SelectedText = "";
            this.txtPathFileBackup.SelectionLength = 0;
            this.txtPathFileBackup.SelectionStart = 0;
            this.txtPathFileBackup.Size = new System.Drawing.Size(226, 23);
            this.txtPathFileBackup.TabIndex = 73;
            this.txtPathFileBackup.TabStop = false;
            this.txtPathFileBackup.UseSystemPasswordChar = false;
            this.txtPathFileBackup.Click += new System.EventHandler(this.txtPathFileBackup_Click);
            // 
            // lbErrorPathBackup
            // 
            this.lbErrorPathBackup.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPathBackup.Appearance.Options.UseForeColor = true;
            this.lbErrorPathBackup.Location = new System.Drawing.Point(143, 345);
            this.lbErrorPathBackup.Margin = new System.Windows.Forms.Padding(2);
            this.lbErrorPathBackup.Name = "lbErrorPathBackup";
            this.lbErrorPathBackup.Size = new System.Drawing.Size(64, 13);
            this.lbErrorPathBackup.TabIndex = 72;
            this.lbErrorPathBackup.Text = "error location";
            this.lbErrorPathBackup.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 321);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 13);
            this.labelControl4.TabIndex = 71;
            this.labelControl4.Text = "Chọn file restore";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "RESTORE DATABASE";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "BACKUP DATABASE";
            // 
            // SettingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtPathFileBackup);
            this.Controls.Add(this.lbErrorPathBackup);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtPathFileRestore);
            this.Controls.Add(this.lbErrorPathRestore);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSeverName);
            this.Controls.Add(this.lbErrorName);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private MaterialSkin.Controls.MaterialSingleLineTextField txtSeverName;
        private DevExpress.XtraEditors.LabelControl lbErrorName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPathFileRestore;
        private DevExpress.XtraEditors.LabelControl lbErrorPathRestore;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private MaterialSkin.Controls.MaterialRaisedButton btnRestore;
        private MaterialSkin.Controls.MaterialRaisedButton btnBackup;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPathFileBackup;
        private DevExpress.XtraEditors.LabelControl lbErrorPathBackup;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}