using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL.MoPlaneacion
{
    public class PLAPDSNIV_Entity
    {
        public string Tabla = "plapdsniv";//PLAPDSNIV
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
        public PLAPDSNIV_Entity()
        {
            RefDetalle_PLANDESNIV1 = new List<PLAPDSNIV1_Entity>();
            RefDetalle_PLAOBJESTEJE = new List<PLAOBJESTEJE_Entity>();
            RefDetalle_PLAOBJPROG = new List<PLAOBJPROG_Entity>();
            RefDetalle_PLAPROYFUEFIN = new List<PLAPROYFUEFIN_Entity>();
            RefDetalle_PLAPROYAREARES = new List<PLAPROYAREARES_Entity>();
            RefDetalle_PLAPROYINDMETA = new List<PLAPROYINDMETA_Entity>();
        }

        //PARA OBTENER EL CODIGO Y DESCRIPCION DEL COMBOBOX
        public string CodDesEmpresa { get; set; }
        public string CodDesSucursal { get; set; }
        public string AñoVersionPDS { get; set; }
        public string CodDesPlanDesa { get; set; } //PLAN DE DESARROLLO
        public string CodDesEjeEst { get; set; }   //EJE ESTRATEGICO 
        public string CodDesPrograma { get; set; } //PROGRAMA
    }


    public class Forma_PLAPDSNIV_Entity//NO ES UN CAMPO DE LA TABLA
    {
        public int EDNIVEL { get; set; }
        public string EDCODPLANDES { get; set; }
        public string EDCODEJEEST { get; set; }
        public string EDCODPROGRAMA { get; set; }
        public string EDCODPROYECTO { get; set; }

    }
    public class moplan16_17_18
    {
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
        public string CODACTIVIDAD { get; set; }
        public string CODTAREA { get; set; }
        public string DESCRIPCION { get; set; }
        public double FACTPOND { get; set; }
        public double VALOR { get; set; }
        public double TOTAL { get; set; }
        ///ACTIV 
        public int ANORUBRO { get; set; }
        

        //TAREA              
        public Double CANTTAREA { get; set; }
        public string CODRESULTADO { get; set; }

    }



    public class moplan23
    {
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
        public string CODACTIVIDAD { get; set; }
        public string CODTAREA { get; set; }
        public string DESCRIPCION { get; set; }
        public double FACTPOND { get; set; }
        public double VALOR { get; set; }
        public double TOTAL { get; set; }
        ///ACTIV 
        public int ANORUBRO { get; set; }


        //TAREA              
        public Double CANTTAREA { get; set; }
        public string CODRESULTADO { get; set; }

        //META
        public string CODINDICADOR { get; set; }
        public string CODMETA { get; set; }
        public Double CANTMETA { get; set; }
        public Double CANTAVANCE { get; set; }
    }



}
