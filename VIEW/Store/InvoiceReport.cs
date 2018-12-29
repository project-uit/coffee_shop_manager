using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using COFFEE_SHOP_MANAGER.DTO;
using System.Collections.Generic;

namespace COFFEE_SHOP_MANAGER.VIEW.Store
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void InitData(List<tblInvoiceDTO> invoice, String staff, String sum, String discount, String total)
        {
            DataSource = invoice;
            this.date.Value = DateTime.Now;
            this.staff.Value = staff;
            this.sum.Value = sum;
            this.discount.Value = discount;
            this.total.Value = total;
        }
    }
}
