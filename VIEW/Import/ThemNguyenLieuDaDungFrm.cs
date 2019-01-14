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

namespace COFFEE_SHOP_MANAGER.VIEW.Import
{
    public partial class ThemNguyenLieuDaDungFrm : MaterialSkin.Controls.MaterialForm
    {
        private int fragCheck = 0;
        private List<chitietnguyenlieudadung> list = new List<chitietnguyenlieudadung>();
        private nguyenlieudadung nguyenlieudadung;
        private chitietnguyenlieudadung chitietnguyenlieudadung;
        int flag = 1;
        public ThemNguyenLieuDaDungFrm()
        {
            InitializeComponent();
            dateEdit.Value = DateTime.Now;
            labelTenNguyenLieu.Visible = false;
            labelDinhLuong.Visible = false;

        }

        private void ThemNguyenLieuDaDungFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tabImport.tennldd.Count; i++)
                cbTenNguyenLieu.Items.Add(tabImport.tennldd[i]);
            tabImport.tennldd.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                nguyenlieudadung = new nguyenlieudadung();
                nguyenlieudadung.ngaynhap = Convert.ToDateTime(dateEdit.Value);
                NguyenLieuDaDungDAO.insert(nguyenlieudadung);
                flag = 0;
            }
            checkInput();
            if (fragCheck == 1)
            {
                int i = cbTenNguyenLieu.SelectedIndex;
                chitietnguyenlieudadung = new chitietnguyenlieudadung();
                chitietnguyenlieudadung.dinhluong = Double.Parse(txtDinhLuong.Text);
                chitietnguyenlieudadung.idkhonguyenlieu = tabImport.idnldd[i];
                chitietnguyenlieudadung.idnguyenlieudadung = nguyenlieudadung.idnguyenlieudadung;
               
                if (ChiTietNguyenLieuDaDungDAO.insert(chitietnguyenlieudadung))
                {
                    cbTenNguyenLieu.Items.Remove(cbTenNguyenLieu.Text);
                    tabImport.idnldd.RemoveAt(i);
     
                    txtDinhLuong.Clear();
                    cbTenNguyenLieu.SelectedIndex = -1;
                    
                    XtraMessageBox.Show(this, "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                cbTenNguyenLieu.Refresh();
            }
            else
            {

            }
            fragCheck = 0;
        }

        private void checkInput()
        {
            if (string.IsNullOrEmpty(cbTenNguyenLieu.Text))
            {
                labelTenNguyenLieu.Visible = true;
            }
            if (!string.IsNullOrEmpty(cbTenNguyenLieu.Text))
            {
                labelTenNguyenLieu.Visible = false;
            }
            if (string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                labelDinhLuong.Visible = true;
            }
            if (!string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                labelDinhLuong.Visible = false;
            }
            if(!string.IsNullOrEmpty(cbTenNguyenLieu.Text) && !string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                fragCheck = 1;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tabImport.tennldd.Clear();
            tabImport.idnldd.Clear();
            this.Close();
        }

        private void cbTenNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbTenNguyenLieu.SelectedIndex;
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

        private void txtDinhLuong_Click(object sender, EventArgs e)
        {
            labelDinhLuong.Visible = false;
        }

        private void cbTenNguyenLieu_Click(object sender, EventArgs e)
        {
            labelTenNguyenLieu.Visible = false;
        }


    }
}
