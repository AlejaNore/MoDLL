using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLACIEMESENC_Entity
    {
        public string Tabla = "placiemesenc";
        //SON CAMPOS DE LA TABLA
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public string AUTORIZADO { get; set; }


        //NO SON CAMPOS DE LA TABLA
        public int Estado { get; set; }



    }
}
