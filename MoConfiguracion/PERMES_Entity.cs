using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoDLL
{
    public class PERMES_Entity
    {
        public string Tabla = "PERMES";
        public int Estado { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODSUCURSAL { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public string CIERREMES { get; set; }
        public string CIERRECTASCOSTO { get; set; }
        public double PROHORASREALLABOR { get; set; }
        public string CIERREMESNIFF { get; set; }
        public string ABCDISAUTPROAP { get; set; }
        public string ABCDISAUTPROES { get; set; }
        public string ABCDISPROCPROAP { get; set; }
        public string ABCDISPROCPROES { get; set; }
        public string ABCDISAUTMISC { get; set; }
        public string ABCDISAUTPRESTAC { get; set; }
        public string ABCDISAUTVARIOS { get; set; }
        public string ABCDISPROCMISC { get; set; }
        public string ABCDISPROCPRESTAC { get; set; }
        public string ABCDISPROCVARIOS { get; set; }
        public string ABCDISAUTAFEQ { get; set; }
        public string ABCDISAUTAFED { get; set; }
        public string ABCDISPROCAFEQ { get; set; }
        public string ABCDISPROCAFED { get; set; }
        public string ABCDISAUTMATERIAL { get; set; }
        public string ABCDISPROCMATERIAL { get; set; }
        public string ABCDISAUTBIENES { get; set; }
        public string ABCDISPROCBIENES { get; set; }
        public string ABCDISAUTMATEVAR { get; set; }
        public string ABCDISPROCMATVAR { get; set; }
        public string ABCDISAUT_EDVAR { get; set; }
        public string ABCDISPROC_EDVAR { get; set; }
        public string ABCDISPROCPROCOM { get; set; }
        public string ABCDISAUTPROCOM { get; set; }
        public string ABCDISREMOTMISC { get; set; }
        public string ABCDISREMOTPRESTAC { get; set; }
        public string ABCDISREMOTVARIOS { get; set; }
        public string ABCDISREMOTAFEQ { get; set; }
        public string ABCDISREMOTAFED { get; set; }
        public string ABCDISREMOTMATERIAL { get; set; }
        public string ABCDISREMOTBIENES { get; set; }
        public string ABCDISREMOTMATEVAR { get; set; }
        public string ABCDISREMOT_EDVAR { get; set; }
        public DateTime FECHA_INI { get; set; }
        public DateTime FECHA_FIN { get; set; }
    }
}
