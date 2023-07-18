using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAREGDOCDET_Entity
    {

        public string Tabla = "PLAREGDOCDET";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODDOC { get; set; }
        public string PREFIJO { get; set; }
        public int CONSEC { get; set; }
        public int POSICION { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANORUBRO { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string CODACTIVIDAD { get; set; }
        public string CODTAREA { get; set; }
        public double CANTAVANCE { get; set; }
        public string EXPLICACION { get; set; }

        //CAMPOS QUE NO ESTAN EN LA TABLA 
        public int ANO { get; set; }
        public int MES { get; set; }
        public DateTime FECHAINI { get; set; }
        public DateTime FECHAFIN { get; set; }

        public int AUTORIZADO { get; set; }
        public string desplandes { get; set; }
        public string desejeest { get; set; }
        public string desprograma { get; set; }
        public string desproyecto { get; set; }
        public string DESACTIVIDAD { get; set; }
        public string DESTAREA { get; set; }

    }

    public class Forma_PLAREGDOCDET_Entity//NO ES UN CAMPO DE LA TABLA
    {
        public string EDCODDOC { get; set; }
        public string EDPREFIJO { get; set; }
        public int EDCONSEC { get; set; }
        public string EDCODPLANDES { get; set; }
        public string EDCODEJEEST { get; set; }
        public string EDCODPROGRAMA { get; set; }
        public string EDCODPROYECTO { get; set; }
        public string EDCODACTIVIDAD { get; set; }
        public string EDCODTAREA { get; set; }
        public Boolean CHCANTDIFCERO { get; set; }

    }


    public class M_MoPlan21
    {
        public string Tabla = "PLAREGDOCDET";
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANORUBRO { get; set; }
        public int POSINF { get; set; }

        public string CODDOC { get; set; }
        public string PREFIJO { get; set; }
        public int CONSEC { get; set; }
        public string DOCUMENTO { get; set; }
        public int POSICION { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public DateTime FECHADOC { get; set; }
        public string FECHAstr { get; set; }
        public string CPROYECTO { get; set; }
        public string CODPLANDES { get; set; }
        public string DESPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string DESEJEEST { get; set; }       
        public string CODPROGRAMA { get; set; }
        public string DESPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string DESPROYECTO { get; set; }
        
        public string CODACTIVIDAD { get; set; }
        public string DESACTIVIDAD { get; set; }
        public string CODTAREA { get; set; }
        public string DESTAREA { get; set; }
        public double CANTAVANCE { get; set; }
        public string EXPLICACION { get; set; }
    }


}
