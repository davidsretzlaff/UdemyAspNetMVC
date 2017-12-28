using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace learnaspnet.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public DateTime DataLancamento { get; set; }
        public DateTime DataAdicionada { get; set; }
        public byte NumeroEstoque { get; set; }

        [Required]
        public Genero Genero { get; set; }
        public byte GeneroId { get; set; }
    }
}