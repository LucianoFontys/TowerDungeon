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
    public partial class MainMenuPannel: UserControl
    {
        public MainMenuPannel()
        {
            InitializeComponent();
        }

        private void MainMenuPannel_SizeChanged(object sender, EventArgs e)
        {
            btnNewGame.Left = (this.ClientSize.Width - btnNewGame.Width) / 2;
            btnContinue.Left = (this.ClientSize.Width - btnContinue.Width) / 2;
            btnStats.Left = (this.ClientSize.Width - btnStats.Width) / 2;
            btnLeave.Left = (this.ClientSize.Width - btnLeave.Width) / 2;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ChooseHeroPanel chooseHero = new ChooseHeroPanel();
            chooseHero.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(chooseHero);
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void btnStats_Click(object sender, EventArgs e)
        {

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LoginPannel login = new LoginPannel();
            login.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(login);
        }
    }
}
