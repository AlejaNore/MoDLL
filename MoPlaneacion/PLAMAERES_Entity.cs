using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAMAERES_Entity
    {
        public string Tabla = "PLAMAERES";
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public int Estado { get; set; } //NO ES UN CAMPO DE LA TABLA
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODRESULTADO { get; set; }
        public string DESRESULTADO { get; set; }
        public string EXPLICACION { get; set; }
        public double PESOESPECIFICO { get; set; }
        public string CODRESULTADO_TEM { get; set; }
    }
}
