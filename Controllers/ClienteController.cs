using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using learnaspnet.Models;
using learnaspnet.ViewModels;

namespace learnaspnet.Controllers
{
    public class ClienteController : Controller
    {
        private ApplicationDbContext _context;

        public ClienteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = _context.Clientes.Include(x => x.TipoMembro).ToList();
            return View(clientes);
        }
        public ActionResult Details(int id)
         {
             var cliente = _context.Clientes.Include(x => x.TipoMembro).SingleOrDefault(c => c.IdCliente == id);
 
             if (cliente == null)
                 return HttpNotFound();
 
             return View(cliente);
         }


    }
}