using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class LayoutEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["var"] != null)
            {

                string variables = Request.QueryString["var"].ToString();
                byte[] data = Convert.FromBase64String(variables);
                variables = Encoding.UTF8.GetString(data);
                string[] ids = variables.Split('&');
                string[] idsEvento = ids[0].Split('=');
                string[] idsParticipante = ids[1].Split('=');
                Session["id_Evento"] = idsEvento[1];
                Session["id_Participante"] = idsParticipante[1];
            }
        }
    }
}