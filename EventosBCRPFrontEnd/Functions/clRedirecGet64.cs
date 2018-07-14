using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clRedirecGet64
    {
        public static string Send(string variables, string pageaspx)
        {
            //string variables = "id_Evento=" + this.id_Evento + "&id_Participante=" + this.id_Participante;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(variables);
            variables = Convert.ToBase64String(plainTextBytes);

            string link = pageaspx + "?" + "var=" + variables;
            return link;
        }
    }
}