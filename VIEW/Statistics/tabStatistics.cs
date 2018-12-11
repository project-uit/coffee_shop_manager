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
using System.IO;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabStatistics : UserControl
    {
        public tabStatistics()
        {
            InitializeComponent();
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
    }
}
