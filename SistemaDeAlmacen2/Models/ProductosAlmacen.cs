using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlmacen2.Models
{
    class ProductosAlmacen
    {
        public int Id { get; set; }

        public string Producto { get; set; }

        public int Cantidad { get; set; }

        public string Categoria { get; set; }

        public DateTime FechaIngreso { get; set; }

        public double PrecioCompra { get; set; }

        public double PrecioVenta { get; set; }
    }
}
