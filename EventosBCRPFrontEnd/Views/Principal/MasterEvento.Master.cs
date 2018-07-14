using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class MaterEvento : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0 && Session == null)
            {
                Response.Redirect("../../login.aspx");
            }
            int _id_Participante = int.Parse(Session["id_Participante"].ToString());
            List<pa_ObtenerListaTextoPlantillaFront_Result> ListaPlantilla = plantillaFrontService.obtenerListaTextoPlantillaFront(new obtenerListaTextoPlantillaFrontParams { codIdioma = Session["codIdioma"].ToString(), id_Participante = _id_Participante });
            Session["ListaPlantilla"] = ListaPlantilla;
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], null);
            HomeEvento.InnerText = obj.ReadEntityBodyMode("M1");
            InscripcionEvento.InnerText = obj.ReadEntityBodyMode("M2");
            opAgend.InnerText = obj.ReadEntityBodyMode("M3");
            opPresentacione.InnerText = obj.ReadEntityBodyMode("M4");
            opExpositoresPart.InnerText = obj.ReadEntityBodyMode("M5");
            opCerrarSesio.InnerText= obj.ReadEntityBodyMode("M8");
        }
    }
}