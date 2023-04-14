using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAMAETAR_Entity
    {
        public string Tabla = "plamaetar";// PLAMAETAR

        //NO SON CAMPOS DE LA TABLA
        public int Estado { get; set; } 
        public string Seleccionar { get; set; } 

        //SI SON CAMPOS DE LA TABLA
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANOPLANACC { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODACTIVIDAD { get; set; }
        public string CODTAREA { get; set; }
        public string DESTAREA { get; set; }
        public Double CANTTAREA { get; set; }
        public string CODRESULTADO { get; set; }
        public string CODTAREA_TEM { get; set; }
        //DESCRIPCIONES
        public string DESRESULTADO { get; set; }
    }
}
