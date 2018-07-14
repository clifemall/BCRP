using EventosBCRPFrontEnd.Functions;
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

namespace EventosBCRPFrontEnd
{
    public partial class Inscripcion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            //string img = obtenerFotoParticipante(Session["id_Usuario"].ToString());
            //imgParticipante.ImageUrl = datoServicio.CadenaConexionRepositorio + img;

            pa_ObtenerDatosParticipantePorIDParticipante_Result datosUsuario = participanteService.obtenerDatosParticipantePorIDParticipante(new obtenerDatosParticipantePorIDParticipanteParams { id_Participante =  int.Parse(Session["id_Participante"].ToString())} );
            lblCorreo.Text = datosUsuario.CorreoPersona;
            lblNombre.Text = datosUsuario.NombrePersona +"<br/>"+ datosUsuario.ApellidosPersona;
            lblOrganizacion.Text = datosUsuario.OrganizacionPersona;
            imgParticipante.ImageUrl = clGetRepositorio.Read(datosUsuario.FotoPersona);
        }

        //private inscripcion_master obtenerDatosParticipantes(string id_participante)
        //{
        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1", id_participante);

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerDatosParticipantePorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "337d0657-e792-46f4-9ae9-8dc4f1658b4b");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    inscripcion_master datos = JsonConvert.DeserializeObject<inscripcion_master>(response.Content);

        //    return datos;
        //}

        //private string obtenerFotoParticipante(string id_participante)
        //{
 
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1",id_participante);

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerFotoParticipantePorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "337d0657-e792-46f4-9ae9-8dc4f1658b4b");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    FotoEventoPorIDEvento foto = JsonConvert.DeserializeObject<FotoEventoPorIDEvento>(response.Content);

        //    return  foto.fotoresult;
        //}

        protected void btnInformacionAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("informacionAdicional.aspx");
        }

        protected void btnAgendaActividad_Click(object sender, EventArgs e)
        {

            Response.Redirect("agendaActividad.aspx");
        }

        protected void inscripcionInfGeneral_Click(object sender, EventArgs e)
        {
            Response.Redirect("datosPersonales.aspx");
        }

        protected void btnDelegar_Click(object sender, EventArgs e)
        {
            Response.Redirect("delegarInformacion.aspx");
        }
    }
}