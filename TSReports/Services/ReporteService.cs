using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace TSReports.Services
{
    class ReporteService : RestConnection, IRest
    {
        private string basepath = "entorno";
        private static ReporteService instance;
        private ReporteService(){}
        public static ReporteService Instance {
            get {
                if (instance == null) {
                    instance = new ReporteService();
                }
                return instance;
            }
        }

        IList<Reporte> IRest.List<Reporte>()
        {
            JObject resp = JObject.Parse(this.DoGet(basepath + "/getentornos").Content);
            JArray data = (JArray)resp["data"];
            return data.ToObject<List<Reporte>>();
        }
        object IRest.Get()
        {
            throw new NotImplementedException();
        }

        int IRest.Save()
        {
            throw new NotImplementedException();
        }

        int IRest.Update()
        {
            throw new NotImplementedException();
        }

        public JObject Ejecutar(int id, int limit, int offset, List<dynamic> parametros)
        {
            string url = this.basepath+"/ejecutarEntorno?identorno=" + id + "&limit=" + limit + "&offset=" + offset;
            return JObject.Parse(this.DoPost(url, parametros).Content);
        }

        
    }
}
