using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tower_Dungeon.Business.Monsters;

namespace Tower_Dungeon.Business
{
    class RandomMonster
    {
        Goblin goblin = new Goblin();
        Skeleton skeleton = new Skeleton();
        Zombie zombie = new Zombie();
        Dragon dragon = new Dragon();
        Beholder beholder = new Beholder();
        // Add more monsters as needed

        public Monster GetRandomMonster()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6); // Generates a number between 1 and 
            switch (randomNumber)
            {
                case 1:
                    return goblin;
                case 2:
                    return skeleton;
                case 3:
                    return zombie;
                case 4:
                    return dragon;
                case 5:
                    return beholder;
                default:
                    throw new Exception("Invalid random number generated.");
            }
        }
    }
}
