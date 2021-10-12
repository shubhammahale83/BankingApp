using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;                                                              
using BDAL;

namespace BBAL
{                      
    public class UserLoginBAL:UserRegisterResponseBE
    {
        public UserLoginResponseBE UserLoginSave(UserLoginRequestBE request)
        {
            UserLoginDAL customerLoginObj = new UserLoginDAL();
            UserLoginResponseBE response = null;

            try                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
            {
                response = customerLoginObj.UserLoginSave(request);
            }
            catch (Exception ex)
            {
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
    }
}
