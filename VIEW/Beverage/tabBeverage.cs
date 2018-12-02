using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEE_SHOP_MANAGER.VIEW.Beverage;
using COFFEE_SHOP_MANAGER.DAO;
using System.Data.Entity;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabBeverage : UserControl
    {
        public tabBeverage()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
            grdCtrlThucUong.DataSource = BeverageDAO.getList();
        }

        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            BeverageFrm form = new BeverageFrm();
            form.ShowDialog();
            
        }
    }
}
