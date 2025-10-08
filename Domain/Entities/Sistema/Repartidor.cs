using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Ventas;

namespace Domain.Entities.Sistema
{
    public class Repartidor : Usuario
    {
        public List<Venta> entregables { get; set; }
    }
}
