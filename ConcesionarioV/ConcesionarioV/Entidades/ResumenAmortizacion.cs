using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class ResumenAmortizacion
    {
        public int Id_Resumen { get; set; }
        public string Cliente { get; set; }

        public decimal ValorPrestamo { get; set; }

        public decimal SumaCuotas { get; set; }
        public decimal SumaInteres { get; set; }

        public string Prestamo { get; set; }

        // Relacion con Cliente
        public int Id_Cliente { get; set; }

        // Relacion con Cliente
        public int Id_Ingreso { get; set; }
    }



}
