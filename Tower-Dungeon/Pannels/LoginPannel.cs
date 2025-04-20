using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tower_Dungeon.Business;

namespace Tower_Dungeon.Pannels
{
    public partial class LoginPannel : UserControl
    {
        public LoginPannel()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            ValidateUser validateUser = new ValidateUser();

            if (validateUser.ValidateUsername(username))
            {
                if (validateUser.ValidatePassword(password, username))
                {
                    MessageBox.Show("Login successful");
                    MainMenuPannel mainMenu = new MainMenuPannel();
                    mainMenu.Dock = DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(mainMenu);
                }
                else
                {
                    MessageBox.Show("Invalid password");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter an existing username");
                return;
            }
        }

        private void AddUCRegister()
        {
            RegisterPannel register = new RegisterPannel();
            register.Dock = DockStyle.Fill;
            this.Controls.Add(register);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            AddUCRegister();
        }

        private void chkbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbShowPass.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '*';
            }
        }
    }
}
