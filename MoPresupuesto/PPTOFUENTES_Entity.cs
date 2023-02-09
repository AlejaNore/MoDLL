using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PPTOFUENTES_Entity
    {
        public string Tabla = "PPTOFUENTES";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string CON_FONDOS { get; set; }
        public string LIBRE_DESTINACION { get; set; }
        public string INVERSION { get; set; }
        public string FUNCIONAMIENTO { get; set; }
        public string CODIGOHOMOLOGADO { get; set; }
        public string CODHOMOCHIP { get; set; }
    }
}
