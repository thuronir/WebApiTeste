using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWaProject.Models;

namespace WebApiWaProject.Data
{
    public class WaApiContext : DbContext
    {
        public WaApiContext(DbContextOptions<WaApiContext> options) : base (options)
        {

        }

        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoPedido> ProdutoPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipe>()
                .HasData(
                    new Equipe { Id = 1, Nome = "White", Descricao = "Essa é a equipe White", PlacaVeiculo = "AAA1A23" },
                    new Equipe { Id = 2, Nome = "Red", Descricao = "Essa é a equipe Red", PlacaVeiculo = "BBB1B23" },
                    new Equipe { Id = 3, Nome = "Black", Descricao = "Essa é a equipe Black", PlacaVeiculo = "CCC1C23" },
                    new Equipe { Id = 4, Nome = "Blue", Descricao = "Essa é a equipe Blue", PlacaVeiculo = "DDD1D23" }
                );

            modelBuilder.Entity<Pedido>()
                .HasData(
                    new Pedido {Id = 1, DataCriacao = Convert.ToDateTime("19/04/2021"), DataEntrega = Convert.ToDateTime("25/04/2021"), Endereco = "JOHN SMITH 300 BOYLSTON AVE E SEATTLE WA 98102 USA", EquipeId = 1 },
                    new Pedido { Id = 2, DataCriacao = Convert.ToDateTime("20/04/2021"), DataEntrega = Convert.ToDateTime("26/04/2021"), Endereco = "JANE ROE 200 E MAIN ST PHOENIX AZ 85123 USA", EquipeId = 2 },
                    new Pedido { Id = 3, DataCriacao = Convert.ToDateTime("21/04/2021"), DataEntrega = Convert.ToDateTime("27/04/2021"), Endereco = "MARY ROE MEGASYSTEMS INC 799 E DRAGRAM SUITE 5ATUCSON AZ 85705 USA", EquipeId = 3 },
                    new Pedido { Id = 4, DataCriacao = Convert.ToDateTime("22/04/2021"), DataEntrega = Convert.ToDateTime("28/04/2021"), Endereco = "CHRIS NISWANDEE SMALLSYS INC 795 E DRAGRAM TUCSON AZ 85705 USA", EquipeId = 4 }
                );
            modelBuilder.Entity<Produto>()
               .HasData(
                   new Produto { Id = 1, Nome = "Flanelas", Descricao = "Flanelas", Valor = 2.55M },
                   new Produto { Id = 2, Nome = "Farinha", Descricao = "Farinha", Valor = 8.15M },
                   new Produto { Id = 3, Nome = "Óleo", Descricao = "Óleo", Valor = 3.50M },
                   new Produto { Id = 4, Nome = "Inseticida", Descricao = "Inseticida", Valor = 10.00M },
                   new Produto { Id = 5, Nome = "Algodão", Descricao = "Algodão", Valor = 6.75M },
                   new Produto { Id = 6, Nome = "Papel Alumínio", Descricao = "Papel Alumínio", Valor = 9.25M }
               );
            modelBuilder.Entity<ProdutoPedido>()
               .HasData(
                   new ProdutoPedido { Id = 1, PedidoId = 1, ProdutoId = 1, Quantidade = 5, Valor = 12.75M },
                   new ProdutoPedido { Id = 2, PedidoId = 1, ProdutoId = 2, Quantidade = 2, Valor = 16.30M },
                   new ProdutoPedido { Id = 3, PedidoId = 1, ProdutoId = 3, Quantidade = 4, Valor = 14.00M },
                   new ProdutoPedido { Id = 4, PedidoId = 1, ProdutoId = 4, Quantidade = 7, Valor = 70.00M },
                   new ProdutoPedido { Id = 5, PedidoId = 1, ProdutoId = 5, Quantidade = 3, Valor = 20.25M },
                   new ProdutoPedido { Id = 6, PedidoId = 1, ProdutoId = 6, Quantidade = 1, Valor = 9.25M },
                   new ProdutoPedido { Id = 7, PedidoId = 2, ProdutoId = 1, Quantidade = 5, Valor = 12.75M },
                   new ProdutoPedido { Id = 8, PedidoId = 2, ProdutoId = 2, Quantidade = 2, Valor = 16.30M },
                   new ProdutoPedido { Id = 9, PedidoId = 2, ProdutoId = 3, Quantidade = 4, Valor = 14.00M },
                   new ProdutoPedido { Id = 10, PedidoId = 2, ProdutoId = 4, Quantidade = 7, Valor = 70.00M },
                   new ProdutoPedido { Id = 11, PedidoId = 2, ProdutoId = 5, Quantidade = 3, Valor = 20.25M },
                   new ProdutoPedido { Id = 12, PedidoId = 2, ProdutoId = 6, Quantidade = 1, Valor = 9.25M },
                   new ProdutoPedido { Id = 13, PedidoId = 3, ProdutoId = 1, Quantidade = 5, Valor = 12.75M },
                   new ProdutoPedido { Id = 14, PedidoId = 3, ProdutoId = 2, Quantidade = 2, Valor = 16.30M },
                   new ProdutoPedido { Id = 15, PedidoId = 3, ProdutoId = 3, Quantidade = 4, Valor = 14.00M },
                   new ProdutoPedido { Id = 16, PedidoId = 3, ProdutoId = 4, Quantidade = 7, Valor = 70.00M },
                   new ProdutoPedido { Id = 17, PedidoId = 3, ProdutoId = 5, Quantidade = 3, Valor = 20.25M },
                   new ProdutoPedido { Id = 18, PedidoId = 3, ProdutoId = 6, Quantidade = 1, Valor = 9.25M },
                   new ProdutoPedido { Id = 19, PedidoId = 4, ProdutoId = 1, Quantidade = 5, Valor = 12.75M },
                   new ProdutoPedido { Id = 20, PedidoId = 4, ProdutoId = 2, Quantidade = 2, Valor = 16.30M },
                   new ProdutoPedido { Id = 21, PedidoId = 4, ProdutoId = 3, Quantidade = 4, Valor = 14.00M },
                   new ProdutoPedido { Id = 22, PedidoId = 4, ProdutoId = 4, Quantidade = 7, Valor = 70.00M },
                   new ProdutoPedido { Id = 23, PedidoId = 4, ProdutoId = 5, Quantidade = 3, Valor = 20.25M },
                   new ProdutoPedido { Id = 24, PedidoId = 4, ProdutoId = 6, Quantidade = 1, Valor = 9.25M }
               );
        }

    }
}
