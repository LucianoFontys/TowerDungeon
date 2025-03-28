using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Business
{
    class Person
    {
        private int id;
        private string fName;
        private string lName;
        private string email;
        private string password;
        private string username;
        private bool isAdmin;

        public Person(int id, string fName, string lName, string email, string password, string username, bool isAdmin)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.password = password;
            this.username = username;
            this.isAdmin = isAdmin;
        }

        
    }
}
