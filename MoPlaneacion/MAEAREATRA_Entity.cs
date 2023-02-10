using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class MAEAREATRA_Entity
    {
        public string Tabla = "MAEAREATRA";
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public int Estado { get; set; } //NO ES UN CAMPO DE LA TABLA      
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODAREATRA { get; set; }
        public string DESAREATRA { get; set; }
        public string CODAREATRA_TEM { get; set; }
    }
}
