using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;

namespace BBE
{
    public class UserRegisterRequestBE : BaseRequest
    {
        public string Name { get; set; }
        public string Accno { get; set; }
        public string Mnumber { get; set; }
        public string Adharnumber { get; set; }
        public new string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public new string UserName { get; set; }
        public string Address { get; set; }
        public string Statement { get; set; }
        public string CustomerID { get; set; }
    }
}
