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
    public class plantillaFrontService
    {
        public static List<pa_ObtenerListaTextoPlantillaFront_Result> obtenerListaTextoPlantillaFront(obtenerListaTextoPlantillaFrontParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaTextoPlantillaFrontWEB", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaTextoPlantillaFront_Result>>(response.Content);
        }

        public static List<pa_ObtenerListaPermisosPlantillaFrontPorIDParticipante_Result> obtenerListaPermisosPlantillaFrontPorIDParticipante(obtenerListaPermisosPlantillaFrontPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaPermisosPlantillaFrontPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaPermisosPlantillaFrontPorIDParticipante_Result>>(response.Content);
        }
    }
}