using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEE_SHOP_MANAGER.DAO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using COFFEE_SHOP_MANAGER.VIEW.Store;
using COFFEE_SHOP_MANAGER.DTO;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabStore : UserControl
    {
        public nhanvien loggedStaff;
        private List<thucuong> beverages = new List<thucuong>();
        private List<hoadon> invoices = new List<hoadon>();
        private List<tblInvoiceDTO> listInvoiceDetail = new List<tblInvoiceDTO>();
        public tabStore()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }

        private void tabStore_Load(object sender, EventArgs e)
        {
            loadDiscount();
            beverages = BeverageDAO.getList();
            grdCtrlThucUong.DataSource = beverages;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (thucuong beverage in beverages)
            {
                collection.Add(beverage.tenthucuong);
            }

            txtSearch.AutoCompleteCustomSource = collection;

            invoices = StoreDAO.getInvoices();
            gcSearchInvoice.DataSource = invoices;
        }

        private void loadDiscount()
        {
            int last = DiscountDAO.getList().Count();
            if (last == 0) return;
            giamgia discount = new giamgia();
            discount = DiscountDAO.getList()[last - 1];
            DateTime today = DateTime.Today;
            string dateEndformated = string.Format("{0:dd-MM-yyyy}", discount.ngayketthuc);
            string todayformated = string.Format("{0:dd-MM-yyyy}", today);
            int result = DateTime.Compare(DateTime.Parse(dateEndformated), DateTime.Parse(todayformated));
            if (result > 0)
            {
                lbDiscount.Text = discount.hesogiamgia.ToString() + "%";
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            grdCtrlThucUong.DataSource = beverages.FindAll(i => i.tenthucuong.ToLower().StartsWith(txtSearch.Text.ToLower())
               || i.nhomthucuong.tennhomthucuong.ToLower().StartsWith(txtSearch.Text.ToLower()));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            grdCtrlThucUong.DataSource = beverages;
            GridView gridview = grdCtrlThucUong.FocusedView as GridView;
            thucuong beverage = gridview.GetRow(gridview.FocusedRowHandle) as thucuong;
            tblInvoiceDTO tblInvoiceDTO = new tblInvoiceDTO {
                idthucuong = beverage.id_thucuong,
                tenthucuong = beverage.tenthucuong,
                nhomthucuong = beverage.nhomthucuong.tennhomthucuong,
                giaban = beverage.giaban,
                soluong = 1,
                thanhtien = beverage.giaban
            };

            List<tblInvoiceDTO> list = new List<tblInvoiceDTO>();
            if ((gcInvoice.DataSource as IEnumerable<tblInvoiceDTO>) != null)
            {
                list = (gcInvoice.DataSource as IEnumerable<tblInvoiceDTO>).ToList();
            }
            
            foreach (tblInvoiceDTO item in list)
            {
                if (tblInvoiceDTO.idthucuong == item.idthucuong)
                {
                    XtraMessageBox.Show(this, "Thức uống này đã được thêm trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            list.Add(tblInvoiceDTO);
            gcInvoice.DataSource = list;
            updateTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                List<tblInvoiceDTO> list = (gcInvoice.DataSource as IEnumerable<tblInvoiceDTO>).ToList();
                GridView gridview = gcInvoice.FocusedView as GridView;
                tblInvoiceDTO item = gridview.GetRow(gridview.FocusedRowHandle) as tblInvoiceDTO;
                list.Remove(item);
                gcInvoice.DataSource = list;
                updateTotal();
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtsoluong_Leave(object sender, EventArgs e)
        {
            List<tblInvoiceDTO> list = (gcInvoice.DataSource as IEnumerable<tblInvoiceDTO>).ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                list[i].thanhtien = list[i].giaban * list[i].soluong;
            }
            gcInvoice.DataSource = list;
            updateTotal();
        }

        private void updateTotal()
        {
            int sum = 0;
            List<tblInvoiceDTO> list = (gcInvoice.DataSource as IEnumerable<tblInvoiceDTO>).ToList();
            foreach(tblInvoiceDTO item in list)
            {
                sum += Int32.Parse(item.giaban.Value.ToString("0.##")) * item.soluong;
            }
            int discount = Int32.Parse(lbDiscount.Text.Replace("%", ""));
            lbSum.Text = sum.ToString();
            lbTotal.Text = (sum * (100 - discount) / 100).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<tblInvoiceDTO> list = (gcInvoice.DataSource as IEnumerable<tblInvoiceDTO>).ToList();
            if (list.Count() == 0)
            {
                XtraMessageBox.Show(this, "Chưa chọn thức uống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            hoadon invoice = new hoadon
            {
                tongtien = Int32.Parse(lbTotal.Text),
                ngaylap = DateTime.Now
            };
            List<chitiethoadon> invoiceDetails = new List<chitiethoadon>();    
            foreach (tblInvoiceDTO item in list)
            {
                chitiethoadon invoiceDetail = new chitiethoadon
                {
                    id_thucuong = item.idthucuong,
                    soluong = item.soluong,
                    dongia = item.giaban,
                    thanhtien = item.thanhtien
                };
                invoiceDetails.Add(invoiceDetail);
            }
            if (StoreDAO.addInvoice(invoice, invoiceDetails))
            {
                XtraMessageBox.Show(this, "Thêm hóa đơn mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listInvoiceDetail = list;
                resetGridControlInvoices();
            }
            else
            {
                XtraMessageBox.Show(this, "Thêm hóa đơn mới không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetGridControlInvoices()
        {
            invoices = StoreDAO.getInvoices();
            gcSearchInvoice.DataSource = invoices;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GridView gridview = gcSearchInvoice.FocusedView as GridView;
            hoadon invoice = gridview.GetRow(gridview.FocusedRowHandle) as hoadon;
            ViewInvoiceFrm viewInvoiceFrm = new ViewInvoiceFrm();
            viewInvoiceFrm.invoice = invoice;
            viewInvoiceFrm.Show();
        }

        private void searchInvoice(object sender, EventArgs e)
        {
            String dateStr = "";
            if (txtDate.EditValue != null)
            {
                DateTime date = DateTime.Parse(txtDate.EditValue.ToString());
                dateStr = date.ToString("dd-MM-yyyy");
            }

            gcSearchInvoice.DataSource = invoices
                .FindAll(i => i.id_hoadon.ToString().ToLower().StartsWith(txtSearchInvoice.Text.ToLower())
                && string.Format("{0:dd-MM-yyyy}", i.ngaylap).ToLower().StartsWith(dateStr.ToLower()));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            InvoicePrintFrm invoicePrintFrm = new InvoicePrintFrm();
            invoicePrintFrm.invoice = listInvoiceDetail;
            invoicePrintFrm.staff = loggedStaff.hoten;
            invoicePrintFrm.sum = lbSum.Text;
            invoicePrintFrm.discount = lbDiscount.Text;
            invoicePrintFrm.total = lbTotal.Text;
            invoicePrintFrm.Print();
            invoicePrintFrm.ShowDialog();
        }
    }
}



