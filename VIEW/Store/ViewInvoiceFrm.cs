using COFFEE_SHOP_MANAGER.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER.VIEW.Store
{
    public partial class ViewInvoiceFrm : MaterialSkin.Controls.MaterialForm
    {
        public hoadon invoice = new hoadon();
        public ViewInvoiceFrm()
        {
            InitializeComponent();
        }

        private void ViewInvoiceFrm_Load(object sender, EventArgs e)
        {
            this.Text = "Hóa đơn Số: #" + invoice.id_hoadon;
            lbDate.Text = "Ngày lập: " + invoice.ngaylap.ToString();
            gcInvoiceDetail.DataSource = StoreDAO.getInvoiceDetailsByInvoice(invoice);
        }
    }
}
