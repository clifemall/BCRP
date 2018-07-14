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
    public partial class DatosContacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Session["id_Participante"] != null)
            {
                pa_ObtenerDatosContactoPorIDParticipante_Result datosContacto = participanteService.obtenerDatosContactoPorIDParticipante(new obtenerDatosContactoPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
                txtCiudad.Text = datosContacto.CiudadPersona;
                txtTelefono.Text = datosContacto.TelefonoPersona;
                txtCorreoEmergencia.Text = datosContacto.CorreoEmergenciaParticipante;
                txtDireccion.Text = datosContacto.DireccionPersona;
                txtTelefonoEmergencia.Text = datosContacto.TelefonoEmergenciaPersona;
                txtContactoEmergencia.Text = datosContacto.ContactoEmergenciaParticipante;
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            actualizarDatosContactoParticipanteParams enti = new actualizarDatosContactoParticipanteParams()
            {
                id_Participante = int.Parse(Session["id_Evento"].ToString()),
                ciudadPersona = txtCiudad.Text.Trim(),
                direccionPersona = txtDireccion.Text.Trim(),
                telefonoPersona = txtTelefono.Text.Trim(),
                telefonoEmergenciaPersona = txtTelefonoEmergencia.Text.Trim(),
                correoEmergenciaParticipante = txtCorreoEmergencia.Text.Trim(),
                contactoEmergenciaParticipante = txtContactoEmergencia.Text.Trim()
            };
            pa_ActualizarDatosContactoParticipante_Result resultActualizar = participanteService.actualizarDatosContactoParticipante(enti);
            if (resultActualizar.errorstatus == true)
            {
                seccionVerde.Visible = true;
            }
            else
            {
                seccionVerde.Visible = true;
            }
        }

    }
}