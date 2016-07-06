using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class tipoelemento
    {
        public int idtipoelemento { get; set; }
        public String tipo { get; set; }

        public tipoelemento() { }

        public tipoelemento(int cidtipoelemento, String ctipo) {
            this.idtipoelemento = cidtipoelemento;
            this.tipo = ctipo;
        }
    }
}
