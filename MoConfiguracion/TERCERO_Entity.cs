using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoConfiguracion
{
    public class TERCERO_Entity
    {
        public string Tabla = "TERCERO";
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public string NITCC { get; set; }
        public string DESCRIPCION { get; set; }
        public string CODIGO { get; set; }        
        public string CLIENTE { get; set; }
        public string PROVEEDOR { get; set; }
        public string ACREEDOR { get; set; }
        public string EMPLEADO { get; set; }
        public string VENDEDOR { get; set; }
        public string OPERARIO { get; set; }
        public string SOCIO { get; set; }
        public string CONTRATISTA { get; set; }
        public string OTROS { get; set; }

        /// //ESTAN LOS CAMPOS EN OTRA TABLA
        public string SUCURTER { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string DIRECCION { get; set; }
        public string TEL1 { get; set; }

    }
    public class Forma_TERCERO_Entity//NO ES UN CAMPO DE LA TABLA
    {
        public string EDNITCC { get; set; }
        public string EDDESC { get; set; }
        public string EDCODIGO { get; set; }
        public string EDTEL { get; set; }
        public string EDDESSUCURTER { get; set; }
        public Boolean CHCLIENTE { get; set; }
        public Boolean CHPROVEEDOR { get; set; }
        public Boolean CHACREEDOR { get; set; }
        public Boolean CHEMPLEADO { get; set; }
        public Boolean CHVENDEDOR { get; set; }
        public Boolean CHOPERARIO { get; set; }
        public Boolean CHSOCIO { get; set; }
        public Boolean CHCONTRATISTA { get; set; }
        public Boolean CHOTROS { get; set; }
    }
}
