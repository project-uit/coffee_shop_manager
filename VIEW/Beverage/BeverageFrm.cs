using COFFEE_SHOP_MANAGER.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    public partial class BeverageFrm : MaterialSkin.Controls.MaterialForm
    {
        public BeverageFrm()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            thucuong thucuong = new thucuong();
            BeverageDAO.insert(thucuong);
        }
    }
}
