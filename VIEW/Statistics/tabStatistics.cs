﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEE_SHOP_MANAGER.DAO;
using DevExpress.XtraCharts;
using COFFEE_SHOP_MANAGER.DTO;
using COFFEE_SHOP_MANAGER.VIEW.Statistics;
using Series = DevExpress.XtraCharts.Series;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabStatistics : UserControl
    {
        public tabStatistics()
        {
            InitializeComponent();
        }

        private void tabStatistics_Load(object sender, EventArgs e)
        {
            List<String> years = StatictisDAO.getListYearAvaiable();
            cmbYear.DataSource = years;

            cmbYearTabBeverage.DataSource = years;
            cmbMonthTabBeverage.SelectedIndex = 0;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<hoadon> invoices = new List<hoadon>();
            String year = cmbYear.SelectedItem.ToString();
            invoices = StatictisDAO.getInvoicesByYear(year);
            chartRevenue.Series.Clear();
            Series series = new Series("Doanh thu", ViewType.Bar);
            chartRevenue.Series.Add(series);

            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU TRONG NĂM";
            chartRevenue.Titles.Clear();
            chartRevenue.Titles.Add(chartTitle);

            for (int i=0; i < 12; i ++)
            {
                String month = (i + 1).ToString();
                chartRevenue.Series["Doanh thu"].Points.Add(
                    new SeriesPoint(month, getRevenueByMonth(invoices, month))
                );
            }
            ((XYDiagram)chartRevenue.Diagram).AxisX.NumericScaleOptions.AutoGrid = false;
            ((XYDiagram)chartRevenue.Diagram).AxisX.NumericScaleOptions.GridSpacing = 1;
            ((XYDiagram)chartRevenue.Diagram).AxisX.Title.Text = "Tháng";
            ((XYDiagram)chartRevenue.Diagram).AxisX.Title.Visibility = DefaultBoolean.True;

            ((XYDiagram)chartRevenue.Diagram).AxisY.Title.Text = "Doanh thu (VND)";
            ((XYDiagram)chartRevenue.Diagram).AxisY.Title.Visibility = DefaultBoolean.True;
        }

        private void cmbYearTabBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            createChartPie();
        }

        private void cmbMonthTabBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            createChartPie();
        }

        private void createChartPie()
        {
            String year = DateTime.Now.Year.ToString();
            if (cmbYearTabBeverage.SelectedItem != null)
            {
                year = cmbYearTabBeverage.SelectedItem.ToString();
            }

            String month = DateTime.Now.Month.ToString();
            if (cmbMonthTabBeverage.SelectedItem != null)
            {
                month = cmbMonthTabBeverage.SelectedItem.ToString();
            }
            List<chitiethoadon> invoiceDetails = new List<chitiethoadon>();
            invoiceDetails = StatictisDAO.getInvoiceDetailsByMonthYear(month, year);

            chartBeverage.Series.Clear();
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("beverage", ViewType.Pie);
            chartBeverage.Series.Add(series);
            // Adjust the text pattern of the series label.
            PieSeriesLabel label = (PieSeriesLabel)series.Label;
            label.TextPattern = "{A}: {VP:P0}";

            // Detect overlapping of series labels.
            label.ResolveOverlappingMode = ResolveOverlappingMode.Default;

            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "BIỂU ĐỒ THÔNG KÊ DOANH THU NHÓM THỨC UỐNG TRONG THÁNG";
            chartBeverage.Titles.Clear();
            chartBeverage.Titles.Add(chartTitle);

            foreach (nhomthucuong group in GroupBeverageDAO.getList())
            {
                chartBeverage.Series["beverage"].Points.Add(
                    new SeriesPoint(group.tennhomthucuong, getRevenueByGroupBeverage(invoiceDetails, group.tennhomthucuong))
                );
            }
        }

        private Decimal getRevenueByGroupBeverage(List<chitiethoadon> invoiceDetails, string groupBeverage)
        {
            int total = 0;
            foreach (chitiethoadon invoiceDetail in invoiceDetails)
            {
                if (invoiceDetail.thucuong.nhomthucuong.tennhomthucuong == groupBeverage)
                {
                    total += (int) invoiceDetail.thanhtien;
                }
            }
            return total;
        }

        private Decimal getRevenueByMonth(List<hoadon> invoices, string month)
        {
            List<hoadon> invoicesByMonth = invoices.FindAll(i => i.ngaylap.Value.Month.ToString() == month);
            Decimal total = 0;
            foreach (hoadon invoice in invoicesByMonth)
            {
                total += invoice.tongtien;
            }
            return total;
        }

        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            List<hoadon> invoices = new List<hoadon>();
            String year = "";
            if (cmbYear.SelectedItem !=null)
                year = cmbYear.SelectedItem.ToString();
            else
            {
                XtraMessageBox.Show(this, "Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            invoices = StatictisDAO.getInvoicesByYear(year);

            List<RevenueReportDTO> revenues = new List<RevenueReportDTO>();
            for (int i = 0; i < 12; i++)
            {
                int month = (i + 1);
                revenues.Add(new RevenueReportDTO(month, (int)getRevenueByMonth(invoices, month.ToString())));
            }

            RevenuePrintFrm revenuePrintFrm = new RevenuePrintFrm();
            revenuePrintFrm.revenues = revenues;
            revenuePrintFrm.year = year;
            revenuePrintFrm.Print();
            revenuePrintFrm.ShowDialog();
        }

        private void btnPrintBeverageRevenue_Click(object sender, EventArgs e)
        {
            String year = "";
            if (cmbYearTabBeverage.SelectedItem != null)
                year = cmbYearTabBeverage.SelectedItem.ToString();
            else
            {
                XtraMessageBox.Show(this, "Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String month = "";
            if (cmbMonthTabBeverage.SelectedItem != null)
            {
                month = cmbMonthTabBeverage.SelectedItem.ToString();
            }
            List<chitiethoadon> invoiceDetails = new List<chitiethoadon>();
            invoiceDetails = StatictisDAO.getInvoiceDetailsByMonthYear(month, year);
            List<BeverageRevenueReportDTO> revenues = new List<BeverageRevenueReportDTO>();

            foreach (nhomthucuong group in GroupBeverageDAO.getList())
            {
                revenues.Add(new BeverageRevenueReportDTO(group.tennhomthucuong, (int)getRevenueByGroupBeverage(invoiceDetails, group.tennhomthucuong)));
            }
            BeverageRevenuePrintFrm revenuePrintFrm = new BeverageRevenuePrintFrm();
            revenuePrintFrm.revenues = revenues;
            revenuePrintFrm.month = month;
            revenuePrintFrm.year = year;
            revenuePrintFrm.Print();
            revenuePrintFrm.ShowDialog();
        }

        private void dateThongKe_EditValueChanged(object sender, EventArgs e)
        {
            grdCtrThongKeNguyenLieu.DataSource = StatisticResourcesDAO.thongke(dateThongKe.DateTime);
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "report";
            savefile.Filter = "Excel 2003|*.xls|Excel 2007|*.xlsx";
            savefile.Title = "Xuất file";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(savefile.FileName);
                string savePath = Path.GetFullPath(savefile.FileName);
                switch (extension.ToLower())
                {
                    case ".xls":
                        grdCtrThongKeNguyenLieu.ExportToXls(savePath);
                        break;
                    case ".xlsx":
                        grdCtrThongKeNguyenLieu.ExportToXlsx(savePath);
                        break;
                    default:
                        break;
                }
            }
        }

        private void dateWeek_EditValueChanged(object sender, EventArgs e)
        {
            grdCtrThongKeNguyenLieu.DataSource = StatisticResourcesDAO.thongkeTheoTuan(dateWeek.DateTime);
        }
    }
}

