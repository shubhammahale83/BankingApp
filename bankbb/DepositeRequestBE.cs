using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBE
{
    public class DepositeRequestBE: BaseRequest
    {
        public string Accno { get; set; }
        public string Amount { get; set; }
        public string ifsccode { get; set; }
    }
}
