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
    public class invitadoParticipanteService
    {
        public static pa_EliminarInvitadoPorIDInvitado_Result eliminarInvitadoPorIDInvitado(eliminarInvitadoPorIDInvitadoParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("eliminarInvitadoPorIDInvitado", jsonparams);
            return JsonConvert.DeserializeObject<pa_EliminarInvitadoPorIDInvitado_Result>(response.Content);
        }
    }
}