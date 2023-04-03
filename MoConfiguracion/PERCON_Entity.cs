using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PERCON_Entity
    {
        public string Tabla = "PERCON";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public string CODCOMP { get; set; }
        public int CONSECCOMP { get; set; }
        public DateTime DIADESDE { get; set; }
        public DateTime DIAHASTA { get; set; }
        public string DESCRIPCION { get; set; }
        public string DESCCOMP { get; set; }
        public string CERRADO { get; set; }
        public string NOTAS { get; set; }
        public string CIERRECOMPNIFF { get; set; }

    }
}
