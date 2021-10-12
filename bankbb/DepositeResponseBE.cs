using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBE
{
    public class DepositeResponseBE : BaseResponse
    {
        public int status { get; set; }
        public string currentbalance { get; set; }
        public object amount { get; set; }

        
    }
}
