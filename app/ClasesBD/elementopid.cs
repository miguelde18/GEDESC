using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class elementopid
    {
        public String tag { get; set; }
        public int sistema { get; set; }
        public String instalacion { get; set; }
        public String tipo { get; set; }
        public String codpid { get; set; }

        public elementopid() { }

        public elementopid (String ctag, int csistema, String cinstalacion, String ctipo, String ccodpid)
        {
            this.tag = ctag;
            this.sistema = csistema;
            this.instalacion = cinstalacion;
            this.codpid = ccodpid;
        }
    }
}
