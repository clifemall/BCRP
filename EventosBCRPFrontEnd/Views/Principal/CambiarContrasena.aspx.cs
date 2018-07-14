using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Principal
{
    public partial class CambiarContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SI LA SESION TERMINO REGRESA AL LOGIN
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string idioma = Session["codIdioma"].ToString();
            int idusuario = int.Parse(Session["id_Usuario"].ToString());
            
            if (txtContraNuev1.Text == "")
            {
                seccionNaranja.InnerText = "Campo vacio";
                seccionNaranja.Visible = true;
                return;
            }
            if (txtContraNuev1.Text == "")
            {
                seccionNaranja.InnerText = "Campo vacio";
                seccionNaranja.Visible = true;
                return;
            }
            if (txtContraNuev1.Text == txtContraNuev2.Text)
            {
                cambiarClaveUsuarioResult enti = usuarioService.cambiarClaveUsuario(new cambiarClaveUsuarioParams { id_Usuario = idusuario, claveUsuarioAnterior = txtContraAnte.Text, claveUsuarioNueva = txtContraNuev1.Text, claveUsuarioNueva2 = txtContraNuev2.Text, codIdioma = idioma });
                int value = enti.status;
                switch (enti.status)
                {
                    case 0:
                        seccionVerde.InnerText = "Guardo!";
                        seccionVerde.Visible = true;
                        break;
                    case 1:

                        seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                        seccionNaranja.Visible = true;
                        break;
                }
            }
            else
            {
                seccionNaranja.InnerText = "Las contraseña ingresadas no son igual";
                seccionNaranja.Visible = true;
            }
        }
    }
}