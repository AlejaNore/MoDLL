using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAPROYAREARES_Entity
    {

        public string Tabla = "PLAPROYAREARES";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODAREATRA { get; set; }
        public string NITCC { get; set; }
        public string SUCURTER { get; set; }

        public string CODAREATRA_TEM { get; set; }
        public string NITCC_TEM { get; set; }
        public string SUCURTER_TEM { get; set; }

    }
}
