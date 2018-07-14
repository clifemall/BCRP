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
    public class participanteService
    {
        public static List<pa_ObtenerListaParticipantePorIDEvento_Result> obtenerListaParticipantePorIDEvento(obtenerListaParticipantePorIDEventoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaParticipantePorIDEvento", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaParticipantePorIDEvento_Result>>(response.Content);
        }

        public static List<pa_ObtenerListaExpositoresPorIDEvento_Result> obtenerListaExpositoresPorIDEvento(obtenerListaExpositoresPorIDEventoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaExpositoresPorIDEvento", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaExpositoresPorIDEvento_Result>>(response.Content);
        }

        public static List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result> obtenerListaInvitadoParticipantePorIDParticipante(obtenerListaInvitadoParticipantePorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaInvitadoParticipantePorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaInvitadoParticipantePorIDParticipante_Result>>(response.Content);
        }

        public static pa_ObtenerDatosParticipantePorIDParticipante_Result obtenerDatosParticipantePorIDParticipante(obtenerDatosParticipantePorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerDatosParticipantePorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerDatosParticipantePorIDParticipante_Result>(response.Content);
        }

        public static pa_InsertarListaInvitadoParticipantePorIDParticipante_Result insertarListaInvitadoParticipantePorIDParticipante(insertarListaInvitadoParticipantePorIDParticipanteParams Params)
        { 
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("insertarListaInvitadoParticipantePorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_InsertarListaInvitadoParticipantePorIDParticipante_Result>(response.Content);
        }

        public static pa_ObtenerCondicionesEspecialesPorIDParticipante_Result obtenerCondicionesEspecialesPorIDParticipante(obtenerCondicionesEspecialesPorIDParticipanteParams Params )
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerCondicionesEspecialesPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerCondicionesEspecialesPorIDParticipante_Result>(response.Content);
        }

        public static pa_ActualizarCondicionesEspecialesParticipante_Result actualizarCondicionesEspecialesParticipante(actualizarCondicionesEspecialesParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("actualizarCondicionesEspecialesParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ActualizarCondicionesEspecialesParticipante_Result>(response.Content);
        }

        public static pa_ObtenerDatosContactoPorIDParticipante_Result obtenerDatosContactoPorIDParticipante(obtenerDatosContactoPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerDatosContactoPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerDatosContactoPorIDParticipante_Result>(response.Content);
        }

        public static pa_ActualizarDatosContactoParticipante_Result actualizarDatosContactoParticipante(actualizarDatosContactoParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("actualizarDatosContactoParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ActualizarDatosContactoParticipante_Result>(response.Content);
        }

        public static pa_ObtenerDatosPersonalesPorIDParticipante_Result obtenerDatosPersonalesPorIDParticipante(obtenerDatosPersonalesPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerDatosPersonalesPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerDatosPersonalesPorIDParticipante_Result>(response.Content);
        }

        public static pa_ActualizarDatosPersonalesParticipante_Result actualizarDatosPersonalesParticipante(actualizarDatosPersonalesParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("actualizarDatosPersonalesParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ActualizarDatosPersonalesParticipante_Result>(response.Content);
        }

        public static pa_ObtenerDatosAdicionalesPorIDParticipante_Result obtenerDatosAdicionalesPorIDParticipante(obtenerDatosAdicionalesPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerDatosAdicionalesPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerDatosAdicionalesPorIDParticipante_Result>(response.Content);
        }

        public static pa_ActualizarDatosAdicionalesPorIDParticipante_Result actualizarDatosAdicionalesPorIDParticipante(actualizarDatosAdicionalesPorIDParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("actualizarDatosAdicionalesPorIDParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_ActualizarDatosAdicionalesPorIDParticipante_Result>(response.Content);
        }

        public static pa_InsertarDelegadoParticipante_Result insertarDelegadoParticipante(insertarDelegadoParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("insertarDelegadoParticipante", jsonparams);
            return JsonConvert.DeserializeObject<pa_InsertarDelegadoParticipante_Result>(response.Content);
        }

        public static pa_ObtenerListaHoteles_Result obtenerListaHoteles(obtenerListaHotelesParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaHoteles", jsonparams);
            return JsonConvert.DeserializeObject<pa_ObtenerListaHoteles_Result>(response.Content);
        }
        public static List<pa_ObtenerListaHotelRecomendado_Result> obtenerListaHotelRecomendado()
        {
            //string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("obtenerListaHotelRecomendado");
            return JsonConvert.DeserializeObject<List<pa_ObtenerListaHotelRecomendado_Result>>(response.Content);
        }
    }
}