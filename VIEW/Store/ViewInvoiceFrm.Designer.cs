namespace COFFEE_SHOP_MANAGER.VIEW.Store
{
    partial class ViewInvoiceFrm
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
            this.gcInvoiceDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tennhomthucuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbDate = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInvoiceDetail
            // 
            this.gcInvoiceDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcInvoiceDetail.Location = new System.Drawing.Point(66, 223);
            this.gcInvoiceDetail.MainView = this.gridView1;
            this.gcInvoiceDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gcInvoiceDetail.Name = "gcInvoiceDetail";
            this.gcInvoiceDetail.Size = new System.Drawing.Size(952, 487);
            this.gcInvoiceDetail.TabIndex = 0;
            this.gcInvoiceDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenthucuong,
            this.tennhomthucuong,
            this.dongia,
            this.soluong,
            this.thanhtien});
            this.gridView1.GridControl = this.gcInvoiceDetail;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            // 
            // tenthucuong
            // 
            this.tenthucuong.Caption = "Tên thức uống";
            this.tenthucuong.FieldName = "thucuong.tenthucuong";
            this.tenthucuong.MinWidth = 40;
            this.tenthucuong.Name = "tenthucuong";
            this.tenthucuong.OptionsColumn.AllowEdit = false;
            this.tenthucuong.Visible = true;
            this.tenthucuong.VisibleIndex = 0;
            this.tenthucuong.Width = 150;
            // 
            // tennhomthucuong
            // 
            this.tennhomthucuong.Caption = "Nhóm thức uống";
            this.tennhomthucuong.FieldName = "thucuong.nhomthucuong.tennhomthucuong";
            this.tennhomthucuong.MinWidth = 40;
            this.tennhomthucuong.Name = "tennhomthucuong";
            this.tennhomthucuong.OptionsColumn.AllowEdit = false;
            this.tennhomthucuong.Visible = true;
            this.tennhomthucuong.VisibleIndex = 1;
            this.tennhomthucuong.Width = 150;
            // 
            // dongia
            // 
            this.dongia.Caption = "Đơn giá";
            this.dongia.FieldName = "dongia";
            this.dongia.MinWidth = 40;
            this.dongia.Name = "dongia";
            this.dongia.OptionsColumn.AllowEdit = false;
            this.dongia.Visible = true;
            this.dongia.VisibleIndex = 2;
            this.dongia.Width = 150;
            // 
            // soluong
            // 
            this.soluong.Caption = "Số lượng";
            this.soluong.FieldName = "soluong";
            this.soluong.MinWidth = 40;
            this.soluong.Name = "soluong";
            this.soluong.OptionsColumn.AllowEdit = false;
            this.soluong.Visible = true;
            this.soluong.VisibleIndex = 3;
            this.soluong.Width = 150;
            // 
            // thanhtien
            // 
            this.thanhtien.Caption = "Thành tiền";
            this.thanhtien.FieldName = "thanhtien";
            this.thanhtien.MinWidth = 40;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.OptionsColumn.AllowEdit = false;
            this.thanhtien.Visible = true;
            this.thanhtien.VisibleIndex = 4;
            this.thanhtien.Width = 150;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Depth = 0;
            this.lbDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDate.Location = new System.Drawing.Point(72, 154);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(103, 37);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "lbDate";
            // 
            // ViewInvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 765);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.gcInvoiceDetail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewInvoiceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInvoiceFrm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewInvoiceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcInvoiceDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialLabel lbDate;
        private DevExpress.XtraGrid.Columns.GridColumn tenthucuong;
        private DevExpress.XtraGrid.Columns.GridColumn tennhomthucuong;
        private DevExpress.XtraGrid.Columns.GridColumn dongia;
        private DevExpress.XtraGrid.Columns.GridColumn soluong;
        private DevExpress.XtraGrid.Columns.GridColumn thanhtien;
    }
}