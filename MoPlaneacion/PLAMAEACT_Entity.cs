﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAMAEACT_Entity
    {
        public string Tabla = "plamaeact";//PLAMAEACT
        public string Seleccionar { get; set; } //NO ES UN CAMPO DE LA TABLA
        public int Estado { get; set; } //NO ES UN CAMPO DE LA TABLA       
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public string CODACTIVIDAD { get; set; }
        public string DESACTIVIDAD { get; set; }
        public string CODACTIVIDAD_TEM { get; set; }
    }

}
