using DZ1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1.Models
{
    public class UserSingleton
    {
        private static Users _user;

        public static Users Instance()
        {
            if (_user == null)
                _user = new Users();


            return _user;
        }
    }
}
