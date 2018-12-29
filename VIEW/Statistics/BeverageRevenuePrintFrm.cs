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

namespace COFFEE_SHOP_MANAGER.VIEW.Statistics
{
    public partial class BeverageRevenuePrintFrm : DevExpress.XtraEditors.XtraForm
    {
        public List<BeverageRevenueReportDTO> revenues;
        public string month, year;

        public BeverageRevenuePrintFrm()
        {
            InitializeComponent();
        }

        public void Print()
        {
            BeverageRevenueReport beverageRevenueReport = new BeverageRevenueReport();
            beverageRevenueReport.InitData(month, year, revenues);
            foreach (Parameter p in beverageRevenueReport.Parameters)
                p.Visible = false;
            documentViewer1.DocumentSource = beverageRevenueReport;
            beverageRevenueReport.CreateDocument();
        }
    }
}