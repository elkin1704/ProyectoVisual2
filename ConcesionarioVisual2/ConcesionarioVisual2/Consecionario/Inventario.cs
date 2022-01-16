using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVisual2.Consecionario
{
    internal class Inventario
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int Unidades { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public string Estado { get; set; }

        public decimal Precio_por_unidad { get; set; }
    }
}
