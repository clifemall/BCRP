using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosBCRPFrontEnd.Views.Evento
{
    public partial class PresentacionesEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            Url.Text = ConfigurationManager.AppSettings.Get("Repositorio");
            //SI LA SESION TERMINO REGRESA AL LOGIN
            if (Session == null || Session.Count == 0)
            {
                Response.Redirect("../../Login.aspx");
            }
            if (Session["id_Evento"] != null)
            {
                List<pa_ObtenerListaRepositoriosPorIDEvento_Result> Listarepositorios = eventoService.obtenerListaRepositoriosPorIDEvento(new Models.Params.obtenerListaRepositoriosPorIDEventoParams { id_Evento = int.Parse(Session["id_Evento"].ToString()), codIdioma = Session["codIdioma"].ToString() });
                //List<repositorio> Listarepositorios = obtenerListaRepositoriosPorIDEvento(Session["id_Evento"].ToString(), "SPA");
                Repeater1.DataSource = Listarepositorios;
                Repeater1.DataBind();
            }
            else
            {
                seccionNaranja.InnerText = "No hay datos de <Participante> a consultar!";
                seccionNaranja.Visible = true;

            }

            pintarPlantilla();


        }
         
        private void pintarPlantilla()
        {
            clGetIdiomaPlantilla obj = new clGetIdiomaPlantilla(Session["ListaPlantilla"], Session["listaPermisos"]);

            tituloPresentaciones.InnerText = obj.ReadEntityBodyMode("txtPresentaciones");
            tituloPresentaciones.Visible = obj.ReadEntityVisible("txtPresentaciones");


        }

        protected void btnDescarga_Click(object sender, EventArgs e)
        {
            LinkButton myControl1 = (LinkButton)sender;
          
            string url = myControl1.CommandArgument;

            if (url.Contains("http") || url.Contains("www"))
            {
                System.Diagnostics.Process.Start(url);
            }
            else
            {
                string urlcompleto = clGetRepositorio.Read(url);
                DownloadFile2(urlcompleto);
            }

           
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
            catch {
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
    }
}