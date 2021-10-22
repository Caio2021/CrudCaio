using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCaio.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }
    }
}
