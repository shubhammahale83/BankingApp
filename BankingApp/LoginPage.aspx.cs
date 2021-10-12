using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BBE;
using BBAL;

namespace BankingApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserRegisterBAL UserRegisterObj = new UserRegisterBAL();
        UserLoginBAL LoginObj = new UserLoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginRequestBE request = new UserLoginRequestBE();

            request.UserName = txtUserName.Text;
            request.Password = txtPassword.Text;

            var response = LoginObj.UserLoginSave(request);
            if (response.Status == 1)
            {
                lblmes.Text = "Login Successfully!";
            }
            else
            {
                lblmes.Text = "Login Failed!";
            }
        }
    }
}