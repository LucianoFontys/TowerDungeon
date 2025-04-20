using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tower_Dungeon.Business.Heroes;

namespace Tower_Dungeon.Business
{
    abstract class Monster
    {
        protected int id;
        protected string name;
        protected int health;
        protected int attack;
        protected int magicAttack;
        protected int defense;
        protected int magicDefense;

        public Monster(int id, string name, int health, int attack, int magicAttack, int defense, int magicDefense)
        {
            this.id = id;
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.magicAttack = magicAttack;
            this.defense = defense;
            this.magicDefense = magicDefense;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int MagicAttack
        {
            get { return magicAttack; }
            set { magicAttack = value; }
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public int MagicDefense
        {
            get { return magicDefense; }
            set { magicDefense = value; }
        }

        public Monster StatRaise(Monster monster, int floor)
        {
            monster.health += floor * 10;
            monster.attack += floor * 2;
            monster.magicAttack += floor * 2;
            monster.defense += floor * 1;
            monster.magicDefense += floor * 1;
            return monster;
        }

        public int AttackDamage(int heroDefence)
        {
            Random random = new Random();
            attack = random.Next(attack - 5, attack + 5);
            int damage = attack - heroDefence;

            if (damage < 0)
            {
                damage = 0;
            }
            return damage;
        }
    }
}
