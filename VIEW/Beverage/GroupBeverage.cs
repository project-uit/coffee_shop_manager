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
using System.Data.Entity;
using COFFEE_SHOP_MANAGER.VIEW.MessageBox;

namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    public partial class GroupBeverage : MaterialSkin.Controls.MaterialForm
    {
        public GroupBeverage()
        {
            InitializeComponent();
        }

        private void GroupBeverage_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            grdCtrNhomThucUong.DataSource = GroupBeverageDAO.getList();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhomthucuong nhomthucuong = new nhomthucuong();
            nhomthucuong.tennhomthucuong = txtTenThucUong.Text;
            GroupBeverageDAO.insert(nhomthucuong);
            loadTable();
            MessageBoxMaterial.Show("Lưu thành công", "Thông báo", MessageBoxButtons.YesNo);
        }
    }
}
