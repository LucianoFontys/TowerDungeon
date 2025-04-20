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
    public partial class ChooseHeroPanel: UserControl
    {
        public ChooseHeroPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(250, 550);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(250, 550);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(250, 550);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenuPannel mainMenu = new MainMenuPannel();
            mainMenu.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(mainMenu);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(200, 500);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(200, 500);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(200, 500);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FloorBattlePanel floorBattle = new FloorBattlePanel(1);
            floorBattle.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(floorBattle);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FloorBattlePanel floorBattle = new FloorBattlePanel(2);
            floorBattle.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(floorBattle);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FloorBattlePanel floorBattle = new FloorBattlePanel(3);
            floorBattle.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(floorBattle);
        }
    }
}
