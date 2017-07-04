using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TSReports.Models.Entities
{
    [Serializable]
    class Tabla
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string alias { get; set; }
        public List<Campo> campos { get; set; }

       
    }
}
