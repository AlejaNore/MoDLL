using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class MAESTRODET_PLAPDSNIV_Entity
    {
        public string Tabla = "PLAPDSNIV";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANOINIVIG { get; set; }
        public int VERSION { get; set; }
        public int NIVEL { get; set; }
        public string CODPLANDES { get; set; }
        public string CODEJEEST { get; set; }
        public string CODPROGRAMA { get; set; }
        public string CODPROYECTO { get; set; }
        public string DESCRIPCION { get; set; }
        public double FACTPOND { get; set; }
        public string CODPLANDES_TEM { get; set; }
        public string CODEJEEST_TEM { get; set; }
        public string CODPROGRAMA_TEM { get; set; }
        public string CODPROYECTO_TEM { get; set; }        

        ///HIJOS public List<DETALLE_PLAPDSNIV1_Entity> RefDetalle_PLANDESNIV1 { get; set; }
        public List<PLAPDSNIV1_Entity> RefDetalle_PLANDESNIV1 { get; set; }
        public List<PLAOBJESTEJE_Entity> RefDetalle_PLAOBJESTEJE { get; set; }
        public List<PLAOBJPROG_Entity> RefDetalle_PLAOBJPROG { get; set; }
        public List<PLAPROYFUEFIN_Entity> RefDetalle_PLAPROYFUEFIN { get; set; }
        public List<PLAPROYAREARES_Entity> RefDetalle_PLAPROYAREARES { get; set; }
        public List<PLAPROYINDMETA_Entity> RefDetalle_PLAPROYINDMETA { get; set; }

        //MAESTRODET_PLAPDSNIV_Entity
        public MAESTRODET_PLAPDSNIV_Entity()
        {
            RefDetalle_PLANDESNIV1 = new List<PLAPDSNIV1_Entity>();
            RefDetalle_PLAOBJESTEJE = new List<PLAOBJESTEJE_Entity>();
            RefDetalle_PLAOBJPROG = new List<PLAOBJPROG_Entity>();
            RefDetalle_PLAPROYFUEFIN = new List<PLAPROYFUEFIN_Entity>();
            RefDetalle_PLAPROYAREARES = new List<PLAPROYAREARES_Entity>();
            RefDetalle_PLAPROYINDMETA = new List<PLAPROYINDMETA_Entity>();
        }
    }

}
