using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clGetFileFTP
    {
        public static string ReadImage(string path)
        {
            WebClient request = new WebClient();
            string url = "ftp://ftp.microsoft.com/developr/fortran/" + "README.TXT";
            request.Credentials = new NetworkCredential("zeit 39", "123");

            try
            {
                byte[] newFileData = request.DownloadData(path);
                MemoryStream ms = new MemoryStream(newFileData);
                return "data:image/gif;base64," + Convert.ToBase64String(newFileData);
                //Image returnImage = Image.FromStream(ms);
                //return returnImage;
                //string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                //Console.WriteLine(fileString);
            }
            catch (WebException e)
            {
                return null;
                // Do something such as log error, but this is based on OP's original code
                // so for now we do nothing.
            }
        }
    }
}