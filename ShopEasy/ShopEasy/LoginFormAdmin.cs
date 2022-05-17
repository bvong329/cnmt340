using ShopEasy.Models.DataLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class LoginFormAdmin : Form
    {
        public LoginFormAdmin()
        {
            InitializeComponent();
            lbl_error.Hide();
        }

        //when back button is clicked, re open main login page
        private void btn_loginBack_Click(object sender, EventArgs e)
        {
            LoginMain f = new LoginMain();
            f.Show();
            Close();
        }

        //when login button is clicked, do the following:
        private void btn_login_Click(object sender, EventArgs e)
        {
            ShopEasyContext context = new ShopEasyContext();

            //gets users from Admins table and compares them to entered info. If successful, login.
            //Not a simple query because they're not case sensitive. Had to do it this way
            var user = from users in context.Admins
                       where users.Username.Equals(txtBox_Username.Text) && users.Password.Equals(txtBox_Password.Text)
                       select users;

            //checks if only a single user came back in the query
            if (user.SingleOrDefault() != null)
            {
                var username = user.Single().Username;
                var password = user.Single().Password;

                //need to check again because the query is not case sensitive
                if (username.Equals(txtBox_Username.Text) && password.Equals(txtBox_Password.Text))
                {
                    //opens main shop easy page. -1 passed in signifies user is admin
                    ShopEasyMain f = new ShopEasyMain(-1);
                    f.Show();
                    Close();
                }
                else
                {
                    lbl_error.Show();
                }
            }
            else
            {
                lbl_error.Show();
            }
        }
    }
}
