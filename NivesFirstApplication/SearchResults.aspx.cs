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
    public partial class SearchResults : System.Web.UI.Page
    {
        protected List<Novost> FiltriraneNovosti()
        {            
            string keyword = Request.QueryString["search"];   //pretraga po kljucnoj rijeci

            List<Novost> rezultat = new List<Novost>();

            if (!string.IsNullOrEmpty(keyword))
            {
                rezultat = DataManager.PretraziNovosti(keyword);
            }
            return rezultat;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PostaviSeo();
                RenderNewsList();
            }
        }

        protected void PostaviSeo()
        {
            Page.Title = HttpUtility.HtmlEncode(string.Format(@"Rezultati pretrage za pojam ""{0}"" ", Request.QueryString["search"]));
            Page.MetaDescription = "Rezultati pretrage";
            Page.MetaKeywords = "Rezultati, pretrage, Klobas Transport, prijevoz rijeka";
        }

        protected void RenderNewsList()
        {           
            StringBuilder rezultat = new StringBuilder();

            rezultat.AppendLine(@"<div class=""list"">");
            rezultat.AppendLine(string.Format(@"<h3>Rezultati pretrage za pojam ""{0}""</h3>", Request.QueryString["search"]));

            List<Novost> novosti = FiltriraneNovosti();

            if (novosti.Count < 1)
            {
                // prikazi poruku
                rezultat.AppendLine(@"<div class=""notification-attention"">
						<ul>
							<li>Za traženi pojam nije pronađen niti jedan rezultat </li>
						</ul>
					</div>");
            }
            else
            {
                foreach (Novost novost in novosti)
                {
                    rezultat.AppendLine(@"<div class=""item list2"">");
                    rezultat.AppendLine(string.Format(@"<h4>{0}</h4>", novost.Naslov));
                    rezultat.AppendLine(@"<div class=""sdescription"">");
                    rezultat.AppendLine(string.Format(@"<p>{0}</p>", novost.KratkiOpis));

                    rezultat.AppendLine(string.Format(@"<p class=""readMoreP"">"));
                    rezultat.AppendLine(string.Format(@"<a href=""NewsDescription.aspx?idNovosti={0}"" class=""readmore"">Saznajte više</a>", novost.Id));
                    rezultat.AppendLine(string.Format(@"</p>"));

                    rezultat.AppendLine(@"</div>");
                    rezultat.AppendLine(@"<div class=""clear""></div>");
                    rezultat.AppendLine(@"</div>");
                }
            }

            rezultat.AppendLine("</div>");        
            litNewsList.Text = rezultat.ToString();
          
        }
    }
}