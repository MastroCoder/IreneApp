using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace APITESTE.Models
{
    [Table("VendasAnteriores")]
    public class VendasAnteriores : BaseModel
    {
        [ExplicitKey]
        public int Id { get; set; }
        public int IdSacola { get; set; }
        public string MesDeEntrega { get; set; }
        public float Valor { get; set; }
    }
}
