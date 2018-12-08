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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using COFFEE_SHOP_MANAGER.VIEW.Discount;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabBeverage : UserControl
    {
        private thucuong thucuong;
        public tabBeverage()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
            loadtable();
        }

        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            BeverageFrm form = new BeverageFrm();
            form.FormClosing += BeverageFrm_Closing;
            form.ShowDialog();          
        }

        private void BeverageFrm_Closing(object sender, FormClosingEventArgs e)
        {
            loadtable();
        }
        private void loadtable()
        {
            grdCtrlThucUong.DataSource = BeverageDAO.getList();
        }

        private void btnNhomThucUong_Click(object sender, EventArgs e)
        {
            GroupBeverage frm = new GroupBeverage();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                GridView gridview = grdCtrlThucUong.FocusedView as GridView;
                thucuong = gridview.GetRow(gridview.FocusedRowHandle) as thucuong;
                if (BeverageDAO.delete(thucuong))
                {
                    lbMessage.Text = "Bạn xóa thành công!";
                    loadtable();
                }
                else
                {
                    lbMessage.Text = "Bạn xóa thất bại!";
                }
                flyoutPanel1.ShowBeakForm();
            }           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrlThucUong.FocusedView as GridView;
            thucuong = gridview.GetRow(gridview.FocusedRowHandle) as thucuong;
            BeverageFrm form = new BeverageFrm(thucuong);
            form.FormClosing += BeverageFrm_Closing;
            form.ShowDialog();
        }

        private void btnCongThuc_Click(object sender, EventArgs e)
        {

        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            DiscountFrm x = new DiscountFrm();
            x.ShowDialog();
        }
    }
}
