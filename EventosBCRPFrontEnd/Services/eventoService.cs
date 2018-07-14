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

namespace EventosBCRPFrontEnd.Services
{
    public class eventoService
    {
        public static pa_ObtenerDetalleEventoPorIDEvento_Result obtenerDetalleEventoPorIDEvento(obtenerDetalleEventoPorIDEventoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerDetalleEventoPorIDEvento", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerDetalleEventoPorIDEvento_Result>(response.Content);
        }

        public static List<pa_ObtenerListaEventosPorIDUsuario_Result> obtenerListaEventosPorIDUsuario(obtenerListaEventosPorIDUsuarioParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaEventosPorIDUsuario", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaEventosPorIDUsuario_Result>>(response.Content);

        }

        public static List<pa_ObtenerListaRepositoriosPorIDEvento_Result> obtenerListaRepositoriosPorIDEvento(obtenerListaRepositoriosPorIDEventoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaRepositoriosPorIDEvento", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaRepositoriosPorIDEvento_Result>>(response.Content);
        }

        public static List<pa_ObtenerListaRepositoriosPorIDActividad_Result> obtenerListaRepositoriosPorIDActividad(obtenerListaRepositoriosPorIDActividadParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaRepositoriosPorIDActividad", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaRepositoriosPorIDActividad_Result>>(response.Content);
        }
    }
}