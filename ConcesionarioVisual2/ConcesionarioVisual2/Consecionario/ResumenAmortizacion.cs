using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVisual2.Consecionario
{
    internal class ResumenAmortizacion
    {
        public int Id { get; set; }
        public string Cliente { get; set; }

        public decimal ValorPrestamo { get; set; }

        public decimal SumaCuotas { get; set; }
        public decimal SumaInteres { get; set; }

        public string Prestamo { get; set; }
    }
}
