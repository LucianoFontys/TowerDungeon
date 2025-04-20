using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Business.Heroes
{
    abstract class Heroes
    {
        string name;
        int level;
        int health;
        int mana;
        int attack;
        int defense;
        int magicAttack;
        int magicDefense;

        public Heroes(string name, int level, int health, int mana, int attack, int defense, int magicAttack, int magicDefense)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.mana = mana;
            this.attack = attack;
            this.defense = defense;
            this.magicAttack = magicAttack;
            this.magicDefense = magicDefense;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public int MagicAttack
        {
            get { return magicAttack; }
            set { magicAttack = value; }
        }
        public int MagicDefense
        {
            get { return magicDefense; }
            set { magicDefense = value; }
        }
        public void LevelUp()
        {
            level++;
            health += 10;
            mana += 5;
            attack += 2;
            defense += 2;
            magicAttack += 2;
            magicDefense += 2;
        }
    }
}
