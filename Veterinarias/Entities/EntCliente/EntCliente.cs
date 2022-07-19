using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EntCliente
{
    public class EntCliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public int Sexo { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public string Telefono { get; set; }
        public string  Correo { get; set; }

    }
}
