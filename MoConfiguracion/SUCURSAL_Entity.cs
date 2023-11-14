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
        public string SERVERSMTP { get; set; }
        public int PORT { get; set; }
        public string PASSWORD { get; set; }
        public int TIMEOUT { get; set; }
        public string SSL { get; set; }
        public string CREDENCIALES { get; set; }
        public string RUTAPDFCOMPAGNOM { get; set; }
        public string EMAILNOM { get; set; }

        //CAMPOS QUE NO SON DE LA TABLA SUCURSAL
        public string DESPAIS { get; set; }
        public string DESPROVINCIA { get; set; }
        public string DESMUNICIPIO { get; set; }


    }
}
