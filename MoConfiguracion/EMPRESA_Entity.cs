﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class EMPRESA_Entity
    {
        public string Tabla = "EMPRESA";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string NIT { get; set; }
        public int DIGVERIF { get; set; }
        public string RUTALOGO { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string DIRECCION { get; set; }
        public string EMAIL { get; set; }

    }
}
