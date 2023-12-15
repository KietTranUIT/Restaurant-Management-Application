using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Statement
    {
        public static string getLoginSQL = "SELECT username, password FROM manager WHERE username='{0}' and password='{1}'"; 
    }
}
