using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Services;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class ExpositoresParticipantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack) return;
            btnExpositores.Enabled = false;
            btnParticipantes.Enabled = true;
            if (Session["id_Evento"] != null)
            {
                pintarExpositoresPorEvento(int.Parse(Session["id_Evento"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "Ningun <Evento> seleccionado!";
                seccionNaranja.Visible = true;
            }
        }


        //private List<Participante> obtenerParticipantes(string idEvento)
        //{
        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Evento\": idParam,\r\n  \"filtro\": \"filtParam\"\r\n}";

        //    body = body.Replace("idParam", idEvento);
        //    body = body.Replace("filtParam", "");

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerListaParticipantePorIDEvento");
        //    var request = new RestRequest(Method.POST);

        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    participanteService.obtenerListaParticipantePorIDEvento(new Models.Params.obtenerListaParticipantePorIDEventoParams { id_Evento = int.Parse(idEvento), filtro = "" });
        //    List<Participante> ListParticipantes = JsonConvert.DeserializeObject<List<Participante>>(response.Content);

        //    return ListParticipantes;
        //}

        //private List<ExpositoresPorIDEvento> obtenerListaExpositoresPorIDEvento(string idEvento)
        //{

        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Evento\": 1\r\n}";
        //    body = body.Replace("1", idEvento);

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerListaExpositoresPorIDEvento");
        //    var request = new RestRequest(Method.POST);

        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    List<ExpositoresPorIDEvento> ListExpositoresPorIDEvento = JsonConvert.DeserializeObject<List<ExpositoresPorIDEvento>>(response.Content);

        //    return ListExpositoresPorIDEvento;
        //}

        protected void btnExpositores_Click(object sender, EventArgs e)
        {
            btnExpositores.Enabled = false;
            btnParticipantes.Enabled = true;
            if (Session["id_Evento"] != null)
            {
                pintarExpositoresPorEvento(int.Parse(Session["id_Evento"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "Ningun <Evento> seleccionado!";
                seccionNaranja.Visible = true;
            }
        }

        protected void btnParticipantes_Click(object sender, EventArgs e)
        {
            btnExpositores.Enabled = true;
            btnParticipantes.Enabled = false;
            if (Session["id_Evento"] != null)
            {
                pintarParticipantesEvento(int.Parse(Session["id_Evento"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "Ningun <Evento> seleccionado!";
                seccionNaranja.Visible = true;
            }
        }

        private void pintarParticipantesEvento(int _id_Evento)
        {
            txtParticiante1.Text = "";
            txtParticiante2.Text = "";
            txtParticiante3.Text = "";
            txtParticiante4.Text = "";
            List<pa_ObtenerListaParticipantePorIDEvento_Result> ListaParticipante = participanteService.obtenerListaParticipantePorIDEvento(new Models.Params.obtenerListaParticipantePorIDEventoParams { id_Evento = _id_Evento, filtro = "" });
            //List<Participante> ListaParticipante = obtenerParticipantes(id_Evento);
            int count = 0;
           

            for (int i = 0; i < ListaParticipante.Count; i++)
            {
                if (count == 0)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante1.Text += "<table class =\"tabla_participante\"> <tr><td><img class=\"img_participante\" src =\"" + img + "\" /><br><b>" + ListaParticipante[i].NombreCompleto + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaParticipante[i].AbreviaturaOrganizacionPersona + ListaParticipante[i].PuestoPersona + "<br></span> <span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaParticipante[0].CorreoPersona + "</span> </td> </tr> </table><br/>";
                    count++;
                }
                else if (count == 1)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante2.Text += "<table class =\"tabla_participante\"> <tr><td><img class=\"img_participante\" src =\"" + img + "\" /><br><b>" + ListaParticipante[i].NombreCompleto + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaParticipante[i].AbreviaturaOrganizacionPersona + ListaParticipante[i].PuestoPersona + "<br></span> <span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaParticipante[0].CorreoPersona + "</span> </td> </tr> </table><br/>";
                    count++;
                }
                else if (count == 2)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante3.Text += "<table class =\"tabla_participante\"> <tr><td><img class=\"img_participante\" src =\"" + img + "\" /><br><b>" + ListaParticipante[i].NombreCompleto + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaParticipante[i].AbreviaturaOrganizacionPersona + ListaParticipante[i].PuestoPersona + "<br></span> <span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaParticipante[0].CorreoPersona + "</span> </td> </tr> </table><br/>";
                    count++;
                }
                else if (count == 3)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante4.Text += "<table class =\"tabla_participante\"> <tr><td><img class=\"img_participante\" src =\"" + img + "\" /><br><b>" + ListaParticipante[i].NombreCompleto + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaParticipante[i].AbreviaturaOrganizacionPersona + ListaParticipante[i].PuestoPersona + "<br></span> <span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaParticipante[0].CorreoPersona + "</span> </td> </tr> </table><br/>";
                    count = 0; ;
                }
            }
        }

        private void pintarExpositoresPorEvento(int _id_Evento)
        {
            txtParticiante1.Text = "";
            txtParticiante2.Text = "";
            txtParticiante3.Text = "";
            txtParticiante4.Text = "";
            List<pa_ObtenerListaExpositoresPorIDEvento_Result> ListaExpositores = participanteService.obtenerListaExpositoresPorIDEvento(new Models.Params.obtenerListaExpositoresPorIDEventoParams { id_Evento = _id_Evento });
            //List<ExpositoresPorIDEvento> ListaExpositores = obtenerListaExpositoresPorIDEvento(id_Evento);

            int count = 0;
            
            for (int i = 0; i < ListaExpositores.Count; i++)
            {
                if (count == 0)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante1.Text += "<table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br><b>" + ListaExpositores[i].NombreCompletoUsuario + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaExpositores[i].PuestoPersona + "<br></span><span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count++;
                }
                else if (count == 1)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante2.Text += " <table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br><b>" + ListaExpositores[i].NombreCompletoUsuario + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaExpositores[i].PuestoPersona + "<br></span><span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count++;
                }
                else if (count == 2)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante3.Text += "<table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br><b>" + ListaExpositores[i].NombreCompletoUsuario + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaExpositores[i].PuestoPersona + "<br></span><span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count++;
                }
                else if (count == 3)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante4.Text += "<table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br><b>" + ListaExpositores[i].NombreCompletoUsuario + "<br></b><span style='FONT-SIZE: 14PX;color: #fd230bfc;font-weight: bold'>" + ListaExpositores[i].PuestoPersona + "<br></span><span style='FONT-SIZE: 12PX;color: #02459afc'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count = 0; ;
                }
            }
        }
    }
}