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

namespace CapaPresentacion
{
    public partial class informacionAdicional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["id_Participante"] != null)
            {                
                MostrarInformacionAdicional(int.Parse(Session["id_Participante"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;
            }
            
        }

        private void MostrarInformacionAdicional(int _id_Participante)
        {
           
            pa_ObtenerDatosAdicionalesPorIDParticipante_Result infAdional = participanteService.obtenerDatosAdicionalesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerDatosAdicionalesPorIDParticipanteParams { id_Participante = _id_Participante });
            

            txtApodo.Text = infAdional.ApodoPersona;
            imgParticipante.ImageUrl = clGetRepositorio.Read(infAdional.FotoPersona);
            txtVuelo.Text = infAdional.AerolineaVuelo + ", " + infAdional.CodigoVuelo;
            txtLlegadaFecha.Text = infAdional.FechaLLegadaVuelo;
            txtLlegadaHora.Text = infAdional.HoraLLegadaVuelo;
            txtSalidaFecha.Text = infAdional.FechaSalidaVuelo;
            txtSalidaHora.Text = infAdional.HoraSalidaVuelo;

            txtHospedajeNombre.Text = infAdional.NombreHotel;
            txtHospedajeLlegadaFecha.Text = infAdional.FechaEntradaHotel;
            txtHosspedajeLlegadaChek.Text = infAdional.HoraEntradaHotel;
            txtHosopedajeSalidaFecha.Text = infAdional.FechaSalidaHotel;
            txtHospedajeSalidaCkec.Text = infAdional.HoraSalidaHotel;
        }

        //private infAdicional obtenerDatosAdicionalesPorIDParticipante(string id_Participante)
        //{
        //    datoServicio datoServicio = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1", id_Participante);

        //    var client = new RestClient(datoServicio.CadenaConexion + "/api/obtenerDatosAdicionalesPorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "9fa3776e-0de8-4d38-9344-ab7994b588bd");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    infAdicional result = JsonConvert.DeserializeObject<infAdicional>(response.Content);
        //    return result;
        //}

        //No usando actualmente
        //private string obtenerFotoParticipante(string id_participante)
        //{
        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1", id_participante);

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerFotoParticipantePorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "337d0657-e792-46f4-9ae9-8dc4f1658b4b");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    FotoEventoPorIDEvento foto = JsonConvert.DeserializeObject<FotoEventoPorIDEvento>(response.Content);

        //    return foto.fotoresult;
        //}

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //datoServicio datoServicio = new datoServicio();
            //string body = "{\r\n  \"FotoPersona\": \"foto\",\r\n  \"ApodoPersona\": \"apodo\",\r\n  \"AerolineaVuelo\": \"aerolinea\",\r\n  \"CodigoVuelo\": \"codigo\",\r\n  \"FechaLLegadaVuelo\": \"fllegada_vuelo\",\r\n  \"FechaSalidaVuelo\": \"fSalida_vuelo\",\r\n  \"NombreHotel\": \"hotel\",\r\n  \"DireccionHotel\": \"direccion\",\r\n  \"FechaEntradaHotel\": \"fentrada_hotel\",\r\n  \"FechaSalidaHotel\": \"fsalida_hotel\",\r\n  \"id_Participante\": 1\r\n}";
            //body = body.Replace("foto", "RutaFoto");
            //body = body.Replace("apodo", txtApodo.Text);

            string[] Vuelo = txtVuelo.Text.Split(',');
            //body = body.Replace("aerolinea", Vuelo[0]);
            //body = body.Replace("codigo", Vuelo[1].Trim());

            //body = body.Replace("fllegada_vuelo", txtLlegadaFecha.Text + " " + txtLlegadaHora.Text);
            //body = body.Replace("fSalida_vuelo", txtSalidaFecha.Text + " " + txtLlegadaHora.Text);

            //body = body.Replace("fentrada_hotel", txtHospedajeLlegadaFecha.Text + " " + txtHosspedajeLlegadaChek.Text);
            //body = body.Replace("fsalida_hotel", txtHosopedajeSalidaFecha.Text + " " + txtHospedajeSalidaCkec.Text);

            //body = body.Replace("hotel", txtHospedajeNombre.Text);
            //body = body.Replace("direccion", "Direccion D");
            //body = body.Replace("1", Session["id_Participante"].ToString());

            //var client = new RestClient(datoServicio.CadenaConexion + "/api/ActualizarDatosAdicionalesPorIDParticipante");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "3a545215-9e0a-4ce9-b285-a5f7139f033c");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);

            //actualizarGeneral result = new actualizarGeneral();
            //result = JsonConvert.DeserializeObject<actualizarGeneral>(response.Content);

            actualizarDatosAdicionalesPorIDParticipanteParams enti = new actualizarDatosAdicionalesPorIDParticipanteParams()
            {
                FotoPersona = "",
                ApodoPersona = txtApodo.Text,
                AerolineaVuelo = Vuelo[0],
                CodigoVuelo = Vuelo[1].Trim(),
                FechaLLegadavuelo = DateTime.Parse(txtLlegadaFecha.Text),
                HoraLLegadavuelo = TimeSpan.Parse(txtLlegadaHora.Text),
                FechaSalidavuelo = DateTime.Parse(txtHosopedajeSalidaFecha.Text),
                HoraSalidavuelo = TimeSpan.Parse(txtLlegadaHora.Text),
                NombreHotel = txtHospedajeNombre.Text,
                DireccionHotel = "",
                FechaEntradaHotel = DateTime.Parse(txtHospedajeLlegadaFecha.Text),
                HoraEntradaHotel = TimeSpan.Parse(txtHosspedajeLlegadaChek.Text),
                FechaSalidaHotel = DateTime.Parse(txtHosopedajeSalidaFecha.Text),
                HoraSalidaHotel = TimeSpan.Parse(txtHospedajeSalidaCkec.Text),
                id_Participante = int.Parse(Session["id_Participante"].ToString())
            };

            pa_ActualizarDatosAdicionalesPorIDParticipante_Result result = participanteService.actualizarDatosAdicionalesPorIDParticipante(enti);
            if (result.errorstatus == true)
            {
                seccionNaranja.Visible = true;
            }
            else { SeccionVerde.Visible = true;
                MostrarInformacionAdicional(int.Parse(Session["id_Participante"].ToString()));
            }
        }
    }
}