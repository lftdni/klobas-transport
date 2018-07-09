using KlobasTransport.AppCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KlobasTransport.Administration
{
    public partial class EditBanner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int idBanera = UcitajIdBanera();

                Banner baner = DataManager.UcitajBaner(idBanera);

                if (baner == null)
                {
                    return;
                }
                txtNaslov.Text = baner.Naslov;
                imgContentImage.ImageUrl = baner.PutanjaSlike;
                txtKratkiOpis.Text = baner.KratkiOpis;
                txtLink.Text = baner.Link;

            }   
        }

        protected void btnSpremi_Click(object sender, EventArgs e)
        {
            Banner baner = new Banner();

            baner.Id = UcitajIdBanera();
            baner.Naslov = txtNaslov.Text;
            baner.PutanjaSlike = imgContentImage.ImageUrl;
            baner.KratkiOpis = txtKratkiOpis.Text;
            baner.Link = txtLink.Text;
            baner.IdAdmin = UcitajIdAdmina();

            if (baner.Id > 0) // provjera za Id
            {
                DataManager.IzmjeniBaner(baner);
                PrikaziPoruku("Baner uspješno izmijenjen ");
            }
            else
            {
                DataManager.SpremiBaner(baner);
                PrikaziPoruku("Baner uspješno unesen ");
                OcistiPolja();
            }
            
        }

        protected void btnPonisti_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/BannerList.aspx");          
        }
        
        protected void btnRemoveImage_Click(object sender, EventArgs e)  //brisanje slike
        {
            imgContentImage.ImageUrl = "";
        }

        protected void btnUploadImage_Click(object sender, EventArgs e)   //spremanje
        {
            if (!fuImage.HasFile)
            {
                return;
            }

            string relativeFilePath = string.Format("~/Upload/{0}", fuImage.FileName); // definira relativnu putanju i mjesto za upload
            string serverFilePath = Server.MapPath(relativeFilePath); //fizicko mjesto

            fuImage.SaveAs(serverFilePath); //metoda spremanja

            imgContentImage.ImageUrl = relativeFilePath;
        }

        private void PrikaziPoruku(string poruka)
        {
            liPoruka.InnerText = poruka;
            divPoruka.Visible = true;
        }

        private void OcistiPolja()  // metoda ciscenja polja kada je unesen
        {
            txtNaslov.Text = null;
            txtKratkiOpis.Text = null;
            imgContentImage.ImageUrl = null;
            txtLink.Text = null;
        }

        protected int UcitajIdBanera()
        {
            int id = -1;

            int.TryParse(Request.QueryString["idBanera"], out id);

            return id;
        }

        protected int UcitajIdAdmina()
        {
            Admin admin = (Admin)Session["Admin"]; // izvadi admin iz sesije

            return admin.Id;
        }
       
    }
}