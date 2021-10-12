using BBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDAL;

namespace BBAL
{
    public class UserRegisterBAL
    {
        public UserRegisterResponseBE UserRegisterSave(UserRegisterRequestBE request)
        {
            UserRegisterDAL customerRegisterObj = new UserRegisterDAL();
            UserRegisterResponseBE response = null;

            try { 
                response = customerRegisterObj.UserRegisterSave(request);
            }
            catch (Exception ex)
            {
                response.ErrorMsg = ex.Message;
            }
            return response;  
        }
    }
}
