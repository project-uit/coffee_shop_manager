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
    public partial class AddStaffFrm : MaterialSkin.Controls.MaterialForm
    {
       public AddStaffFrm()
        {
            InitializeComponent();
        }

        private void AddStaffFrm_Load(object sender, EventArgs e)
        {
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
                hoten = txtHoTen.Text,
                ngaysinh = DateTime.Parse(txtNgaySinh.EditValue.ToString()),
                cmnd = txtCMND.Text,
                diachi = txtDiaChi.Text,
                luong = decimal.Parse(txtLuong.Text),
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
