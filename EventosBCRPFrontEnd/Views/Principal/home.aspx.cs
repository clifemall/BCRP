using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaPresentacion.Custom;
using System.Data.SqlClient;
using System.Data;
using CapaPresentacion;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using EventosBCRPFrontEnd.Services;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Functions;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class home : BasePage
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            //variable de sesion Menu: 1 --> 4 opciones visibles 
            //variable de sesion Menu: 2 --> 8 opciones visibles
            if (IsPostBack) return;

            Session["Menu"] = "2";

            if (Request.QueryString["var"] != null)
            {

                string variables = Request.QueryString["var"].ToString();
                byte[] data = Convert.FromBase64String(variables);
                variables = Encoding.UTF8.GetString(data);
                string[] ids = variables.Split('&');
                string[] idsEvento = ids[0].Split('=');
                string[] idsParticipante = ids[1].Split('=');
                Session["id_Evento"] = idsEvento[1];
                Session["id_Participante"] = idsParticipante[1];
            }
            else
            {
                //Session["id_Evento"] = null;
                //Session["id_Participante"] = null;               
            }
            obtenerDatosPantalle(Session["id_Evento"].ToString());

        }

        private void obtenerDatosPantalle(string id_Evento)
        {
            pa_ObtenerDetalleEventoPorIDEvento_Result detalleEvento = eventoService.obtenerDetalleEventoPorIDEvento(new obtenerDetalleEventoPorIDEventoParams { id_Evento = int.Parse(Session["id_Evento"].ToString()), codIdioma = Session["codIdioma"].ToString() });
            imgBackApp.ImageUrl = clGetRepositorio.Read(detalleEvento.FotoAPPEvento);
            txtTitulo.InnerText = detalleEvento.NombreEvento;
            txtDireccion.InnerText = detalleEvento.DireccionEvento;
            txtFecha.InnerText = detalleEvento.FechaInicioEvento.ToShortDateString();
        }
       
    }
}