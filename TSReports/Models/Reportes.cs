using System;
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
            this.reportes = (List<Reporte>)((IRest)ReporteService.Instance).List<Reporte>();
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
    }
}
