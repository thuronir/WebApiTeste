using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWaProject.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DataCriacao { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DataEntrega { get; set; }
        [Column(TypeName = "Text")]
        public string Endereco { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }       
    }
}
