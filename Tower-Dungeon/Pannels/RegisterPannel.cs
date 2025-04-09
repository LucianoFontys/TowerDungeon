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
    public partial class RegisterPannel: UserControl
    {
        public RegisterPannel()
        {
            InitializeComponent();
        }

        private void Registerpannel_Resize(object sender, EventArgs e)
        {
            tbxUsername.Location = new Point((this.Width / 2) - (tbxUsername.Width / 2), tbxUsername.Location.Y);
            tbxPassword.Location = new Point((this.Width / 2) - (tbxPassword.Width / 2), tbxPassword.Location.Y);
            tbxEmailAddress.Location = new Point((this.Width / 2) - (tbxEmailAddress.Width / 2), tbxEmailAddress.Location.Y);
            tbxFName.Location = new Point((this.Width / 2) - (tbxFName.Width / 2), tbxFName.Location.Y);
            tbxLName.Location = new Point((this.Width / 2) - (tbxLName.Width / 2), tbxLName.Location.Y);
            tbxPasswordConfirm.Location = new Point((this.Width / 2) - (tbxPasswordConfirm.Width / 2), tbxPasswordConfirm.Location.Y);
        }

        private void AddUCLogin()
        {
            LoginPannel login = new LoginPannel();
            login.Dock = DockStyle.Fill;
            this.Controls.Add(login);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string fName = tbxFName.Text;
            string lName = tbxLName.Text;
            string email = tbxEmailAddress.Text;
            string password = tbxPassword.Text;
            string passwordConfirm = tbxPasswordConfirm.Text;
            bool isAdmin = false;

            if (username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.");
            }
            else if (fName.Length < 2)
            {
                MessageBox.Show("First name must be at least 2 characters long.");
            }
            else if (lName.Length < 2)
            {
                MessageBox.Show("Last name must be at least 2 characters long.");
            }
            else if (!new ValidEmailCheck().IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.");
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Passwords do not match.");
            }
            else if (tbxUsername.Text == "" || tbxFName.Text == "" || tbxLName.Text == "" || tbxEmailAddress.Text == "" || tbxPassword.Text == "" || tbxPasswordConfirm.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                // Call the method to add the user to the database
                Data.Database_Connection db = new Data.Database_Connection();
                db.addUsers(username, fName, lName, email, password, isAdmin);
                MessageBox.Show("User registered successfully.");

                this.Controls.Clear();
                AddUCLogin();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            AddUCLogin();
        }
    }
}
