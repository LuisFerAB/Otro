using Bussines.BusCliente;
using Entities.EntCliente;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            List<EntCliente> lstClientes = new BusCliente().ObtenerClientes();
            return View(lstClientes);
        }
    }
}
