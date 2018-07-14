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

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class HomeEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SI LA SESION TERMINO REGRESA AL LOGIN
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
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
            obtenerDatosPantalle();
            List<pa_ObtenerListaPermisosPlantillaFrontPorIDParticipante_Result> listaPermisos = plantillaFrontService.obtenerListaPermisosPlantillaFrontPorIDParticipante(new obtenerListaPermisosPlantillaFrontPorIDParticipanteParams { id_Entorno = 1, id_Participante = Convert.ToInt32(Session["id_Participante"]) });
            Session["listaPermisos"] = listaPermisos;


        }

        private void obtenerDatosPantalle()
        {
            pa_ObtenerDetalleEventoPorIDEvento_Result detalleEvento = eventoService.obtenerDetalleEventoPorIDEvento(new obtenerDetalleEventoPorIDEventoParams { id_Evento = int.Parse(Session["id_Evento"].ToString()), codIdioma = Session["codIdioma"].ToString() });
            backgroundprincipal.Style.Add(HtmlTextWriterStyle.BackgroundImage, clGetRepositorio.Read(detalleEvento.FotoWebEvento));

            //imgBackApp.ImageUrl = clGetRepositorio.Read(detalleEvento.FotoAPPEvento);
            txtTitulo.InnerText = detalleEvento.NombreEvento;
            txtDireccion.InnerText = detalleEvento.DireccionEvento;
            txtFecha.InnerText = detalleEvento.FechaInicioEvento.ToShortDateString();
        }
    }
}