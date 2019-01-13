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
using DevExpress.XtraGrid.Views.Grid;

namespace COFFEE_SHOP_MANAGER.VIEW.Beverage
{
    public partial class FormulaFrm : MaterialSkin.Controls.MaterialForm
    {
        private int id_thucuong;
        public FormulaFrm()
        {
            InitializeComponent();
        }
        public FormulaFrm(int id_thucuong, string tenthucuong)
        {
            InitializeComponent();
            this.id_thucuong = id_thucuong;
            this.Text = "Lập công thức cho " + tenthucuong;
        }

        private void FormulaFrm_Load(object sender, EventArgs e)
        {
            loadtable();
            cbbNguyenLieu.DataSource = FormulaDAO.GetKhonguyenlieus();
            cbbNguyenLieu.ValueMember = "idkhonguyenlieu";
            cbbNguyenLieu.DisplayMember = "tennguyenlieu";
        }
        private void loadtable()
        {
            grdCtrCongThuc.DataSource = FormulaDAO.loadFormulaByIdThucUong(id_thucuong);
        }

        private bool isValid()
        {
            bool isValid = true;
            double dinhluong;
            if (string.IsNullOrEmpty(txtDinhLuong.Text))
            {
                lbErrorDinhLuong.Text = "*Định lượng không được trống";
                isValid = false;
                lbErrorDinhLuong.Visible = true;
            }
            if (double.TryParse(txtDinhLuong.Text, out dinhluong))
            {
                if (dinhluong <= 0)
                {
                    lbErrorDinhLuong.Text = "*Định lượng phải nhập số thực lớn hơn 0";
                    isValid = false;
                    lbErrorDinhLuong.Visible = true;
                }
            }
            else
            {
                lbErrorDinhLuong.Text = "*Định lượng phải nhập số thực lớn hơn 0";
                isValid = false;
                lbErrorDinhLuong.Visible = true;
            }
            return isValid;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                chitietcongthuc chitietcongthuc = new chitietcongthuc();
                chitietcongthuc.idkhonguyenlieu = Int32.Parse(cbbNguyenLieu.SelectedValue.ToString());
                chitietcongthuc.dinhluong = Math.Round(double.Parse(txtDinhLuong.Text), 3, MidpointRounding.AwayFromZero);
                chitietcongthuc.id_thucuong = this.id_thucuong;
                if (FormulaDAO.isExist(chitietcongthuc.id_thucuong, chitietcongthuc.idkhonguyenlieu))
                {
                    XtraMessageBox.Show(this, "Đã tồn tại nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (FormulaDAO.insert(chitietcongthuc))
                {
                    XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDinhLuong.Clear();
                    loadtable();
                }
                else
                {
                    XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrCongThuc.FocusedView as GridView;
            chitietcongthuc chitietcongthuc = gridview.GetRow(gridview.FocusedRowHandle) as chitietcongthuc;
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (FormulaDAO.delete(chitietcongthuc))
                {
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadtable();
                }
                else
                {
                    XtraMessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDinhLuong_Click(object sender, EventArgs e)
        {
            lbErrorDinhLuong.Visible = false;
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
    }
}
