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
    public partial class BeverageRevenueReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BeverageRevenueReport()
        {
            InitializeComponent();
        }

        public void InitData(string month, string year, List<BeverageRevenueReportDTO> revenues)
        {
            DataSource = revenues;
            Series series = new Series("Doanh thu", ViewType.Pie);
            // Adjust the text pattern of the series label.
            PieSeriesLabel label = (PieSeriesLabel)series.Label;
            label.TextPattern = "{A}: {VP:P0}";

            // Detect overlapping of series labels.
            label.ResolveOverlappingMode = ResolveOverlappingMode.Default;
            chartBeverageRevenue.Series.Add(series);

            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "THỐNG KÊ DOANH THU THEO NHÓM THỨC UỐNG THÁNG" + month + "/" + year;
            chartTitle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            chartBeverageRevenue.Titles.Add(chartTitle);

            foreach (BeverageRevenueReportDTO revenue in revenues)
            {
                chartBeverageRevenue.Series["Doanh thu"].Points.Add(
                    new SeriesPoint(revenue.groupBeverage, revenue.revenue)
                );
            }

            this.date.Value = DateTime.Now;
        }
    }
}
