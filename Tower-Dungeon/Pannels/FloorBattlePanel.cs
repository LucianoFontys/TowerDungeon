using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tower_Dungeon.Business.Heroes;

namespace Tower_Dungeon.Pannels
{
    public partial class FloorBattlePanel: UserControl
    {
        public FloorBattlePanel(int choice)
        {
            InitializeComponent();
            ChosenHero(choice);
        }

        private void ChosenHero(int choice)
        {
            switch (choice)
            {
                case 1:
                    Warrior warrior = new Warrior();
                    SetupBattle(choice, warrior);
                    break;
                case 2:
                    Wizard wizard = new Wizard();
                    SetupBattle(choice, wizard);
                    break;
                case 3:
                    Rogue rogue = new Rogue();
                    SetupBattle(choice, rogue);
                    break;
                default:
                    break;
            }
        }

        private void SetupBattle(int choice, Heroes heroe)
        {
            lblName.Text = heroe.Name;
            lblLevel.Text = heroe.Level.ToString();
            lblHealth.Text = heroe.Health.ToString();
            lblMana.Text = heroe.Mana.ToString();
            lblAttack.Text = heroe.Attack.ToString();
            lblDefence.Text = heroe.Defense.ToString();
            lblMAttack.Text = heroe.MagicAttack.ToString();
            lblMDefence.Text = heroe.MagicDefense.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?\r\n" + "If you leave without saving it will reset your progress", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ChooseHeroPanel chooseHero = new ChooseHeroPanel();
                chooseHero.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(chooseHero);
            }
            
        }
    }
}
