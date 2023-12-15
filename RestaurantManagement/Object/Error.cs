using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Error
    {
        public string Message;
        public bool Status;
        public Error()
        {
            Message = "";
            Status = true;
        }
    }
}
