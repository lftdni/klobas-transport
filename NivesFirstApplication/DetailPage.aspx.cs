using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace KlobasTransport
{
    public partial class DetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            if (!IsPostBack)
            {
                PostaviSeo();
                RenderDetailPage();             

            }
        }
        protected void PostaviSeo()
        {
            Page.Title = "Klobas Transport Detalji";
            Page.MetaDescription = HttpUtility.HtmlEncode("Klobas Transport");
            Page.MetaKeywords = HttpUtility.HtmlEncode("Klobas Transport, klobas usluge prijevoza, rijeka transport tereta");
        }
        protected void RenderDetailPage()
        {
        
            StringBuilder rezultat = new StringBuilder();

            rezultat.AppendLine(@"<div class=""detail"">");
            rezultat.AppendLine(@"<h3>O nama</h3>");
                             
            rezultat.AppendLine(@"<div class=""floatLeftImg"">");
            rezultat.AppendLine(@"<a href=""images/Naslovna1.jpg"" rel=""lightbox"" title=""none""> <img src=""images/Naslovna1.jpg"" alt=""slika1"" width=""150"" title=""Slika test""/> </a>");
			rezultat.AppendLine(@"</div>");

			rezultat.AppendLine(@"<div class=""sdescription"">");
            rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam orci mauris, euismod eget ornare non, 
lacinia vitae quam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rhoncus posuere leo. Praesent at laoreet nulla, quis eleifend est. 
Donec convallis laoreet tortor vitae ornare. Vestibulum lacinia, justo at imperdiet lacinia, sem est cursus quam, dapibus volutpat odio erat eu dolor. 
Proin id tincidunt quam, ut consequat mauris.
Sed iaculis volutpat dolor, ac viverra ligula consectetur sed. Morbi non tempus enim, sit amet accumsan velit. 
Maecenas vitae enim ac dolor mattis tincidunt. Etiam in enim aliquam, ultrices felis vel, luctus risus. 
Donec interdum, tellus et euismod hendrerit, ante ex sollicitudin libero, a dictum augue tortor nec erat. Mauris malesuada et tortor non facilisis. 
Nam consequat tincidunt lorem, sodales rutrum augue faucibus non. Curabitur id pulvinar erat. Morbi nulla metus, maximus sed orci vel, auctor euismod massa. 
Sed erat metus, semper id tristique vel, lobortis porttitor est. Proin ut lacus elementum enim iaculis semper.
Etiam nibh massa, ullamcorper at lorem eget, pretium interdum tellus. 
Cras ante risus, lacinia a interdum vel, congue id est. Nulla pharetra eros purus, a placerat metus ultrices sit amet. 
Nunc scelerisque egestas nunc sit amet accumsan. Nulla vel nunc porttitor justo cursus commodo ut quis eros. In orci velit, pretium et orci ac, maximus tempus lorem. 
Ut ac pellentesque ante. Fusce molestie tempor ante, eget ullamcorper lacus egestas sit amet. Suspendisse ultrices pharetra convallis. Duis in imperdiet velit. 
Vivamus fringilla ante at odio viverra finibus. Integer lobortis ex volutpat est vehicula egestas.</p>");
            rezultat.AppendLine(@"<p>Pellentesque dictum tristique euismod. Sed tincidunt, velit ut hendrerit viverra, mi eros tincidunt nunc, at malesuada dui dui feugiat risus. 
Integer a suscipit leo. Fusce porta mauris eget sagittis ullamcorper. In mattis mi quis tempus gravida. 
Integer viverra massa quis risus egestas, non varius sem vehicula. Nullam ut ante dui. Pellentesque mollis molestie dui quis blandit. 
Sed tortor purus, cursus nec nisi sed, mattis mattis ante. Vestibulum rutrum est ligula, at placerat nunc sollicitudin et. 
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam placerat ultricies purus non aliquam. 
Phasellus porttitor enim eu elit volutpat, id imperdiet magna venenatis.</p>");
            
            rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>");
        
            rezultat.AppendLine(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>");

			rezultat.AppendLine(@"</div>");//zatvara description

            rezultat.AppendLine(@"</div>");
            // zatvori parent elemente
            litDetailPage.Text = rezultat.ToString();
        }


    }
}
