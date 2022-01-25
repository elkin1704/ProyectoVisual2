using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV.Entidades
{
    public class Inventario
    {
        public int precio total {get; set;}
        public int Id_Inventario { get; set; }
        public string Marca { get; set; }
        public int Unidades { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public string Estado { get; set; }

        public decimal Precio_por_unidad { get; set; }

        //Relacion con Distribuidora
        public int Id_Distribuidora { get; set; }
    }
}
