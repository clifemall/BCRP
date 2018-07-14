using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clGenNombreFoto
    {
        /// <summary>
        /// Generador de nuevo nombre de imagen a subir o actualizar
        /// </summary>
        /// <param name="Carpeta">Ejemplo: /caperta A/carpeta B/ </param>
        /// <param name="FileName">Nombre del archivo /n/r Ejemplo: Archivo.jpg </param>
        /// <returns></returns>
        public static string Generar(string Carpeta, string FileName)
        {
            string aleatorio = System.Guid.NewGuid().ToString();
            string fechahora = DateTime.Now.ToString("ddMMyyyyHmmss");
            string extension = Path.GetExtension(FileName);
            return Carpeta + aleatorio + fechahora + extension;
            //"/eventos/" + Path.GetFileNameWithoutExtension(Params.fotoEvento) + DateTime.Now.ToString("ddMMyyyyHmmss") + Path.GetExtension(Params.fotoEvento);
        }
    }
}