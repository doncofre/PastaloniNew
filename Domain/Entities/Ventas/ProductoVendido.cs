using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Ventas
{
    public class ProductoVendido
    {
        public int idVenta { get; set; }
        public Producto producto { get; set; }
        public string descripcion { get; set; }
        public decimal costoProducto { get; set; }
        public decimal precioProducto { get; set; }


    }
}
