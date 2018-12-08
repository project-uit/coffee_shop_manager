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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    public partial class GroupBeverage : MaterialSkin.Controls.MaterialForm
    {
        private bool flag_sua = false;
        private nhomthucuong nhomthucuong;
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
            
            if (string.IsNullOrEmpty(txtTenThucUong.Text))
            {
                XtraMessageBox.Show(this, "Tên thức uống không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (flag_sua)
            {
                nhomthucuong.tennhomthucuong = txtTenThucUong.Text;
                
                flag_sua = false;
                if (GroupBeverageDAO.update(nhomthucuong))
                {
                    loadTable();
                    lbMessage.Text = "Lưu thành công!";                   
                } else
                {
                    lbMessage.Text = "Lưu thất bại!";
                }
                flyoutPanel1.ShowBeakForm();

            } else
            {
                nhomthucuong = new nhomthucuong();
                nhomthucuong.tennhomthucuong = txtTenThucUong.Text;
                if (GroupBeverageDAO.insert(nhomthucuong))
                {
                    loadTable();
                    lbMessage.Text = "Lưu thành công!";
                }
                else
                {
                    lbMessage.Text = "Lưu thất bại!";
                }
                flyoutPanel1.ShowBeakForm();
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                GridView gridview = grdCtrNhomThucUong.FocusedView as GridView;
                nhomthucuong = gridview.GetRow(gridview.FocusedRowHandle) as nhomthucuong;
                if (GroupBeverageDAO.delete(nhomthucuong))
                {
                    loadTable();
                    nhomthucuong = null;
                    lbMessage.Text = "Xóa thành công!";
                    flyoutPanel1.ShowBeakForm();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrNhomThucUong.FocusedView as GridView;
            nhomthucuong = gridview.GetRow(gridview.FocusedRowHandle) as nhomthucuong;
            flag_sua = !flag_sua;
            txtTenThucUong.Text = nhomthucuong.tennhomthucuong;
        }
    }
}
