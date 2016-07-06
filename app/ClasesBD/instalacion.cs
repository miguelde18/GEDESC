using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class instalacion
    {
        public int idinstalacion { get; set; }
        public String nombreinstalacion { get; set; }

        public instalacion () { }

        public instalacion (int cidinstalacion, String cnombreinstalacion)
        {
            this.idinstalacion = cidinstalacion;
            this.nombreinstalacion = cnombreinstalacion;
        }
    }
}
