using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class MUNICIPI_Entity
    {
        public string Tabla = "MUNICIPI";
        public int Estado { get; set; }
        public string CODPAIS { get; set; }
        public string CODPROVINCIA { get; set; }
        public string CODMUNICIPIO { get; set; }
        public string DESCRIPCION { get; set; }
        public string PREDETERMINADO { get; set; }
        public string MANICA { get; set; }
        public string EXCENTOIVA { get; set; }
    }
}
