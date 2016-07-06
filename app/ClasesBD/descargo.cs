using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class descargo
    {
        public int iddescargo { get; set; }
        public String coddescargo { get; set; }
        public int descargotipo { get; set; }

        public descargo() { }

        public descargo(int ciddescargo, String ccoddescargo, int cdescargotipo)
        {
            this.iddescargo = ciddescargo;
            this.coddescargo = ccoddescargo;
            this.descargotipo = cdescargotipo;
        }
    }
}
