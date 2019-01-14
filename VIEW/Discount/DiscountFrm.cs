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
        private bool isValid()
        {
            bool isValid = true;
            float hesogiamgia;
            if (float.TryParse(txtGiamGia.Text, out hesogiamgia))
            {
                if (!(hesogiamgia <= 100 && hesogiamgia >= 0))
                {
                    lbErrorGiamGia.Text = "*Phần trăm giảm giá số thực thuộc [0,100]";
                    isValid = false;
                    lbErrorGiamGia.Visible = true;
                }
            } else
            {
                lbErrorGiamGia.Text = "*Phần trăm giảm giá không được trống";
                isValid = false;
                lbErrorGiamGia.Visible = true;
            }
            bool flag = true;
            if(dateNgayBatDau.Value == null)
            {
                lbErrorDate.Text = "*Ngày bắt đầu không được trống";
                flag = false;
                lbErrorDate.Visible = true;
            }
            if (dateNgayKetThuc.Value == null)
            {
                lbErrorNgayKetThuc.Text = "*Ngày kết thúc không được trống";
                flag = false;
                lbErrorNgayKetThuc.Visible = true;
            }
            if (flag)
            {
                giamgia giamgia = new giamgia();
                giamgia.ngaybatdau = Convert.ToDateTime(dateNgayBatDau.Value);
                giamgia.ngayketthuc = Convert.ToDateTime(dateNgayKetThuc.Value);
                switch (DiscountDAO.isValid(giamgia))
                {
                    case 2:
                        lbErrorDate.Text = "*Ngày bắt đầu phải nhỏ hơn ngày kết thúc";
                        isValid = false;
                        lbErrorDate.Visible = true;
                        break;
                    case 3:
                        lbErrorDate.Text = "*Ngày bắt đầu phải lớn hơn ngày hiện tại";
                        isValid = false;
                        lbErrorDate.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            return isValid && flag;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isValid())
            {              
                giamgia giamgia = new giamgia();                
                giamgia.hesogiamgia = Math.Round(float.Parse(txtGiamGia.Text), 2, MidpointRounding.AwayFromZero);
                giamgia.ngaybatdau = Convert.ToDateTime(dateNgayBatDau.Value);
                giamgia.ngayketthuc = Convert.ToDateTime(dateNgayKetThuc.Value);
                if (DiscountDAO.isAccepted(giamgia))
                {
                    if (DiscountDAO.insert(giamgia))
                    {
                        XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadtable();
                    } else
                    {
                        XtraMessageBox.Show(this, "Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    XtraMessageBox.Show(this, "Bạn không thể thêm đợt khuyến mãi có cùng thời gian đợt khuyến mãi hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrGiamGia.FocusedView as GridView;
            giamgia giamgia = gridview.GetRow(gridview.FocusedRowHandle) as giamgia;
            if (DiscountDAO.delete(giamgia))
            {
                XtraMessageBox.Show(this, "Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadtable();
            } else
            {
                XtraMessageBox.Show(this, "Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGiamGia_Click(object sender, EventArgs e)
        {
            lbErrorGiamGia.Visible = false;
        }

        private void dateNgayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            lbErrorDate.Visible = false;
        }

        private void dateNgayKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            lbErrorNgayKetThuc.Visible = false;
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
