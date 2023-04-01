using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class DOCUMENT_Entity
    {
        public string Tabla = "DOCUMENT";
        public int Estado { get; set; }
        public string CODDOC { get; set; }
        public string DESCRIPCION { get; set; }
        public string CODTIPODOC { get; set; }
        public string AFECTA_PPTO { get; set; }
        public string CODTR { get; set; }
        public string DOC_OFICIAL { get; set; }
        public string CODINT_1 { get; set; }
        public string ACTIVO { get; set; }
        public string RCLING { get; set; }
        public string RCL0701AP { get; set; }
        public string RCLGTO { get; set; }
        public string RCL0702AP { get; set; }
        public string NOMRETRO { get; set; }
        public string CODCOMP { get; set; }
    }
}
