using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class ZONAS_Entity
    {
        public string Tabla = "ZONAS";
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public bool PREDETERMINADO { get; set; }
        public int Estado { get; set; }
    }
}
