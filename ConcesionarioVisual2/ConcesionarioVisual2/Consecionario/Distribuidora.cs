using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVisual2.Consecionario
{
    internal class Distribuidora
    {
        public int Id { get; set; }
        public string Distribuidor { get; set; }

        public string Modelo { get; set; }
        public int Unidades { get; set; }

        public string Motivo { get; set; }

        public decimal Precio_Total { get; set; }
    }
}
