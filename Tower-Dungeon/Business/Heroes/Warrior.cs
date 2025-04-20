using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Business.Heroes
{
    class Warrior : Heroes
    {
        public Warrior() : base("Warrior", 1, 100, 0, 10, 5, 0, 0)
        {
            
        }
        
    }
}
