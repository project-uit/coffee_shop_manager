using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace COFFEE_SHOP_MANAGER
{
    public partial class tabStaff : UserControl
    {
        public tabStaff()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
        }
    }
}
