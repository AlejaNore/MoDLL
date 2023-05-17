using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAOBJESTEJE_Entity
    {
        public string Tabla = "plaobjesteje";// PLAOBJESTEJE
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }       
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODOBJETIVO { get; set; }
        public string DESCRIPCION { get; set; }       
        public string CODOBJETIVO_TEM { get; set; }
        public string DESCRIPCIONEJE { get; set; }
    }
}
