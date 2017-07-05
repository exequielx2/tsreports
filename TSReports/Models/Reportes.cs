using System;
using System.Collections.Generic;
using System.Linq;
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
            this.UpdateAll();
        }

        public static Reportes Instance {
            get {
                if (instance == null) {
                    instance = new Reportes();
                }
                return instance;
            }
        }

        public Reportes UpdateAll()
        {
            this.reportes = (List<Reporte>)ReporteService.Instance.List<Reporte>();
            return this;
        }
        public Reporte Update(int id)
        {
            throw new NotImplementedException();
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

        public bool Delete(int id)
        {
            foreach (Reporte r in this.reportes) {
                if (r.id == id) {
                    if (ReporteService.Instance.Delete(id)) {
                        this.reportes.Remove(r);
                        return true;
                    }
                    break;
                }
            }
            return false;
        }

        public List<string> Groups()
        {
             return this.reportes.Where(r=>r.grupo != "default").GroupBy(r => r.id).Select(r => r.First().grupo).ToList();
        }

    }
     
}
