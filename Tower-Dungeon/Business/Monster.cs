using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Business
{
    class Monster
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

        public int Attack()
        {
            return attack;
        }

        public int MagicAttack()
        {
            return magicAttack;
        }

        public int Defense()
        {
            return defense;
        }

        public int MagicDefense()
        {
            return magicDefense;
        }
    }
}
