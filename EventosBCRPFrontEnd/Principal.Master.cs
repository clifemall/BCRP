using EventosBCRPFrontEnd.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd
{
	public partial class Principal : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"],null);
            
            Nav01.InnerText = obj.ReadEntityBodyMode("SM9");
            Nav02.InnerText = obj.ReadEntityBodyMode("SM6");
            Nav03.InnerText = obj.ReadEntityBodyMode("SM7");
            Nav04.InnerText = obj.ReadEntityBodyMode("SM8");
        }
	}
}