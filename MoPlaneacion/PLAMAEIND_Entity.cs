using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAMAEIND_Entity
    {
        public string Tabla = "PLAMAEIND";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODINDICADOR { get; set; }
        public string DESINDICADOR { get; set; }
        public string DESFORMULA { get; set; }
        public float LINEABASE { get; set; }
        public string CODINDICADOR_TEM { get; set; }
    }
}
