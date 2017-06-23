using RestSharp;
using System;

namespace TSReports.Services
{
    abstract class RestConnection
    {
        static RestClient cliente = null;

        public RestConnection()
        {
            if(null == cliente) {
                cliente = new RestClient(Properties.Settings.Default.server_url);
                cliente.CookieContainer = new System.Net.CookieContainer();
            } 
        }

        protected IRestResponse DoPost(String url, object bodyjson)
        { 
            var request = new RestRequest(url, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(bodyjson);
            return cliente.Execute(request);
        }
        protected IRestResponse DoGet(String url)
        { 
            var request = new RestRequest(url, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            return cliente.Execute(request);
        }
        protected IRestResponse DoDelete(String url, object bodyjson)
        {
            var request = new RestRequest(url, Method.DELETE);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(bodyjson);
            return cliente.Execute(request);
        }

    }
}
