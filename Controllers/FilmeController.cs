using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using learnaspnet.Models;
using learnaspnet.ViewModels;

namespace learnaspnet.Controllers
{
    public class FilmeController : Controller
    {
        // GET: Filme
        public ViewResult Index()
        {
            var filmes = GetFilmes();
            return View(filmes);
        }
        public ActionResult Details(int id)
        {
            var filme = GetFilmes().SingleOrDefault(c => c.IdFilme == id);

            if (filme == null)
                return HttpNotFound();

            return View(filme);
        }

        public IEnumerable<Filme> GetFilmes()
        {
            return new List<Filme>
            {
                 new Filme { IdFilme = 1, Nome = "Extraordinario" },
                 new Filme { IdFilme = 2, Nome = "Rock Marlboro" }
            };

        }
    }
}