using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class planosid
    {
        public int idpid { get; set; }
        public String codpid { get; set; }
        public String datapid { get; set; }
     
        
        public planosid()
        {

        }

        public planosid(int cidpid, String ccodpid, String cdatapid)
        {
            this.idpid = cidpid;
            this.codpid = ccodpid;
            this.datapid = cdatapid;         
        }
    }
}
