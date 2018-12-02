namespace COFFEE_SHOP_MANAGER
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlDrawer = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStatistics = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBeverage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnToggleDrawer = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbNameStore = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbTabName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTab = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlDrawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleDrawer)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawer
            // 
            this.pnlDrawer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDrawer.Controls.Add(this.bunifuImageButton1);
            this.pnlDrawer.Controls.Add(this.btnExit);
            this.pnlDrawer.Controls.Add(this.btnDashboard);
            this.pnlDrawer.Controls.Add(this.btnImport);
            this.pnlDrawer.Controls.Add(this.btnStore);
            this.pnlDrawer.Controls.Add(this.btnStatistics);
            this.pnlDrawer.Controls.Add(this.btnBeverage);
            this.pnlDrawer.Controls.Add(this.btnToggleDrawer);
            this.pnlDrawer.Controls.Add(this.btnStaff);
            this.pnlDrawer.Controls.Add(this.lbNameStore);
            this.bunifuTransition1.SetDecoration(this.pnlDrawer, BunifuAnimatorNS.DecorationType.None);
            this.pnlDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDrawer.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawer.Name = "pnlDrawer";
            this.pnlDrawer.Size = new System.Drawing.Size(233, 406);
            this.pnlDrawer.TabIndex = 0;
            this.pnlDrawer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawer_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(62, 36);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(96, 86);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Thoát";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 50D;
            this.btnExit.IsTab = true;
            this.btnExit.Location = new System.Drawing.Point(3, 555);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(230, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.Click += new System.EventHandler(this.exit);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Tổng quan";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.IsTab = true;
            this.btnDashboard.Location = new System.Drawing.Point(0, 189);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnDashboard.selected = true;
            this.btnDashboard.Size = new System.Drawing.Size(233, 55);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Tổng quan";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnImport
            // 
            this.btnImport.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderRadius = 0;
            this.btnImport.ButtonText = "Nhập hàng";
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnImport, BunifuAnimatorNS.DecorationType.None);
            this.btnImport.DisabledColor = System.Drawing.Color.Gray;
            this.btnImport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImport.Iconimage")));
            this.btnImport.Iconimage_right = null;
            this.btnImport.Iconimage_right_Selected = null;
            this.btnImport.Iconimage_Selected = null;
            this.btnImport.IconMarginLeft = 0;
            this.btnImport.IconMarginRight = 0;
            this.btnImport.IconRightVisible = true;
            this.btnImport.IconRightZoom = 0D;
            this.btnImport.IconVisible = true;
            this.btnImport.IconZoom = 50D;
            this.btnImport.IsTab = true;
            this.btnImport.Location = new System.Drawing.Point(0, 372);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImport.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImport.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnImport.selected = false;
            this.btnImport.Size = new System.Drawing.Size(233, 55);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Nhập hàng";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImport.Textcolor = System.Drawing.Color.White;
            this.btnImport.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnStore
            // 
            this.btnStore.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStore.BorderRadius = 0;
            this.btnStore.ButtonText = "Bán hàng";
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStore, BunifuAnimatorNS.DecorationType.None);
            this.btnStore.DisabledColor = System.Drawing.Color.Gray;
            this.btnStore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStore.Iconimage")));
            this.btnStore.Iconimage_right = null;
            this.btnStore.Iconimage_right_Selected = null;
            this.btnStore.Iconimage_Selected = null;
            this.btnStore.IconMarginLeft = 0;
            this.btnStore.IconMarginRight = 0;
            this.btnStore.IconRightVisible = true;
            this.btnStore.IconRightZoom = 0D;
            this.btnStore.IconVisible = true;
            this.btnStore.IconZoom = 50D;
            this.btnStore.IsTab = true;
            this.btnStore.Location = new System.Drawing.Point(0, 250);
            this.btnStore.Margin = new System.Windows.Forms.Padding(6);
            this.btnStore.Name = "btnStore";
            this.btnStore.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStore.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStore.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnStore.selected = false;
            this.btnStore.Size = new System.Drawing.Size(233, 55);
            this.btnStore.TabIndex = 5;
            this.btnStore.Text = "Bán hàng";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStore.Textcolor = System.Drawing.Color.White;
            this.btnStore.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStatistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistics.BorderRadius = 0;
            this.btnStatistics.ButtonText = "Thống kê";
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStatistics, BunifuAnimatorNS.DecorationType.None);
            this.btnStatistics.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStatistics.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatistics.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Iconimage")));
            this.btnStatistics.Iconimage_right = null;
            this.btnStatistics.Iconimage_right_Selected = null;
            this.btnStatistics.Iconimage_Selected = null;
            this.btnStatistics.IconMarginLeft = 0;
            this.btnStatistics.IconMarginRight = 0;
            this.btnStatistics.IconRightVisible = true;
            this.btnStatistics.IconRightZoom = 0D;
            this.btnStatistics.IconVisible = true;
            this.btnStatistics.IconZoom = 50D;
            this.btnStatistics.IsTab = true;
            this.btnStatistics.Location = new System.Drawing.Point(0, 433);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(6);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatistics.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStatistics.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnStatistics.selected = false;
            this.btnStatistics.Size = new System.Drawing.Size(233, 55);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistics.Textcolor = System.Drawing.Color.White;
            this.btnStatistics.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnBeverage
            // 
            this.btnBeverage.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBeverage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBeverage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeverage.BorderRadius = 0;
            this.btnBeverage.ButtonText = "Thức uống";
            this.btnBeverage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnBeverage, BunifuAnimatorNS.DecorationType.None);
            this.btnBeverage.DisabledColor = System.Drawing.Color.Gray;
            this.btnBeverage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBeverage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBeverage.Iconimage")));
            this.btnBeverage.Iconimage_right = null;
            this.btnBeverage.Iconimage_right_Selected = null;
            this.btnBeverage.Iconimage_Selected = null;
            this.btnBeverage.IconMarginLeft = 0;
            this.btnBeverage.IconMarginRight = 0;
            this.btnBeverage.IconRightVisible = true;
            this.btnBeverage.IconRightZoom = 0D;
            this.btnBeverage.IconVisible = true;
            this.btnBeverage.IconZoom = 50D;
            this.btnBeverage.IsTab = true;
            this.btnBeverage.Location = new System.Drawing.Point(0, 311);
            this.btnBeverage.Margin = new System.Windows.Forms.Padding(6);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBeverage.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBeverage.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnBeverage.selected = false;
            this.btnBeverage.Size = new System.Drawing.Size(233, 55);
            this.btnBeverage.TabIndex = 3;
            this.btnBeverage.Text = "Thức uống";
            this.btnBeverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBeverage.Textcolor = System.Drawing.Color.White;
            this.btnBeverage.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnBeverage.Click += new System.EventHandler(this.btnBeverage_Click);
            // 
            // btnToggleDrawer
            // 
            this.btnToggleDrawer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToggleDrawer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnToggleDrawer, BunifuAnimatorNS.DecorationType.None);
            this.btnToggleDrawer.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleDrawer.Image")));
            this.btnToggleDrawer.ImageActive = null;
            this.btnToggleDrawer.Location = new System.Drawing.Point(12, 12);
            this.btnToggleDrawer.Name = "btnToggleDrawer";
            this.btnToggleDrawer.Size = new System.Drawing.Size(27, 27);
            this.btnToggleDrawer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggleDrawer.TabIndex = 2;
            this.btnToggleDrawer.TabStop = false;
            this.btnToggleDrawer.Zoom = 10;
            this.btnToggleDrawer.Click += new System.EventHandler(this.btnToggleDrawer_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaff.BorderRadius = 0;
            this.btnStaff.ButtonText = "Nhân viên";
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStaff, BunifuAnimatorNS.DecorationType.None);
            this.btnStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStaff.Iconimage")));
            this.btnStaff.Iconimage_right = null;
            this.btnStaff.Iconimage_right_Selected = null;
            this.btnStaff.Iconimage_Selected = null;
            this.btnStaff.IconMarginLeft = 0;
            this.btnStaff.IconMarginRight = 0;
            this.btnStaff.IconRightVisible = true;
            this.btnStaff.IconRightZoom = 0D;
            this.btnStaff.IconVisible = true;
            this.btnStaff.IconZoom = 50D;
            this.btnStaff.IsTab = true;
            this.btnStaff.Location = new System.Drawing.Point(3, 494);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(6);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStaff.OnHovercolor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStaff.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnStaff.selected = false;
            this.btnStaff.Size = new System.Drawing.Size(230, 55);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStaff.Textcolor = System.Drawing.Color.White;
            this.btnStaff.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // lbNameStore
            // 
            this.lbNameStore.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbNameStore, BunifuAnimatorNS.DecorationType.None);
            this.lbNameStore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbNameStore.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNameStore.Location = new System.Drawing.Point(68, 139);
            this.lbNameStore.Name = "lbNameStore";
            this.lbNameStore.Size = new System.Drawing.Size(90, 21);
            this.lbNameStore.TabIndex = 1;
            this.lbNameStore.Text = "Cafe Brand";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lbTabName);
            this.bunifuTransition1.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(456, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(408, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.exit);
            // 
            // lbTabName
            // 
            this.lbTabName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbTabName, BunifuAnimatorNS.DecorationType.None);
            this.lbTabName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbTabName.ForeColor = System.Drawing.Color.Black;
            this.lbTabName.Location = new System.Drawing.Point(20, 19);
            this.lbTabName.Name = "lbTabName";
            this.lbTabName.Size = new System.Drawing.Size(98, 20);
            this.lbTabName.TabIndex = 0;
            this.lbTabName.Text = "TỔNG QUAN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTab);
            this.panel2.Controls.Add(this.pnlHeader);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 406);
            this.panel2.TabIndex = 1;
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelTab, BunifuAnimatorNS.DecorationType.None);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(0, 58);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(456, 348);
            this.panelTab.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Menu_50px.png");
            this.imageList1.Images.SetKeyName(1, "Left_48px.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(689, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDrawer);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COFFEE SHOP MANAGER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlDrawer.ResumeLayout(false);
            this.pnlDrawer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleDrawer)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDrawer;
        public Bunifu.Framework.UI.BunifuFlatButton btnStore;
        public Bunifu.Framework.UI.BunifuFlatButton btnStatistics;
        public Bunifu.Framework.UI.BunifuFlatButton btnBeverage;
        private Bunifu.Framework.UI.BunifuImageButton btnToggleDrawer;
        public Bunifu.Framework.UI.BunifuFlatButton btnStaff;
        private System.Windows.Forms.Label lbNameStore;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.ImageList imageList1;
        public Bunifu.Framework.UI.BunifuFlatButton btnImport;
        public Bunifu.Framework.UI.BunifuFlatButton btnExit;
        public Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lbTabName;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

