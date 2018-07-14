using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clValueKeyConfig
    {
        public static string ReadKey(string name)
        {
            string value = "";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[name] ?? "Not Found";
                value = result;
            }
            catch (ConfigurationErrorsException)
            {
                value = "Error reading app settings";
            }
            //string value = WebConfigurationManager.AppSettings[name];
            return value;
        }

    }
}