using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.KeyDown += new KeyEventHandler(tb_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
