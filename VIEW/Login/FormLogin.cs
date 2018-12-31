using COFFEE_SHOP_MANAGER.DAO;
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
        LoginDAO loginDao = new LoginDAO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.KeyDown += new KeyEventHandler(tb_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (loginDao.checkLogin(txtUsername.Text, txtPassword.Text) == true)
            {
                nhanvien loggedStaff = loginDao.getStaffFromUsername(txtUsername.Text);
                FormMain formMain = new FormMain();
                formMain.loggedStaff = loggedStaff;
                formMain.Show();
                this.Hide();
            }
            else
            {
                //txtUsername.ForeColor = Color.FromName("RED");
                //txtPassword.ForeColor = Color.FromName("RED");
                lbError.Visible = true;
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
