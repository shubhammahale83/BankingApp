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
    public partial class UserRegister : System.Web.UI.Page
    {
        UserRegisterBAL UserRegisterObj = new UserRegisterBAL();
        UserLoginBAL ob = new UserLoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegisterRequestBE request = new UserRegisterRequestBE();

            request.Name = txtUserName.Text;
            request.Accno = txtAccount.Text;
            request.Adharnumber = txtAdhar.Text.ToString();
            request.Mnumber = txtMobile.Text.ToString();
            request.Password = txtPass.Text;
            request.PasswordConfirm = txtPassConf.Text;
            request.UserName = txtUserLog.Text;
            request.Address = txtAddress.Text;
            request.Statement = "INSERT";

            var response = UserRegisterObj.UserRegisterSave(request);
            if (response.Status == 1)
            {
                lblmes.Text = "Registration Successfully!";
            } 
            else   
            {
                lblmes.Text = "Failed!";
            }
        }
    }
}