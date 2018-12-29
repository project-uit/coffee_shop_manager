using COFFEE_SHOP_MANAGER.DAO;
using COFFEE_SHOP_MANAGER.VIEW.MessageBox;
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

namespace COFFEE_SHOP_MANAGER.VIEW.Staff
{
    public partial class AddStaffFrm : MaterialSkin.Controls.MaterialForm
    {
       public AddStaffFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateForm())
                return;

            StaffDAO staffDAO = new StaffDAO();

            int quyen = 0;
            if (rdbQuanLy.Checked)
                quyen = 1;
            else
                quyen = 0;

            nhanvien staff = new nhanvien
            {
                hoten = txtHoTen.Text,
                ngaysinh = DateTime.Parse(txtNgaySinh.EditValue.ToString()),
                cmnd = txtCMND.Text,
                diachi = txtDiaChi.Text,
                luong = Int32.Parse(txtLuong.Text),
                tentaikhoan = txtTenTaiKhoan.Text,
                matkhau = txtMatKhauComfirm.Text,
                quyen = quyen
            };


            Boolean addStaff = staffDAO.addStaff(staff);
            if(addStaff)
            {
                XtraMessageBox.Show(this, "Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                XtraMessageBox.Show(this, "Thêm nhân viên mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean validateForm()
        {
            if (txtHoTen.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "Họ tên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgaySinh.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "Ngày sinh không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCMND.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "CMND không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "Địa chỉ không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLuong.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "Lương không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "Tên tài khoản không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMatKhauComfirm.Text.Trim() == "")
            {
                XtraMessageBox.Show(this, "Mật khẩu không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMatKhauComfirm.Text.Trim() != txtMatKhau.Text.Trim())
            {
                XtraMessageBox.Show(this, "Xác nhân mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
