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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenThucUong.Text))
            {
                XtraMessageBox.Show(this, "Tên thức uống không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float temp;
            
            if (!float.TryParse(txtGiaBan.Text,out temp))
            {
                XtraMessageBox.Show(this, "Giá bán phải là số thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else
            {
                if(temp <= 0)
                {
                    XtraMessageBox.Show(this, "Giá bán phải là số dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if(thucuong != null)
            {
                update();
            } else
            {
                insert();
            }          
            flyoutPanel1.ShowBeakForm();
        }

        private void update()
        {
            thucuong.tenthucuong = txtTenThucUong.Text;
            thucuong.giaban = decimal.Parse(txtGiaBan.Text);
            thucuong.id_nhomthucuong = Int32.Parse(cbbNhomThucUong.SelectedValue.ToString());
            if (BeverageDAO.update(thucuong))
            {
                lbMessage.Text = "Lưu thành công";

            }
            else
            {
                lbMessage.Text = "Lưu thất bại";
            }
        }

        private void insert()
        {
            thucuong thucuong = new thucuong();
            thucuong.tenthucuong = txtTenThucUong.Text;
            thucuong.giaban = decimal.Parse(txtGiaBan.Text);
            thucuong.id_nhomthucuong = Int32.Parse(cbbNhomThucUong.SelectedValue.ToString());
            if (BeverageDAO.insert(thucuong))
            {
                lbMessage.Text = "Lưu thành công";

            }
            else
            {
                lbMessage.Text = "Lưu thất bại";
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
    }
}
