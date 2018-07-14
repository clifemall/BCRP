using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd
{
    public partial class PrincipalEvento : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (IsPostBack) return;

            // opPrueba.Visible = false;
            if (Session["Menu"].ToString() == "1")
            {
                opInici.Visible = false;
                opInscripcio.Visible = false;
                opAgend.Visible = false;
                opPresentacione.Visible = false;
                opExpositoresPart.Visible = false;
                opCambiarContrasen.Visible = true;
            }
            else
            {
                opCambiarContrasen.Visible = false;

                opInici.Visible = true;
                opInscripcio.Visible = true;
                opAgend.Visible = true;
                opPresentacione.Visible = true;
                opExpositoresPart.Visible = true;
            }
            labDate.Text = DateTime.Now.ToLongTimeString();

        }
	}
}