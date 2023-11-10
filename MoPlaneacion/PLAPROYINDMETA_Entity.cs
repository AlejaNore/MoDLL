using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAPROYINDMETA_Entity
    {
        public string Tabla = "plaproyindmeta";// PLAPROYINDMETA
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODINDICADOR { get; set; }
        public string CODMODULO { get; set; }
        public string CODMETA { get; set; }
        public double CANTMETA { get; set; }        
        public string CODINDICADOR_TEM { get; set; }
        public string CODMETA_TEM { get; set; }
        public string DESCRIPCIONPROY { get; set; }
        public string DESMETA { get; set; }
        public string DESINDICADOR { get; set; }

        //CAMPOS QUE NO SON DE LA TABLA 
        public int NumReg { get; set; }
    }
}
