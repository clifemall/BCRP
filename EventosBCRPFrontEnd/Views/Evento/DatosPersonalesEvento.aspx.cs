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
    public partial class DatosPersonalesEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["id_Usuario"] != null)
            {
                pa_ObtenerDatosPersonalesPorIDParticipante_Result infGeneralParticipante = participanteService.obtenerDatosPersonalesPorIDParticipante(new obtenerDatosPersonalesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Usuario"].ToString()), CodIdioma = Session["codIdioma"].ToString() });
                txtTitulo.Text = infGeneralParticipante.TituloPersona;
                txtPuesto.Text = infGeneralParticipante.PuestoPersona;
                txtDocumento.Text = infGeneralParticipante.NroDocumentoPersona;
                txtOrganizacion.Text = infGeneralParticipante.OrganizacionPersona;
                txtAbreviatura.Text = infGeneralParticipante.AbreviaturaOrganizacionPersona;
                txtPais.Text = infGeneralParticipante.PaisPersona;

                List<pa_ObtenerListaTipoDocumento_Result> listaDocumentos = tipoDocumentoService.obtenerListaTipoDocumento(new obtenerListaTipoDocumentoParams { codIdioma = Session["codIdioma"].ToString() });
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

        

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_Evento = int.Parse(Session["id_Evento"].ToString());
            int id_Participante = int.Parse(Session["id_Participante"].ToString()); // no usado 



            string body = "{\r\n  \"id_Participante\": " + id_Participante + ",\r\n  \"tituloPersona\": \"" + txtTitulo.Text.Trim() + "\",\r\n  \"organizacionPersona\": \"" + txtOrganizacion.Text.Trim() + "\",\r\n  \"abreviaturaOrganizacionPersona\": \"" + txtAbreviatura.Text.Trim() + "\",\r\n  \"puestoPersona\": \"" + txtPuesto.Text.Trim() + "\",\r\n  \"paisPersona\": \"" + txtPais.Text.Trim() + "\",\r\n  \"id_TipoDocumento\": " + dpTipoDocumento.SelectedValue + ",\r\n  \"nroDocumentoPersona\": \"" + txtDocumento.Text.Trim() + "\"\r\n}";
            
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
            

            if (result.errorstatus == true)
            {
                seccionNaranja.Visible = true;
            }
            else { seccionVerde.Visible = true; }
        }
    }
}