
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
    public class autenticacionParticipanteService
    {
        public AutenticacionParticipanteResult autenticacionParticipante(autenticacionParticipanteParams Params)
        {
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("autenticacionParticipante", jsonparams);
            return JsonConvert.DeserializeObject<AutenticacionParticipanteResult>(response.Content);
        }
    }
}