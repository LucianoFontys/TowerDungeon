using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Business.Monsters
{
    class Zombie : Monster
    {
        public Zombie() : base(6, "Zombie", 200, 20, 10, 10, 5)
        {
            // Zombie specific properties and methods can be added here
        }
    }
}
