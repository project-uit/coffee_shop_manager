using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using COFFEE_SHOP_MANAGER.DTO;
using System.Collections.Generic;
using DevExpress.XtraCharts;

namespace COFFEE_SHOP_MANAGER.VIEW.Statistics
{
    public partial class RevenueReport : DevExpress.XtraReports.UI.XtraReport
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        public void InitData(string year, List<RevenueReportDTO> revenues)
        {
            DataSource = revenues;
            Series series = new Series("Doanh thu", ViewType.Bar);
            chartRevenue.Series.Add(series);
            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "THỐNG KÊ DOANH THU NĂM " + year;
            chartRevenue.Titles.Add(chartTitle);
            for (int i = 0; i < 12; i++)
            {
                int month = (i + 1);
                chartRevenue.Series["Doanh thu"].Points.Add(
                    new SeriesPoint(month, revenues[i].revenue)
                );
            }
            this.date.Value = DateTime.Now;
        }
    }
}
