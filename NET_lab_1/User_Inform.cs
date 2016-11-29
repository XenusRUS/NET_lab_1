using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_lab_1
{
    class User_Inform
    {
        int Age_User = 15;
        string Name_User = "LoL";

        public int Age
        {
            get
            {
                return Age_User;
            }
            set
            {
                Age_User = value;
            }
        }

        public string Name
        {
            get
            {
                return Name_User;
            }
        }
    }
}
