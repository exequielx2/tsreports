using System.Collections.Generic;
using System.Windows.Forms;

namespace TSReports.Models.Entities
{
    class Campo
    {
        public enum orderbyenum { ASC, DESC };
        public int id { get; set; }
        public string titulo { get; set; }
        public bool visible { get; set; } = true;
        public int orden { get; set; }
        public orderbyenum orderby { get; set; } = orderbyenum.ASC;
        public List<Filtro> filtros { get; set; }
    }
}
