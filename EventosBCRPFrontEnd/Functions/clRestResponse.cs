using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clRestResponse
    {
        public static IRestResponse ReadApi(string nameApi)
        {
            string Host = clValueKeyConfig.ReadKey("HostService");
            //string jsonparams = JsonConvert.SerializeObject(Params);         
            var client = new RestClient(Host + "/Api/"+nameApi);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "0aac63e5-0890-4441-a24c-2f4db155b6e5");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", jsonParams, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            return client.Execute(request); ;
        }
        public static IRestResponse ReadApi(string nameApi, string jsonParams)
        {
            string Host = clValueKeyConfig.ReadKey("HostService");
            //string jsonparams = JsonConvert.SerializeObject(Params);         
            var client = new RestClient(Host + "/Api/" + nameApi);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "0aac63e5-0890-4441-a24c-2f4db155b6e5");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", jsonParams, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            return client.Execute(request); ;
        }
    }
}