using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
