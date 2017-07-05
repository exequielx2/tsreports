using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSReports.Models.Entities
{
    [Serializable]
    class Relacion
    {
        public Campo campoorigen { get; set; }
        public Campo campodestino { get; set; }

    }
}
