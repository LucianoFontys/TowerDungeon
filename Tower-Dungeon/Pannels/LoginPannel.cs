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
    public partial class LoginPannel: UserControl
    {
        public LoginPannel()
        {
            InitializeComponent();
        }

        private void LoginPannel_Resize(object sender, EventArgs e)
        {
            tbxUsername.Location = new Point((this.Width / 2) - (tbxUsername.Width / 2), tbxUsername.Location.Y);
            tbxPassword.Location = new Point((this.Width / 2) - (tbxPassword.Width / 2), tbxPassword.Location.Y);
        }
    }
}
