using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class sistema
    {
        public int idsistema { get; set; }
        public String nombresistema { get; set; }
        public String descripcion { get; set; }

        public sistema() { }

        public sistema(int cidsistema, String cnombresistema, String cdescripcion) {
            this.idsistema = cidsistema;
            this.nombresistema = cnombresistema;
            this.descripcion = cdescripcion;
        }
    }
}
