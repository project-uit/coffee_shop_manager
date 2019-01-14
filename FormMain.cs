using COFFEE_SHOP_MANAGER.DAO;
using COFFEE_SHOP_MANAGER.VIEW.SettingStore;
using MaterialSkin;
using System;
using System.Threading;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER
{
    public partial class FormMain : Form
    {
        public nhanvien loggedStaff = new nhanvien();
        private SwitchTab switchTab;
        public FormMain()
        {

            //Thread thread = new Thread(new ThreadStart(Splash));
            InitializeComponent();
            //thread.Start();
            //this.TopMost = true;
            //string str = string.Empty;
            //for (int i = 0; i < 70000; i++)
            //{
            //    str += i.ToString();
            //}
            //thread.Abort();
            Console.WriteLine("logged user with id -> " + loggedStaff.id_nhanvien);
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }

        bool DrawerOpen = true;

        void Splash()
        {
            SplashScreen.SplashForm splashForm = new SplashScreen.SplashForm();
            splashForm.AppName = "Coffee Mannager";
            Application.Run(splashForm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            lbNameStore.Text = StoreInfoDAO.getInfo().ten;
            setAccess();
            changeTab(tabDashboard);
            switchTab = SwitchTab.Dashboard;           
        }

        public void setAccess()
        {
            btnBeverage.Enabled = loggedStaff.quyen == 1 ? true : false;
            btnStaff.Enabled = loggedStaff.quyen == 1 ? true : false;
            btnStatistics.Enabled = loggedStaff.quyen == 1 ? true : false;
            btnSetting.Enabled = loggedStaff.quyen == 1 ? true : false;
        }

        private void btnToggleDrawer_Click(object sender, EventArgs e)
        {
            lbNameStore.Visible = !lbNameStore.Visible;

            DrawerOpen = !DrawerOpen;
            pnlDrawer.Visible = false;

            if (DrawerOpen)
            {
                //animated Drawer Open
                pnlDrawer.Width = 233;
                btnToggleDrawer.Image = imageList1.Images[0];
                bunifuTransition1.ShowSync(pnlDrawer);
            }
            else
            {
                //Aminated Drawer close
                pnlDrawer.Width = 56;
                btnToggleDrawer.Image = imageList1.Images[1];
                bunifuTransition1.ShowSync(pnlDrawer);
            }
        }

       
        private void pnlDrawer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeTab(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelTab.Controls.Clear();
            panelTab.Controls.Add(userControl);
        }

        private tabDashboard tabDashboard = new tabDashboard();
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(!(switchTab == SwitchTab.Dashboard))
            {
                bunifuTransition1.HideSync(panelTab);
                bunifuTransition1.ShowSync(panelTab);
                tabDashboard.LoadData();
                changeTab(tabDashboard);
                lbTabName.Text = "TỔNG QUAN";
                switchTab = SwitchTab.Dashboard;
            }
        }

        private tabStore tabStore = new tabStore();
        private void btnStore_Click(object sender, EventArgs e)
        {
            if (!(switchTab == SwitchTab.Store))
            {
                bunifuTransition1.HideSync(panelTab);
                bunifuTransition1.ShowSync(panelTab);
                tabStore.loggedStaff = loggedStaff;
                tabStore.LoadData();
                changeTab(tabStore);
                lbTabName.Text = "BÁN HÀNG";
                switchTab = SwitchTab.Store;
            }
        }

        private tabBeverage tabBeverage = new tabBeverage();
        private void btnBeverage_Click(object sender, EventArgs e)
        {
            if (!(switchTab == SwitchTab.Beverage))
            {
                bunifuTransition1.HideSync(panelTab);
                bunifuTransition1.ShowSync(panelTab);
                changeTab(tabBeverage);
                lbTabName.Text = "THỨC UỐNG";
                switchTab = SwitchTab.Beverage;
            }
        }

        private tabImport tabImport = new tabImport();
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!(switchTab == SwitchTab.Import))
            {
                bunifuTransition1.HideSync(panelTab);
                bunifuTransition1.ShowSync(panelTab);
                tabImport.loggedstaff = loggedStaff;
                changeTab(tabImport);
                lbTabName.Text = "NHẬP HÀNG";
                switchTab = SwitchTab.Import;

            }
        }

        private tabStatistics tabStatistics = new tabStatistics();
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (!(switchTab == SwitchTab.Statistics))
            {
                bunifuTransition1.HideSync(panelTab);
                bunifuTransition1.ShowSync(panelTab);
                changeTab(tabStatistics);
                lbTabName.Text = "THỐNG KÊ";
                switchTab = SwitchTab.Statistics;
            }
        }

        private tabStaff tabStaff = new tabStaff();
        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (!(switchTab == SwitchTab.Staff))
            {
                bunifuTransition1.HideSync(panelTab);
                bunifuTransition1.ShowSync(panelTab);
                changeTab(tabStaff);
                lbTabName.Text = "NHÂN VIÊN";
                switchTab = SwitchTab.Staff;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loggedStaff = null;
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnMiniMize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void updateStoreInfo(object sender, FormClosingEventArgs e)
        {
            lbNameStore.Text = StoreInfoDAO.getInfo().ten;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingStoreFrm settingStoreFrm = new SettingStoreFrm();
            settingStoreFrm.FormClosing += updateStoreInfo;
            settingStoreFrm.ShowDialog();
        }
    }
}
