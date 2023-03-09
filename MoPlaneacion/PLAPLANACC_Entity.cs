using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PLAPLANACC_Entity
    {
        public string Tabla = "PLAPLANACC";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int ANOPLANACC { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }      
        public string CODACTIVIDAD { get; set; }
        public double FACTPOND { get; set; }
        public string CODACTIVIDAD_TEM { get; set; }

        public List<PLAHOMACTINDMETA_Entity> ListPLAHOMACTINDMETA { get; set; }
        public List<PLAMAETAR_Entity> ListPLAMAETAR { get; set; }

        public PLAPLANACC_Entity()
        {
            ListPLAHOMACTINDMETA = new List<PLAHOMACTINDMETA_Entity>();
            ListPLAMAETAR = new List<PLAMAETAR_Entity>();
        }
    }
}
