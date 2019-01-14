using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using COFFEE_SHOP_MANAGER.VIEW.Staff;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using COFFEE_SHOP_MANAGER.DAO;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabStaff : UserControl
    {
        private StaffDAO staffDAO = new StaffDAO();
        public tabStaff()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
            gcUsers.DataSource = StaffDAO.getStaffs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaffFrm addStaffFrm = new AddStaffFrm();
            addStaffFrm.FormClosing += DoAfterAddOrEditStaff;
            addStaffFrm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GridView gridview = gcUsers.FocusedView as GridView;
            nhanvien staff = gridview.GetRow(gridview.FocusedRowHandle) as nhanvien;
            EditStaffFrm editStaffFrm = new EditStaffFrm();
            editStaffFrm.editstaff = staff;
            editStaffFrm.FormClosing += DoAfterAddOrEditStaff;
            editStaffFrm.ShowDialog();
        }

        private void DoAfterAddOrEditStaff(object sender, FormClosingEventArgs e)
        {
            gcUsers.DataSource = StaffDAO.getStaffs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                GridView gridview = gcUsers.FocusedView as GridView;
                nhanvien staff = gridview.GetRow(gridview.FocusedRowHandle) as nhanvien;
                if (StaffDAO.deleteStaff(staff))
                {
                    gcUsers.DataSource = StaffDAO.getStaffs();
                    XtraMessageBox.Show(this, "Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
