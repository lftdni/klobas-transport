using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using KlobasTransport.AppCode;

namespace KlobasTransport
{
    public partial class NewsList : System.Web.UI.Page
    {
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
           Page.Title = @"Novosti";
           Page.MetaDescription = HttpUtility.HtmlEncode("Novosti Klobas transport");
           Page.MetaKeywords = "novosti klobas, klobas, transport, transport rijeka";
        }

        protected void RenderNewsList()
        {
            List<Novost> novosti = DataManager.UcitajSveNovosti();
            StringBuilder rezultat = new StringBuilder();          

            rezultat.AppendLine(@"<div class=""detail"">");
            rezultat.AppendLine(@"<h3>Arhiva Vijesti</h3>");

            for (int i = 0; i < novosti.Count; i++)
            {
                Novost novost = novosti[i];
                rezultat.AppendLine(@"<div class=""item list2"">");
                rezultat.AppendLine(string.Format(@"<h4>{0}</h4>", novost.Naslov));
                rezultat.AppendLine(@"<div class=""sdescription"">");
               
                rezultat.AppendLine(string.Format(@"<p>{0}</p>", novost.KratkiOpis));

                rezultat.AppendLine(string.Format(@"<p class=""readMoreP"">" ));
                rezultat.AppendLine(string.Format(@"<a href=""NewsDescription.aspx?idNovosti={0}"" class=""readmore"">Saznajte više</a>", novost.Id)); 
			    rezultat.AppendLine(string.Format(@"</p>"));
               
                rezultat.AppendLine(@"</div>");
                rezultat.AppendLine(@"<div class=""clear""></div>");
                rezultat.AppendLine(@"</div>");
            }

            rezultat.AppendLine("</div>");         

            //rezultat.AppendLine(@"<div class=""paging"">");
            //rezultat.AppendLine("<ul>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""Prva"">&lt;&lt;</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""Prethodna"">&lt;</a></li>");
            //rezultat.AppendLine(@"<li class=""active"">1</li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""2"">2</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""3"">3</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""4"">4</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""5"">5</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""6"">6</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""7"">7</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""8"">8</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""9"">9</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""Sljedeća"">&gt;</a></li>");
            //rezultat.AppendLine(@"<li><a href=""#"" title=""Posljednja"">&gt;&gt;</a></li>");
            //rezultat.AppendLine(@"</ul>");
            //rezultat.AppendLine(@"</div>");

            litNewsList.Text = rezultat.ToString();

        }
    }
}
