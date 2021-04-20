using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWaProject.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [Column(TypeName = "Text")]
        public string Descricao { get; set; }
        [MaxLength(7)]
        public string PlacaVeiculo { get; set; }
    }
}
