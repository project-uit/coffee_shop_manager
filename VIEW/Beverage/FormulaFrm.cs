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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            chitietcongthuc chitietcongthuc = new chitietcongthuc();
            chitietcongthuc.idkhonguyenlieu = Int32.Parse(cbbNguyenLieu.SelectedValue.ToString());
            if (txtDinhLuong.Text.Contains("."))
            {
                XtraMessageBox.Show(this, "Nhập số thập phân hãy dùng dấu , ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float dinhluong;
            if(float.TryParse(txtDinhLuong.Text, out dinhluong))
            {
                chitietcongthuc.dinhluong = dinhluong;
                chitietcongthuc.id_thucuong = this.id_thucuong;
                if (FormulaDAO.isExist(chitietcongthuc.id_thucuong, chitietcongthuc.idkhonguyenlieu))
                {
                    XtraMessageBox.Show(this, "Đã tồn tại nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                
                if (FormulaDAO.insert(chitietcongthuc))
                {
                    lbMessage.Text = "Lưu thành công";
                    loadtable();
                } else
                {
                    lbMessage.Text = "Lưu thất bại";
                }
                flyoutPanel1.ShowBeakForm();
            } else
            {
                XtraMessageBox.Show(this, "Định lượng phải nhập số thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrCongThuc.FocusedView as GridView;
            chitietcongthuc chitietcongthuc = gridview.GetRow(gridview.FocusedRowHandle) as chitietcongthuc;
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                if (FormulaDAO.delete(chitietcongthuc))
                {
                    lbMessage.Text = "Xóa thành công";
                    loadtable();
                }
                else
                {
                    lbMessage.Text = "Xóa thất bại";
                }
                flyoutPanel1.ShowBeakForm();
            }
        }
    }
}
