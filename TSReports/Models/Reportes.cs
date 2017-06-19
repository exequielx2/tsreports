using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using TSReports.Models.Entities;
using TSReports.Services;

namespace TSReports.Models
{
    class Reportes
    {
        private List<Reporte> reportes;
        private static Reportes instance;  

        private Reportes(){
            this.reportes = new List<Reporte>();
            this.Actualizar();
        }

        public static Reportes Instance {
            get {
                if (instance == null) {
                    instance = new Reportes();
                }
                return instance;
            }
        }

        public Reportes Actualizar()
        {
            var resp = RestConnection.Instance.Get("entorno/getentornos");
            JObject resp2 = JObject.Parse(resp.Content);
            JArray data = (JArray)resp2["data"];
            this.reportes = data.ToObject<List<Reporte>>(); 
            return this;
        }

        public List<Reporte> List()
        {
            return this.reportes;
        }

        public Reporte Get(int id)
        {
            foreach(Reporte r in this.reportes){
                if(r.id == id) {
                    return r;
                } 
            }
            return null;
        }
    }
}
