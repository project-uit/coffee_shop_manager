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

namespace COFFEE_SHOP_MANAGER.VIEW.Setting
{
    public partial class SettingFrm : MaterialSkin.Controls.MaterialForm
    {
        public SettingFrm()
        {
            InitializeComponent();
        }

        private void SettingFrm_Load(object sender, EventArgs e)
        {
            cuahang cuahang = StoreInfoDAO.getInfo();
            txtName.Text = cuahang.ten;
            txtAddress.Text = cuahang.diachi;
            txtPhone.Text = cuahang.dienthoai;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateFields())
                return;

            cuahang cuahang = new cuahang { idcuahang = 1,  ten = txtName.Text, diachi = txtAddress.Text, dienthoai = txtPhone.Text };
            if (StoreInfoDAO.edit(cuahang))
            {
                XtraMessageBox.Show(this, "Cập nhập thông tin cửa hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, "Cập nhập thông tin cửa hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean validateFields()
        {
            int countError = 0;
            if (txtName.Text.Trim() == "")
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = "Tên không được trống";
                countError++;
            }
            else
            {
                lbErrorAddress.Visible = false;
            }

            if (txtAddress.Text.Trim() == "")
            {
                lbErrorAddress.Visible = true;
                lbErrorAddress.Text = "Địa chỉ không được trống";
                countError++;
            }
            else
            {
                lbErrorAddress.Visible = false;
            }

            if (txtPhone.Text.Trim() == "")
            {
                lbErrorPhone.Visible = true;
                lbErrorPhone.Text = "Số điện thoại không được trống";
                countError++;
            }
            else
            {
                lbErrorPhone.Visible = false;
            }

            if (countError != 0)
                return false;

            return true;
        }
    }
}
