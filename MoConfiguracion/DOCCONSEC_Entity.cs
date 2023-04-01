using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class DOCCONSEC_Entity
    {
        public string Tabla = "DOCCONSEC";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODDOC { get; set; }
        public string PREFIJO { get; set; }
        public int CONSECINI { get; set; }
        public int CONSEC { get; set; }
        public int CONSECFIN { get; set; }
        public string CONTCONSECFIN { get; set; }
        public string SISTCONTCONSEC { get; set; }
        public string IMPDESAUTORIZADO { get; set; }
        public string FORMATOPERSONAL { get; set; }
        public string RESOLDIAN { get; set; }
        public string NORMA_FAC { get; set; }
        public string NOTAS { get; set; }
        public string TEXTOCARTA { get; set; }
        public int NUM_ITEMS { get; set; }
        public string NOMBRE1 { get; set; }
        public string CARGO1 { get; set; }
        public string NOMBRE2 { get; set; }
        public string CARGO2 { get; set; }
        public string NOMBRE3 { get; set; }
        public string CARGO3 { get; set; }
        public string RDPROCORIG { get; set; }
        public string RDPROCENTO { get; set; }
        public string RDCODIGO { get; set; }
        public string RDVERSION { get; set; }
        public DateTime RDFECVIGEN { get; set; }
        public string RDACTIVO { get; set; }
        public string TIPOIMPRFORM { get; set; }
        public string IMPLOGO { get; set; }
        public string ACTIVO { get; set; }
        public string OPERADBLMOD { get; set; }
        public string CAMPOAUX1 { get; set; }
        public string CAMPOAUX2 { get; set; }
        public string CAMPOAUX3 { get; set; }
        public string CAMPOAUX4 { get; set; }
        public string CAMPOAUX5 { get; set; }
        public string CAMPOAUX6 { get; set; }
        public string CAMPOAUX7 { get; set; }
        public string CAMPOAUX8 { get; set; }
        public string CAMPOAUX9 { get; set; }
        public string CAMPOAUX0 { get; set; }
        public string RESFACCOMP { get; set; }
        public string CODMODUSOSEC { get; set; }
        public string INCONSENUEVO { get; set; }
        public int DIASVCTOCDP { get; set; }
        public string CODTIPNOT { get; set; }
        public int CONSEC_DES_NE { get; set; }
        public int CONSEC_HAS_NE { get; set; }
        public int CONSEC_INI_NE { get; set; }
        public string CODTIPAMB { get; set; }
        public string CODADJ_DE { get; set; }
        public string RUTAPDF_DE { get; set; }
    }
}
