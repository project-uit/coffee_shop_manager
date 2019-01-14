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

namespace COFFEE_SHOP_MANAGER.VIEW.Import
{

    public partial class ThemNguyenLieuFrm : MaterialSkin.Controls.MaterialForm
    {
        private int fragCheck = 0; // flag check nay la gi? kiem tra nhap vao thoi , rkoic okj
        private khonguyenlieu khonguyenlieu;
        // constructor de them
        public ThemNguyenLieuFrm()
        {
            InitializeComponent();
            labelTenNguyenLieu.Visible = false;
            labelDinhLuong.Visible = false;
            labelTenDonViDinhLuong.Visible = false;
            txtDinhLuong.Enabled = true;
        }
        // constructor de sua
        public ThemNguyenLieuFrm(khonguyenlieu khonguyenlieu)
        {
            InitializeComponent();
            labelTenNguyenLieu.Visible = false;
            labelDinhLuong.Visible = false;
            labelTenDonViDinhLuong.Visible = false;
            this.khonguyenlieu = khonguyenlieu;
            //load du lieu len de sua
            txtTenNguyenLieu.Text = khonguyenlieu.tennguyenlieu;
            txtDinhLuong.Text = khonguyenlieu.dinhluong+"";
            string tendv = khonguyenlieu.tendonvi_dinh_luong.Trim();
            txtDinhLuongMax.Text = khonguyenlieu.dinh_luong_toi_da + "";
            txtDinhLuongMin.Text = khonguyenlieu.dinh_luong_toi_thieu + "";
            txtDinhLuong.Enabled = false;
            switch(tendv)
            {
                case "gam":
                    cbTenDonViDinhLuong.SelectedIndex = 0;
                    break;
                case "mililit":
                    cbTenDonViDinhLuong.SelectedIndex = 1;
                    break;
                case "lit":
                    cbTenDonViDinhLuong.SelectedIndex = 2;
                    break;
                case "kilogam":
                    cbTenDonViDinhLuong.SelectedIndex = 3;
                    break;

            }
           
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            checkInput();
            if (fragCheck == 1)
            {
               
                if (khonguyenlieu != null)
                {
                    // sua thi ko can new
                    khonguyenlieu.tennguyenlieu = txtTenNguyenLieu.Text;
                    khonguyenlieu.dinhluong = double.Parse(txtDinhLuong.Text);
                    khonguyenlieu.tendonvi_dinh_luong = cbTenDonViDinhLuong.Text;
                    khonguyenlieu.dinh_luong_toi_da = double.Parse(txtDinhLuongMax.Text);
                    khonguyenlieu.dinh_luong_toi_thieu = double.Parse(txtDinhLuongMin.Text);
                    if (khonguyenlieu.dinh_luong_toi_thieu >= khonguyenlieu.dinh_luong_toi_da)
                    {
                        XtraMessageBox.Show(this, "Định lượng tối thiểu phải nhỏ hơn định lượng tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //sua
                    if (ThemNguyenLieuDAO.update(khonguyenlieu))
                    {
                        XtraMessageBox.Show(this, "Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);// dm xai cai infor, 
                    }
                }
                else
                {
                    //them moi thi new object
                    khonguyenlieu = new khonguyenlieu();
                    khonguyenlieu.tennguyenlieu = txtTenNguyenLieu.Text;
                    khonguyenlieu.dinhluong = double.Parse(txtDinhLuong.Text);
                    khonguyenlieu.tendonvi_dinh_luong = cbTenDonViDinhLuong.Text;
                    khonguyenlieu.dinh_luong_toi_da = double.Parse(txtDinhLuongMax.Text);
                    khonguyenlieu.dinh_luong_toi_thieu = double.Parse(txtDinhLuongMin.Text);
                    if(khonguyenlieu.dinh_luong_toi_thieu >= khonguyenlieu.dinh_luong_toi_da)
                    {
                        XtraMessageBox.Show(this, "Định lượng tối thiểu phải nhỏ hơn định lượng tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //them
                    if (ThemNguyenLieuDAO.insert(khonguyenlieu))
                    {
                        txtTenNguyenLieu.Clear();
                        txtDinhLuong.Clear();
                        txtDinhLuongMax.Clear();
                        txtDinhLuongMin.Clear();
                        cbTenDonViDinhLuong.SelectedIndex = -1;
                        khonguyenlieu = null;
                        XtraMessageBox.Show(this, "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
              
            }
            else
            {

            }
            fragCheck = 0;
        }

        

        private void checkInput()
        {
            if (string.IsNullOrEmpty(txtTenNguyenLieu.Text))
            {
                labelTenNguyenLieu.Visible = true;
              
            }
            if (string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                labelDinhLuong.Visible = true;
                
            }
            if (string.IsNullOrEmpty(cbTenDonViDinhLuong.Text))
            {
                labelTenDonViDinhLuong.Visible = true;
                
            }
            if (string.IsNullOrEmpty(txtDinhLuongMax.Text))
            {
                label2.Visible = true;
            }
            if (string.IsNullOrEmpty(txtDinhLuongMin.Text))
            {
                label1.Visible = true;
            }
            if (!string.IsNullOrEmpty(txtTenNguyenLieu.Text))
            {
                labelTenNguyenLieu.Visible = false;
               
            }
            if (!string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                labelDinhLuong.Visible = false;
               
            }
            if (!string.IsNullOrEmpty(cbTenDonViDinhLuong.Text))
            {
                labelTenDonViDinhLuong.Visible = false;            
            }
            if (!string.IsNullOrEmpty(txtDinhLuongMax.Text))
            {
                label2.Visible = false;
            }
            if (!string.IsNullOrEmpty(txtDinhLuongMin.Text))
            {
                label1.Visible = false;
            }

            if (!string.IsNullOrEmpty(txtTenNguyenLieu.Text) 
                && !string.IsNullOrEmpty(txtDinhLuong.Text) 
                && !string.IsNullOrEmpty(cbTenDonViDinhLuong.Text)
                && !string.IsNullOrEmpty(txtDinhLuongMin.Text)
                && !string.IsNullOrEmpty(txtDinhLuongMax.Text))
            {
                fragCheck = 1;
            }
           
          
        }

        private void txtTenNguyenLieu_Click(object sender, EventArgs e)
        {
            labelTenNguyenLieu.Visible = false;
        }

        private void txtDinhLuong_Click(object sender, EventArgs e)
        {
            labelDinhLuong.Visible = false;
        }
        private void cbTenDonViDinhLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTenDonViDinhLuong.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDinhLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbTenDonViDinhLuong_Click(object sender, EventArgs e)
        {
            labelTenDonViDinhLuong.Visible = false;
        }

        private void txtDinhLuongMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDinhLuongMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDinhLuongMin_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void txtDinhLuongMax_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
