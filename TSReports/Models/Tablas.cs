using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSReports.Models.Entities;
using TSReports.Services;

namespace TSReports.Models
{
    class Tablas
    {
        private List<Tabla> tablas;
        private static Tablas instance;

        private Tablas()
        {
            this.tablas = new List<Tabla>();
            this.UpdateAll();
        }

        public static Tablas Instance {
            get {
                if (instance == null) {
                    instance = new Tablas();
                }
                return instance;
            }
        }

        public Tablas UpdateAll()
        {
            this.tablas = (List<Tabla>)ReporteService.Instance.ListTables<Tabla>();
            return this;
        }

        public Reporte Update(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tabla> List()
        {
            return this.tablas;
        }

        public Tabla Get(int id)
        {
            foreach (Tabla r in this.tablas) {
                if (r.id == id) {
                    return r;
                }
            }
            return null;
        }

        public Campo GetCampo(int id)
        {
            foreach (Tabla r in this.tablas) {
                foreach (Campo c in r.campos) {
                    if (c.id == id) {
                        return c;
                    }
                }
            }
            return null;
        }


        public dynamic Relaciones(List<int> idsorigen, List<int> idsdestino)
        {
            if(idsorigen.Count == 0 || idsdestino.Count == 0) { return null; }
           return ReporteService.Instance.Relaciones(new { origen = idsorigen, destino = idsdestino });
        }

    }
}
