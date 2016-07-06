using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class elementodescargo
    {
        public String tag { get; set; }
        public String coddescargo { get; set; }
        public Boolean vabierta { get; set; }
        public Boolean vcerrada { get; set; }
        public Boolean venlocal { get; set; }
        public Boolean vsinairecontrol { get; set; }
        public Boolean vbloqueada { get; set; }
        public Boolean vdiscociego { get; set; }
        public Boolean isabierto { get; set; }
        public Boolean iscerrado { get; set; }
        public Boolean issintensionmando { get; set; }
        public Boolean isbloqueado { get; set; }
        public Boolean isextraido { get; set; }
        public Boolean ispat { get; set; }
        public String otros { get; set; }
        public String observaciones { get; set; }

        public elementodescargo()
        {

        }

        public elementodescargo(String ctag, String ccoddescargo, Boolean cvabierta, Boolean cvcerrada, Boolean cvenlocal, Boolean cvsinairecontrol, Boolean cvbloqueada, Boolean cvdiscoviego, Boolean cisabierto, Boolean ciscerrado, Boolean cissintensionmando, Boolean cisbloqueado, Boolean cisextraido, Boolean cispat, String cotros, String cobservaciones)
        {
            this.tag = ctag;
            this.coddescargo = ccoddescargo;
            this.vabierta = cvabierta;
            this.vcerrada = cvcerrada;
            this.venlocal = cvenlocal;
            this.vsinairecontrol = cvsinairecontrol;
            this.vbloqueada = cvbloqueada;
            this.vdiscociego = cvdiscoviego;
            this.isabierto = cisabierto;
            this.iscerrado = ciscerrado;
            this.issintensionmando = cissintensionmando;
            this.isbloqueado = cisbloqueado;
            this.isextraido = cisextraido;
            this.ispat = cispat;
            this.otros = cotros;
            this.observaciones = cobservaciones;
        }
}
}
