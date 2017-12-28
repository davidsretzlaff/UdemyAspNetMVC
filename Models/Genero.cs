using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace learnaspnet.Models
{
    public class Genero
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}