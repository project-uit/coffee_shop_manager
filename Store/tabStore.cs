using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabStore : UserControl
    {
        public tabStore()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }
    }
}
