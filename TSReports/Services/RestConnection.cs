using RestSharp;
using System;

namespace TSReports.Services
{
    class RestConnection
    {
        private static RestConnection instance;
        private RestClient cliente;

        private RestConnection()
        {
            this.cliente = new RestClient("http://192.168.0.58/ar/");
            this.cliente.CookieContainer = new System.Net.CookieContainer();
        }

        public static RestConnection Instance {
            get {
                if (instance == null) {
                    instance = new RestConnection();
                }
                return instance;
            }
        }

        public IRestResponse Post(String url, object bodyjson)
        { 
            var request = new RestRequest(url, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(bodyjson);
            return this.cliente.Execute(request);
        }
        public IRestResponse Get(String url)
        { 
            var request = new RestRequest(url, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            return this.cliente.Execute(request);
        }

    }
}
