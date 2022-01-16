using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVisual2.Consecionario
{
    internal class InformeGastos
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public decimal Agua { get; set; }
        public decimal Luz { get; set; }
        public decimal Telefono { get; set; }

        public decimal Otros_servicios { get; set; }

        public decimal Total { get; set; }
    }
}
