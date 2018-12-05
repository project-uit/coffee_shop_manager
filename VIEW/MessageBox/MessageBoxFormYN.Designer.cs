namespace COFFEE_SHOP_MANAGER.VIEW.MessageBox
{
    partial class MessageBoxFormYN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnHuy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDongY = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMessage);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDongY);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 187);
            this.panel1.TabIndex = 1;
            // 
            // lbMessage
            // 
            this.lbMessage.Depth = 0;
            this.lbMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMessage.Location = new System.Drawing.Point(3, 10);
            this.lbMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(319, 74);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "message";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(197, 113);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = true;
            this.btnHuy.Size = new System.Drawing.Size(48, 36);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.AutoSize = true;
            this.btnDongY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDongY.Depth = 0;
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnDongY.Icon = null;
            this.btnDongY.Location = new System.Drawing.Point(59, 113);
            this.btnDongY.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Primary = true;
            this.btnDongY.Size = new System.Drawing.Size(70, 36);
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // MessageBoxFormYN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 253);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxFormYN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnHuy;
        private MaterialSkin.Controls.MaterialRaisedButton btnDongY;
        private MaterialSkin.Controls.MaterialLabel lbMessage;
    }
}