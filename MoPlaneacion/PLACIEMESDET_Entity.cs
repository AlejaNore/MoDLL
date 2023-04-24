using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLACIEMESDET_Entity
    {
        public string Tabla = "placiemesdet";
        //SON CAMPOS DE LA TABLA
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public int POSICION { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANORUBRO { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODACTIVIDAD { get; set; }
        public double TOTCANTAVANCE { get; set; }


        //NO SON CAMPOS DE LA TABLA
        public int Estado { get; set; }
    }
}
