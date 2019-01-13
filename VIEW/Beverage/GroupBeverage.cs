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
                lbErrorTenNhomThucUong.Text = "*Tên thức uống không được trống";
                lbErrorTenNhomThucUong.Visible = true;
                return;
            }
            if (flag_sua)
            {
                nhomthucuong.tennhomthucuong = txtTenThucUong.Text;
                
                flag_sua = false;
                if (GroupBeverageDAO.update(nhomthucuong))
                {
                    loadTable();
                    XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                nhomthucuong = new nhomthucuong();
                nhomthucuong.tennhomthucuong = txtTenThucUong.Text;
                if (GroupBeverageDAO.insert(nhomthucuong))
                {
                    loadTable();
                    txtTenThucUong.Clear();
                    XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lbErrorTenNhomThucUong.Visible = false;
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                GridView gridview = grdCtrNhomThucUong.FocusedView as GridView;
                nhomthucuong = gridview.GetRow(gridview.FocusedRowHandle) as nhomthucuong;
                if (GroupBeverageDAO.delete(nhomthucuong))
                {
                    loadTable();
                    nhomthucuong = null;
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrNhomThucUong.FocusedView as GridView;
            nhomthucuong = gridview.GetRow(gridview.FocusedRowHandle) as nhomthucuong;
            flag_sua = !flag_sua;
            txtTenThucUong.Text = nhomthucuong.tennhomthucuong;
            lbErrorTenNhomThucUong.Visible = false;
        }

        private void txtTenThucUong_Click(object sender, EventArgs e)
        {
            lbErrorTenNhomThucUong.Visible = false;
        }
    }
}
