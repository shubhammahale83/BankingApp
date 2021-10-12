using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;

namespace BBE
{
    public class BaseResponse
    {
        public int Status { get; set; }
        public int  ErrorNo { get; set; }
        public string ErrorMsg { get; set; }
    }
}
