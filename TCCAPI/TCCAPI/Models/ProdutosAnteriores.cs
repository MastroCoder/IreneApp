using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace APITESTE.Models
{
    [Table("ProdutosAnteriores")]
    public class ProdutosAnteriores : BaseModel
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Referencia { get; set; }
        public string Tamanho { get; set; }
        public float Valor { get; set; }
        public int IdSacola { get; set; }
        public int Quantidade { get; set; }
    }
}
