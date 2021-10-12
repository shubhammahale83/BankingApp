using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;
using BDAL;

namespace BBAL
{
    public class DisplayUserDetailsBAL
    {
        public DisplayUserDetailsResponseBE GetAllUserDetails()
        {
            //WithdrawDAL obj = new WithdrawDAL();
            DisplayUserDetailsResponseBE response = null;
            DisplayUserDetailsDAL obj = new DisplayUserDetailsDAL();
            response = obj.GetAllUserDetails();
            return response;
        }
    }
    }
}
