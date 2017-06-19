using System.Collections.Generic;

namespace TSReports.Models.Entities
{
    class Reporte
    {
        public enum TipoEntorno { dinamico,estatico };

        public int id;
        public bool exportable;
        public string descripcion;
        public Reporte.TipoEntorno tipo;
        public string grupo;
        public List<Campo> campos;
    }
}
