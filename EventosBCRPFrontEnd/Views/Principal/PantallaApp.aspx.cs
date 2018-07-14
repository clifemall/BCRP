using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class PantallaApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SI LA SESION TERMINO REGRESA AL LOGIN
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
        }
    }
}