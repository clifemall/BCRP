using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models;
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
    public partial class ListaEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session == null || Session.Count == 0 || Session["codIdioma"] == null)
            {
                Response.Redirect("../../Login.aspx");
            }
            string idioma = Session["codIdioma"].ToString();
            int _idusuario = int.Parse(Session["id_Usuario"].ToString());
            List<pa_ObtenerListaEventosPorIDUsuario_Result> lst = eventoService.obtenerListaEventosPorIDUsuario(new obtenerListaEventosPorIDUsuarioParams { id_Usuario = _idusuario, codIdioma = idioma }).ToList();
            Repeater1.DataSource = lst;
            Repeater1.DataBind();

            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"],null);
            tituloEvento.InnerText = obj.ReadEntityBodyMode("lblInscripcion");
            textoevento.InnerText = obj.ReadEntityBodyMode("lblEventosSec");
        }
        //
        private void ToastSucces(string Title, string Message)
        {
            string func = String.Format("ToastSucces('{0}','{1}')", Title, Message);
            ScriptManager.RegisterStartupScript(
                        this,
                        this.GetType(),
                        "Succes",
                        func,
                        true);
        }
        private void ToastError(string Title, string Message)
        {
            string func = String.Format("ToastError('{0}','{1}')", Title, Message);
            ScriptManager.RegisterStartupScript(
                        this,
                        this.GetType(),
                        "Error",
                        func,
                        true);
        }
        private void ToastInfo(string Title, string Message)
        {
            string func = String.Format("ToastInfo('{0}','{1}')", Title, Message);
            ScriptManager.RegisterStartupScript(
                        this,
                        this.GetType(),
                        "Info",
                        func,
                        true);
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            //Get the reference of the clicked button.
            LinkButton button = (sender as LinkButton);

            //Get the command argument
            string commandArgument = button.CommandArgument;

            //Get the Repeater Item reference
            RepeaterItem item = button.NamingContainer as RepeaterItem;
            string idParticipante = ((HiddenField)item.FindControl("HiddenField1")).Value;
            string linkCast = ((HiddenField)item.FindControl("HiddenField2")).Value;
            //Get the repeater item index
            int index = item.ItemIndex;

            List<pa_ObtenerListaTextoPlantillaFront_Result> ListaPlantilla = plantillaFrontService.obtenerListaTextoPlantillaFront(new obtenerListaTextoPlantillaFrontParams { codIdioma = Session["codIdioma"].ToString(), id_Participante = int.Parse(idParticipante) });

            if (ListaPlantilla.Where(x => x.CodeID.Trim() == "M1").SingleOrDefault() == null)
            {
                if (Session["codIdioma"].ToString() == "SPA")
                {
                    ToastError("ERROR", "No hay permisos asignados por el usuario administrador");
                }
                else
                    ToastError("ERROR", "No permissions assigned by the administrator user");
            }
            else
            {
                Session["ListaPlantilla"] = ListaPlantilla;
                Response.Redirect(linkCast);
            }
            
        }
    }
}