using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAMAEMETA_Entity
    {
        public string Tabla = "PLAMAEMETA";
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public int Estado { get; set; } //NO ES UN CAMPO DE LA TABLA
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODMETA { get; set; }
        public string DESMETA { get; set; }
        public string CODMETA_TEM { get; set; }

    }
}
