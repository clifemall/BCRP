using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class agenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_Participante"] != null)
            {
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()),codigoTipoActividad="02",codIdioma= Session["codIdioma"].ToString() });
                ParentRepeater.DataSource = listAgenda.GroupBy(q=>q.CabeceraFecha).Select(group => new { CabeceraFecha = group.Key }).ToList();
                ParentRepeater.DataBind();
            }
            else
            {

            }
        }

        protected void ItemBound(object sender, RepeaterItemEventArgs args)
        {
            //LISTADO DENTRO DE OTRO REPEATER 
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)args.Item.FindControl("ChildRepeater");
                Label label = (Label)args.Item.FindControl("Label1");
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "02", codIdioma = Session["codIdioma"].ToString() });
                childRepeater.DataSource = listAgenda.Where(q=>q.CabeceraFecha == label.Text).ToList();
                childRepeater.DataBind();
            }
        }
    }
}