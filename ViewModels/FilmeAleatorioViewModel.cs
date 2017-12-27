using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using learnaspnet.Models;

namespace learnaspnet.ViewModels
{
    public class FilmeAleatorioViewModel
    {
        public List<Filme> Filme { get; set; }
        public List<Cliente> Cliente{ get; set; }
    }
}