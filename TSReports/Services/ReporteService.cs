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
        
        public IList<Reporte> List<Reporte>()
        {
            JObject resp = JObject.Parse(this.DoGet(basepath + "/getentornos").Content);
            JArray data = (JArray)resp["data"];
            return data.ToObject<List<Reporte>>();
        }


        public JObject Ejecutar(int id, int limit, int offset, List<dynamic> parametros)
        {
            string url = this.basepath+"/ejecutarEntorno?identorno=" + id + "&limit=" + limit + "&offset=" + offset;
            return JObject.Parse(this.DoPost(url, parametros).Content);
        }

        public bool Delete(int id)
        {
            string url = this.basepath + "/" + id;
            dynamic resp = JObject.Parse(this.DoDelete(url, null).Content);
            if(resp.code == 1) {
                return true;
            }
            return false;
        }

        public object Get()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
