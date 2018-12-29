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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace COFFEE_SHOP_MANAGER.VIEW.Statistics
{
    public partial class RevenuePrintFrm : DevExpress.XtraEditors.XtraForm
    {
        public List<RevenueReportDTO> revenues;
        public string year;

        public RevenuePrintFrm()
        {
            InitializeComponent();
        }

        public void Print()
        {
            RevenueReport revenueReport = new RevenueReport();
            revenueReport.InitData(year, revenues);

            foreach (Parameter p in revenueReport.Parameters)
                p.Visible = false;
            documentViewer1.DocumentSource = revenueReport;
            revenueReport.CreateDocument();
        }
    }
}