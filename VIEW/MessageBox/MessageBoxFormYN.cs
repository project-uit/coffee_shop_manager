using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER.VIEW.MessageBox
{
    public partial class MessageBoxFormYN : MaterialSkin.Controls.MaterialForm
    {
        public MessageBoxFormYN()
        {
            InitializeComponent();
            btnHuy.AutoSize = false;
            btnHuy.Size = new Size(70, 36);
            btnHuy.AutoSize = false;
            btnHuy.AutoSizeMode = AutoSizeMode.GrowOnly;
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //// Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);
        }
        public void setMessage(string message)
        {
            lbMessage.Text = message;
        }
        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
