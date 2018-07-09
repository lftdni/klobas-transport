using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KlobasTransport.AppCode;

namespace KlobasTransport
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {

        public Category[] Kategorije
        {
            get
            {
                return new Category[] 
                {
                    new Category() { Title = "O nama", Link = "/DetailPage.aspx"},
                    new Category() { Title = "Usluge", Link = "/ServicePage.aspx"},
                    new Category() { Title = "Vozni park", Link = "/ContentList.aspx"},
                    new Category() { Title = "Novosti", Link = "/NewsList.aspx"},
                    new Category() { Title = "Kontakt", Link = "/Kontakt.aspx"},
                
                };
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {              
                RenderInformacije();
            }
        }       

        protected void RenderInformacije()
        {
            List<Novost> novosti = DataManager.UcitajZadnjeTriNovosti();            

            StringBuilder rezultat = new StringBuilder();

            rezultat.AppendLine(@"<div id=""media"" class=""group"">");

            for (int i = 0; i < novosti.Count; i++)
            {
                Novost trenutnaNovost = novosti[i]; 
                string itemClass = i % 3 != 0 ? "importantBox" : "importantBoxR"; // provjera 

                rezultat.AppendLine(string.Format(@"<div class=""{0}"">", itemClass));
                rezultat.AppendLine(string.Format(@" <h4> <a href=""NewsDescription.aspx?idNovosti={0}"">  Najnovije: <strong> <span class=""green"">{1}</span> </strong> </a></h4>	", trenutnaNovost.Id, trenutnaNovost.Naslov ));
                rezultat.AppendLine(string.Format(@"<p class=""tweet"">{0}  -<a href=""NewsDescription.aspx?idNovosti={1}"" class=""t-link""> Detaljno </a>	</p>", trenutnaNovost.KratkiOpis, trenutnaNovost.Id));
             
                rezultat.AppendLine(string.Format(@"<p class=""time"">{0:dd.MM.yyyy}</p>", trenutnaNovost.Datum));
                rezultat.AppendLine(@"</div>");
            }

            rezultat.AppendLine("</div>"); 
            litInformacije.Text = rezultat.ToString();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("/SearchResults.aspx?search=" + txtSearch.Text);
        }

        public void PostaviSEO(string pageTitle, string keywords, string description)
        {
            litSeo.Text = string.Format(@"
                    <title>{0}</title>
                    <meta name=""keywords"" content=""{1}""/>
                    <meta name=""description"" content=""{2}""/>",
                pageTitle,
                keywords,
                HttpUtility.HtmlEncode(description));
        }

    }

}