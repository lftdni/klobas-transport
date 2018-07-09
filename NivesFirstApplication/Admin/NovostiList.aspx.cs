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
    public partial class NovostiList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {               
                UcitajNovosti();
            }
        }
        protected void UcitajNovosti()
        {

            DataTable novosti = DataManager.GetAllNews();
                 
            if (novosti != null)
            {
                gridNovosti.DataSource = novosti;
                gridNovosti.DataBind();
            }

        }
     
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/EditNovosti.aspx");
        }

        protected void gridNovosti_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // dohvati index kliknutog reda - na koji red je korisnik kliknuo
            int rowindex = Convert.ToInt32(e.CommandArgument);

            // pomoću indexa se čita id objekta koji se prikazuje (admin)
            int novostId = Convert.ToInt32(gridNovosti.DataKeys[rowindex].Value);

            switch (e.CommandName)
            { 
                case "ukloni":
                    // obriši admina iz baze na temelju učitanog id-a
                    DataManager.DeleteNovost(novostId);

                    // ponovo učitaj 
                    UcitajNovosti();

                    PrikaziPoruku();
                    break;

                case "izmjeni":
                    Response.Redirect(string.Format("~/Admin/EditNovosti.aspx?idNovosti={0}",novostId));
                    break;

            }           
        }

        private void PrikaziPoruku()
        {
            divPoruka.Visible = true;
        }
    }
}