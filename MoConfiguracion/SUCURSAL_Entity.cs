using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class SUCURSAL_Entity
    {
        public string Tabla = "SUCURSAL";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string DIRECCION { get; set; }
        public string CODPAIS { get; set; }
        public string CODPROVINCIA { get; set; }
        public string CODMUNICIPIO { get; set; }
        public string TELEFONO1 { get; set; }
        public string TELEFONO2 { get; set; }
        public string TELEFONO3 { get; set; }
        public string FAX1 { get; set; }
        public string WEB_SITE { get; set; }
        public string EMAIL { get; set; }

    }
}
