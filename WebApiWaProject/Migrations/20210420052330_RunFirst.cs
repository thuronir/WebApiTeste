using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiWaProject.Migrations
{
    public partial class RunFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Descricao = table.Column<string>(type: "Text", nullable: true),
                    PlacaVeiculo = table.Column<string>(type: "varchar(7) CHARACTER SET utf8mb4", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    Descricao = table.Column<string>(type: "Text", nullable: true),
                    Valor = table.Column<decimal>(type: "Decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false),
                    DataEntrega = table.Column<DateTime>(type: "Date", nullable: false),
                    Endereco = table.Column<string>(type: "Text", nullable: true),
                    EquipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Equipes_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "Decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoPedidos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Equipes",
                columns: new[] { "Id", "Descricao", "Nome", "PlacaVeiculo" },
                values: new object[,]
                {
                    { 1, "Essa é a equipe White", "White", "AAA1A23" },
                    { 2, "Essa é a equipe Red", "Red", "BBB1B23" },
                    { 3, "Essa é a equipe Black", "Black", "CCC1C23" },
                    { 4, "Essa é a equipe Blue", "Blue", "DDD1D23" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "Valor" },
                values: new object[,]
                {
                    { 1, "Flanelas", "Flanelas", 2.55m },
                    { 2, "Farinha", "Farinha", 8.15m },
                    { 3, "Óleo", "Óleo", 3.50m },
                    { 4, "Inseticida", "Inseticida", 10.00m },
                    { 5, "Algodão", "Algodão", 6.75m },
                    { 6, "Papel Alumínio", "Papel Alumínio", 9.25m }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "Id", "DataCriacao", "DataEntrega", "Endereco", "EquipeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "JOHN SMITH 300 BOYLSTON AVE E SEATTLE WA 98102 USA", 1 },
                    { 2, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "JANE ROE 200 E MAIN ST PHOENIX AZ 85123 USA", 2 },
                    { 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "MARY ROE MEGASYSTEMS INC 799 E DRAGRAM SUITE 5ATUCSON AZ 85705 USA", 3 },
                    { 4, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CHRIS NISWANDEE SMALLSYS INC 795 E DRAGRAM TUCSON AZ 85705 USA", 4 }
                });

            migrationBuilder.InsertData(
                table: "ProdutoPedidos",
                columns: new[] { "Id", "PedidoId", "ProdutoId", "Quantidade", "Valor" },
                values: new object[,]
                {
                    { 1, 1, 1, 5, 12.75m },
                    { 22, 4, 4, 7, 70.00m },
                    { 21, 4, 3, 4, 14.00m },
                    { 20, 4, 2, 2, 16.30m },
                    { 19, 4, 1, 5, 12.75m },
                    { 18, 3, 6, 1, 9.25m },
                    { 17, 3, 5, 3, 20.25m },
                    { 16, 3, 4, 7, 70.00m },
                    { 15, 3, 3, 4, 14.00m },
                    { 14, 3, 2, 2, 16.30m },
                    { 13, 3, 1, 5, 12.75m },
                    { 12, 2, 6, 1, 9.25m },
                    { 11, 2, 5, 3, 20.25m },
                    { 10, 2, 4, 7, 70.00m },
                    { 9, 2, 3, 4, 14.00m },
                    { 8, 2, 2, 2, 16.30m },
                    { 7, 2, 1, 5, 12.75m },
                    { 6, 1, 6, 1, 9.25m },
                    { 5, 1, 5, 3, 20.25m },
                    { 4, 1, 4, 7, 70.00m },
                    { 3, 1, 3, 4, 14.00m },
                    { 2, 1, 2, 2, 16.30m },
                    { 23, 4, 5, 3, 20.25m },
                    { 24, 4, 6, 1, 9.25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EquipeId",
                table: "Pedidos",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedidos_PedidoId",
                table: "ProdutoPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedidos_ProdutoId",
                table: "ProdutoPedidos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoPedidos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Equipes");
        }
    }
}
