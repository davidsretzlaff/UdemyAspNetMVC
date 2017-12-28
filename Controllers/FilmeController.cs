using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using learnaspnet.Models;
using learnaspnet.ViewModels;
using System.Data.Entity;

namespace learnaspnet.Controllers
{
    public class FilmeController : Controller
    {
        private ApplicationDbContext _context;

        public FilmeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Filme
        public ViewResult Index()
        {
            var filmes = _context.Filme.Include(x => x.Genero).ToList();
            return View(filmes);
        }
        public ActionResult Details(int id)
        {
            var filme = _context.Filme.Include(x => x.Genero).SingleOrDefault(c => c.Id == id);

            if (filme == null)
                return HttpNotFound();

            return View(filme);
        }


    }
}