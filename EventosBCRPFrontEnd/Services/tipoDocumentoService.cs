using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Entities;
using EventosBCRPFrontEnd.Models.Params;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Services
{
    public class tipoDocumentoService
    {
        public static List<pa_ObtenerListaTipoDocumento_Result> obtenerListaTipoDocumento(obtenerListaTipoDocumentoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaTipoDocumento", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaTipoDocumento_Result>>(response.Content);
        }
    }
}