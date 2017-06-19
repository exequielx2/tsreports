using System.Collections.Generic; 

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
