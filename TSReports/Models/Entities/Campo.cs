using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TSReports.Models.Entities
{
    [Serializable]
    class Campo 
    {
        public enum orderbyenum { ASC, DESC };
        public int id { get; set; }
        public int idtabla { get; set; }
        public string titulo { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public bool visible { get; set; } = true;
        public int orden { get; set; }
        public orderbyenum orderby { get; set; } = orderbyenum.ASC;
        public List<Filtro> filtros { get; set; }
        public Tabla tabla { get; set; }
    }
}
