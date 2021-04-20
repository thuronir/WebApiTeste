using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWaProject.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string Nome { get; set; }
        [Column(TypeName = "Text")]
        public string Descricao { get; set; }
        [Column(TypeName = "Decimal(10,2)")]
        public decimal Valor { get; set; }
    }
}
