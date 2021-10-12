using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBE
{
    public class WithdrawResponseBE
    {
        public int status { get; set; }
        public int currentbalance { get; set; }
        public object amount { get; set; }

        public bool Read()
        {
            throw new NotImplementedException();
        }
    }
}
