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
    public partial class ContentList : System.Web.UI.Page
    {
        public SiteContent[] Sadrzaji
        {
            get
            {
                return new SiteContent[] 
                {
                    new SiteContent() 
                    { 
                        Id = 1,  
                        Title = "Naslov 1",
                        ShortDescription= @"Kratki opis Lorem ipsum dolor sit amet, 
                        consectetur adipiscing elit. Donec ultricies sodales dui eu ultrices. 
                         Praesent nulla risus, rutrum quis posuere at, hendrerit eu orci. Nullam sodales 
                        facilisis purus, vel tempor lorem. Fusce feugiat erat sit amet ipsum malesuada luctus.
                        Maecenas cursus, dui eget tempor egestas, neque mauris dictum augue, commodo consectetur metus elit ac est. 
                       Praesent dictum luctus felis, sit amet suscipit eros commodo vitae. Nullam cursus augue a lacus dictum, 
                           a suscipit sem molestie. Nullam vitae iaculis tortor, sit amet vehicula tortor. Aenean bibendum id purus vel tincidunt." ,
                       
                        ImagePath = "Slike/PB300126.jpg" 
                    } ,
                    new SiteContent() 
                    {
                        Id = 2, 
                        Title = "Naslov 2", 
                        ShortDescription= @"Lorem ipsum dolor sit amet, 
                        consectetur adipiscing elit. Donec ultricies sodales dui eu ultrices. 
                         Praesent nulla risus, rutrum quis posuere at, hendrerit eu orci. Nullam sodales 
                        facilisis purus, vel tempor lorem. Fusce feugiat erat sit amet ipsum malesuada luctus.
                        Maecenas cursus, dui eget tempor egestas, neque mauris dictum augue, commodo consectetur metus elit ac est. 
                       Praesent dictum luctus felis, sit amet suscipit eros commodo vitae. Nullam cursus augue a lacus dictum, 
                           a suscipit sem molestie. Nullam vitae iaculis tortor, sit amet vehicula tortor. Aenean bibendum id purus vel tincidunt.", 
                       
                        ImagePath = "Slike/PB300126.jpg" 
                    } ,
                    new SiteContent() 
                    {
                        Id = 3, 
                        Title = "Naslov 3", 
                        ShortDescription= @"Lorem ipsum dolor sit amet, 
                        consectetur adipiscing elit. Donec ultricies sodales dui eu ultrices. 
                         Praesent nulla risus, rutrum quis posuere at, hendrerit eu orci. Nullam sodales 
                        facilisis purus, vel tempor lorem. Fusce feugiat erat sit amet ipsum malesuada luctus.
                        Maecenas cursus, dui eget tempor egestas, neque mauris dictum augue, commodo consectetur metus elit ac est. 
                       Praesent dictum luctus felis, sit amet suscipit eros commodo vitae. Nullam cursus augue a lacus dictum, 
                           a suscipit sem molestie. Nullam vitae iaculis tortor, sit amet vehicula tortor. Aenean bibendum id purus vel tincidunt.", 
                      
                        ImagePath = "Slike/PB300126.jpg"
                    }, 
                    new SiteContent() 
                    {
                        Id = 3, 
                        Title = "Naslov", 
                        ShortDescription= "Opis stavke",
                       
                        ImagePath = "Slike/PB300126.jpg"
                    },
                    new SiteContent() 
                    {
                        Id = 3, 
                        Title = "Naslov", 
                        ShortDescription= "Opis stavke", 
                    
                        ImagePath = "Slike/PB300126.jpg"
                    } 
                };
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PostaviSeo();
                RenderContentList();                
            }
        }
        protected void PostaviSeo()
        {
            Page.Title = "Klobas Transport usluge";
            Page.MetaDescription = HttpUtility.HtmlEncode("Klobas Transport usluge");
            Page.MetaKeywords = HttpUtility.HtmlEncode("Klobas Transport, klobas usluge prijevoza, vozni park Klobas, rijeka transport");
        }
        protected void RenderContentList()
        {

            StringBuilder rezultat = new StringBuilder();

            rezultat.AppendLine(@"<div class=""detail"">");
            rezultat.AppendLine(@"<h3>Vozni park</h3>");

            foreach (SiteContent sadrzaj in Sadrzaji)
            {
                rezultat.AppendLine(@"<div class=""item list2"">");
                rezultat.AppendLine(string.Format(@"<h4>{0}</h4>", sadrzaj.Title));

                if (!string.IsNullOrEmpty(sadrzaj.ImagePath))
                {
                    rezultat.AppendLine(@"<div class=""floatLeftImg"">");
                    rezultat.AppendLine(string.Format(@"<a href=""{0}"" rel=""lightbox"" title=""Slika1"" alt=""slika1"" width=""466"">", sadrzaj.ImagePath));
                    rezultat.AppendLine(string.Format(@"<img src=""{0}"" alt=""slika1"" width=""266"" title=""Slika test""/></a>", sadrzaj.ImagePath));
                    rezultat.AppendLine(string.Format("Ovo je strig"));
                    rezultat.AppendLine(@"</div>");
                }

                rezultat.AppendLine(@"<div class=""sdescription"">");

                rezultat.AppendLine(string.Format(@"<p>{0}</p>", sadrzaj.ShortDescription));
                rezultat.AppendLine(@"</div>");

                rezultat.AppendLine(@"<div class=""clear""></div>");
                rezultat.AppendLine(@"</div>");
            }

            rezultat.AppendLine("</div>");

            litContentList.Text = rezultat.ToString();


        }


    }
}