using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Services;
using Newtonsoft.Json;
using RestSharp;

namespace CapaPresentacion
{
    public partial class agendaActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_Participante"] != null)
            {
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "01", codIdioma = Session["codIdioma"] .ToString()});

                if (listAgenda != null)
                {
                    GridViewAgendaActividad.DataSource = listAgenda;
                    GridViewAgendaActividad.DataBind();
                }
                else
                {
                    seccionNaranja.InnerText = "No hay registros a mostrar! ";
                    seccionNaranja.Visible = true;
                }
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;
            }
        }

        protected void GridViewAgendaActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "01", codIdioma = Session["codIdioma"].ToString() });

            List<int> ListaIdsAgenda = new List<int>();
            for (int i = 0; i < listAgenda.Count; i++)
            {
                ListaIdsAgenda.Add(listAgenda[i].id_Actividad);
            }

            pa_EliminarListaActividadesPorIDParticipante_Result result = actividadService.eliminarAgendaActividadPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.eliminarAgendaActividadPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), id_Actividad = int.Parse(Convert.ToString(ListaIdsAgenda[GridViewAgendaActividad.SelectedIndex])) });
            //actualizarGeneral result = JsonConvert.DeserializeObject<actualizarGeneral>(response.Content);

            if (result.errorstatus == true)
            {
                seccionNaranja.Visible = true;
            }
            else
            {
                seccionVerde.Visible = true;
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda2 = actividadService.obtenerListaActividadesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "01", codIdioma = Session["codIdioma"].ToString() });

                GridViewAgendaActividad.DataSource = listAgenda2;
                GridViewAgendaActividad.DataBind();
            }    
        }

        //private List<Agenda> obtenerListaActividadesPorIDParticipante(string id_Participante, string codigoTipoActividad, string codIdioma)
        //{
        //    datoServicio datoServicio = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1,\r\n  \"codigoTipoActividad\": \"01\",\r\n  \"codIdioma\": \"SPA\"\r\n}";
        //    body = body.Replace("1", id_Participante);
        //    body = body.Replace("01", codigoTipoActividad);
        //    body = body.Replace("SPA", codIdioma);

        //    var client = new RestClient(datoServicio.CadenaConexion + "/api/obtenerListaActividadesPorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "af9236e1-d230-4263-b928-938460b54f53");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);


        //    List<Agenda> result = JsonConvert.DeserializeObject<List<Agenda>>(response.Content);
        //    return result;
        //}


    }
}