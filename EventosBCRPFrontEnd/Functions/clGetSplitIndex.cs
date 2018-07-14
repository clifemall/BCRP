using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clGetSplitIndex
    {
        public static string Read(string cadena, string stringsplit, int index)
        {
            //string value = "cat\r\ndog\r\nanimal\r\nperson";
            // Split the string on line breaks.
            // ... The return value from Split is a string array.
            //cadena = cadena.Replace("\\", "|");
            string[] delimiters = new string[] { "\\r", "\\n" };
            string[] lines = cadena.Split(delimiters,
                         StringSplitOptions.None);
            //string[] lines = Regex.Split(cadena, "|");
            return lines[index];
        }
    }
}