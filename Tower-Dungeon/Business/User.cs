using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Business
{
    class User : Person
    {
        private string username;
        public User(int id, string fName, string lName, string email, string password, string username) : base(id, fName, lName, email, password)
        {
            this.username = username;
        }
    }
}
