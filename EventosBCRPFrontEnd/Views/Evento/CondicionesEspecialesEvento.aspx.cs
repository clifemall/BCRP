using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class CondicionesEspecialesEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["id_Participante"] != null)
            {
                pa_ObtenerCondicionesEspecialesPorIDParticipante_Result condEspeciales = participanteService.obtenerCondicionesEspecialesPorIDParticipante(new obtenerCondicionesEspecialesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            actualizarCondicionesEspeciales();
        }

        private void actualizarCondicionesEspeciales()
        {
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