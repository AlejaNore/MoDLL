using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAMAEIND_Entity
    {
        public string Tabla = "plamaeind";//PLAMAEIND
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public int Estado { get; set; } //NO ES UN CAMPO DE LA TABLA      
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODMODULO { get; set; }
        public int CODINDICADOR { get; set; }
        public string DESINDICADOR { get; set; }
        public string DESFORMULA { get; set; }
        public double LINEABASE { get; set; }
        public int CODINDICADOR_TEM { get; set; }
    }
}
