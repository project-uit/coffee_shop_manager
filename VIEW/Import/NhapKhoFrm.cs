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
    public partial class NhapKhoFrm : MaterialSkin.Controls.MaterialForm
    {
        private int fragCheck = 0;
        
        private nhapkho nhapkho;
        private chitietnhapkho chitietnhapkho;
        int flag = 1;

        private List<khonguyenlieu> list = new List<khonguyenlieu>();
        private khonguyenlieu khonguyenlieu;
        public NhapKhoFrm()
        {
            InitializeComponent();
            dateEdit.EditValue = DateTime.Now;
            labelTenNguyenLieu.Visible = false;
            labelsoLuong.Visible = false;
            labelTenDVSoLuong.Visible = false;
            labelDonGia.Visible = false;
            labelDinhLuong.Visible = false;
            labelDinhLuongDonVi.Visible = false;
            

        }






        private void NhapKhoFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tabImport.tennl.Count; i++)
                cbTenNguyenLieu.Items.Add(tabImport.tennl[i]);
            tabImport.tennl.Clear();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            
            if (flag == 1)
            {
                nhapkho = new nhapkho();
                nhapkho.ngaynhap = Convert.ToDateTime(dateEdit.EditValue);
                nhapkho.id_nhanvien = 1;
                NhapKhoDAO.insert(nhapkho);
                flag = 0;
            }


            checkInput();
            if (fragCheck == 1)
            {
                int i = cbTenNguyenLieu.SelectedIndex;
                chitietnhapkho = new chitietnhapkho();
                chitietnhapkho.tendonvi_so_luong = cbTenDonViSoLuong.Text;
                chitietnhapkho.soluong = int.Parse(txtSoLuong.Text);
                string tendl = tabImport.tendl[i].ToString().Trim();
                if (tendl == "gam" || tendl == "mililit")
                {
                    if (Double.Parse(txtSoLuong.Text) != 0)
                    {
                        chitietnhapkho.dinhluong = (Double.Parse(txtDinhLuong.Text)) * Double.Parse(txtDinhLuongDonVi.Text) * Double.Parse(txtSoLuong.Text);
                       
                    }
                    if (Double.Parse(txtSoLuong.Text) == 0)
                        chitietnhapkho.dinhluong = (Double.Parse(txtDinhLuong.Text)) * Double.Parse(txtDinhLuongDonVi.Text);
                }
                if (tendl == "kilogam" || tendl == "lit")

                {
                    if (Double.Parse(txtSoLuong.Text) != 0)
                        chitietnhapkho.dinhluong = 1000 * (Double.Parse(txtDinhLuong.Text)) * Double.Parse(txtDinhLuongDonVi.Text) * Double.Parse(txtSoLuong.Text);
                    if (Double.Parse(txtSoLuong.Text) == 0)
                        chitietnhapkho.dinhluong = 1000 * (Double.Parse(txtDinhLuong.Text)) * Double.Parse(txtDinhLuongDonVi.Text);
                }
                //chitietnhapkho.dinhluong = tabImport.dl[i];
                chitietnhapkho.dongia = int.Parse(txtDonGia.Text);
                chitietnhapkho.idnhapkho = nhapkho.idnhapkho;
                chitietnhapkho.idkhonguyenlieu = tabImport.idnl[i];
                if (ChiTietNhapKhoDAO.insert(chitietnhapkho))
                {
                    ThemNguyenLieuDAO.UpdateDinhLuong(chitietnhapkho.idkhonguyenlieu, chitietnhapkho.dinhluong);
                    cbTenNguyenLieu.Items.Remove(cbTenNguyenLieu.Text);
                    tabImport.idnl.RemoveAt(i);
                    tabImport.tendl.RemoveAt(i);
                    //tabImport.dl.RemoveAt(i);
                    txtSoLuong.Clear();
                    cbTenDonViSoLuong.SelectedIndex = -1;
                    txtDinhLuong.Clear();
                    txtDonGia.Clear();
                    txtDinhLuong.Clear();
                    txtDinhLuongDonVi.Clear();
                    XtraMessageBox.Show(this, "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                cbTenNguyenLieu.Refresh();
            }
            else
            {

            }
            fragCheck = 0;

        }

        private void cbTenNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbTenNguyenLieu.SelectedIndex;
            //txtDinhLuong.Text = (tabImport.dl[i]).ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tabImport.tennl.Clear();
            tabImport.idnl.Clear();
            tabImport.tendl.Clear();
            //tabImport.dl.Clear();
            this.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbTenNguyenLieu_Click(object sender, EventArgs e)
        {
            labelTenNguyenLieu.Visible = false;
          
        }

        private void txtSoLuong_Click(object sender, EventArgs e)
        {
            labelsoLuong.Visible = false;
            
        }

        private void cbTenDonViSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            labelTenDVSoLuong.Visible = false;
        }

        private void txtDonGia_Click(object sender, EventArgs e)
        {
          
            labelDonGia.Visible = false;
        }
        private void checkInput()
        {
            if (string.IsNullOrEmpty(cbTenNguyenLieu.Text))
            {
                labelTenNguyenLieu.Visible = true;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                labelsoLuong.Visible = true;
            }
            if (string.IsNullOrEmpty(cbTenDonViSoLuong.Text))
            {
                labelTenDVSoLuong.Visible = true;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                labelDonGia.Visible = true;
            }
            if (string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                labelDinhLuong.Visible = true;
            }
            if (string.IsNullOrEmpty(txtDinhLuongDonVi.Text))
            {
                labelDinhLuongDonVi.Visible = true;
            }
            if (!string.IsNullOrEmpty(cbTenNguyenLieu.Text))
            {
                labelTenNguyenLieu.Visible = false;
            }
            if (!string.IsNullOrEmpty(txtSoLuong.Text))
            {
                labelsoLuong.Visible = false;
            }
            if (!string.IsNullOrEmpty(cbTenDonViSoLuong.Text))
            {
                labelTenDVSoLuong.Visible = false;
            }
            if (!string.IsNullOrEmpty(txtDonGia.Text))
            {
                labelDonGia.Visible = false;
            }
            if (!string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                labelDinhLuong.Visible = false;
            }
            if (!string.IsNullOrEmpty(txtDinhLuongDonVi.Text))
            {
                labelDinhLuongDonVi.Visible = false;
            }
            if (!string.IsNullOrEmpty(cbTenNguyenLieu.Text) && !string.IsNullOrEmpty(txtSoLuong.Text) && !string.IsNullOrEmpty(cbTenDonViSoLuong.Text) 
                && !string.IsNullOrEmpty(txtDonGia.Text) && !string.IsNullOrEmpty(txtDinhLuong.Text) && !string.IsNullOrEmpty(txtDinhLuongDonVi.Text))
            {
                fragCheck = 1;
            }
        }

        private void txtDinhLuong_Click(object sender, EventArgs e)
        {
            labelDinhLuong.Visible = false;
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

        private void txtDinhLuongDonVi_Click(object sender, EventArgs e)
        {
            labelDinhLuongDonVi.Visible = false;
        }

        private void txtDinhLuongDonVi_KeyPress(object sender, KeyPressEventArgs e)
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
