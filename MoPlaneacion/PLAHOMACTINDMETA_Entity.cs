using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAHOMACTINDMETA_Entity
    {
        public string Tabla = "PLAHOMACTINDMETA";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANOPLANACC { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODACTIVIDAD { get; set; }
        public string CODMODULO { get; set; }
        public int CODINDICADOR { get; set; }
        public double LINEABASE { get; set; }
        public string CODMETA { get; set; }
        public double CANTACT { get; set; }
        public string CODRESULTADO { get; set; }
        //public string OBSERVMETA { get; set; }}
        public string CODMODULO_TEM { get; set; }
        public int CODINDICADOR_TEM { get; set; }
        public string CODMETA_TEM { get; set; }
    }
}
