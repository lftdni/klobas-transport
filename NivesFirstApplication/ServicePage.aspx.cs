using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace KlobasTransport
{
    public partial class ServicePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               PostaviSeo();
               RenderServices();               
            }
        }

        protected void PostaviSeo()
        {
            Page.Title = "Vozni park Klobas";
            Page.MetaDescription = HttpUtility.HtmlEncode("Klobas transport vozni park");
            Page.MetaKeywords = HttpUtility.HtmlEncode("KlobasTrasnport, usluge prijevoza, prijevoz kontejnera, rijeka prijevoz, prijevoz tereta rijeka, transport tereta");
        }

        protected void RenderServices()
        {
                StringBuilder rezultat = new StringBuilder();

                rezultat.AppendLine(@"<div class=""detail"">");
                rezultat.AppendLine(@"<h3>Usluge</h3>");           

                rezultat.AppendLine(@"<div class=""floatLeftImg"">");
                rezultat.AppendLine(@"<a href=""slike/PB300126.jpg"" rel=""lightbox"" title=""none""> <img src=""slike/PB300126.jpg"" alt=""slika1"" width=""150"" title=""Slika test""/> </a>");
                rezultat.AppendLine(@"</div>");

                rezultat.AppendLine(@"<div class=""sdescription"">");
                rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
         Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>");
                rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, 
                        consectetur adipiscing elit. Donec ultricies sodales dui eu ultrices. 
                         Praesent nulla risus, rutrum quis posuere at, hendrerit eu orci. Nullam sodales 
                        facilisis purus, vel tempor lorem. Fusce feugiat erat sit amet ipsum malesuada luctus.
                        Maecenas cursus, dui eget tempor egestas, neque mauris dictum augue, commodo consectetur metus elit ac est. 
                       Praesent dictum luctus felis, sit amet suscipit eros commodo vitae. Nullam cursus augue a lacus dictum, 
                           a suscipit sem molestie. Nullam vitae iaculis tortor, sit amet vehicula tortor. Aenean bibendum id purus vel tincidunt.</p>");
                            

                rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>");
                rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>");

                rezultat.AppendLine(@"</div>");//zatvara description

            rezultat.AppendLine(@"</div>");
           
            litServicePage.Text = rezultat.ToString();    //pretvorba u znakove
        
        }

    }
}