using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class correcaoprodutao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ControleEstoque_EstoqueId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EstoqueId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EstoqueMinimo",
                table: "ControleEstoque");

            migrationBuilder.DropColumn(
                name: "QuantidadeEstoque",
                table: "ControleEstoque");

            migrationBuilder.RenameColumn(
                name: "EstoqueId",
                table: "Produtos",
                newName: "QuantidadeEstoque");

            migrationBuilder.AddColumn<int>(
                name: "EstoqueMinimo",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstoqueMinimo",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "QuantidadeEstoque",
                table: "Produtos",
                newName: "EstoqueId");

            migrationBuilder.AddColumn<int>(
                name: "EstoqueMinimo",
                table: "ControleEstoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeEstoque",
                table: "ControleEstoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EstoqueId",
                table: "Produtos",
                column: "EstoqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ControleEstoque_EstoqueId",
                table: "Produtos",
                column: "EstoqueId",
                principalTable: "ControleEstoque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
