﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PERPLANDES_Entity
    {
        public string Tabla = "PLAPERPDS";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int VERSION { get; set; }
        public int ANOINIVIG { get; set; }
        public DateTime FECHAINI { get; set; }
        public DateTime FECHAFIN { get; set; }
        public Boolean ACTIVO { get; set; }
        
    }
}
