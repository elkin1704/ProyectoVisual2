using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVisual2.Consecionario
{
    internal class IngresosNetos
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public int Rol_Pagos_Netos { get; set; }
        public string Servicios_Basicos_Netos { get; set; }
        public string Ingresos_Totales { get; set; }

        public string Valor_Aprobacion { get; set; }

        
    }
}
