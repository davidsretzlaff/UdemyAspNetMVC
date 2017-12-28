using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learnaspnet.Models
{
    public class TipoMembro
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public short TaxaInscricao { get; set; }
        public byte DuracaoMeses { get; set; }
        public byte TaxaDesconto{ get; set; }
    }
}