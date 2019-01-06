using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEE_SHOP_MANAGER.VIEW.Beverage;
using COFFEE_SHOP_MANAGER.DAO;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using COFFEE_SHOP_MANAGER.VIEW.Discount;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms.DataVisualization.Charting;
using Image = iTextSharp.text.Image;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabBeverage : UserControl
    {
        private thucuong thucuong;
        private List<thucuong> list = new List<thucuong>();
        public tabBeverage()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
            loadtable();
            createChart();
        }

        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            BeverageFrm form = new BeverageFrm();
            form.FormClosing += BeverageFrm_Closing;
            form.ShowDialog();          
        }

        private void BeverageFrm_Closing(object sender, FormClosingEventArgs e)
        {
            loadtable();
        }
        private void loadtable()
        {
            list = BeverageDAO.getList();
            grdCtrlThucUong.DataSource = list;
        }

        private void btnNhomThucUong_Click(object sender, EventArgs e)
        {
            GroupBeverage frm = new GroupBeverage();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show(this, "Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                GridView gridview = grdCtrlThucUong.FocusedView as GridView;
                thucuong = gridview.GetRow(gridview.FocusedRowHandle) as thucuong;
                if (BeverageDAO.delete(thucuong))
                {
                    lbMessage.Text = "Bạn xóa thành công!";
                    loadtable();
                }
                else
                {
                    lbMessage.Text = "Bạn xóa thất bại!";
                }
                flyoutPanel1.ShowBeakForm();
            }           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrlThucUong.FocusedView as GridView;
            thucuong = gridview.GetRow(gridview.FocusedRowHandle) as thucuong;
            BeverageFrm form = new BeverageFrm(thucuong);
            form.FormClosing += BeverageFrm_Closing;
            form.ShowDialog();
        }

        private void btnCongThuc_Click(object sender, EventArgs e)
        {
            GridView gridview = grdCtrlThucUong.FocusedView as GridView;
            thucuong = gridview.GetRow(gridview.FocusedRowHandle) as thucuong;
            FormulaFrm frm = new FormulaFrm(thucuong.id_thucuong, thucuong.tenthucuong);
            frm.ShowDialog();
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            DiscountFrm x = new DiscountFrm();
            x.ShowDialog();
        }

        private void txtTenThucUong_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {         
            grdCtrlThucUong.DataSource = list.FindAll(i => i.tenthucuong.ToLower().StartsWith(txtTenThucUong.Text.ToLower())
               || i.nhomthucuong.tennhomthucuong.ToLower().StartsWith(txtTenThucUong.Text.ToLower()));
        }
        // xuat file 
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "report";
            savefile.Filter = "Excel 2003|*.xls|Excel 2007|*.xlsx|PDF|*.pdf";
            savefile.Title = "Xuất file";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(savefile.FileName);
                string savePath = Path.GetFullPath(savefile.FileName);

                switch (extension.ToLower())
                {
                    case ".xls":
                        grdCtrlThucUong.ExportToXls(savePath);
                        break;
                    case ".xlsx":
                        grdCtrlThucUong.ExportToXlsx(savePath);
                        break;
                    case ".pdf":
                        createReportPDF(savePath, list);
                        break;
                    default:
                        break;
                }
            }
        }
        private void createChart()
        {
            //chart1.Series.Clear();
            //var series = new Series("Finance");
            //series.Points.DataBindXY(new[] { 2000, 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150, 180 });
            //chart1.Series.Add(series);
        }
        private void createReportPDF(string path, List<thucuong> list)
        {
            // lay font trong he thong mac dinh la times new roman 
            var arialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            BaseFont header = BaseFont.CreateFont(arialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font fontheader = new iTextSharp.text.Font(header, 16, 1); // 16 size, 1 la style border, underline,...
            // header
            Paragraph pHeader = new Paragraph(new Chunk("Báo cáo", fontheader));
           // table
            PdfPTable table = new PdfPTable(3); // so cot
            table.AddCell(new PdfPCell(new Phrase(new Chunk("tên thức uống", fontheader))));
            table.AddCell(new PdfPCell(new Phrase(new Chunk("nhóm thức uống", fontheader))));
            table.AddCell(new PdfPCell(new Phrase(new Chunk("gia ban", fontheader))));
            list.ForEach(i =>
            {
                table.AddCell(i.tenthucuong);
                table.AddCell(i.nhomthucuong.tennhomthucuong);
                table.AddCell(i.giaban+"");
            });
            // lay img tu chart
            MemoryStream ms = new MemoryStream();
            //chart1.SaveImage(ms, ChartImageFormat.Jpeg);
            Image img = Image.GetInstance(ms.GetBuffer());
            // tao file pdf
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.OpenOrCreate));
            document.Open();
            pHeader.Alignment = Element.ALIGN_CENTER; // canh giua
            document.Add(pHeader); // add header
            document.Add(new Paragraph(" ")); // xuong dong
            document.Add(new Paragraph(" "));
            document.Add(table); // add table
            document.Add(new Paragraph(" "));
            document.Add(img);// add img tu chart
            document.Close();
        }

        private void txtTenThucUong_Click(object sender, EventArgs e)
        {

        }
    }
}
