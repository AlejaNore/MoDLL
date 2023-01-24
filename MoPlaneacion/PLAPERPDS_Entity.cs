using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAPERPDS_Entity
    {
        public string Tabla = "PLAPERPDS";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }        
        public DateTime FECHAINI { get; set; }
        public DateTime FECHAFIN { get; set; }
        public string ACTIVO { get; set; }

        public string ANOTEMP { get; set; }
    }
}
