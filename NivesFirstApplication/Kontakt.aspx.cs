using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using System.Net.Mail;
using System.Net;
using System.Web.Configuration;


namespace KlobasTransport
{
    public partial class Kontakt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PostaviSeo();
            }
        }

        protected void PostaviSeo()
        {
            Page.Title = "Pošaljite upit";
            Page.MetaDescription = HttpUtility.HtmlEncode("Pošaljite upit");
            Page.MetaKeywords = HttpUtility.HtmlEncode("pošaljite, upit");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Validate();

            if (!IsValid)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Ime: {0}", txtIme.Text));
            sb.AppendLine(string.Format("Prezime: {0}", txtPrezime.Text));
            sb.AppendLine(string.Format("E-mail: {0}", txtEmail.Text));
            sb.AppendLine(string.Format("Telefon: {0}", txtPhone.Text));
            sb.AppendLine(string.Format("Poruka: {0}", txtPoruka.Text));

            string poruka = sb.ToString();

            if (PosaljiEmail("Novi korisnički upit", poruka))
            {
                ShowSuccessMessage("Poruka uspješno poslana");
                queryForm.Visible = false;
            }

            else
            {
                ShowAttentionMessage("Došlo je do greške prilikom slanja poruke. Molimo pokušajte ponovo.");
            }
        }

        protected void ShowSuccessMessage(string message)
        {
            litMessages.Text = string.Format(@"<div class=""notification-success"">
						<ul>
							<li>{0}</li>
						</ul>
					</div>", message);
        }

        protected void ShowAttentionMessage(string message)
        {
            litMessages.Text = string.Format(@"<div class=""notification-attention"">
						<ul>
							<li>{0}</li>
						</ul>
					</div>", message);
        }        

        public static bool PosaljiEmail(string naslovPoruke, string poruka)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.Subject = naslovPoruke;
            mailMessage.Body = poruka;
            mailMessage.IsBodyHtml = false;
            mailMessage.Priority = MailPriority.Normal;
            mailMessage.From = new MailAddress(WebConfigurationManager.AppSettings["ContactMailFrom"]);
            mailMessage.To.Add(WebConfigurationManager.AppSettings["ContactMailTo"]);
            
            SmtpClient smtp = new SmtpClient();
            
            smtp.Host = WebConfigurationManager.AppSettings["SmtpHost"]; //"mail.t-com.hr";
            smtp.Credentials = new NetworkCredential(WebConfigurationManager.AppSettings["SmtpUsername"], WebConfigurationManager.AppSettings["SmtpPassword"]);            

            bool result = true;
            try
            {
                smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            return result;
        }

    }

     
}