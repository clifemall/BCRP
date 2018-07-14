using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class ExpositoresParticipanteEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            //btnExpositores.Enabled = false;
            btnParticipantes.BackColor = System.Drawing.Color.White;
            btnParticipantes.BorderColor = System.Drawing.Color.Goldenrod;
            btnParticipantes.ForeColor = System.Drawing.Color.Black;
            btnExpositores.BackColor = System.Drawing.Color.Goldenrod;
            //SI LA SESION TERMINO REGRESA AL LOGIN
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
            //btnParticipantes.Enabled = true;
            if (Session["id_Evento"] != null)
            {
                pintarExpositoresPorEvento(int.Parse(Session["id_Evento"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "Ningun <Evento> seleccionado!";
                seccionNaranja.Visible = true;
            }

            pintarPlantilla();
        }
        private void pintarPlantilla()
        {
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], Session["listaPermisos"]);

            btnParticipantes.Text = obj.ReadEntityBodyMode("btnParticipantes");
            //btnParticipantes.Enabled = obj.ReadEntityEnable("btnParticipantes");
            //btnParticipantes.Visible = obj.ReadEntityVisible("btnParticipantes");

            btnExpositores.Text = obj.ReadEntityBodyMode("btnExpositores");
            //btnExpositores.Enabled = obj.ReadEntityEnable("btnExpositores");
            //btnExpositores.Visible = obj.ReadEntityVisible("btnExpositores");

            tituloExpoPart.InnerText = obj.ReadEntityBodyMode("lblExpositores");
            tituloExpoPart.Visible = obj.ReadEntityVisible("lblExpositores");
        }

        protected void btnExpositores_Click(object sender, EventArgs e)
        {
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], Session["listaPermisos"]);

            btnParticipantes.BackColor = System.Drawing.Color.White;
            btnParticipantes.BorderColor = System.Drawing.Color.Goldenrod;
            btnParticipantes.ForeColor = System.Drawing.Color.Black;

            btnExpositores.BackColor = System.Drawing.Color.Goldenrod;
            btnExpositores.BorderColor = System.Drawing.Color.White;
            btnExpositores.ForeColor = System.Drawing.Color.White;
            if (Session["id_Evento"] != null)
            {
                pintarExpositoresPorEvento(int.Parse(Session["id_Evento"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "Ningun <Evento> seleccionado!";
                seccionNaranja.Visible = true;
            }
            tituloExpoPart.InnerText = obj.ReadEntityBodyMode("lblExpositores");
            tituloExpoPart.Visible = obj.ReadEntityVisible("lblExpositores");
        }

        protected void btnParticipantes_Click(object sender, EventArgs e)
        {
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], Session["listaPermisos"]);
            btnExpositores.BackColor = System.Drawing.Color.White;
            btnExpositores.BorderColor = System.Drawing.Color.Goldenrod;
            btnExpositores.ForeColor = System.Drawing.Color.Black;

            btnParticipantes.BackColor = System.Drawing.Color.Goldenrod;
            btnParticipantes.BorderColor = System.Drawing.Color.White;
            btnParticipantes.ForeColor = System.Drawing.Color.White;

            if (Session["id_Evento"] != null)
            {
                pintarParticipantesEvento(int.Parse(Session["id_Evento"].ToString()));
            }
            else
            {
                seccionNaranja.InnerText = "Ningun <Evento> seleccionado!";
                seccionNaranja.Visible = true;
            }
            tituloExpoPart.InnerText = obj.ReadEntityBodyMode("lblPartipantes");
            tituloExpoPart.Visible = obj.ReadEntityVisible("lblPartipantes");
        }

        private void pintarParticipantesEvento(int _id_Evento)
        {
            txtParticiante1.Text = "";
            txtParticiante2.Text = "";
            txtParticiante3.Text = "";
            txtParticiante4.Text = "";
            List<pa_ObtenerListaParticipantePorIDEvento_Result> ListaParticipante = participanteService.obtenerListaParticipantePorIDEvento(new Models.Params.obtenerListaParticipantePorIDEventoParams { id_Evento = _id_Evento, filtro = "" });
            //List<Participante> ListaParticipante = obtenerParticipantes(id_Evento);
            int count = 0;


            for (int i = 0; i < ListaParticipante.Count; i++)
            {
                if (count == 0)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante1.Text += "<div class =\"tabla_participante\"> <div><img class=\"img_participante\" src =\"" + img + "\" /></div><div>" + ListaParticipante[i].NombreCompleto + "<br></div><div class='texto1a'>" + ListaParticipante[i].PuestoPersona + "<br></div><div class='texto1'>" + ListaParticipante[i].OrganizacionPersona + "<br></div> <div class='texto2'>" + ListaParticipante[0].CorreoPersona + "</span> </div> </div><br/>";
                    count++;
                }
                else if (count == 1)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante2.Text += "<div class =\"tabla_participante\"> <div><img class=\"img_participante\" src =\"" + img + "\" /></div><div>" + ListaParticipante[i].NombreCompleto + "<br></div><div class='texto1a'>" + ListaParticipante[i].PuestoPersona + "<br></div><div class='texto1'>" + ListaParticipante[i].OrganizacionPersona + "<br></div> <div class='texto2'>" + ListaParticipante[0].CorreoPersona + "</span> </div> </div><br/>";
                    count++;
                }
                else if (count == 2)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante3.Text += "<div class =\"tabla_participante\"> <div><img class=\"img_participante\" src =\"" + img + "\" /></div><div>" + ListaParticipante[i].NombreCompleto + "<br></div><div class='texto1a'>" + ListaParticipante[i].PuestoPersona + "<br></div><div class='texto1'>" + ListaParticipante[i].OrganizacionPersona + "<br></div> <div class='texto2'>" + ListaParticipante[0].CorreoPersona + "</span> </div> </div><br/>";
                    count++;
                }
                else if (count == 3)
                {
                    string img = clGetRepositorio.Read(ListaParticipante[i].FotoPersona);
                    txtParticiante4.Text += "<div class =\"tabla_participante\"> <div><img class=\"img_participante\" src =\"" + img + "\" /></div><div>" + ListaParticipante[i].NombreCompleto + "<br></div><div class='texto1a'>" + ListaParticipante[i].PuestoPersona + "<br></div><div class='texto1'>" + ListaParticipante[i].OrganizacionPersona + "<br></div> <div class='texto2'>" + ListaParticipante[0].CorreoPersona + "</span> </div> </div><br/>";
                    count = 0; ;
                }
            }
        }

        private void pintarExpositoresPorEvento(int _id_Evento)
        {
            txtParticiante1.Text = "";
            txtParticiante2.Text = "";
            txtParticiante3.Text = "";
            txtParticiante4.Text = "";
            List<pa_ObtenerListaExpositoresPorIDEvento_Result> ListaExpositores = participanteService.obtenerListaExpositoresPorIDEvento(new Models.Params.obtenerListaExpositoresPorIDEventoParams { id_Evento = _id_Evento });
            //List<ExpositoresPorIDEvento> ListaExpositores = obtenerListaExpositoresPorIDEvento(id_Evento);

            int count = 0;

            for (int i = 0; i < ListaExpositores.Count; i++)
            {
                if (count == 0)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante1.Text += "<div class =\"tabla_participante\"><div><img src=\"" + img + "\" class=\"img_expositor\" /></div><div>" + ListaExpositores[i].NombreCompletoUsuario + "<br></div><div class='texto1'>" + ListaExpositores[i].PuestoPersona + "<br></div><div class='texto2'>" + ListaExpositores[i].OrganizacionPersona + "</span><div/> </div><br/>";
                    count++;
                }
                else if (count == 1)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante2.Text += " <table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br><b>" + ListaExpositores[i].NombreCompletoUsuario + "<br></b><span class='texto1'>" + ListaExpositores[i].PuestoPersona + "<br></span><span class='texto2'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count++;
                }
                else if (count == 2)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante3.Text += "<table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br>" + ListaExpositores[i].NombreCompletoUsuario + "<br><span class='texto1'>" + ListaExpositores[i].PuestoPersona + "<br></span><span class='texto2'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count++;
                }
                else if (count == 3)
                {
                    string img = clGetRepositorio.Read(ListaExpositores[i].FotoPersona);
                    txtParticiante4.Text += "<table class =\"tabla_participante\"> <tr><td><img src=\"" + img + "\" class=\"img_expositor\" /><br><b>" + ListaExpositores[i].NombreCompletoUsuario + "<br></b><span class='texto1'>" + ListaExpositores[i].PuestoPersona + "<br></span><span class='texto2'>" + ListaExpositores[i].OrganizacionPersona + "</span><td/></tr> </table><br/>";
                    count = 0; ;
                }
            }
        }
    }
}