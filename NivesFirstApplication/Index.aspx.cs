using KlobasTransport.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KlobasTransport
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PostaviSeo();
                RenderBaneri(); 
            }
        }

        protected void PostaviSeo()
        {
            Page.Title = "Dobro došli na stranice firme Klobas Transport";
            Page.MetaDescription = HttpUtility.HtmlEncode("Dobro došli na stranice firme Klobas Transport");
            Page.MetaKeywords = HttpUtility.HtmlEncode("transport, prijevoz kontejnera, rijeka prijevoz");
        }

        protected void RenderBaneri()
        {
            List<Banner> baneri = DataManager.UcitajSveBanere();

            // ako nema banera ne renderira ih se
            if (baneri == null || baneri.Count < 1)
            {
                return;
            }


            StringBuilder rezultat = new StringBuilder();
            
            rezultat.AppendLine(@"<div id=""slides"">");
            rezultat.AppendLine(@"<div class=""slides_container"">");

            for (int i = 0; i < baneri.Count; i++)
            {
                Banner trenutniBaner = baneri[i];

                rezultat.AppendLine(@"<div>" );
                rezultat.AppendLine(string.Format(@"<img src=""{0}"" alt=""{1}"" width=""871"" height=""370"" />", trenutniBaner.PutanjaSlike.Replace("~", ""), trenutniBaner.Naslov));

                rezultat.AppendLine(@"<div class=""slide-right"">");
                rezultat.AppendLine(string.Format(@"<h1 class=""slide-heading"">{0}</h1>", trenutniBaner.Naslov));
                rezultat.AppendLine(@"<p class=""info"">");
                rezultat.AppendLine(string.Format(@"{0}",trenutniBaner.KratkiOpis));
                rezultat.AppendLine(@"</p>");

                if (!string.IsNullOrEmpty(trenutniBaner.Link))
                {
                    rezultat.AppendLine(string.Format(@" <p><a href=""{0}"" class=""readmore"">Saznajte više </a></p>", trenutniBaner.Link));
                }
                
                rezultat.AppendLine(@"</div>");
                rezultat.AppendLine(@"</div>");
            }

            rezultat.AppendLine("</div>"); // zatvaram div id slides
            rezultat.AppendLine("</div>"); // zatvaram div class slides_container

            // zatvori parent elemente

            litBanners.Text = rezultat.ToString();
        }
        
        
    }
}