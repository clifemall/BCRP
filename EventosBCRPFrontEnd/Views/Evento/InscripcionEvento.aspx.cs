using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmailValidation;
using System.Drawing;
using System.IO;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class InscripcionEvento : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
            ScriptManager.RegisterStartupScript(
                        UpdatePanelDatosPersonales,
                        this.GetType(),
                        "MyAction",
                        "callAlert();",
                        true);
            if (IsPostBack) return;
            CargarIdioma();
            txtDocumento.Attributes.Add("onkeypress", "return OnlyNumber(event)");

            obtenerDatosParticipantePorIDParticipanteParams enti = new obtenerDatosParticipantePorIDParticipanteParams()
            {
                id_Participante = int.Parse(Session["id_Participante"].ToString())
            };
            pa_ObtenerDatosParticipantePorIDParticipante_Result datosUsuario = participanteService.obtenerDatosParticipantePorIDParticipante(enti);
            lblCorreo.Text = datosUsuario.CorreoPersona;
            lblNombre.Text = datosUsuario.NombrePersona + "<br/>" + datosUsuario.ApellidosPersona;
            lblOrganizacion.Text = datosUsuario.OrganizacionPersona;
            txtNombre.Text = datosUsuario.NombrePersona + " " + datosUsuario.ApellidosPersona;
            
            txtCorreo.Text = datosUsuario.CorreoPersona;
            imgParticipante.ImageUrl = clGetRepositorio.Read(datosUsuario.FotoPersona);

            
            CargarDatosPersonales();
            CargarDatosContacto();
            CargarCondicionesEspeciales();
            CargarAcompanantes();
            CargarAgendaActividad();
            CargarInformacionAdicional();
            CargarHotelesRecomendados();
        }
        //
        private void ToastSucces(string Title, string Message)
        {
            string func = String.Format("ToastSucces('{0}','{1}')", Title, Message);
            ScriptManager.RegisterStartupScript(
                        UpdatePanelDatosPersonales,
                        this.GetType(),
                        "Succes",
                        func,
                        true);
        }
        private void ToastError(string Title, string Message)
        {
            string func = String.Format("ToastError('{0}','{1}')", Title, Message);
            ScriptManager.RegisterStartupScript(
                        UpdatePanelDatosPersonales,
                        this.GetType(),
                        "Error",
                        func,
                        true);
        }
        private void ToastInfo(string Title, string Message)
        {
            string func = String.Format("ToastInfo('{0}','{1}')", Title, Message);
            ScriptManager.RegisterStartupScript(
                        UpdatePanelDatosPersonales,
                        this.GetType(),
                        "Info",
                        func,
                        true);
        }
        //EVENTO DE TIPO DE DOCUMENTO CUANDO SELECCIONAS
        private void dpTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dpTipoDocumento.SelectedItem.Text == "DNI")
            {
                txtTelefonoEmergencia.Text = "asd1";

            }
        }
        //CARGA DE DATOS PERSONALES
        private void CargarDatosPersonales()
        {
            if (Session["id_Participante"] != null)
            {
                pa_ObtenerDatosPersonalesPorIDParticipante_Result infGeneralParticipante = participanteService.obtenerDatosPersonalesPorIDParticipante(new obtenerDatosPersonalesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), CodIdioma = Session["codIdioma"].ToString() });
                txtTitulo.Text = infGeneralParticipante.TituloPersona;
                txtPuesto.Text = infGeneralParticipante.PuestoPersona;
                txtDocumento.Text = infGeneralParticipante.NroDocumentoPersona;
                txtOrganizacion.Text = infGeneralParticipante.OrganizacionPersona;
                //txtAbreviatura.Text = infGeneralParticipante.AbreviaturaOrganizacionPersona;
                txtPais.Text = infGeneralParticipante.PaisPersona;
                
                List<pa_ObtenerListaTipoDocumento_Result> listaDocumentos = tipoDocumentoService.obtenerListaTipoDocumento(new obtenerListaTipoDocumentoParams { codIdioma = Session["codIdioma"].ToString() });
                dpTipoDocumento.DataSource = listaDocumentos;
                dpTipoDocumento.DataBind();
                dplTipoDocumentoDl.DataSource= listaDocumentos;
                dplTipoDocumentoDl.DataBind();
                int indexListBox = 0;
                for (int i = 0; i < listaDocumentos.Count; i++)
                {
                    if (listaDocumentos[i].id_TipoDocumento == infGeneralParticipante.id_TipoDocumento)
                    {
                        indexListBox = i;
                    }
                }

                dpTipoDocumento.SelectedIndex = indexListBox;
                dplTipoDocumentoDl.SelectedIndex= indexListBox;                
            }
            else
            {
                D01.InnerText = "No hay datos de <Participante> a consultar!";
                D01.Visible = true;
            }
        }
        //CARGA DE DATOS DE CONTACTO
        private void CargarDatosContacto()
        {
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
                D02.InnerText = "No hay datos de <Participante> a consultar!";
                D02.Visible = true;
            }
        }
        private void CargarCondicionesEspeciales()
        {
            if (Session["id_Participante"] != null)
            {
                pa_ObtenerCondicionesEspecialesPorIDParticipante_Result condEspeciales = participanteService.obtenerCondicionesEspecialesPorIDParticipante(new obtenerCondicionesEspecialesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
                //chFisica.Checked = condEspeciales.DiscapacidadFisicoParticipante;
                //chSensorial.Checked = condEspeciales.DiscapacidadSensorialParticipante;
                //txtDiscapacidad.Text = condEspeciales.DiscapacidadObservacionParticipante;
                //chDiabetico.Checked = condEspeciales.RequerimientoEspecialDiabetesParticipante;
                //chOtros.Checked = condEspeciales.RequerimientoEspecialOtrosParticipante;
                txtRequerimiento.Text = condEspeciales.RequerimientoEspecialObservacionParticipante;
            }
            else
            {
                D03.InnerText = "No hay datos de <Participante> a consultar!";
                D03.Visible = true;
            }
        }
        //CARGA DE LISTA DE ACOMPAÑANTES
        private void CargarAcompanantes()
        {
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
                    D04.InnerText = "No hay registros a mostrar! ";
                    D04.Visible = true;
                }

            }
            else
            {
                D04.InnerText = "No hay datos de <Participante> a consultar!";
                D04.Visible = true;
            }
        }
        //CARGA DE AGENDA 
        private void CargarAgendaActividad()
        {
            if (Session["id_Participante"] != null)
            {
                int idevento = int.Parse(Session["id_Evento"].ToString());
                //List<pa_ObtenerListaActividadesPorIDEvento_Result> listAgenda = actividadService.obtenerListaActividadesPorIDEvento(new obtenerListaActividadesPorIDEventoParams { id_Evento = idevento, codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                //List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "01", codIdioma = Session["codIdioma"].ToString() });
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                if (listAgenda != null)
                {
                    ParentRepeater.DataSource = listAgenda.GroupBy(q => q.CabeceraFecha).Select(group => new { CabeceraFecha = group.Key }).ToList();
                    ParentRepeater.DataBind();
                    //GridViewAgendaActividad.DataSource = listAgenda;
                    //GridViewAgendaActividad.DataBind();
                }
                else
                {
                    D05.InnerText = "No hay registros a mostrar! ";
                    D05.Visible = true;
                }
            }
            else
            {
                D05.InnerText = "No hay datos de <Participante> a consultar!";
                D05.Visible = true;
            }
        }
        //CARGA DE HOTELES RECOMENDADOS
        private void CargarHotelesRecomendados()
        {
            List<pa_ObtenerListaHotelRecomendado_Result> ListHoteles = participanteService.obtenerListaHotelRecomendado();
            pa_ObtenerListaHotelRecomendado_Result[] myArray = ListHoteles.ToArray();
            //_ListaHotel.Value = myArray;
            //string func = String.Format("CargarArrayhoteles('{0}')", myArray);
            //ScriptManager.RegisterStartupScript(
            //            this,
            //            this.GetType(),
            //            "CargarArrayHoteles",
            //            func,
            //            true);
        }
        //CARGA DE INFORMACION ADICIONAL
        private void CargarInformacionAdicional()
        {
            if (Session["id_Participante"] != null)
            {
                string ID = Session["id_Participante"].ToString();
                pa_ObtenerDatosAdicionalesPorIDParticipante_Result infAdional = participanteService.obtenerDatosAdicionalesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerDatosAdicionalesPorIDParticipanteParams { id_Participante = int.Parse(ID) });

                if (infAdional == null)
                    return;
                string[] _vuelo = infAdional.AerolineaVuelo == null || infAdional.AerolineaVuelo == "" ? ("|").Split('|') : infAdional.AerolineaVuelo.Split('|');
                string[] _codvuelo = infAdional.CodigoVuelo == null || infAdional.CodigoVuelo == "" ? ("|").Split('|') : infAdional.CodigoVuelo.Split('|');

                txtApodo.Text = infAdional.ApodoPersona;
                imgParticipante.ImageUrl = clGetRepositorio.Read(infAdional.FotoPersona);
                Image4.Src = clGetRepositorio.Read(infAdional.FotoPersona);
                txtVuelo.Text = _vuelo[0];
                txtCodigoVuelo.Text = _codvuelo[0];
                txtVuelo1.Text = _vuelo[1];
                txtCodigoVuelo1.Text = _codvuelo[1];
                txtLlegadaFecha.Text = infAdional.FechaLLegadaVuelo;
                txtLlegadaHora.Text = infAdional.HoraLLegadaVuelo;
                txtSalidaFecha.Text = infAdional.FechaSalidaVuelo;
                txtSalidaHora.Text = infAdional.HoraSalidaVuelo;

                txtHospedajeNombre.Text = infAdional.NombreHotel;
                //txtHospedajeNombre1.Value = infAdional.NombreHotel;
                txtHospedajeLlegadaFecha.Text = infAdional.FechaEntradaHotel;
                //txtHosspedajeLlegadaChek.Text = infAdional.HoraEntradaHotel;
                txtHosopedajeSalidaFecha.Text = infAdional.FechaSalidaHotel;
                //txtHospedajeSalidaCkec.Text = infAdional.HoraSalidaHotel;
                txtDireccionHotel.Text = infAdional.DireccionHotel;
                txtLong.Value = infAdional.CoordenadaXHotel;
                txtAlti.Value = infAdional.CoordenadaYHotel;

                ScriptManager.RegisterStartupScript(
                        this,
                        this.GetType(),
                        "MyAction2",
                        "MostrarUbicacion();",
                        true);
            }
        }

       //CARGAR REPEATER DE AGENDA
        protected void ItemBound(object sender, RepeaterItemEventArgs args)
        {
            //LISTADO DENTRO DE OTRO REPEATER 
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)args.Item.FindControl("ChildRepeater");
                Label label = (Label)args.Item.FindControl("Label1");
                int idevento = int.Parse(Session["id_Evento"].ToString());
                //List <pa_ObtenerListaActividadesPorIDEvento_Result> listAgenda = actividadService.obtenerListaActividadesPorIDEvento(new obtenerListaActividadesPorIDEventoParams { id_Evento = idevento, codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgendaMarcados = actividadService.obtenerListaActividadesPorIDParticipante(new EventosBCRPFrontEnd.Models.Params.obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                //foreach (pa_ObtenerListaActividadesPorIDEvento_Result enti in listAgenda)
                //{
                //    if (listAgendaMarcados.Where(q => q.id_Actividad == enti.id_Actividad).Count() > 0)
                //    {
                //        enti.ConfirmadoParticipante = true;
                //    }
                //    else
                //    {
                //        enti.ConfirmadoParticipante = false;
                //    }
                //}
                
                childRepeater.DataSource = listAgendaMarcados.Where(q => q.CabeceraFecha == label.Text).ToList();
                childRepeater.DataBind();
            }
        }

        
        protected void btnEnviarMdl_Click(object sender, EventArgs e)
        {
            string correo= txtCorreoDl.Text.Trim();            
            EmailValidator emailValidator = new EmailValidator();
            EmailValidationResult resultEmail;
            string resultadoCorreo = "";    

            bool c = emailValidator.Validate(correo, out resultEmail);
            resultadoCorreo = resultEmail.ToString();
            if (resultadoCorreo == "OK") {
                pa_InsertarDelegadoParticipante_Result result = participanteService.insertarDelegadoParticipante(new insertarDelegadoParticipanteParams { apMaternoPersona = txtApellidoMaternoDl.Text.Trim(), apPaternoPersona = txtApellidoMaternoDl.Text.Trim(), nombrePersona = txtNombreDl.Text.Trim(), correo_Usuario = txtCorreoDl.Text.Trim(), puestoPersona = txtPuestoDl.Text.Trim(), organizacionPersona = txtOrganizacionDl.Text.Trim(), nroDocumentoPersona = txtNumeroDocumentoDl.Text.Trim(), id_Participante = int.Parse(Session["id_Participante"].ToString()), id_TipoDocumento = Convert.ToInt32(dplTipoDocumentoDl.SelectedValue) });
                if (result.errorstatus == true) { Div2.Visible = true; }
                else
                {
                    Div1.Visible = true;
                    Response.Redirect("Login.aspx");
                }
            }
            else {
                txtCorreoDl.Text = "Ingresar correo Valido";
                txtCorreoDl.Focus();
            }
           
        }

        protected void CheckAll_Click(object sender, EventArgs e)
        {
            int id_Evento = int.Parse(Session["id_Evento"].ToString());
            int _id_Participante = int.Parse(Session["id_Participante"].ToString()); // no usado 
            //string body = "{\r\n  \"id_Participante\": " + id_Participante + ",\r\n  \"tituloPersona\": \"" + txtTitulo.Text.Trim() + "\",\r\n  \"organizacionPersona\": \"" + txtOrganizacion.Text.Trim() + "\",\r\n  \"abreviaturaOrganizacionPersona\": \"" + txtAbreviatura.Text.Trim() + "\",\r\n  \"puestoPersona\": \"" + txtPuesto.Text.Trim() + "\",\r\n  \"paisPersona\": \"" + txtPais.Text.Trim() + "\",\r\n  \"id_TipoDocumento\": " + dpTipoDocumento.SelectedValue + ",\r\n  \"nroDocumentoPersona\": \"" + txtDocumento.Text.Trim() + "\"\r\n}";
            try
            {
                actualizarDatosPersonalesParticipanteParams enti = new actualizarDatosPersonalesParticipanteParams()
                {
                    id_Participante = _id_Participante,
                    tituloPersona = txtTitulo.Text.Trim(),
                    organizacionPersona = txtOrganizacion.Text.Trim(),
                    //abreviaturaOrganizacionPersona = txtAbreviatura.Text.Trim(),
                    puestoPersona = txtPuesto.Text.Trim(),
                    paisPersona = txtPais.Text.Trim(),
                    id_TipoDocumento = int.Parse(dpTipoDocumento.SelectedValue.ToString()),
                    nroDocumentoPersona = txtDocumento.Text.Trim()
                };
                pa_ActualizarDatosPersonalesParticipante_Result result = participanteService.actualizarDatosPersonalesParticipante(enti);
                if (result.errorstatus == true)
                {
                    D01.Visible = true;
                }
                else { S01.Visible = true; }
            }
            catch (Exception ex)
            {
                //lblErrorDatosPersonales.Text = ex.Message;
            }

            //ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert();", true);
        }

        protected void btnGuardarDatosPersonales_Click(object sender, EventArgs e)
        {
            int id_Evento = int.Parse(Session["id_Evento"].ToString());
            int _id_Participante = int.Parse(Session["id_Participante"].ToString()); // no usado 
            //string body = "{\r\n  \"id_Participante\": " + id_Participante + ",\r\n  \"tituloPersona\": \"" + txtTitulo.Text.Trim() + "\",\r\n  \"organizacionPersona\": \"" + txtOrganizacion.Text.Trim() + "\",\r\n  \"abreviaturaOrganizacionPersona\": \"" + txtAbreviatura.Text.Trim() + "\",\r\n  \"puestoPersona\": \"" + txtPuesto.Text.Trim() + "\",\r\n  \"paisPersona\": \"" + txtPais.Text.Trim() + "\",\r\n  \"id_TipoDocumento\": " + dpTipoDocumento.SelectedValue + ",\r\n  \"nroDocumentoPersona\": \"" + txtDocumento.Text.Trim() + "\"\r\n}";
            try
            {
                actualizarDatosPersonalesParticipanteParams enti = new actualizarDatosPersonalesParticipanteParams()
                {
                    id_Participante = _id_Participante,
                    tituloPersona = txtTitulo.Text.Trim(),
                    organizacionPersona = txtOrganizacion.Text.Trim(),
                    //abreviaturaOrganizacionPersona = txtAbreviatura.Text.Trim(),
                    puestoPersona = txtPuesto.Text.Trim(),
                    paisPersona = txtPais.Text.Trim(),
                    id_TipoDocumento = int.Parse(dpTipoDocumento.SelectedValue.ToString()),
                    nroDocumentoPersona = txtDocumento.Text.Trim()
                };
                pa_ActualizarDatosPersonalesParticipante_Result result = participanteService.actualizarDatosPersonalesParticipante(enti);
                if (result.errorstatus == true)
                {
                    D01.Visible = true;
                }
                else { S01.Visible = true; }
            }
            catch (Exception ex)
            {
                //lblErrorDatosPersonales.Text = ex.Message;
            }
            
            //ClientScript.RegisterStartupScript(GetType(), "Message", "callAlert();", true);
        }
        protected void btnGuardarDatosContacto_Click(object sender, EventArgs e)
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
                D02.Visible = true;
            }
            else
            {
                S02.Visible = true;
            }
        }
        protected void btnGuardarCondicionesEspeciales_Click(object sender, EventArgs e)
        {
            actualizarCondicionesEspecialesParticipanteParams enti = new actualizarCondicionesEspecialesParticipanteParams()
            {
                id_Participante = Convert.ToInt32(Session["id_Participante"]),
                //discapacidadFisicoParticipante = chFisica.Checked,
                //discapacidadSensorialParticipante = chSensorial.Checked,
                //discapacidadObservacionParticipante = txtDiscapacidad.Text.Trim(),
                //requerimientoEspecialDiabetesParticipante = chDiabetico.Checked,
                //requerimientoEspecialOtrosParticipante = chOtros.Checked,
                requerimientoEspecialObservacionParticipante = txtRequerimiento.Text.Trim()
            };

            pa_ActualizarCondicionesEspecialesParticipante_Result result = participanteService.actualizarCondicionesEspecialesParticipante(enti);
            //actualizarGeneral result = JsonConvert.DeserializeObject<actualizarGeneral>(response.Content);
            if (result.errorstatus == true)
            {
                D03.Visible = true;
            }
            else { S03.Visible = true; }
        }
        protected void btnGuardarAcompanantes_Click(object sender, EventArgs e)
        {
            if (txtNombreAcompanante.Text == null || txtNombreAcompanante.Text == "")
            {
                D04.Visible = true;
                return;
            }
            pa_InsertarListaInvitadoParticipantePorIDParticipante_Result result = participanteService.insertarListaInvitadoParticipantePorIDParticipante(new insertarListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), NombreInvitado = txtNombreAcompanante.Text, FechaRegInvitado = DateTime.Now });
            if (result.errorstatus == true)
            {
                D04.Visible = true;
            }
            else
            {
                S04.Visible = true;
                txtNombreAcompanante.Text = "";
                List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
                //GridViewAcompanantes.DataSource = ListAcompañantes;
                //GridViewAcompanantes.DataBind();
                Repeater1.DataSource = ListAcompañantes;
                Repeater1.DataBind();
            }
        }
        protected void btnEliminarAcompanante_Click(object sender, EventArgs e)
        {
            List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });

            int _id_Invitado = Convert.ToInt32((sender as LinkButton).CommandArgument.ToString());


            pa_EliminarInvitadoPorIDInvitado_Result result = invitadoParticipanteService.eliminarInvitadoPorIDInvitado(new eliminarInvitadoPorIDInvitadoParams { id_Invitado = _id_Invitado });


            if (result.errorstatus == false)
            {
                S04.Visible = true;
                List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> ListAcompañantes2 = participanteService.obtenerListaInvitadoParticipantePorIDParticipante(new obtenerListaInvitadoParticipantePorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()) });
                //List<map_acompañante> ListAcompañantes2 = obtenerListaInvitadoParticipantePorIDParticipante(Session["id_Participante"].ToString());
                Repeater1.DataSource = ListAcompañantes2;
                Repeater1.DataBind(); ;
            }
            else { D04.Visible = true; }

        
        }
        private void SalvarImagen(string base64, string directorio)
        {
            RepositoriesService.SalvarImagenRepositorio(new SalvarImagenRepositorioParams { Base64Image = base64, UrlImage = directorio });
        }
        public bool IsBase64Encoded(String str)
        {
            try
            {
                str = Regex.Replace(str, "^data:image/[a-zA-Z]+;base64,", string.Empty);
                // If no exception is caught, then it is possibly a base64 encoded string
                byte[] data = Convert.FromBase64String(str);
                // The part that checks if the string was properly padded to the
                // correct length was borrowed from d@anish's solution
                return (str.Replace(" ", "").Length % 4 == 0);
            }
            catch
            {
                // If exception is caught, then it is not a base64 encoded string
                return false;
            }
        }

        protected void btnGuardarInformacionAdicional_Click(object sender, EventArgs e)
        {
            //Console.WriteLine();
            string NameFoto = _ImagenFotoName.Value;
            string Base64 = _ImagenFoto64.Value;
            //Generar Nuevo nombre de imagen

            string nuevonombre = "";
            if (IsBase64Encoded(Base64) && NameFoto != "")
            {
                nuevonombre = clGenNombreFoto.Generar("/Participantes/", NameFoto);
            }
            else
            {
                nuevonombre = null;
            }

            //string[] Vuelo = txtVuelo.Text.Split(',');
            //string _AerolineaVuelo = "";
            //string _AerolineaVuelo1 = "";
            //string _CodigoVuelo = "";
            //try
            //{
            //    _AerolineaVuelo = Vuelo[0];
            //    _CodigoVuelo = Vuelo[0];
            //    _CodigoVuelo = Vuelo[1].Trim();
            //}
            //catch { }

            actualizarDatosAdicionalesPorIDParticipanteParams enti = new actualizarDatosAdicionalesPorIDParticipanteParams()
            {

                FotoPersona = nuevonombre,
                ApodoPersona = txtApodo.Text,
                AerolineaVuelo = txtVuelo.Text + "|" + txtVuelo1.Text,
                //AerolineaVuelo1 = Vuelo[0],
                CodigoVuelo = txtCodigoVuelo.Text + "|" + txtCodigoVuelo1.Text,
                FechaLLegadavuelo = DateTime.Parse(txtLlegadaFecha.Text),
                HoraLLegadavuelo = TimeSpan.Parse(txtLlegadaHora.Text),
                FechaSalidavuelo = DateTime.Parse(txtHosopedajeSalidaFecha.Text),
                HoraSalidavuelo = TimeSpan.Parse(txtLlegadaHora.Text),
                NombreHotel = txtHospedajeNombre.Text,
                DireccionHotel = txtDireccion.Text,
                CoordenadaXHotel = "",
                CoordenadaYHotel = "",
                FechaEntradaHotel = DateTime.Parse(txtHospedajeLlegadaFecha.Text),
                //HoraEntradaHotel = TimeSpan.Parse(txtHosspedajeLlegadaChek.Text),
                FechaSalidaHotel = DateTime.Parse(txtHosopedajeSalidaFecha.Text),
                //HoraSalidaHotel = TimeSpan.Parse(txtHospedajeSalidaCkec.Text),
                id_Participante = int.Parse(Session["id_Participante"].ToString())
            };
            try
            {
                pa_ActualizarDatosAdicionalesPorIDParticipante_Result result = participanteService.actualizarDatosAdicionalesPorIDParticipante(enti);
                if (result.errorstatus == true)
                {
                    ToastError("ERROR", "Ocurrio un error | unexpected error ");
                }
                else
                {
                    CargarInformacionAdicional();
                    ToastSucces("SAVE | GUARDADO","Success | Correctamente");
                }
            }
            catch {
                ToastError("ERROR", "Ocurrio un error | unexpected error ");
            }
            if (Base64 != "")
            {
                try
                {
                    SalvarImagen(Base64, nuevonombre);
                }
                catch { }
            }
        }
        //GUARDAR SELECCION DE AGENDA/ACTIVIDADES
        protected void btnGuardarAgendaActividad_Click(object sender, EventArgs e)
        {
            
            foreach (RepeaterItem i in ParentRepeater.Items)
            {
                Repeater child = (Repeater)i.FindControl("ChildRepeater");
                foreach (RepeaterItem x in child.Items)
                {
                    //Retrieve the state of the CheckBox
                    CheckBox cb = (CheckBox)x.FindControl("CheckBox1");
                    HiddenField hiddenEmail = (HiddenField)x.FindControl("IdActividad");
                    int id_Participante = int.Parse(Session["id_Participante"].ToString());
                    if (cb.Checked)
                    {
                        //Retrieve the value associated with that CheckBox
                        //Now we can use that value to do whatever we want
                        pa_InsertarListaActividadesPorIDParticipante_Result result = actividadService.insertarListaActividadesPorIDParticipante(new insertarListaActividadesPorIDParticipanteParams {  id_Actividad = int.Parse(hiddenEmail.Value), id_Participante = id_Participante });
                        //SendWelcomeMessage(hiddenEmail.Value);
                        if (result.errorstatus == true)
                        {
                            seccionNaranja.Visible = true;
                        }
                        else
                        {

                            SeccionVerde.Visible = true;
                            CargarInformacionAdicional();
                        }
                    }
                    else
                    {
                        pa_EliminarListaActividadesPorIDParticipante_Result result = actividadService.eliminarAgendaActividadPorIDParticipante(new eliminarAgendaActividadPorIDParticipanteParams { id_Actividad = int.Parse(hiddenEmail.Value), id_Participante = id_Participante });
                        if (result.errorstatus == true)
                        {
                            seccionNaranja.Visible = true;
                        }
                        else
                        {

                            SeccionVerde.Visible = true;
                            CargarInformacionAdicional();
                        }
                    }
                }
                    
            }
        }

        private bool validarCorreo(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //private void ControlesInValidacion()
        //{
        //    var ctrlName = Request.Params[Page.postEventSourceID];
        //    var args = Request.Params[Page.postEventArgumentID];

        //    if (ctrlName == txtTitulo.UniqueID && args == "OnKeyPress")
        //    {
        //        MyTextBox_OnKeyPress(ctrlName, args);
        //    }
        //}

        private void MyTextBox_OnKeyPress(string ctrlName, string args)
        {
            Control item = new Control();
            
        }

        private void CargarIdioma()
        {
           
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], Session["listaPermisos"]);
            navinfogeneral.InnerText = obj.ReadEntityBodyMode("E0");
            navinfogeneral.Visible = obj.ReadEntityVisible("E0");
            navagenda.InnerText = obj.ReadEntityBodyMode("E1");
            navagenda.Visible = obj.ReadEntityVisible("E1");
            navadicional.InnerText = obj.ReadEntityBodyMode("E2");
            navadicional.Visible = obj.ReadEntityVisible("E2");
            navdatospersonales.InnerText = obj.ReadEntityBodyMode("D1");
            navdatospersonales.Visible = obj.ReadEntityVisible("D1");
            //navdatoscontacto.InnerText = obj.ReadEntityBodyMode("D2");
            //navdatoscontacto.Visible = obj.ReadEntityVisible("D2");
            navcondicionesespeciales.InnerText = obj.ReadEntityBodyMode("D3");
            navcondicionesespeciales.Visible = obj.ReadEntityVisible("D3");
            navacompanantes.InnerText = obj.ReadEntityBodyMode("D4");
            navacompanantes.Visible = obj.ReadEntityVisible("D4");
            titInscripcion.InnerText = obj.ReadEntityBodyMode("lblInscripcion");
            titInscripcion.Visible = obj.ReadEntityVisible("lblInscripcion");
            //btnDelegar.Text = obj.ReadEntityBodyMode("btnDelegarInvitacion");
            //btnDelegar.Enabled = obj.ReadEntityEnable("btnDelegarInvitacion");
            //btnDelegar.Visible = obj.ReadEntityVisible("btnDelegarInvitacion");

            // DATOS Personales
            TituloParticipante.InnerHtml = obj.ReadEntityBodyMode("txtTitulo");
            TituloParticipante.Visible = obj.ReadEntityVisible("txtTitulo");

            puestoParticipante.InnerHtml = obj.ReadEntityBodyMode("txtPuesto");
            puestoParticipante.Visible = obj.ReadEntityVisible("txtPuesto");

            docIdentidadPartic.InnerHtml = obj.ReadEntityBodyMode("txtDniCarne");
            docIdentidadPartic.Visible = obj.ReadEntityVisible("txtDniCarne");

            institucPartic.InnerHtml = obj.ReadEntityBodyMode("txtInstitucionDt");
            institucPartic.Visible = obj.ReadEntityVisible("txtInstitucionDt");

            paisParticip.InnerHtml = obj.ReadEntityBodyMode("txtPais");
            paisParticip.Visible = obj.ReadEntityVisible("txtPais");

            btnGuardarDatosPersonales.Text = obj.ReadEntityBodyMode("btnGuardarDatosPers");
            btnGuardarDatosPersonales.Visible = obj.ReadEntityVisible("btnGuardarDatosPers");
            btnGuardarDatosPersonales.Enabled = obj.ReadEntityEnable("btnGuardarDatosPers");
            

            //DATOS CONTACTOS
            Ciudad.InnerText = obj.ReadEntityBodyMode("txtCiudad");
            Ciudad.Visible = obj.ReadEntityVisible("txtCiudad");

            Direccion.InnerText = obj.ReadEntityBodyMode("txtDireccion");
            Direccion.Visible = obj.ReadEntityVisible("txtDireccion");

            Telefono.InnerText = obj.ReadEntityBodyMode("txtTelefono");
            Telefono.Visible = obj.ReadEntityVisible("txtTelefono");

            TelefonoEmergencia.InnerText = obj.ReadEntityBodyMode("txtTelefonoEmergencia");
            TelefonoEmergencia.Visible = obj.ReadEntityVisible("txtTelefonoEmergencia");

            CorreoEmergencia.InnerText = obj.ReadEntityBodyMode("txtCorreoEmergencia");
            CorreoEmergencia.Visible = obj.ReadEntityVisible("txtCorreoEmergencia");

            ContactoEmergencia.InnerText = obj.ReadEntityBodyMode("txtContactoEmergencia");
            ContactoEmergencia.Visible = obj.ReadEntityVisible("txtContactoEmergencia");

            btnGuardarContacto.Text = obj.ReadEntityBodyMode("btnGuardarContacto");
            btnGuardarContacto.Enabled = obj.ReadEntityEnable("btnGuardarContacto");
            btnGuardarContacto.Visible = obj.ReadEntityVisible("btnGuardarContacto");
            

            //COND. ESPECIALES
            //SufresDisc.InnerText = obj.ReadEntityBodyMode("txtSufresDisc");
            ContactoEmergencia.Visible = obj.ReadEntityVisible("txtContactoEmergencia");

            TienesReq.InnerText = obj.ReadEntityBodyMode("txtTienesReq");
            ContactoEmergencia.Visible = obj.ReadEntityVisible("txtContactoEmergencia");

            //chDiabetico.Text = obj.ReadEntityBodyMode("chDiabetico");
            //chDiabetico.Visible = obj.ReadEntityVisible("chDiabetico");
            //chDiabetico.Enabled = obj.ReadEntityEnable("chDiabetico");

            //chOtros.Text = obj.ReadEntityBodyMode("chOtro");
            //chOtros.Visible = obj.ReadEntityVisible("chOtro");
            //chOtros.Enabled = obj.ReadEntityEnable("chOtro");

            //Especifique1.InnerText = obj.ReadEntityBodyMode("txtEspecifique");
            //Especifique1.Visible = obj.ReadEntityVisible("txtEspecifique");

            //Especifique2.InnerText = obj.ReadEntityBodyMode("txtEspecifique");
            //Especifique2.Visible = obj.ReadEntityVisible("txtEspecifique");

            //chFisica.Text = obj.ReadEntityBodyMode("chFisica");
            //chFisica.Enabled = obj.ReadEntityEnable("chFisica");
            //chFisica.Visible = obj.ReadEntityVisible("chFisica");

            //chSensorial.Text = obj.ReadEntityBodyMode("chSensorial");
            //chSensorial.Enabled = obj.ReadEntityEnable("chSensorial");
            //chSensorial.Visible = obj.ReadEntityVisible("chSensorial");

            btnGuardarCondicionesEspeciales.Text = obj.ReadEntityBodyMode("btnGuardarCondEspec");
            btnGuardarCondicionesEspeciales.Visible = obj.ReadEntityVisible("btnGuardarCondEspec");
            btnGuardarCondicionesEspeciales.Enabled = obj.ReadEntityEnable("btnGuardarCondEspec");
           

            //DATOS ACOMPAÑANTES
            NombreAcomp.InnerText = obj.ReadEntityBodyMode("txtNombreAcomp");
            NombreAcomp.Visible = obj.ReadEntityVisible("txtNombreAcomp");

            Acompa.InnerText = obj.ReadEntityBodyMode("txtAcompa");
            Acompa.Visible = obj.ReadEntityVisible("txtAcompa");

            btnGuardarAcompanantes.Text = obj.ReadEntityBodyMode("btnAgregarAcomp");
            btnGuardarAcompanantes.Visible = obj.ReadEntityVisible("btnAgregarAcomp");
            btnGuardarAcompanantes.Enabled = obj.ReadEntityEnable("btnAgregarAcomp");
            

            //AGENDA ACTIVIDAD            
            Inforacion.InnerText = obj.ReadEntityBodyMode("txtInforacionAgAct");
            Inforacion.Visible = obj.ReadEntityVisible("txtInforacionAgAct");
            btnGuardarAgendaActividad.Text = obj.ReadEntityBodyMode("btnAgendaActiv");
            btnGuardarAgendaActividad.Enabled = obj.ReadEntityEnable("btnAgendaActiv");
            btnGuardarAgendaActividad.Visible = obj.ReadEntityVisible("btnAgendaActiv");

            //chDesInscripEvento.Text= obj.ReadEntityBodyMode("txtDescartar");
            //chDesInscripEvento.Enabled = obj.ReadEntityEnable("txtDescartar");
            //chDesInscripEvento.Visible = obj.ReadEntityVisible("txtDescartar");

            //INFORMACION ADICIONAL
            InformacionVuelo.InnerText = obj.ReadEntityBodyMode("txtInformaccion");
            InformacionVuelo.Visible = obj.ReadEntityVisible("txtInformaccion");

            Apodo.InnerText = obj.ReadEntityBodyMode("txtApodo");
            Apodo.Visible = obj.ReadEntityVisible("txtApodo");

            //btnSubirFoto.Text = obj.ReadEntityBodyMode("btnSubirFoto");
            //btnSubirFoto.Enabled = obj.ReadEntityEnable("btnSubirFoto");
            //btnSubirFoto.Visible = obj.ReadEntityVisible("btnSubirFoto");

            btnEliminar.Text = obj.ReadEntityBodyMode("btnEliminar");
            btnEliminar.Enabled = obj.ReadEntityEnable("btnEliminar");
            btnEliminar.Visible = obj.ReadEntityVisible("btnEliminar");

            AerolineaVuelo.InnerText = obj.ReadEntityBodyMode("txtAerolineaVuelo");
            AerolineaVuelo.Visible = obj.ReadEntityVisible("txtAerolineaVuelo");

            Llegada.InnerText = obj.ReadEntityBodyMode("txtLlegada");
            Llegada.Visible = obj.ReadEntityVisible("txtLlegada");

            Salida.InnerText = obj.ReadEntityBodyMode("txtAerolineaVuelo");
            Salida.Visible = obj.ReadEntityVisible("txtAerolineaVuelo");
            // Departamento.InnerText = obj.ReadEntityBodyMode("txtInforacion");
            Dia.InnerText = obj.ReadEntityBodyMode("txtDia");
            Dia.Visible = obj.ReadEntityVisible("txtDia");

            Hora.InnerText = obj.ReadEntityBodyMode("txtHora");
            Hora.Visible = obj.ReadEntityVisible("txtHora");

            Dia2.InnerText = obj.ReadEntityBodyMode("txtDia");
            Dia2.Visible = obj.ReadEntityVisible("txtDia");

            Hora2.InnerText = obj.ReadEntityBodyMode("txtHora");
            Hora2.Visible = obj.ReadEntityVisible("txtHora");

            InformacionHospedaje.InnerText = obj.ReadEntityBodyMode("txtInformacionHospedaje");
            InformacionHospedaje.Visible = obj.ReadEntityVisible("txtInformacionHospedaje");

            Hotel.InnerText = obj.ReadEntityBodyMode("txtHotel");
            Hotel.Visible = obj.ReadEntityVisible("txtHotel");

            Desde.InnerText = obj.ReadEntityBodyMode("txtDesde");
            Desde.Visible = obj.ReadEntityVisible("txtDesde");

            //CheckIn.InnerText = obj.ReadEntityBodyMode("txtCheckIn");
            //CheckIn.Visible = obj.ReadEntityVisible("txtCheckIn");

            Hasta.InnerText = obj.ReadEntityBodyMode("txtHasta");
            Hasta.Visible = obj.ReadEntityVisible("txtHasta");

            //Checkout.InnerText = obj.ReadEntityBodyMode("txtCheckout");
            //Checkout.Visible = obj.ReadEntityVisible("txtCheckout");

            SalidaVuelo.InnerText = obj.ReadEntityBodyMode("txtSalidaVuelo");
            SalidaVuelo.Visible = obj.ReadEntityVisible("txtSalidaVuelo");

            btnGuardarInformacionAdicional.Text = obj.ReadEntityBodyMode("btnGuardarInfAdicc");
            btnGuardarInformacionAdicional.Enabled = obj.ReadEntityEnable("btnGuardarInfAdicc");
            btnGuardarInformacionAdicional.Visible = obj.ReadEntityVisible("btnGuardarInfAdicc");

            //Modal
            //delegarPartMdl.InnerText = obj.ReadEntityBodyMode("delegarPartMdl");
            //delegarPartMdl.Visible = obj.ReadEntityVisible("delegarPartMdl");

            //tituloMdl.InnerText = obj.ReadEntityBodyMode("txtTituloMdl");
            //tituloMdl.Visible = obj.ReadEntityVisible("txtTituloMdl");

            //titulo2Mdl.InnerText = obj.ReadEntityBodyMode("txtTituloMdl");
            //titulo2Mdl.Visible = obj.ReadEntityVisible("txtTituloMdl");

            //btnEnviarMdl.Text = obj.ReadEntityBodyMode("btnGuardarMdl");
            //btnEnviarMdl.Enabled = obj.ReadEntityEnable("btnGuardarMdl");
            //btnEnviarMdl.Visible = obj.ReadEntityVisible("btnGuardarMdl");

        }
        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        //    //if (fileUploadImage.HasFile)
        //    //{
        //    //    //fileName = fileUploadImage.FileName;
        //    //    //fileUploadImage.SaveAs("~/Images/" + fileUploadImage.FileName);
        //    //    Image4.ImageUrl = fileUploadImage.FileName;
        //    //}
        //}
    }
}