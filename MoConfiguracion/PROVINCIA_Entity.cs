using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PROVINCIA_Entity
    {
        public string Tabla = "PROVINCIA";
        public int Estado { get; set; }
        public string CODPAIS { get; set; }
        public string CODPROVINCIA { get; set; }
        public string DESCRIPCION { get; set; }
        public string CODISO31662 { get; set; }
    }
}
