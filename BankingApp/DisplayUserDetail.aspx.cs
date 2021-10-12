using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BBAL;
using BBE;

namespace BankingApp
{
    public partial class DisplayUserDetail : System.Web.UI.Page
    {
        DisplayUserDetailsBAL obj = new DisplayUserDetailsBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
                BindDataToGrind();
        }

        private void BindDataToGrind()
         {
                var respnse = obj.GetAllUserDetails();
                GridView1.DataSource = Response.UserDetails;
                UserDetails.DataBind();
         }

      
    }
}