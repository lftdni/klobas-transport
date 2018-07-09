using KlobasTransport.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KlobasTransport.Administration
{
    public partial class BannerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UcitajBanere();                  
            }
        }

        protected void UcitajBanere()
        {
            DataTable baneri = DataManager.GetAllBanners();

            if (baneri != null)
            {
                gridBaneri.DataSource = baneri;
                gridBaneri.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/EditBanner.aspx");
        }

        protected void gridBaneri_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // dohvati index kliknutog reda - na koji red je korisnik kliknuo
            int rowindex = Convert.ToInt32(e.CommandArgument);

            // pomoću indexa se čita id objekta koji se prikazuje 
            int banerId = Convert.ToInt32(gridBaneri.DataKeys[rowindex].Value);

            switch (e.CommandName)
            {
                case "ukloni":
                    // obriši admina iz baze na temelju učitanog id-a
                    DataManager.DeleteBaner(banerId);

                    // ponovo učitaj sve admine - osvježi prikaz
                    UcitajBanere();

                    PrikaziPoruku();
                    break;

                case "izmjeni":
                    Response.Redirect(string.Format("~/Admin/EditBanner.aspx?idBanera={0}", banerId));
                    break;
            }                  
        }

        private void PrikaziPoruku()
        {
            divPoruka.Visible = true;
        }
    }
}