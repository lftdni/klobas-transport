using KlobasTransport.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KlobasTransport
{
    public partial class NewsDescription : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RenderirajNovost();
            }
        }

        protected void PostaviSeo(Novost novost)
        {
            Page.Title = novost.Naslov;
            Page.MetaDescription = HttpUtility.HtmlEncode(novost.KratkiOpis);
            Page.MetaKeywords = novost.KratkiOpis;
        }

        protected void RenderirajNovost()
        {
            int idNovosti = UcitajIdNovosti();

            Novost vijest = DataManager.UcitajNovost(idNovosti);

            if (vijest == null)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, "Nije pronađeno");
            }

            PostaviSeo(vijest);

            StringBuilder rezultat = new StringBuilder();

            rezultat.AppendLine(@"<div class=""detail"" id=""vijest"">");          
            
            Novost novost = vijest;               

            rezultat.AppendLine(string.Format(@"<h3>{0}</h3>", novost.Naslov));
            rezultat.AppendLine(@"<div class=""sdescription"">");
               
            rezultat.AppendLine(novost.DugiOpis);

            rezultat.AppendLine(@"<p class=""readMoreP"">
                        <a href=""#"" onclick=""history.go(-1);return false;"" class=""readmore"">Natrag</a>
                        </p>");

            rezultat.AppendLine(@"</div>");
            rezultat.AppendLine(@"<div class=""clear""></div>");               
           
            rezultat.AppendLine("</div>");        
         
            litDetaljiNovosti.Text = rezultat.ToString();
        }

        protected int UcitajIdNovosti()
        {
            int id = -1;
            int.TryParse(Request.QueryString["idNovosti"], out id);            
            return id;
        }


    }
}