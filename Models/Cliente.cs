using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace learnaspnet.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        [StringLength(8)]
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public bool Inscrito { get; set; }
        public TipoMembro TipoMembro { get; set; }
        public byte TipoMembroId { get; set; }
    }
}