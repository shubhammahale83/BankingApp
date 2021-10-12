using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;
using BDAL;

namespace BBAL
{
    public class WithdrawBAL
    {
        public WithdrawResponseBE GetBalance(WithdrawRequestBE request)
        {
            WithdrawDAL obj = new WithdrawDAL();
            WithdrawResponseBE response = null;
            response = obj.GetBalance(request);
            return response;
        }

        public WithdrawResponseBE GetWithdraw(WithdrawRequestBE request)
        {
            WithdrawDAL obj = new WithdrawDAL();
            WithdrawResponseBE response = null;
            response = obj.GetWithdraw(request);
            return response;
        }
    }
}
