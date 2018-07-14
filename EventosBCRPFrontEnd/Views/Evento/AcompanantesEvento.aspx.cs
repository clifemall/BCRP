using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class AcompanantesEvento : System.Web.UI.Page
    {
        int idparticipante;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            idparticipante = int.Parse(Session["id_Participante"].ToString());
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           
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

            int _id_Invitado = Convert.ToInt32((sender as LinkButton).CommandArgument.ToString());


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