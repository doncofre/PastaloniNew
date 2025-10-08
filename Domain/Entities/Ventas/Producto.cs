using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Ventas
{
    public class Producto
    {
        public int id {  get; set; }
        public string proveedor { get; set; }
        public string descripcion { get; set; }
    }
}
