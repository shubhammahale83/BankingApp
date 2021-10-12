using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;
using BDAL;

namespace BBAL
{
	public class DepositeBAL
	{
        public DepositeResponseBE GetBalance(DepositeRequestBE request)
        {
            DepositeDAL obj = new DepositeDAL();
            DepositeResponseBE response = null;
            response = obj.GetBalance(request);
            return response;
        }

        public DepositeResponseBE GetDeposite(DepositeRequestBE request)
        {
            DepositeDAL obj = new DepositeDAL();
            DepositeResponseBE response = null;
            response = obj.GetDeposite(request);
            return response;
        }
    }
}
