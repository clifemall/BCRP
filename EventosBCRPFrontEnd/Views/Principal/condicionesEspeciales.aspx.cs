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

namespace CapaPresentacion
{
    public partial class condicionesEspeciales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["id_Participante"] != null)
            {
                pa_ObtenerCondicionesEspecialesPorIDParticipante_Result condEspeciales = participanteService.obtenerCondicionesEspecialesPorIDParticipante(new obtenerCondicionesEspecialesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) } );
                chFisica.Checked = condEspeciales.DiscapacidadFisicoParticipante;
                chSensorial.Checked = condEspeciales.DiscapacidadSensorialParticipante;
                txtDiscapacidad.Text = condEspeciales.DiscapacidadObservacionParticipante;
                chDiabetico.Checked = condEspeciales.RequerimientoEspecialDiabetesParticipante;
                chOtros.Checked = condEspeciales.RequerimientoEspecialOtrosParticipante;
                txtRequerimiento.Text = condEspeciales.RequerimientoEspecialObservacionParticipante;
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;
            }
        }

        //private condEspeciales obtenerCondicionesEspecialesPorIDParticipante(string id_participante)
        //{
        //    datoServicio datosservidor = new datoServicio();
        //    string body = "{\r\n  \"id_Participante\": 1\r\n}";
        //    body = body.Replace("1", id_participante);

        //    var client = new RestClient(datosservidor.CadenaConexion + "/api/obtenerCondicionesEspecialesPorIDParticipante");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Postman-Token", "337d0657-e792-46f4-9ae9-8dc4f1658b4b");
        //    request.AddHeader("Cache-Control", "no-cache");
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    IRestResponse response = client.Execute(request);

        //    condEspeciales result = JsonConvert.DeserializeObject<condEspeciales>(response.Content);

        //    return result;
        //}

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            actualizarCondicionesEspeciales();
        }

        private void actualizarCondicionesEspeciales()
        {

            //string fisica, sensorial, diabetico, otros;

            //#region Variables bool            
            //if (chFisica.Checked == true) { fisica = "1"; }
            //else { fisica = "0"; }

            //if (chSensorial.Checked == true) { sensorial = "1"; }
            //else { sensorial = "0"; }

            //if (chDiabetico.Checked == true) { diabetico = "1"; }
            //else { diabetico = "0"; }

            //if (chOtros.Checked == true) { otros = "1"; }
            //else { otros = "0"; }
            //#endregion

            //string body = "{\r\n  \"id_Participante\": " + Convert.ToInt32(Session["id_Participante"]) + ",\r\n  \"discapacidadFisicoParticipante\": "+fisica+",\r\n  \"discapacidadSensorialParticipante\": "+sensorial+",\r\n  \"discapacidadObservacionParticipante\": \""+txtDiscapacidad.Text.Trim()+"\",\r\n  \"requerimientoEspecialDiabetesParticipante\": "+diabetico+",\r\n  \"requerimientoEspecialOtrosParticipante\": "+otros+",\r\n  \"requerimientoEspecialObservacionParticipante\": \""+txtRequerimiento.Text.Trim()+"\"\r\n}";


            //var client = new RestClient(datoServicio.CadenaConexion+ "/api/actualizarCondicionesEspecialesParticipante");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "057bd6a9-9d65-4671-8a18-42a1552abad7");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            actualizarCondicionesEspecialesParticipanteParams enti = new actualizarCondicionesEspecialesParticipanteParams()
            {
                id_Participante = Convert.ToInt32(Session["id_Participante"]),
                discapacidadFisicoParticipante = chFisica.Checked,
                discapacidadSensorialParticipante = chSensorial.Checked,
                discapacidadObservacionParticipante = txtDiscapacidad.Text.Trim(),
                requerimientoEspecialDiabetesParticipante = chDiabetico.Checked,
                requerimientoEspecialOtrosParticipante = chOtros.Checked,
                requerimientoEspecialObservacionParticipante = txtRequerimiento.Text.Trim()
            };

            pa_ActualizarCondicionesEspecialesParticipante_Result result = participanteService.actualizarCondicionesEspecialesParticipante(enti);
            //actualizarGeneral result = JsonConvert.DeserializeObject<actualizarGeneral>(response.Content);
            if (result.errorstatus == true)
            {
                seccionNaranja.Visible = true;
            }
            else { seccionVerde.Visible = true; }
        }
    }

}