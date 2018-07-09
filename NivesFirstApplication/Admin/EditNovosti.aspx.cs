using KlobasTransport.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KlobasTransport.Administration
{
    public partial class EditNovosti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int idNovosti = UcitajIdNovosti();

                Novost vijest = DataManager.UcitajNovost(idNovosti);               

                if (vijest == null)
                {
                    return;
                }
                txtNaslov.Text = vijest.Naslov;
                txtDatum.Text = vijest.Datum.ToShortDateString();
                txtKratkiO.Text = vijest.KratkiOpis;
                txtDugiO.Text = vijest.DugiOpis;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Validate();

            if (!IsValid)
            {
                return;
            }
                        
            Novost novost = new Novost();

            novost.Id = UcitajIdNovosti();
            novost.Naslov = txtNaslov.Text;
            novost.KratkiOpis = txtKratkiO.Text;
            novost.DugiOpis = txtDugiO.Text;
            novost.Datum = DateTime.Parse(txtDatum.Text);
            novost.IdAdmin = UcitajIdAdmina();

            if (novost.Id > 0)
            {
                DataManager.IzmijeniNovost(novost);
                PrikaziPoruku("Novost uspješno izmijenjena");
            }
            else 
            {
                DataManager.SpremiNovost(novost);
                PrikaziPoruku("Novost uspješno unešena");
                OcistiPolja();
            }                        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/NovostiList.aspx");
        }

        private void PrikaziPoruku(string poruka)
        {
            liPoruka.InnerText = poruka;
            divPoruka.Visible = true;
        }

        private void OcistiPolja()
        {
            txtNaslov.Text = null;
            txtKratkiO.Text = null;
            txtDugiO.Text = null;
            txtDatum.Text = null;
        }

        protected int UcitajIdNovosti()
        {
            int id = -1;            
            int.TryParse(Request.QueryString["idNovosti"], out id);

            return id;
        }

        protected int UcitajIdAdmina()
        {
            Admin admin = (Admin)Session["Admin"]; // izvadi admin iz sesije
            return admin.Id;
        }

    }
}