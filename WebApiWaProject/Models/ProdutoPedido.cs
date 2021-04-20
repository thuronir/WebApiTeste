using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWaProject.Models
{
    public class ProdutoPedido
    {
        public int Id {get; set;}
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }       
        public int Quantidade { get; set; }
        [Column(TypeName = "Decimal(10,2)")]
        public decimal Valor { get; set; }
    }
}
