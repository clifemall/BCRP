using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Services;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class Presentaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            Url.Text =ConfigurationManager.AppSettings.Get("Repositorio");

            if (Session["id_Evento"] != null)
            {
                List<pa_ObtenerListaRepositoriosPorIDEvento_Result> Listarepositorios = eventoService.obtenerListaRepositoriosPorIDEvento(new Models.Params.obtenerListaRepositoriosPorIDEventoParams { id_Evento = int.Parse(Session["id_Evento"].ToString()), codIdioma = Session["codIdioma"].ToString() });
                //List<repositorio> Listarepositorios = obtenerListaRepositoriosPorIDEvento(Session["id_Evento"].ToString(), "SPA");
                Repeater1.DataSource = Listarepositorios;
                Repeater1.DataBind();
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;
               
            }
        }

        //private List<repositorio> obtenerListaRepositoriosPorIDEvento(string id_Evento, string codIdioma)
        //{
        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Evento\": " + id_Evento + ",\r\n  \"codIdioma\": \"" + codIdioma + "\"\r\n}";

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerListaRepositoriosPorIDEvento");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    List<repositorio> ListRepositorio = JsonConvert.DeserializeObject<List<repositorio>>(response.Content);
        //    return ListRepositorio;
        //}

    }
}