using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using learnaspnet.Models;
using learnaspnet.ViewModels;

namespace learnaspnet.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = GetCliente();
            return View(clientes);
        }
        public ActionResult Details(int id)
         {
             var cliente = GetCliente().SingleOrDefault(c => c.IdCliente == id);
 
             if (cliente == null)
                 return HttpNotFound();
 
             return View(cliente);
         }

         public IEnumerable<Cliente> GetCliente()
        {
            return new List<Cliente>
            {
                 new Cliente { IdCliente = 1, Nome = "John Smith" },
                 new Cliente { IdCliente = 2, Nome = "Mary Williams" }
            };

        }


    }
}