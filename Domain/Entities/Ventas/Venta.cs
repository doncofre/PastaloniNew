using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Ventas
{
    public class Venta
    {
        public List<ProductoVendido> productosVendidos {  get; set; }
        public MetodoPago metodoPago { get; set; }
        public int estadoVenta { get; set; } // enum
        public int id { get; set; }
        public int idVendedor { get; set; }
        public int idCliente { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }

    }
}
