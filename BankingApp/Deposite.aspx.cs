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
    public partial class Deposite : System.Web.UI.Page
    {
        DepositeBAL newObj = new DepositeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeposite_Click(object sender, EventArgs e)
        {
            DepositeRequestBE request = new DepositeRequestBE();
            request.Accno = TxtAcc.Text;
            request.ifsccode = txtIFSC.Text;
            request.Amount = txtAmount.Text;
            var response = newObj.GetBalance(request);
        }

       
        protected void btnShow_Click(object sender, EventArgs e)
        {
            DepositeRequestBE request = new DepositeRequestBE();
            request.Accno = TxtAcc.Text;
            request.ifsccode = txtIFSC.Text;
            request.Amount = txtAmount.Text;

            var response = newObj.GetBalance(request);
            lblbal.Text += "   -" + response.currentbalance.ToString();
        }
    }
}