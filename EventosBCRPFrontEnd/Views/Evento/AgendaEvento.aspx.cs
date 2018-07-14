using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Net;
using EventosBCRPFrontEnd.Views.Principal;
using System.Web.Services;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class AgendaEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
            if (Session["id_Participante"] != null)
            {
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                ParentRepeater.DataSource = listAgenda.GroupBy(q => q.CabeceraFecha).Select(group => new { CabeceraFecha = group.Key }).ToList();
                ParentRepeater.DataBind();
            }
            else
            {

            }
            pintarPlantilla();
            obtenerDatosPantalle();

            
        }
        protected void btnDescarga_Click(object sender, EventArgs e)
        {
            LinkButton myControl1 = (LinkButton)sender;
            string url = myControl1.CommandArgument;
            string urlcompleto = clGetRepositorio.Read(url);
            DownloadFile2(urlcompleto);
        }

        protected void btnPop_Click(object sender, EventArgs e)
        {
            LinkButton myControl1 = (LinkButton)sender;
            string url = myControl1.CommandArgument;
            //List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
            //MaterEvento frm = new MaterEvento();
            //frm.RepeaterPreguntas.DataSource = listAgenda.GroupBy(q => q.CabeceraFecha).Select(group => new { CabeceraFecha = group.Key }).ToList();
            //frm.RepeaterPreguntas.DataBind();
            ScriptManager.RegisterStartupScript(
                         this,
                         this.GetType(),
                         "MyAction",
                         "CallPop(" + url + ");",
                         true);
        }
        

        protected void doOpen(string sender, string path)
        {
            Control myControl1 = FindControl(sender);

        }

        public void DownloadFile2(string url)
        {
            string fileName = System.IO.Path.GetFileName(url);
            //Create a stream for the file
            Stream stream = null;

            //This controls how many bytes to read at a time and send to the client
            int bytesToRead = 10000;

            // Buffer to read bytes in chunk size specified above
            byte[] buffer = new Byte[bytesToRead];

            // The number of bytes read
            try
            {
                //Create a WebRequest to get the file
                HttpWebRequest fileReq = (HttpWebRequest)HttpWebRequest.Create(url);

                //Create a response for this request
                HttpWebResponse fileResp = (HttpWebResponse)fileReq.GetResponse();

                if (fileReq.ContentLength > 0)
                    fileResp.ContentLength = fileReq.ContentLength;

                //Get the Stream returned from the response
                stream = fileResp.GetResponseStream();

                // prepare the response to the client. resp is the client Response
                var resp = HttpContext.Current.Response;

                //Indicate the type of data being sent
                resp.ContentType = "application/octet-stream";

                //Name the file 
                resp.AddHeader("Content-Disposition", "attachment; filename=\"" + fileName + "\"");
                resp.AddHeader("Content-Length", fileResp.ContentLength.ToString());

                int length;
                do
                {
                    // Verify that the client is connected.
                    if (resp.IsClientConnected)
                    {
                        // Read data into the buffer.
                        length = stream.Read(buffer, 0, bytesToRead);

                        // and write it out to the response's output stream
                        resp.OutputStream.Write(buffer, 0, length);

                        // Flush the data
                        resp.Flush();

                        //Clear the buffer
                        buffer = new Byte[bytesToRead];
                    }
                    else
                    {
                        // cancel the download if client has disconnected
                        length = -1;
                    }
                } while (length > 0); //Repeat until no data is read
            }
            catch
            {
                return;
            }
            finally
            {
                if (stream != null)
                {
                    //Close the input stream
                    stream.Close();
                }
            }
        }

        public bool DownloadFile(string pathUrl)
        {
            string fileName = System.IO.Path.GetFileName(pathUrl);

            string fullpath = System.IO.Path.GetDirectoryName(pathUrl);
            string root = fullpath;
            //string fullpath = System.IO.Path.GetFullPath;
            //string fullFileName = Environment.GetFolderPath(Environment.SpecialFolder.) + fileName;
            try
            {
                WebRequest myre = WebRequest.Create(pathUrl);
            }
            catch
            {
                return false;
            }
            try
            {
                byte[] fileData;
                using (WebClient client = new WebClient())
                {
                    client.DownloadString(pathUrl);
                    //fileData = client.DownloadData(pathUrl);
                    //client.DownloadFile(root+"\\", fileName);
                }
                //using (FileStream fs =
                //      new FileStream(pathUrl, FileMode.OpenOrCreate))
                //{
                //    fs.Write(fileData, 0, fileData.Length);
                //}
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("download field", ex.InnerException);
            }
        }

        private void pintarPlantilla()
        {
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], Session["listaPermisos"]);
            tituloAgenda.InnerText = obj.ReadEntityBodyMode("txtAgenda");
            tituloAgenda.Visible = obj.ReadEntityVisible("txtAgenda");
        }

        protected void ItemBound(object sender, RepeaterItemEventArgs args)
        {
            //LISTADO DENTRO DE OTRO REPEATER 
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)args.Item.FindControl("ChildRepeater");
                Label label = (Label)args.Item.FindControl("Label1");
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                childRepeater.DataSource = listAgenda.Where(q => q.CabeceraFecha == label.Text).ToList();
                childRepeater.DataBind();
            }
        }
        protected void ItemBound2(object sender, RepeaterItemEventArgs args)
        {
            //LISTAR ADENTRO DEL ADENTRO
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater ChildRepeater2 = (Repeater)args.Item.FindControl("ChildRepeater2");
                Label label2 = (Label)args.Item.FindControl("LabelID");
                List<pa_ObtenerListaRepositoriosPorIDActividad_Result> Listarepositorios = eventoService.obtenerListaRepositoriosPorIDActividad(new Models.Params.obtenerListaRepositoriosPorIDActividadParams {  id_Actividad = int.Parse(label2.Text), codIdioma = Session["codIdioma"].ToString() }).ToList();
                //List<repositorio> Listarepositorios = obtenerListaRepositoriosPorIDEvento(Session["id_Evento"].ToString(), "SPA");
                ChildRepeater2.DataSource = Listarepositorios;
                ChildRepeater2.DataBind();
                //List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "02", codIdioma = Session["codIdioma"].ToString() });
                //ChildRepeater2.DataSource = listAgenda.Where(q => q.CabeceraFecha == label.Text).ToList();
                //ChildRepeater2.DataBind();
                Repeater childRepeater3 = (Repeater)args.Item.FindControl("RepeaterPreguntas");
                List<pa_ObtenerListaPreguntasActividadPorIDActividad_Result> listpreguntas = actividadService.obtenerListaPreguntasActividadPorIDActividad(new obtenerListaPreguntasActividadPorIDActividadParams { id_Actividad = int.Parse(label2.Text) });
                childRepeater3.DataSource = listpreguntas;
                childRepeater3.DataBind();
            }
        }
        protected void ItemBound3(object sender, RepeaterItemEventArgs args)
        {
            //LISTADO DENTRO DE OTRO REPEATER 
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)args.Item.FindControl("RepeaterPreguntas");
                Label label = (Label)args.Item.FindControl("Label1");
                List<pa_ObtenerListaActividadesPorIDParticipante_Result> listAgenda = actividadService.obtenerListaActividadesPorIDParticipante(new obtenerListaActividadesPorIDParticipanteParams { id_Participante = int.Parse(Session["id_Participante"].ToString()), codigoTipoActividad = "00", codIdioma = Session["codIdioma"].ToString() });
                childRepeater.DataSource = listAgenda.Where(q => q.CabeceraFecha == label.Text).ToList();
                childRepeater.DataBind();
            }
        }
        private void obtenerDatosPantalle()
        {
            pa_ObtenerDetalleEventoPorIDEvento_Result detalleEvento = eventoService.obtenerDetalleEventoPorIDEvento(new obtenerDetalleEventoPorIDEventoParams { id_Evento = int.Parse(Session["id_Evento"].ToString()), codIdioma = Session["codIdioma"].ToString() });
            //backgroundprincipal.Style.Add(HtmlTextWriterStyle.BackgroundImage, clGetRepositorio.Read(detalleEvento.FotoWebEvento));


            //imgBackApp.ImageUrl = clGetRepositorio.Read(detalleEvento.FotoAPPEvento);
            txtTitulo.InnerText = detalleEvento.NombreEvento;
            txtDireccion.InnerText = detalleEvento.DireccionEvento;
            txtFecha.InnerText = detalleEvento.FechaInicioEvento.ToShortDateString();
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            //Get the reference of the clicked button.
            LinkButton button = (sender as LinkButton);

            //Get the command argument
            string commandArgument = button.CommandArgument;

            //Get the Repeater Item reference
            RepeaterItem item = button.NamingContainer as RepeaterItem;

            //Get the repeater item index
            int index = item.ItemIndex;
        }
    }
}