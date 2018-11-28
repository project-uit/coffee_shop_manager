using System;
using System.Threading;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Thread thread = new Thread(new ThreadStart(Splash));
            InitializeComponent();
            thread.Start();
            this.TopMost = true;
            string str = string.Empty;
            for (int i = 0; i < 70000; i++)
            {
                str += i.ToString();
            }
            thread.Abort();
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
            this.TopMost = false;
        }

        private void btnToggleDrawer_Click(object sender, EventArgs e)
        {
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panelTab);
            bunifuTransition1.ShowSync(panelTab);
            tabDashboard1.BringToFront();
            lbTabName.Text = "TỔNG QUAN";
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panelTab);
            bunifuTransition1.ShowSync(panelTab);
            tabStore1.BringToFront();
            lbTabName.Text = "BÁN HÀNG";
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panelTab);
            bunifuTransition1.ShowSync(panelTab);
            tabBeverage1.BringToFront();
            lbTabName.Text = "THỨC UỐNG";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panelTab);
            bunifuTransition1.ShowSync(panelTab);
            tabImport1.BringToFront();
            lbTabName.Text = "NHẬP HÀNG";
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panelTab);
            bunifuTransition1.ShowSync(panelTab);
            tabStatistics1.BringToFront();
            lbTabName.Text = "THỐNG KÊ";  
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panelTab);
            bunifuTransition1.ShowSync(panelTab);
            tabStaff1.BringToFront();
            lbTabName.Text = "NHÂN VIÊN";
        }
    }
}
