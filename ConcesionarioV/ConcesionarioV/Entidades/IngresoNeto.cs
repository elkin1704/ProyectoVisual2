using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class IngresoNeto
    {
        public int Id_Ingreso{ get; set; }
        public string Cliente { get; set; }
        public int Rol_Pagos_Netos { get; set; }
        public string Servicios_Basicos_Netos { get; set; }
        public string Ingresos_Totales { get; set; }

        public string Valor_Aprobacion { get; set; }

        // Relacion con Cliente
        public int Id_Cliente { get; set; }

        // Relacion con Rol de Pagos
        public int Id_RolPago { get; set; }

        //Relacion con Informe Gastos
        public int Id_Informe { get; set; }
    }
}
