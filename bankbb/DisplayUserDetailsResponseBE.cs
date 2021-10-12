using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBE
{
    public class DisplayUserDetailsResponseBE: BaseResponse
    {
        public List<UserRegisterRequestBE> UserDetails { get; set; }
    }
}
