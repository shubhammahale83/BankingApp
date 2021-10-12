using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApp
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblmes.Text = "in button";
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("vibishnathangopi1999@gmail.com");
            msg.To.Add(txtto.Text);
            msg.Subject = "Email with Attachements:)";
            msg.Body = txtBody.Text;
            msg.IsBodyHtml = true;
            if (FileUpload1.HasFile)
            {
                msg.Attachments.Add(new Attachment(FileUpload1.PostedFile.InputStream, FileUpload1.FileName));
            }
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntc = new NetworkCredential();
            ntc.UserName = "shubhammahale83@gmail.com";
            ntc.Password = "shubh1232";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = ntc;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            lblmes.Text = "Email Send Successfully";
        }
    }
}