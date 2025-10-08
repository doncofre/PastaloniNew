using Domain.Entities.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Ventas
{
    public class Zona
    {
        public int id { get; set; }
        public string nombreZona { get; set; }
        public List<Cliente> clientes { get; set; }
    }
}
