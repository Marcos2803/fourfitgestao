using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class vendas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPagamentoPcId = table.Column<int>(type: "int", nullable: false),
                    ContasBancariasId = table.Column<int>(type: "int", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: false),
                    ValorVenda = table.Column<decimal>(type: " decimal(18,2)", nullable: false),
                    Desconto = table.Column<decimal>(type: " decimal(18,2)", nullable: false),
                    ValorPago = table.Column<decimal>(type: " decimal(18,2)", nullable: false),
                    Troco = table.Column<decimal>(type: " decimal(18,2)", nullable: false),
                    StatusPagamentos = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_ContasBancarias_ContasBancariasId",
                        column: x => x.ContasBancariasId,
                        principalTable: "ContasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamentos_TipoPagamentoPc_TipoPagamentoPcId",
                        column: x => x.TipoPagamentoPcId,
                        principalTable: "TipoPagamentoPc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProdutosId = table.Column<int>(type: "int", nullable: false),
                    PagamentosId = table.Column<int>(type: "int", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "date", nullable: false),
                    StatusPagamentos = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Pagamentos_PagamentosId",
                        column: x => x.PagamentosId,
                        principalTable: "Pagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_ContasBancariasId",
                table: "Pagamentos",
                column: "ContasBancariasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_TipoPagamentoPcId",
                table: "Pagamentos",
                column: "TipoPagamentoPcId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_PagamentosId",
                table: "Vendas",
                column: "PagamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutosId",
                table: "Vendas",
                column: "ProdutosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_UserId",
                table: "Vendas",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Pagamentos");
        }
    }
}
