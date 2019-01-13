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
using System.Globalization;
using DevExpress.XtraCharts;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabDashboard : UserControl
    {
        public tabDashboard()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }

        private void tabDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            updateStatistic();
            createChart();
        }

        private void updateStatistic()
        {
            List<hoadon> invoices = new List<hoadon>();
            invoices = DashboardDAO.getInvoicesToday();
            if (invoices != null)
            {
                float revenue = 0;
                int countBeverage = 0;
                foreach (hoadon invoice in invoices)
                {
                    revenue += (float)invoice.tongtien;
                    foreach (chitiethoadon item in invoice.chitiethoadons)
                    {
                        countBeverage += item.soluong;
                    }
                }
                lbcountInvoice.Text = invoices.Count.ToString();
                lbcountBeverage.Text = countBeverage.ToString();
                if (revenue != 0)
                    lbRevenue.Text = double.Parse(revenue.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + " vnđ";
            }
        }

        private void createChart()
        {
            List<chitiethoadon> listCTHD = new List<chitiethoadon>();
            listCTHD = DashboardDAO.getDetailInvoicesToday();

            if (listCTHD.Count == 0)
                return;

            chart.Series.Clear();
            Series series = new Series("Doanh thu", ViewType.Bar);
            chart.Series.Add(series);

            foreach (nhomthucuong group in GroupBeverageDAO.getList())
            {
                chart.Series["Doanh thu"].Points.Add(
                    new SeriesPoint(group.tennhomthucuong, getRevenueByGroupBeverage(listCTHD, group.tennhomthucuong))
                );
            }
        }

        private Decimal getRevenueByGroupBeverage(List<chitiethoadon> listCTHD, string groupBeverage)
        {
            int total = 0;
            if (listCTHD.Count != 0)
            {
                foreach (chitiethoadon item in listCTHD)
                {
                    if (item.thucuong.nhomthucuong.tennhomthucuong == groupBeverage)
                    {
                        total += (int)item.thanhtien;
                    }
                }
            }
            return total;
        }
    }
}
