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
using Tower_Dungeon.Business;
using Tower_Dungeon.Business.Monsters;
using Tower_Dungeon.Pannels;

namespace Tower_Dungeon.Pannels
{
    public partial class FloorBattlePanel: UserControl
    {
        private Monster monster;
        private Heroes hero;
        private RandomMonster randomMonster = new RandomMonster();
        private FloorManager floorManager = new FloorManager();

        public FloorBattlePanel(int choice)
        {
            InitializeComponent();
            hero = ChosenHero(choice);
            
            monster = SetupMonster();
            FloorPlanner();
        }

        private Heroes ChosenHero(int choice)
        {
            switch (choice)
            {
                case 1:
                    hero = new Warrior();
                    SetupBattle(choice, hero);
                    pbxHeroPortrait.Image = Properties.Resources.WarriorPortrait;
                    return hero;
                case 2:
                    hero = new Wizard();
                    SetupBattle(choice, hero);
                    pbxHeroPortrait.Image = Properties.Resources.WizardPortrait;
                    return hero;
                case 3:
                    hero = new Rogue();
                    SetupBattle(choice, hero);
                    pbxHeroPortrait.Image = Properties.Resources.RoguePortrait;
                    return hero;
                default:
                    break;
            }
            return null;
        }

        private Monster SetupMonster()
        {
            monster = randomMonster.GetRandomMonster();
            return monster;
        }

        private void FloorPlanner()
        {
            monster = floorManager.GetMonster(monster, floorManager.FloorNumber);
            prbMonsterHealth.Maximum = monster.Health;
            prbMonsterHealth.Minimum = 0;
            prbMonsterHealth.Value = monster.Health;
            lblMonsterName.Text = monster.Name;

            switch (monster)
            {
                case Goblin goblin:
                    pbxMonsterPortrait.Image = Properties.Resources.Goblin;
                    break;
                case Skeleton skeleton:
                    pbxMonsterPortrait.Image = Properties.Resources.Skeleton;
                    break;
                case Zombie zombie:
                    pbxMonsterPortrait.Image = Properties.Resources.Zombie;
                    break;
                case Dragon dragon:
                    pbxMonsterPortrait.Image = Properties.Resources.Dragon;
                    break;
                case Beholder beholder:
                    pbxMonsterPortrait.Image = Properties.Resources.Beholder;
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

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int damage = hero.Attack - monster.Defense;
            if (damage < 0)
            {
                damage = 0;
            }

            monster.Health -= damage;
            tbxEvents.Text += $"{hero.Name} attacked {monster.Name} for {damage} damage!\r\n";
            if (monster.Health < 0)
            {
                monster.Health = 0;
                MessageBox.Show("You defeated the monster!");
                floorManager.NextFloor();
                monster = SetupMonster();
                hero.LevelUp();
                FloorPlanner();
            }
            prbMonsterHealth.Value = monster.Health;
            MonsterAttack();

        }
        private void MonsterAttack()
        {
            int damage = monster.AttackDamage(hero.Defense);
            if (damage < 0)
            {
                damage = 0;
            }
            hero.Health -= damage;
            if (hero.Health < 0)
            {
                hero.Health = 0;
                tbxEvents.Text += $"{monster.Name} killed the {hero.Name}!\r\n";
                MainMenuPannel mainMenu = new MainMenuPannel();
                mainMenu.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(mainMenu);
            }
            tbxEvents.Text += $"{monster.Name} attacked {hero.Name} for {damage} damage!\r\n";
            lblHealth.Text = hero.Health.ToString();
        }
    }
}
