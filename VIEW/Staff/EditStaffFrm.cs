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
            txtNgaySinh.EditValue = editstaff.ngaysinh;
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
                ngaysinh = DateTime.Parse(txtNgaySinh.EditValue.ToString()),
                cmnd = txtCMND.Text,
                diachi = txtDiaChi.Text,
                luong = Int32.Parse(txtLuong.Text.ToString()),
                tentaikhoan = txtTenTaiKhoan.Text,
                matkhau = txtMatKhau.Text,
                quyen = quyen
            };


            Boolean addStaff = staffDAO.editStaff(staff);
            if (addStaff)
            {
                XtraMessageBox.Show(this, "Cập nhập nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, "Cập nhập nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtMatKhau.Text.Trim() == "")
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
