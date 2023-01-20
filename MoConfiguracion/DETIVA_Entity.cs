using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class DETIVA_Entity
    {
        public string Tabla = "DETIVA";
        public int ANO { get; set; }
        public string CODIVA { get; set; }
        public float TASAIVA { get; set; }
        public int Estado { get; set; }
    }
}
