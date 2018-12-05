using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER.VIEW.MessageBox
{
    class MessageBoxMaterial
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons btn)
        {
            DialogResult result = DialogResult.None;
            switch (btn)
            {
                case MessageBoxButtons.YesNo:
                    MessageBoxFormYN frm = new MessageBoxFormYN();
                    frm.setMessage(message);
                    frm.Text = caption;
                    result = frm.ShowDialog();
                    break;
                case MessageBoxButtons.OK:
                    MessageBoxFormOK frmOK = new MessageBoxFormOK();
                    frmOK.setMessage(message);
                    frmOK.Text = caption;
                    result = frmOK.ShowDialog();
                    break;
            }
            return result;
        }
    }
}
