using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PERPLANDES_Entity
    {
        public string Tabla = "PERPLANDES";
        public string CODEMPRESA { get; set; }
        public int VERSION { get; set; }
        public int ANO { get; set; }
        public DateTime FECHA_INI { get; set; }
        public DateTime FECHA_FIN { get; set; }
        public int Estado { get; set; }
    }
}
