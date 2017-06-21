using System.Collections.Generic;
using System.Windows.Forms;

namespace TSReports.Models.Entities
{
    class Campo
    {
        public int id;
        public string titulo;
        public bool visible;
        public int orden;
        public string orderby;
        public List<Filtro> filtros;
    }
}
