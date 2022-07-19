using Data.DatClientes;
using Entities.EntCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.BusCliente
{
    public class BusCliente
    {
        public List<EntCliente> ObtenerClientes() {
            return new DatCliente().ListaClientes();
        }
    }
}
