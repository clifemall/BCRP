using EventosBCRPFrontEnd.Functions.Captcha;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            Session.Contents.RemoveAll();
            GenerarCaptcha();
            CargarIdioma();
        }
        private void GenerarCaptcha()
        {
            clGetCaptcha cls = new clGetCaptcha();
            clCaptchaResult enticap = cls.GetImage();
            Session["CaptchaVerify"] = enticap.stringCaptcha;
            Image2.Src = "data:image/gif;base64," + enticap.image64Captcha;
            return;
        }

        private void CargarIdioma()
        {
            string codIdioma = "";
            if (Request.QueryString["codIdioma"] != null)
            {
                codIdioma = Request.QueryString["codIdioma"].ToString();
                if (codIdioma == "ENG")
                {
                    Session["codIdioma"] = "ENG";
                    codIdioma = "ENG";
                }
                else if (codIdioma == "SPA")
                {
                    Session["codIdioma"] = "SPA";
                    codIdioma = "SPA";
                }
                else
                {
                    Session["codIdioma"] = "SPA";
                    codIdioma = "SPA";
                }
            }
            else
            {
                Session["codIdioma"] = "SPA";
                codIdioma = "SPA";
            }

            List<pa_ObtenerListaTextoPlantillaFront_Result> ListaPlantilla = plantillaFrontService.obtenerListaTextoPlantillaFront(new obtenerListaTextoPlantillaFrontParams { codIdioma = codIdioma });

            Session["ListaPlantilla"] = ListaPlantilla;
            asignarTextoEtiquetas();
        }
        private void asignarTextoEtiquetas()
        {
            ////int indice = 0;
            //clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], null);
            //obj.ReadEntityBodyMode("lblPrincipal").ToString();

            //string[] principal = obj.ReadEntityBodyMode("lblPrincipal").ToString().Split('-');
            ////string[] principal = listaPlantilla[indice].NombrePlantillaFront.Split('-');
            //titulo0.InnerText = principal[0].Trim();
            //titulo1.InnerText = principal[1].Trim();

            //lblBienvenida.InnerText = obj.ReadEntityBodyMode("lblBienvenida").ToString();

            ////indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblCorreoElectronico");
            //txtUsuario.Attributes.Add("placeholder", obj.ReadEntityBodyMode("lblCorreoElectronico").ToString());

            ////indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblConrasena");
            //txtContrasena.Attributes.Add("placeholder", obj.ReadEntityBodyMode("lblConrasena").ToString());

            ////indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "btnIngresar");
            //btnIngresar.Text = obj.ReadEntityBodyMode("btnIngresar").ToString();

            ////indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblOlvido");
            //btnOlvidar.InnerText = obj.ReadEntityBodyMode("lblOlvido").ToString();
        }


        protected void btnValid_Click(object sender, EventArgs e)
        {
            string capcharead = "";
            try
            {
                capcharead = Session["CaptchaVerify"].ToString();
            }
            catch
            {
                GenerarCaptcha();
                return;
            }


            if (txtVerificationCode.Text.ToLower() == capcharead)
            {
                autenticacionParticipanteService obj = new autenticacionParticipanteService();
                AutenticacionParticipanteResult logResult = obj.autenticacionParticipante(new autenticacionParticipanteParams { correoUsuario = "1", claveUsuario = "1234" });

                if (logResult != null)
                {
                    if (logResult.EstadoLogin)
                    {
                        Session["id_RolParticipante"] = logResult.id_RolParticipante;
                        Session["id_Usuario"] = logResult.id_Usuario;
                        Response.Redirect("/Views/Principal/ListaEventos.aspx");
                    }
                    else
                    {
                        AlertSesionError2.Visible = true;
                        GenerarCaptcha();
                        txtVerificationCode.Text = "";
                        //AlertCaptchaClose("AlertSesionError2");
                        //Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Session.Contents.RemoveAll();
                GenerarCaptcha();
                txtVerificationCode.Text = "";
                lblCaptchaMessage.Text = "Please enter correct captcha !";
                lblCaptchaMessage.ForeColor = System.Drawing.Color.Red;
            }

        }

    }
}