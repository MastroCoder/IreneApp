using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITESTE.Models
{
    [Table("ProdutoAtual")]
    public class ProdutoAtual : BaseModel
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Referencia { get; set; }
        public string Tamanho  { get; set; }
        public float Valor { get; set; }
        public int IdVendedora { get; set; }
        public int Quantidade { get; set; }
    }
}
