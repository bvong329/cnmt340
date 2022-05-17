using System;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
        }

        //When admin login button is clicked, open admin login form
        private void btn_admin_Click(object sender, EventArgs e)
        {
            LoginFormAdmin f = new LoginFormAdmin();
            f.Show();
            Hide();
        }

        //when exit button is clicked, exit application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //when customer login button is clicked, open customer login form
        private void btn_cust_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            Hide();
        }
    }
}
