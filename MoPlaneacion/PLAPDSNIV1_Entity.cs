using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAPDSNIV1_Entity
    {
        public string Tabla = "PLAPDSNIV1";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }       
        public string CODPLANDES { get; set; }
        public string PROPOSITOGEN { get; set; }
        public string METODOLOGIA { get; set; }
        public string CODPLANDES_TEM { get; set; }       
    }
}
