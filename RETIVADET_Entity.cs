using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class RETIVADET_Entity
    {
        public string Tabla = "RETIVADET";
        public string CODRETIVA { get; set; }
        public int ANO { get; set; }
        public float BASE { get; set; }
        public float TASARETIVA { get; set; }        
        public int Estado { get; set; }
    }
}
