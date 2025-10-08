using Domain.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Sistema
{
    public class Vendedor : Usuario
    {
        public List<Zona> zonas { get; set; }
    }
}
