using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAREGDOCENC_Entity
    {
        public string Tabla = "PLAREGDOCENC";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODDOC { get; set; }
        public string PREFIJO { get; set; }
        public int CONSEC { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public DateTime FECHADOC { get; set; }
        public string NITCC { get; set; }
        public string DESTER { get; set; }
        public string SUCURTER { get; set; }
        public string DESSUCTER { get; set; }
        public string CODUSUARIO { get; set; }
        public string AUTORIZADO { get; set; }
        //
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
    }
}
