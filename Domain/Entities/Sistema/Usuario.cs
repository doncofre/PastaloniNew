using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Sistema
{
    public class Usuario
    {
        public List<Rol> roles { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public string contraseña { get; set; }
        public string domicilio { get; set; }

    }
}
