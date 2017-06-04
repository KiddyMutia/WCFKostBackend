using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCFKostBackend
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id_user = string.Empty;
            string nama = string.Empty;
            string usernameadmin = string.Empty;
            Boolean status = true;

            string username = tb_username.Text;
            string password = tb_password.Text;



            try
            {
                AdminService.AdminServiceClient obj = new AdminService.AdminServiceClient();
                IList<AdminService.AdminInfo> dataInfo = new List<AdminService.AdminInfo>();


                dataInfo = obj.loginAdmin(username, password);

                foreach (var x in dataInfo)
                {
                    if (username == x.UsernameAdmin && password == x.PasswordAdmin)
                    {
                        this.Hide();
                        MainMenu af = new MainMenu();
                        af.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Invalid");
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
