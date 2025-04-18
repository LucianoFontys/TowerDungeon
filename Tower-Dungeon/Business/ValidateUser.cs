﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tower_Dungeon.Data;

namespace Tower_Dungeon.Business
{
    class ValidateUser
    {
        public bool ValidateUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                return false;
            }
            else if (Database_Connection.GetUsername(username) == null)
            {
                return false;
            }
            else if (Database_Connection.GetUsername(username) != username)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatePassword(string password, string username)
        {
            if (String.IsNullOrEmpty(password))
            {
                return false;
            }
            else if (PassHash.Verify(password, Database_Connection.GetPassword(username)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
