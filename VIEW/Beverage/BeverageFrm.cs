using COFFEE_SHOP_MANAGER.DAO;
using DevExpress.XtraEditors;
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
        private thucuong thucuong;
        public BeverageFrm(thucuong thucuong)
        {
            InitializeComponent();
            this.thucuong = thucuong;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isValid()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtTenThucUong.Text))
            {
                lbErrorTenThucUong.Text = "*Tên thức uống không được trống";
                isValid = false;
                lbErrorTenThucUong.Visible = true;
            }
            float temp;
            if (float.TryParse(txtGiaBan.Text, out temp))
            {
             if(temp <= 0)
                {
                    lbErrorGiaBan.Text = "*Giá bán phải là số thực lớn hơn  0";
                    isValid = false;
                    lbErrorGiaBan.Visible = true;
                }
            } else
            {
                lbErrorGiaBan.Text = "*Giá bán phải là số thực lớn hơn 0";
                isValid = false;
                lbErrorGiaBan.Visible = true;
            }
          
            return isValid;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (thucuong != null)
                {
                    update();
                }
                else
                {
                    insert();
                }
            }
        }

        private void update()
        {
            thucuong.tenthucuong = txtTenThucUong.Text;
            thucuong.giaban = Math.Round(decimal.Parse(txtGiaBan.Text), 3, MidpointRounding.AwayFromZero);
            thucuong.id_nhomthucuong = Int32.Parse(cbbNhomThucUong.SelectedValue.ToString());
            if (BeverageDAO.update(thucuong))
            {
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insert()
        {
            thucuong thucuong = new thucuong();
            thucuong.tenthucuong = txtTenThucUong.Text;
            thucuong.giaban =  Math.Round(decimal.Parse(txtGiaBan.Text), 3, MidpointRounding.AwayFromZero);
            thucuong.id_nhomthucuong = Int32.Parse(cbbNhomThucUong.SelectedValue.ToString());
            if (BeverageDAO.insert(thucuong))
            {
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BeverageFrm_Load(object sender, EventArgs e)
        {
            cbbNhomThucUong.DataSource = GroupBeverageDAO.getIList();
            cbbNhomThucUong.ValueMember = "id_nhomthucuong";
            cbbNhomThucUong.DisplayMember = "tennhomthucuong";
            cbbNhomThucUong.SelectionStart = 0;
            if(thucuong != null)
            {
                txtTenThucUong.Text = thucuong.tenthucuong;
                txtGiaBan.Text = thucuong.giaban+"";
                cbbNhomThucUong.SelectedValue = thucuong.id_nhomthucuong;
            }
        }

        private void txtTenThucUong_Click(object sender, EventArgs e)
        {
            lbErrorTenThucUong.Visible = false;
        }

        private void txtGiaBan_Click(object sender, EventArgs e)
        {
            lbErrorGiaBan.Visible = false;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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
