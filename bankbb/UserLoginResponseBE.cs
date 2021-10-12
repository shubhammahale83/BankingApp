using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBE
{
    public class UserLoginResponseBE: BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string UserName { get; set; }
    }
}
