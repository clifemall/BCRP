using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventosBCRPFrontEnd.Models;

namespace EventosBCRPFrontEnd.Services
{
    public class usuarioService
    {
        public static cambiarClaveUsuarioResult cambiarClaveUsuario(cambiarClaveUsuarioParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("cambiarClaveUsuario", jsonparams);
            return JsonConvert.DeserializeObject<cambiarClaveUsuarioResult>(response.Content);
        }

        public static BoolResult recuperarContrasenaPorCorreoUsuario(recuperarContrasenaPorCorreoUsuarioParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("cambiarClaveUsuario", jsonparams);
            
            return JsonConvert.DeserializeObject<BoolResult>(response.Content);
        }
    }
}