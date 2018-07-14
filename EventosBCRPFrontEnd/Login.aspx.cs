using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Liphsoft.Crypto.Argon2;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net.Mail;
using EventosBCRPFrontEnd.Views.Principal;
using EventosBCRPFrontEnd.Functions.Captcha;

namespace EventosBCRPFrontEnd
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(
                        ScriptManagerAcompanante,
                        this.GetType(),
                        "MyAction",
                        "callAlert();",
                        true);

            ScriptManager.RegisterStartupScript(
                        this, // updatepanel
                        this.GetType(),
                        "MyAction",
                        "callAlert();",
                        true);

            if (IsPostBack) return;
            Session.Contents.RemoveAll();
            GenerarCaptcha();
            CargarIdioma();
            
        }

        //CAMBIO DE IDIOMA
        private void CargarIdioma()
        {
            string codIdioma = "";
            if (Request.QueryString["codIdioma"] != null )
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

            List<pa_ObtenerListaTextoPlantillaFront_Result> ListaPlantilla = plantillaFrontService.obtenerListaTextoPlantillaFront(new obtenerListaTextoPlantillaFrontParams { codIdioma = codIdioma, id_Participante = null});

            Session["ListaPlantilla"] = ListaPlantilla;
            asignarTextoEtiquetas();
        }
        //SETEO DE ETIQUETAS
        private void asignarTextoEtiquetas()
        {
            //int indice = 0;

            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], null);
            obj.ReadEntityBodyMode("lblPrincipal").ToString();


            //indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblPrincipal");

            string[] principal = obj.ReadEntityBodyMode("lblPrincipal").ToString().Split('-');
            //string[] principal = listaPlantilla[indice].NombrePlantillaFront.Split('-');
            titulo0.InnerText = principal[0].Trim();
            titulo1.InnerText = principal[1].Trim();

            lblBienvenida.InnerText = obj.ReadEntityBodyMode("lblBienvenida").ToString();

            //indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblCorreoElectronico");
            txtUsuario.Attributes.Add("placeholder", obj.ReadEntityBodyMode("lblCorreoElectronico").ToString());

            //indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblConrasena");
            txtContrasena.Attributes.Add("placeholder", obj.ReadEntityBodyMode("lblConrasena").ToString());

            //indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "btnIngresar");
            btnIngresar.Text = obj.ReadEntityBodyMode("btnIngresar").ToString();

            //indice = listaPlantilla.FindIndex(x => x.CodeID.Trim() == "lblOlvido");
            btnOlvidar.InnerText = obj.ReadEntityBodyMode("lblOlvido").ToString();
            P1.InnerText = obj.ReadEntityBodyMode("lblcapcha").ToString();
            H1.InnerText = obj.ReadEntityBodyMode("lblTitCapcha").ToString();
            btnRefreshCaptcha.Text = obj.ReadEntityBodyMode("btnCapchaActualizar").ToString();
            btnValid.Text = obj.ReadEntityBodyMode("btnCapchaIngresar").ToString();
            lblCaptchaAlter.InnerText = obj.ReadEntityBodyMode("lblTitCapcha").ToString();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //ScriptManager.RegisterStartupScript(
            //          UpdatePanel6,
            //          this.GetType(),
            //          "MyAction",
            //          "RefreshCapcha();",
            //          true);

            //autenticacionParticipanteService obj = new autenticacionParticipanteService();
            ////Liphsoft.Crypto.Argon2.PasswordHasher passwordHasher = new Liphsoft.Crypto.Argon2.PasswordHasher();
  

  

            //AutenticacionParticipanteResult logResult = obj.autenticacionParticipante(new autenticacionParticipanteParams { correoUsuario = txtUsuario.Text, claveUsuario = txtContrasena.Text });

            //if (logResult != null)
            //{
            //    Session["id_RolParticipante"] = logResult.id_RolParticipante;
            //    Session["id_Usuario"] = logResult.id_Usuario;
            //    if (logResult.EstadoLogin == true)
            //    {
            //        ScriptManager.RegisterStartupScript(
            //            this,
            //            this.GetType(),
            //            "MyAction",
            //            "CallCapcha();",
            //            true);
                    
                    
            //        //Response.Redirect("/Views/Principal/ListaEventos.aspx");
            //    }
            //    else
            //    {

            //        //lblLogin.Text = "Credenciales incorretas! ";

            //    }
            //}
            //else
            //{ /*pnlModal.Visible = true;*/

            //}

        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            bool format = true;
            try {
                MailAddress obj = new MailAddress(txtUsuario.Text.Trim());
                format = true;
            }
            catch {
                format = false;
            }

            if (txtUsuario.Text.Trim() == "" || !format)
            {
                D02.Visible = true;
                ScriptManager.RegisterStartupScript(
                        this,
                        this.GetType(),
                        "MyAction",
                        "callAlert();",
                        true);
                return;
            }

            BoolResult enti = usuarioService.recuperarContrasenaPorCorreoUsuario(new recuperarContrasenaPorCorreoUsuarioParams { correoParticipante = txtUsuario.Text.Trim() });

            if (enti.boolresult)
            {
                S02.Visible = true;
            }
            else
            {
                D01.Visible = true;
                return;
            }

            ScriptManager.RegisterStartupScript(
                        ScriptManagerAcompanante,
                        this.GetType(),
                        "MyAction",
                        "callAlert();",
                        true);
        }

        private void GenerarCaptcha()
        {
            clGetCaptcha cls = new clGetCaptcha();
            clCaptchaResult enticap = cls.GetImage();
            Session["CaptchaVerify"] = enticap.stringCaptcha;
            Image2.Src = "data:image/gif;base64," + enticap.image64Captcha;
            return;
        }

        private void AlertCaptchaClose(string param)
        {
            ScriptManager.RegisterStartupScript(
                        this, // updatepanel
                        this.GetType(),
                        "MyAction",
                        "llamarAlerta('"+param+"');",
                        true);
        }
        
        protected void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            GenerarCaptcha();
            return;
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
            int intento = Session["Intento"] == null ? 1 : int.Parse(Session["Intento"].ToString());

            if (txtVerificationCode.Text.ToLower() == capcharead)
            {
                autenticacionParticipanteService obj = new autenticacionParticipanteService();
                AutenticacionParticipanteResult logResult = obj.autenticacionParticipante(new autenticacionParticipanteParams { correoUsuario = txtUsuario.Text, claveUsuario = txtContrasena.Text });

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
                        AlertCaptchaClose("AlertSesionError2");
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
                //Session.Contents.RemoveAll();
                if (intento <= 3)
                {

                    ScriptManager.RegisterStartupScript(
                        this, // updatepanel
                        this.GetType(),
                        "MyAction",
                        "CerrarCapcha();",
                        true);
                }
    
                Session["Intento"] = intento++;
                GenerarCaptcha();
                txtVerificationCode.Text = "";
                lblCaptchaMessage.Text = "Please enter correct captcha !";
                lblCaptchaMessage.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void ValidarCapcha_Click(object sender, EventArgs e)
        {
            
          
                //Image2.ImageUrl = null;
                //Image2.ImageUrl = "#";
                //Image2.ImageUrl = "~/Views/Principal/Captcha.aspx";

                //Image2.ImageUrl = aspform.Request.Url.Host;
                //ScriptManager.RegisterStartupScript(
                //       UpdatePanel5,
                //       this.GetType(),
                //       "MyAction",
                //       "RefreshCapcha();",
                //       true);
                //Image2.ImageUrl = "~/Views/Principal/Captcha.aspx";
                //Image2.ImageUrl = "~/Views/Principal/Captcha.aspx";
                //UpdatePanel5.Update();
                //UpdatePanelCapcha.Update();

           
        }
    }
}