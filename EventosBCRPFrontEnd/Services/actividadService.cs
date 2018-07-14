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
    public class actividadService
    {
        public static List<pa_ObtenerListaActividadesPorIDEvento_Result> obtenerListaActividadesPorIDEvento(obtenerListaActividadesPorIDEventoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaActividadesPorIDEvento", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaActividadesPorIDEvento_Result>>(response.Content);
        }

        public static List<pa_ObtenerListaActividadesPorIDParticipante_Result> obtenerListaActividadesPorIDParticipante(obtenerListaActividadesPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaActividadesPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaActividadesPorIDParticipante_Result>>(response.Content);
        }

        public static pa_EliminarListaActividadesPorIDParticipante_Result eliminarAgendaActividadPorIDParticipante(eliminarAgendaActividadPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("eliminarAgendaActividadPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_EliminarListaActividadesPorIDParticipante_Result>(response.Content);
        }

        public static pa_InsertarListaActividadesPorIDParticipante_Result insertarListaActividadesPorIDParticipante(insertarListaActividadesPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("insertarListaActividadesPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_InsertarListaActividadesPorIDParticipante_Result>(response.Content);
        }

        public static List<pa_ObtenerListaPreguntasActividadPorIDActividad_Result> obtenerListaPreguntasActividadPorIDActividad(obtenerListaPreguntasActividadPorIDActividadParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaPreguntasActividadPorIDActividad", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaPreguntasActividadPorIDActividad_Result>>(response.Content);
        }
        public static string obtenerListaPreguntasActividadPorIDActividadJson(obtenerListaPreguntasActividadPorIDActividadParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaPreguntasActividadPorIDActividad", jsonparams);
            return response.Content;
        }
    }
}