using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace learnaspnet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "FilmesPorLancamentoData",
                "filme/lancamento/{ano}/{mes}",
                new {controller = "Filme", action ="PorLancamentoData" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //routes.MapRoute(
            //    name: "Filmes",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Filme", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "Clientes",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Cliente", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
