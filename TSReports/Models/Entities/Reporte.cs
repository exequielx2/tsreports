using System.Collections.Generic;

namespace TSReports.Models.Entities
{
    class Reporte
    {
        public enum TipoEntorno { dinamico,estatico };

        public int id { get; set; }
        public bool exportable { get; set; }
        public string descripcion { get; set; }
        public Reporte.TipoEntorno tipo { get; set; }
        public string grupo { get; set; }
        public List<Campo> campos { get; set; }
    }
}
