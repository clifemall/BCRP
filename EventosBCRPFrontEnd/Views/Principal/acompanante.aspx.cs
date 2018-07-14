using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using Newtonsoft.Json;
using RestSharp;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class acompanante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["id_Participante"] != null)
            {
                List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });

                if (ListAcompañantes != null)
                {
                    Repeater1.DataSource = ListAcompañantes;
                    Repeater1.DataBind();
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

        //private List<map_acompañante> obtenerListaInvitadoParticipantePorIDParticipante(string id_Participante)
        //{
        //    datoServicio datoServicio = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1", id_Participante);


        //    var client = new RestClient(datoServicio.CadenaConexion + "/api/obtenerListaInvitadoParticipantePorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "cf6de4a6-7cbb-4613-b5df-c72966e24a92");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    List<map_acompañante> result = JsonConvert.DeserializeObject<List<map_acompañante>>(response.Content);
        //    return result;
        //}

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //string body = "{\r\n  \"id_Participante\": id_part,\r\n  \"NombreInvitado\": \"inv1\",\r\n  \"FechaRegInvitado\": \"2018-05-13T00:25:16.7542083-05:00\"\r\n}";
            //body = body.Replace("id_part", Session["id_Participante"].ToString());
            //body = body.Replace("inv1", txtNombreAcompanante.Text);

            //var client = new RestClient(datoServicio.CadenaConexion + "/api/InsertarListaInvitadoParticipantePorIDParticipante");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "1ea19693-b009-4ec1-9375-29e7a29ffeb9");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);

            //actualizarGeneral result = JsonConvert.DeserializeObject<actualizarGeneral>(response.Content);


            pa_InsertarListaInvitadoParticipantePorIDParticipante_Result result = participanteService.insertarListaInvitadoParticipantePorIDParticipante(new insertarListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), NombreInvitado = txtNombreAcompanante.Text, FechaRegInvitado = DateTime.Now });
            if (result.errorstatus == true)
            {
                seccionNaranja.Visible = true;

            }
            else
            {
                seccionVerde.Visible = true;
                txtNombreAcompanante.Text = "";
                List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
                //GridViewAcompanantes.DataSource = ListAcompañantes;
                //GridViewAcompanantes.DataBind();
                Repeater1.DataSource = ListAcompañantes;
                Repeater1.DataBind();
            }
        }

        protected void GridViewAgendaActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });

            int _id_Invitado = Convert.ToInt32( (sender as LinkButton).CommandArgument.ToString());


            pa_EliminarInvitadoPorIDInvitado_Result result = invitadoParticipanteService.eliminarInvitadoPorIDInvitado(new eliminarInvitadoPorIDInvitadoParams { id_Invitado = _id_Invitado });
            

            if (result.errorstatus == false)
            {
                seccionVerde.Visible = true;
                List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes2 = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
                //List<map_acompañante> ListAcompañantes2 = obtenerListaInvitadoParticipantePorIDParticipante(Session["id_Participante"].ToString());
                Repeater1.DataSource = ListAcompañantes2;
                Repeater1.DataBind(); ;
            }
            else { seccionNaranja.Visible = true; }

        }
    }
}