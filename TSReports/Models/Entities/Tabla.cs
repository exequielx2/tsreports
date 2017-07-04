using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSReports.Models.Entities
{
    class Tabla
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public List<Campo> campos { get; set; }
    }
}
