namespace COFFEE_SHOP_MANAGER
{
    partial class tabBeverage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCtrlThucUong = new DevExpress.XtraGrid.GridControl();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnThemThucUong = new MaterialSkin.Controls.MaterialRaisedButton();
            this.colid_thucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhomthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThucUong)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_thucuong,
            this.coltenthucuong,
            this.colgiaban,
            this.colnhomthucuong});
            this.gridView2.GridControl = this.grdCtrlThucUong;
            this.gridView2.Name = "gridView2";
            // 
            // grdCtrlThucUong
            // 
            this.grdCtrlThucUong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrlThucUong.DataSource = typeof(COFFEE_SHOP_MANAGER.thucuong);
            this.grdCtrlThucUong.Location = new System.Drawing.Point(3, 68);
            this.grdCtrlThucUong.MainView = this.gridView2;
            this.grdCtrlThucUong.Name = "grdCtrlThucUong";
            this.grdCtrlThucUong.Size = new System.Drawing.Size(969, 393);
            this.grdCtrlThucUong.TabIndex = 2;
            this.grdCtrlThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Tìm kiếm";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(3, 20);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(194, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // btnThemThucUong
            // 
            this.btnThemThucUong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemThucUong.AutoSize = true;
            this.btnThemThucUong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemThucUong.Depth = 0;
            this.btnThemThucUong.Icon = null;
            this.btnThemThucUong.Location = new System.Drawing.Point(832, 20);
            this.btnThemThucUong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemThucUong.Name = "btnThemThucUong";
            this.btnThemThucUong.Primary = true;
            this.btnThemThucUong.Size = new System.Drawing.Size(140, 36);
            this.btnThemThucUong.TabIndex = 5;
            this.btnThemThucUong.Text = "Thêm thức uống";
            this.btnThemThucUong.UseVisualStyleBackColor = true;
            this.btnThemThucUong.Click += new System.EventHandler(this.btnThemThucUong_Click);
            // 
            // colid_thucuong
            // 
            this.colid_thucuong.FieldName = "id_thucuong";
            this.colid_thucuong.Name = "colid_thucuong";
            // 
            // coltenthucuong
            // 
            this.coltenthucuong.Caption = "Tên thức uống";
            this.coltenthucuong.FieldName = "tenthucuong";
            this.coltenthucuong.Name = "coltenthucuong";
            this.coltenthucuong.Visible = true;
            this.coltenthucuong.VisibleIndex = 0;
            // 
            // colgiaban
            // 
            this.colgiaban.Caption = "Giá bán";
            this.colgiaban.FieldName = "giaban";
            this.colgiaban.Name = "colgiaban";
            this.colgiaban.Visible = true;
            this.colgiaban.VisibleIndex = 1;
            // 
            // colnhomthucuong
            // 
            this.colnhomthucuong.Caption = "Nhóm thức uống";
            this.colnhomthucuong.FieldName = "nhomthucuong.tennhomthucuong";
            this.colnhomthucuong.Name = "colnhomthucuong";
            this.colnhomthucuong.Visible = true;
            this.colnhomthucuong.VisibleIndex = 2;
            // 
            // tabBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnThemThucUong);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.grdCtrlThucUong);
            this.DoubleBuffered = true;
            this.Name = "tabBeverage";
            this.Size = new System.Drawing.Size(975, 461);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlThucUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdCtrlThucUong;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemThucUong;
        private DevExpress.XtraGrid.Columns.GridColumn colid_thucuong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenthucuong;
        private DevExpress.XtraGrid.Columns.GridColumn colgiaban;
        private DevExpress.XtraGrid.Columns.GridColumn colnhomthucuong;
    }
}
