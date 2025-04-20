using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tower_Dungeon.Business.Monsters;

namespace Tower_Dungeon.Business
{
    class FloorManager
    {
        private int floorNumber;

        public FloorManager()
        {
            this.floorNumber = 1;
        }
        public int FloorNumber
        {
            get { return floorNumber; }
            set { floorNumber = value; }
        }

        public Monster GetMonster(Monster monster, int floornumber)
        {
            Monster raisedMonster = monster.StatRaise(monster, floornumber);

            return raisedMonster;
        }

        public void NextFloor()
        {
            floorNumber++;
        }
    }
}
