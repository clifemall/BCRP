using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd
{
    public partial class InformacionGeneral : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            Response.Redirect("datosPersonales.aspx");
        }

        protected void btnDatosContacto_Click(object sender, EventArgs e)
        {
            Response.Redirect("datosContacto.aspx");
        }

        protected void btnCondicionesEspeciales_Click(object sender, EventArgs e)
        {

            Response.Redirect("condicionesEspeciales.aspx");
        }

        protected void btnAcompanante_Click(object sender, EventArgs e)
        {

            Response.Redirect("acompanante.aspx");
        }
    }
}