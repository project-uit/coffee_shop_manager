using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEE_SHOP_MANAGER.VIEW.Import;
using COFFEE_SHOP_MANAGER.DAO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace COFFEE_SHOP_MANAGER
{


    public partial class tabImport : UserControl
    {
        //nhap kho
        public static List<string> tennl = new List<string>();
        public static List<int> idnl = new List<int>();
        public static List<int> idnldd = new List<int>();
       // public static List<double> dl = new List<double>();
        // da dung
        public static List<string> tendl = new List<string>();
        public static List<string> tennldd = new List<string>();
        private List<khonguyenlieu> list = new List<khonguyenlieu>();
        private khonguyenlieu khonguyenlieu;
        public nhanvien loggedstaff = new nhanvien();

        public tabImport()
        {
            InitializeComponent();
            loadtable();
      
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            ThemNguyenLieuFrm form = new ThemNguyenLieuFrm();
            form.FormClosing += ThemNguyenLieuFrm_FormClosing;
            form.ShowDialog();
        }

        private void tabImport_Load(object sender, EventArgs e)
        {
            //loadtable();
            cmbCheckKho.SelectedIndex = 0;
        }

        private void ThemNguyenLieuFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadtable();
        }

        private void NhapKhoFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadtable();
        }

        private void loadtable()
        {
            list = ThemNguyenLieuDAO.getList();
            grdCtrlThemNguyenLieu.DataSource = list;
            // khonguyenlieu.dinhluong += chitietnhapkho.dinhluong;
            // ThemNguyenLieuDAO.update(khonguyenlieu);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            
            GridView gridview = grdCtrlThemNguyenLieu.FocusedView as GridView;
            khonguyenlieu = gridview.GetRow(gridview.FocusedRowHandle) as khonguyenlieu;
            ThemNguyenLieuFrm frm = new ThemNguyenLieuFrm(khonguyenlieu);
            frm.Text = "Sửa Nguyên Liệu " + khonguyenlieu.tennguyenlieu;
            frm.FormClosing += ThemNguyenLieuFrm_FormClosing;
            frm.ShowDialog();


        }
       

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            int k = 0;
            int[] selectedRow = gridView1.GetSelectedRows();

            foreach (int i in selectedRow)
            {
                khonguyenlieu khonguyenlieu = (khonguyenlieu)gridView1.GetRow(i);
                tennl.Add(khonguyenlieu.tennguyenlieu);
                idnl.Add(khonguyenlieu.idkhonguyenlieu);
                //dl.Add(khonguyenlieu.dinhluong.Value);
                tendl.Add(khonguyenlieu.tendonvi_dinh_luong);

                k++;
            }
            if (k != 0)
            {
                NhapKhoFrm form = new NhapKhoFrm();
                form.loggedstaff = loggedstaff;
                form.FormClosing += NhapKhoFrm_FormClosing;
                form.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show(this, "Chưa chọn nguyên liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemNguyenLieuDaDung_Click(object sender, EventArgs e)
        {
            int k = 0;
            int[] selectedRow = gridView1.GetSelectedRows();

            foreach (int i in selectedRow)
            {
                khonguyenlieu khonguyenlieu = (khonguyenlieu)gridView1.GetRow(i);
                tennldd.Add(khonguyenlieu.tennguyenlieu);
                idnldd.Add(khonguyenlieu.idkhonguyenlieu);
                k++;
            }
            if (k != 0)
            {
                ThemNguyenLieuDaDungFrm form = new ThemNguyenLieuDaDungFrm();
                form.FormClosing += NhapKhoFrm_FormClosing;
                form.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show(this, "Chưa chọn nguyên liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {
            grdCtrlThemNguyenLieu.DataSource = list.FindAll(i => i.tennguyenlieu.ToLower().StartsWith(txtTimKiem.Text.ToLower()));
        }

        private void tabImport_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            
      }

        private void grdCtrlThemNguyenLieu_Click(object sender, EventArgs e)
        {

        }

        private void cmbCheckKho_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int index = cmbCheckKho.SelectedIndex;
            list = ThemNguyenLieuDAO.getList();
            switch (index)
            {
                case 0:
                    loadtable();
                    break;
                case 1:
                    list = list.Where(x => x.dinhluong >= x.dinh_luong_toi_thieu && x.dinhluong <= x.dinh_luong_toi_da).ToList();
                    grdCtrlThemNguyenLieu.DataSource = list;
                    break;
                case 2:
                    list = list.Where(x => x.dinhluong > x.dinh_luong_toi_da).ToList();
                    grdCtrlThemNguyenLieu.DataSource = list;
                    break;
                case 3:
                    list = list.Where(x => x.dinhluong <= x.dinh_luong_toi_thieu).ToList();
                    grdCtrlThemNguyenLieu.DataSource = list;
                    break;
                default:
                    break;

            }
        }
    }
}
