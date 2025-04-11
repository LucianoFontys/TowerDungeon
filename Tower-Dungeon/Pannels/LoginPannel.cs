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

        private void LoginPannel_Resize(object sender, EventArgs e)
        {
            tbxUsername.Location = new Point((this.Width / 2) - (tbxUsername.Width / 2), tbxUsername.Location.Y);
            tbxPassword.Location = new Point((this.Width / 2) - (tbxPassword.Width / 2), tbxPassword.Location.Y);
            btnLogin.Location = new Point((this.Width / 2) - (btnLogin.Width / 2), btnLogin.Location.Y);
            btnRegister.Location = new Point((this.Width / 2) - (btnRegister.Width / 2), btnRegister.Location.Y);
            lblUsername.Location = new Point((this.Width / 2) - (lblUsername.Width / 2), lblUsername.Location.Y);
            lblPassword.Location = new Point((this.Width / 2) - (lblPassword.Width / 2), lblPassword.Location.Y);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;

            ValidateUser validateUser = new ValidateUser();

            if (validateUser.ValidateUsername(username))
            {
                MessageBox.Show("So true");
                return;
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
    }
}
