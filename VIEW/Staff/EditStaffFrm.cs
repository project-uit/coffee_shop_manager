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

namespace COFFEE_SHOP_MANAGER.VIEW.Staff
{
    public partial class EditStaffFrm : MaterialSkin.Controls.MaterialForm
    {
        public nhanvien editstaff;
        public EditStaffFrm()
        {
            InitializeComponent();
        }

        private void EditStaffFrm_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = editstaff.hoten;
            txtNgaySinh.Value = Convert.ToDateTime(editstaff.ngaysinh);
            txtCMND.Text = editstaff.cmnd;
            txtDiaChi.Text = editstaff.diachi;
            txtLuong.Text = editstaff.luong.ToString("0.##");
            txtTenTaiKhoan.Text = editstaff.tentaikhoan;
            txtMatKhau.Text = editstaff.matkhau;
            txtMatKhauComfirm.Text = editstaff.matkhau;

            switch (editstaff.quyen)
            {
                case 0: rdbNhanVien.Checked = true; break;
                case 1: rdbQuanLy.Checked = true; break;
            }

            errorHoTen.Text = "";
            errorNgaySinh.Text = "";
            errorCMND.Text = "";
            errorDiaChi.Text = "";
            errorLuong.Text = "";
            errorTenTaiKhoan.Text = "";
            errorMatKhau.Text = "";
            errorMatKhauComfirm.Text = "";
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
                id_nhanvien = editstaff.id_nhanvien,
                hoten = txtHoTen.Text,
                ngaysinh = DateTime.Parse(txtNgaySinh.Value.ToString()),
                cmnd = txtCMND.Text,
                diachi = txtDiaChi.Text,
                luong = decimal.Parse(txtLuong.Text.Trim()),
                tentaikhoan = txtTenTaiKhoan.Text.Trim(),
                matkhau = txtMatKhau.Text,
                quyen = quyen
            };


            Boolean addStaff = staffDAO.editStaff(staff);
            if (addStaff)
            {
                XtraMessageBox.Show(this, "Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, "Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean validateForm()
        {
            int countError = 0;

            if (txtHoTen.Text.Trim() == "")
            {
                errorHoTen.Text = "Họ tên không được trống";
                countError++;
            }
            else
            {
                errorHoTen.Text = "";
            }

            if (txtNgaySinh.Text.Trim() == "")
            {
                errorNgaySinh.Text = "Ngày sinh không được trống";
                countError++;
            }
            else
            {
                errorNgaySinh.Text = "";
            }

            if (txtCMND.Text.Trim() == "")
            {
                errorCMND.Text = "CMND không được trống";
                countError++;
            }
            else
            {
                errorCMND.Text = "";
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                errorDiaChi.Text = "Địa chỉ không được trống";
                countError++;
            }
            else
            {
                errorDiaChi.Text = "";
            }

            if (txtLuong.Text.Trim() == "")
            {
                errorLuong.Text = "Lương không được trống";
                countError++;
            }
            else
            {
                errorLuong.Text = "";
            }

            try
            {
                decimal.Parse(txtLuong.Text.ToString().Trim());
            }
            catch
            {
                errorLuong.Text = "Lương không hợp lệ";
                countError++;
            }

            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                errorTenTaiKhoan.Text = "Tên tài khoản không được trống";
                countError++;
            }
            else
            {
                errorTenTaiKhoan.Text = "";
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                errorMatKhau.Text = "Mật khẩu không được trống";
                countError++;
            }
            else
            {
                errorMatKhau.Text = "";
            }

            if (txtMatKhauComfirm.Text.Trim() != txtMatKhau.Text.Trim())
            {
                errorMatKhauComfirm.Text = "Xác nhân mật khẩu không khớp";
                countError++;
            }
            else
            {
                errorMatKhauComfirm.Text = "";
            }

            if (countError != 0)
                return false;

            return true;
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
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
