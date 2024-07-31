using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class vendaitens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Produtos_ProdutosId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ProdutosId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutosId",
                table: "Vendas");

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(7)");

            migrationBuilder.CreateTable(
                name: "VendaItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutosId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaItens_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendaItensVendas",
                columns: table => new
                {
                    VendaItensId = table.Column<int>(type: "int", nullable: false),
                    VendasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaItensVendas", x => new { x.VendaItensId, x.VendasId });
                    table.ForeignKey(
                        name: "FK_VendaItensVendas_VendaItens_VendaItensId",
                        column: x => x.VendaItensId,
                        principalTable: "VendaItens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaItensVendas_Vendas_VendasId",
                        column: x => x.VendasId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaItens_ProdutosId",
                table: "VendaItens",
                column: "ProdutosId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaItensVendas_VendasId",
                table: "VendaItensVendas",
                column: "VendasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaItensVendas");

            migrationBuilder.DropTable(
                name: "VendaItens");

            migrationBuilder.AddColumn<int>(
                name: "ProdutosId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Alunos",
                type: "varchar(7)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutosId",
                table: "Vendas",
                column: "ProdutosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Produtos_ProdutosId",
                table: "Vendas",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
