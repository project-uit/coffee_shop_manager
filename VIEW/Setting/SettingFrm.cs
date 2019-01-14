using COFFEE_SHOP_MANAGER.DAO;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER.VIEW.Setting
{
    public partial class SettingFrm : MaterialSkin.Controls.MaterialForm
    {
        String severName = ".\\SQLEXPRESS";
        String databaseName = "quanlycafe";
    
        public SettingFrm()
        {
            InitializeComponent();
        }

        private void SettingFrm_Load(object sender, EventArgs e)
        {
            var location = System.Reflection.Assembly.GetEntryAssembly().Location;
            var directory = Path.GetDirectoryName(location) + "\\backup";
            txtPathFileBackup.Text = directory.Replace(@"\", @"\\");
        }

        private Boolean validateFieldsRestore()
        {
            int countError = 0;
            if (txtSeverName.Text.Trim() == "")
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = "Tên Server không được trống";
                countError++;
            }
            else
            {
                lbErrorPathRestore.Visible = false;
            }

            if (txtPathFileRestore.Text.Trim() == "")
            {
                lbErrorPathRestore.Visible = true;
                lbErrorPathRestore.Text = "Chưa chọn đường dẫn file restore";
                countError++;
            }
            else
            {
                lbErrorPathRestore.Visible = false;
            }


            if (countError != 0)
                return false;

            return true;
        }

        private Boolean validateFieldsBackup()
        {
            int countError = 0;
            if (txtSeverName.Text.Trim() == "")
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = "Tên Server không được trống";
                countError++;
            }
            else
            {
                lbErrorPathRestore.Visible = false;
            }

            if (txtPathFileBackup.Text.Trim() == "")
            {
                lbErrorPathBackup.Visible = true;
                lbErrorPathBackup.Text = "Chưa chọn đường dẫn file restore";
                countError++;
            }
            else
            {
                lbErrorPathBackup.Visible = false;
            }

            if (countError != 0)
                return false;

            return true;
        }

        private void txtPathFileRestore_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            FD.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                txtPathFileRestore.Text = fileToOpen.Replace(@"\", @"\\");
                lbErrorPathRestore.Visible = false;
            }
        }

        private void txtPathFileBackup_Click(object sender, EventArgs e)
        {
            using (var FD = new FolderBrowserDialog())
            {
                DialogResult result = FD.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FD.SelectedPath))
                {
                    txtPathFileBackup.Text = FD.SelectedPath.Replace(@"\", @"\\");
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!validateFieldsRestore())
                return;

            severName = ".\\" + txtSeverName.Text;

            DatabaseUtils.RestoreDatabase(severName, databaseName, txtPathFileRestore.Text.ToString());

            try
            {
                DatabaseUtils.createDB(severName, "quanlycafe");
                DatabaseUtils.RestoreDatabase(severName, databaseName, txtPathFileRestore.Text.ToString());
                XtraMessageBox.Show(this, "Restore thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show(this, "Restore thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!validateFieldsBackup())
                return;

            severName = ".\\" + txtSeverName.Text;

            try
            {
                String time = DateTime.Now.ToString("yyyy_MM_ddTHHmmss");
                DatabaseUtils.BackupDatabase(severName, databaseName, txtPathFileBackup.Text + "\\quanlycafe_" + time + ".bak");
                XtraMessageBox.Show(this, "Backup thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmoException ex)
            {
                XtraMessageBox.Show(this, ex.InnerException.Message , "Backup thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
