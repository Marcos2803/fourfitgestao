using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class Estoque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ControleEstoque_ControleEstoqueId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produtos",
                newName: "NomeProduto");

            migrationBuilder.RenameColumn(
                name: "ControleEstoqueId",
                table: "Produtos",
                newName: "EstoqueId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_ControleEstoqueId",
                table: "Produtos",
                newName: "IX_Produtos_EstoqueId");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Categorias",
                newName: "NomeCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ControleEstoque_EstoqueId",
                table: "Produtos",
                column: "EstoqueId",
                principalTable: "ControleEstoque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ControleEstoque_EstoqueId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "NomeProduto",
                table: "Produtos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "EstoqueId",
                table: "Produtos",
                newName: "ControleEstoqueId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_EstoqueId",
                table: "Produtos",
                newName: "IX_Produtos_ControleEstoqueId");

            migrationBuilder.RenameColumn(
                name: "NomeCategoria",
                table: "Categorias",
                newName: "Nome");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ControleEstoque_ControleEstoqueId",
                table: "Produtos",
                column: "ControleEstoqueId",
                principalTable: "ControleEstoque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
