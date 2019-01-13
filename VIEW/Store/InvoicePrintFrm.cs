using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COFFEE_SHOP_MANAGER.DTO;
using DevExpress.XtraReports.Parameters;

namespace COFFEE_SHOP_MANAGER.VIEW.Store
{
    public partial class InvoicePrintFrm : DevExpress.XtraEditors.XtraForm
    {
        public List<tblInvoiceDTO> invoice;
        public String staff, sum, discount, total;

        public InvoicePrintFrm()
        {
            InitializeComponent();
        }

        public void Print()
        {
            InvoiceReport invoiceReport = new InvoiceReport();
            foreach (Parameter p in invoiceReport.Parameters)
                p.Visible = false;
            invoiceReport.InitData(invoice, staff, sum, discount, total);
            documentViewer1.DocumentSource = invoiceReport;
            invoiceReport.CreateDocument();
        }
    }
}