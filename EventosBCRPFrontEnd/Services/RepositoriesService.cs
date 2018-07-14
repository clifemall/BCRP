using EventosBCRPFrontEnd.Functions;
using EventosBCRPFrontEnd.Models.Params;
using EventosBCRPFrontEnd.Models.Result;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace EventosBCRPFrontEnd.Services
{
    public class RepositoriesService
    {
        public static SalvarImagenRepositorioResult SalvarImagenRepositorio(SalvarImagenRepositorioParams Params)
        {
            Params.Base64Image = Regex.Match(Params.Base64Image, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            string jsonparams = JsonConvert.SerializeObject(Params);
            IRestResponse response = clRestResponse.ReadApi("SalvarImagenRepositorio", jsonparams);
            return JsonConvert.DeserializeObject<SalvarImagenRepositorioResult>(response.Content);
        }
    }
}