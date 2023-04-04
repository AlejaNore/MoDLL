using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAREGDOCDET_Entity
    {
        public string Tabla = "PLAREGDOCDET";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODDOC { get; set; }
        public string PREFIJO { get; set; }
        public int CONSEC { get; set; }
        public int POSICION { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANOPLANACC { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODACTIVIDAD { get; set; }
        public string CODTAREA { get; set; }
        public double CANTAVANCE { get; set; }
        public string EXPLICACION { get; set; }
    }
}
