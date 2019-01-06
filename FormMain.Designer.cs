﻿namespace COFFEE_SHOP_MANAGER
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
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMiniMize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlDrawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleDrawer)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiniMize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrawer
            // 
            this.pnlDrawer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDrawer.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this.pnlDrawer, BunifuAnimatorNS.DecorationType.None);
            this.pnlDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDrawer.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawer.Margin = new System.Windows.Forms.Padding(6);
            this.pnlDrawer.Name = "pnlDrawer";
            this.pnlDrawer.Size = new System.Drawing.Size(466, 2130);
            this.pnlDrawer.TabIndex = 0;
            this.pnlDrawer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawer_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Đăng xuất";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 50D;
            this.btnLogout.IsTab = true;
            this.btnLogout.Location = new System.Drawing.Point(4, 996);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(466, 106);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(130, 89);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(192, 165);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
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
            this.btnExit.Location = new System.Drawing.Point(4, 1101);
            this.btnExit.Margin = new System.Windows.Forms.Padding(12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(466, 106);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.Click += new System.EventHandler(this.exit);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
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
            this.btnDashboard.Location = new System.Drawing.Point(4, 373);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDashboard.selected = true;
            this.btnDashboard.Size = new System.Drawing.Size(466, 106);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Tổng quan";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnImport
            // 
            this.btnImport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
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
            this.btnImport.Location = new System.Drawing.Point(4, 677);
            this.btnImport.Margin = new System.Windows.Forms.Padding(12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImport.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnImport.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnImport.selected = false;
            this.btnImport.Size = new System.Drawing.Size(466, 113);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Nhập hàng";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImport.Textcolor = System.Drawing.Color.White;
            this.btnImport.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnStore
            // 
            this.btnStore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStore.BackColor = System.Drawing.Color.Transparent;
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
            this.btnStore.Location = new System.Drawing.Point(4, 477);
            this.btnStore.Margin = new System.Windows.Forms.Padding(12);
            this.btnStore.Name = "btnStore";
            this.btnStore.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStore.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStore.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStore.selected = false;
            this.btnStore.Size = new System.Drawing.Size(466, 106);
            this.btnStore.TabIndex = 5;
            this.btnStore.Text = "Bán hàng";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStore.Textcolor = System.Drawing.Color.White;
            this.btnStore.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
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
            this.btnStatistics.Location = new System.Drawing.Point(4, 788);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(12);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStatistics.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStatistics.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStatistics.selected = false;
            this.btnStatistics.Size = new System.Drawing.Size(466, 106);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistics.Textcolor = System.Drawing.Color.White;
            this.btnStatistics.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnBeverage
            // 
            this.btnBeverage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBeverage.BackColor = System.Drawing.Color.Transparent;
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
            this.btnBeverage.Location = new System.Drawing.Point(4, 582);
            this.btnBeverage.Margin = new System.Windows.Forms.Padding(12);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBeverage.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnBeverage.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBeverage.selected = false;
            this.btnBeverage.Size = new System.Drawing.Size(466, 106);
            this.btnBeverage.TabIndex = 3;
            this.btnBeverage.Text = "Thức uống";
            this.btnBeverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBeverage.Textcolor = System.Drawing.Color.White;
            this.btnBeverage.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnBeverage.Click += new System.EventHandler(this.btnBeverage_Click);
            // 
            // btnToggleDrawer
            // 
            this.btnToggleDrawer.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleDrawer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnToggleDrawer, BunifuAnimatorNS.DecorationType.None);
            this.btnToggleDrawer.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleDrawer.Image")));
            this.btnToggleDrawer.ImageActive = null;
            this.btnToggleDrawer.Location = new System.Drawing.Point(19, 31);
            this.btnToggleDrawer.Margin = new System.Windows.Forms.Padding(6);
            this.btnToggleDrawer.Name = "btnToggleDrawer";
            this.btnToggleDrawer.Size = new System.Drawing.Size(54, 52);
            this.btnToggleDrawer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggleDrawer.TabIndex = 2;
            this.btnToggleDrawer.TabStop = false;
            this.btnToggleDrawer.Zoom = 10;
            this.btnToggleDrawer.Click += new System.EventHandler(this.btnToggleDrawer_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
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
            this.btnStaff.Location = new System.Drawing.Point(4, 889);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(12);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStaff.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStaff.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStaff.selected = false;
            this.btnStaff.Size = new System.Drawing.Size(466, 110);
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
            this.lbNameStore.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbNameStore, BunifuAnimatorNS.DecorationType.None);
            this.lbNameStore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbNameStore.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNameStore.Location = new System.Drawing.Point(133, 260);
            this.lbNameStore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNameStore.Name = "lbNameStore";
            this.lbNameStore.Size = new System.Drawing.Size(180, 45);
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
            this.pnlHeader.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuTransition1.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2924, 112);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(2815, 36);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 58);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.exit);
            // 
            // lbTabName
            // 
            this.lbTabName.AutoSize = true;
            this.lbTabName.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbTabName, BunifuAnimatorNS.DecorationType.None);
            this.lbTabName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbTabName.ForeColor = System.Drawing.Color.White;
            this.lbTabName.Location = new System.Drawing.Point(29, 42);
            this.lbTabName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTabName.Name = "lbTabName";
            this.lbTabName.Size = new System.Drawing.Size(196, 41);
            this.lbTabName.TabIndex = 0;
            this.lbTabName.Text = "TỔNG QUAN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTab);
            this.panel2.Controls.Add(this.pnlHeader);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(466, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2924, 2130);
            this.panel2.TabIndex = 1;
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelTab, BunifuAnimatorNS.DecorationType.None);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(0, 112);
            this.panelTab.Margin = new System.Windows.Forms.Padding(6);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(2924, 2018);
            this.panelTab.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Menu_50px.png");
            this.imageList1.Images.SetKeyName(1, "Left_48px.png");
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnLogout);
            this.bunifuGradientPanel1.Controls.Add(this.btnToggleDrawer);
            this.bunifuGradientPanel1.Controls.Add(this.btnStaff);
            this.bunifuGradientPanel1.Controls.Add(this.lbNameStore);
            this.bunifuGradientPanel1.Controls.Add(this.btnStatistics);
            this.bunifuGradientPanel1.Controls.Add(this.btnDashboard);
            this.bunifuGradientPanel1.Controls.Add(this.btnImport);
            this.bunifuGradientPanel1.Controls.Add(this.btnStore);
            this.bunifuGradientPanel1.Controls.Add(this.btnBeverage);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumPurple;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, -8);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(470, 2140);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnMiniMize);
            this.bunifuGradientPanel2.Controls.Add(this.btnClose);
            this.bunifuGradientPanel2.Controls.Add(this.lbTabName);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.LightSteelBlue;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, -8);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(2925, 120);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // btnMiniMize
            // 
            this.btnMiniMize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniMize.BackColor = System.Drawing.Color.Transparent;
            this.btnMiniMize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMiniMize, BunifuAnimatorNS.DecorationType.None);
            this.btnMiniMize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniMize.Image")));
            this.btnMiniMize.ImageActive = null;
            this.btnMiniMize.Location = new System.Drawing.Point(2732, 36);
            this.btnMiniMize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMiniMize.Name = "btnMiniMize";
            this.btnMiniMize.Size = new System.Drawing.Size(53, 58);
            this.btnMiniMize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMiniMize.TabIndex = 2;
            this.btnMiniMize.TabStop = false;
            this.btnMiniMize.Zoom = 10;
            this.btnMiniMize.Click += new System.EventHandler(this.btnMiniMize_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(3390, 2130);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDrawer);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COFFEE SHOP MANAGER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlDrawer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleDrawer)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiniMize)).EndInit();
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
        public Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuImageButton btnMiniMize;
    }
}

