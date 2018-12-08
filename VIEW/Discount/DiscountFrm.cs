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
using COFFEE_SHOP_MANAGER.DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace COFFEE_SHOP_MANAGER.VIEW.Discount
{
    public partial class DiscountFrm : MaterialSkin.Controls.MaterialForm
    {
        public DiscountFrm()
        {
            InitializeComponent();
           
        }

        private void DiscountFrm_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void loadtable()
        {
            grdCtrGiamGia.DataSource = DiscountDAO.getList();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int hesogiamgia;
            if (int.TryParse(txtGiamGia.Text, out hesogiamgia))
            {
                if(!(hesogiamgia <= 100 && hesogiamgia >= 0))
                {
                    XtraMessageBox.Show(this, "Phần trăm giảm giá phải từ 0 -> 100!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                giamgia giamgia = new giamgia();
                giamgia.hesogiamgia = hesogiamgia;
                giamgia.ngaybatdau = Convert.ToDateTime(dateNgayBatDau.EditValue);
                giamgia.ngayketthuc = Convert.ToDateTime(dateNgayKetThuc.EditValue);
                switch (DiscountDAO.isValid(giamgia))
                {
                    case 2:
                        XtraMessageBox.Show(this, "Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case 3:
                        XtraMessageBox.Show(this, "Ngày bắt đầu phải lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    default:
                        break;
                }
                if (DiscountDAO.isAccepted(giamgia))
                {
                    if (DiscountDAO.insert(giamgia))
                    {
                        lbMessage.Text = "Lưu thành công!";
                        loadtable();
                    } else
                    {
                        lbMessage.Text = "Lưu thất bại!";
                    }
                    flyoutPanel1.ShowBeakForm();
                } else
                {
                    XtraMessageBox.Show(this, "Bạn không thể thêm đợt khuyến mãi có cùng thời gian đợt khuyến mãi hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                XtraMessageBox.Show(this, "Phần trăm giảm giá phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }     
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrGiamGia.FocusedView as GridView;
            giamgia giamgia = gridview.GetRow(gridview.FocusedRowHandle) as giamgia;
            if (DiscountDAO.delete(giamgia))
            {
                lbMessage.Text = "Xóa thành công!";
                loadtable();
            } else
            {
                lbMessage.Text = "Xóa thất bại!";
            }
            flyoutPanel1.ShowBeakForm();
        }
    }
}
