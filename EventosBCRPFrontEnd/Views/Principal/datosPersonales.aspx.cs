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
    public partial class datosPersonales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["id_Usuario"] != null)
            {
                pa_ObtenerDatosPersonalesPorIDParticipante_Result infGeneralParticipante = participanteService.obtenerDatosPersonalesPorIDParticipante(new obtenerDatosPersonalesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Usuario"].ToString()), CodIdioma = Session["codIdioma"].ToString() }  );
                txtTitulo.Text = infGeneralParticipante.TituloPersona;
                txtPuesto.Text = infGeneralParticipante.PuestoPersona;
                txtDocumento.Text = infGeneralParticipante.NroDocumentoPersona;
                txtOrganizacion.Text = infGeneralParticipante.OrganizacionPersona;
                txtAbreviatura.Text = infGeneralParticipante.AbreviaturaOrganizacionPersona;
                txtPais.Text = infGeneralParticipante.PaisPersona;

                List<pa_ObtenerListaTipoDocumento_Result> listaDocumentos = tipoDocumentoService.obtenerListaTipoDocumento(new obtenerListaTipoDocumentoParams { codIdioma = Session["codIdioma"].ToString()} );
                dpTipoDocumento.DataSource = listaDocumentos;
                dpTipoDocumento.DataBind();

                int indexListBox = 0;
                for (int i = 0; i < listaDocumentos.Count; i++)
                {
                    if (listaDocumentos[i].id_TipoDocumento == infGeneralParticipante.id_TipoDocumento)
                    {
                        indexListBox = i;
                    }
                }

                dpTipoDocumento.SelectedIndex = indexListBox;
                //dpTipoDocumento2.DataBind( listaDocumentos);
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;
            }
        }

        //private List<tipoDocumento> obtenerDocumentos(string cod_idioma)
        //{
        //    datoServicio datoServicio = new datoServicio();

        //    var client = new RestClient(datoServicio.CadenaConexion + "/api/obtenerListaTipoDocumento");
        //    string body = "{\r\n  \"codIdioma\": \"SPA\"\r\n}";
        //    body = body.Replace("SPA", cod_idioma);

        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "5b5195ba-f50b-45b9-a80a-c453c8b3936e");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);


        //    List<tipoDocumento> result = JsonConvert.DeserializeObject<List<tipoDocumento>>(response.Content);
        //    return result;
        //}

        //private ins_InfGeneral obtenerDatosPersonalesPorIDParticipante(string id_Participante)
        //{
        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1", id_Participante);

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerDatosPersonalesPorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "68e5239e-d5bc-4103-a017-28dd336c582b");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    ins_InfGeneral result = JsonConvert.DeserializeObject<ins_InfGeneral>(response.Content);
        //    return result;
        //}

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_Evento = int.Parse(Session["id_Evento"].ToString());
            int id_Participante = int.Parse(Session["id_Participante"].ToString()); // no usado 



            string body = "{\r\n  \"id_Participante\": " + id_Participante + ",\r\n  \"tituloPersona\": \"" + txtTitulo.Text.Trim() + "\",\r\n  \"organizacionPersona\": \"" + txtOrganizacion.Text.Trim() + "\",\r\n  \"abreviaturaOrganizacionPersona\": \"" + txtAbreviatura.Text.Trim() + "\",\r\n  \"puestoPersona\": \"" + txtPuesto.Text.Trim() + "\",\r\n  \"paisPersona\": \"" + txtPais.Text.Trim() + "\",\r\n  \"id_TipoDocumento\": " + dpTipoDocumento.SelectedValue + ",\r\n  \"nroDocumentoPersona\": \"" + txtDocumento.Text.Trim() + "\"\r\n}";
            //body = body.Replace("1", id_Participante);
            //body = body.Replace("xx", txtTitulo.Text.Trim());
            //body = body.Replace("org", txtOrganizacion.Text.Trim());
            //body = body.Replace("abr", txtAbreviatura.Text.Trim());
            //body = body.Replace("puesto", txtPuesto.Text.Trim());
            //body = body.Replace("pais", txtPais.Text.Trim());
            //body = body.Replace("6", dpTipoDocumento.SelectedValue);
            //body = body.Replace("123", txtDocumento.Text.Trim());

            //var client = new RestClient(datoServicio.CadenaConexion + "/api/actualizarDatosPersonalesParticipante");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "bca6e40f-1a84-4cf9-8941-1d7be0d2bbe9");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            actualizarDatosPersonalesParticipanteParams enti = new actualizarDatosPersonalesParticipanteParams()
            {
                id_Participante = id_Participante,
                tituloPersona = txtTitulo.Text.Trim(),
                organizacionPersona = txtOrganizacion.Text.Trim(),
                abreviaturaOrganizacionPersona = txtAbreviatura.Text.Trim(),
                puestoPersona = txtPuesto.Text.Trim(),
                paisPersona = txtPais.Text.Trim(),
                id_TipoDocumento = int.Parse(dpTipoDocumento.SelectedValue.ToString()),
                nroDocumentoPersona = txtDocumento.TemplateSourceDirectory
            };
            pa_ActualizarDatosPersonalesParticipante_Result result = participanteService.actualizarDatosPersonalesParticipante(enti);
            //actualizarGeneral result = JsonConvert.DeserializeObject<actualizarGeneral>(response.Content);

            if (result.errorstatus == true)
            {
                seccionNaranja.Visible = true;
            }
            else { seccionVerde.Visible = true; }
        }

    }
}