using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class Alunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPlano_TipoPlanoId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoPlanoId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TipoPlanoId",
                table: "Alunos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPlanoId",
                table: "Alunos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoPlanoId",
                table: "Alunos",
                column: "TipoPlanoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPlano_TipoPlanoId",
                table: "Alunos",
                column: "TipoPlanoId",
                principalTable: "TipoPlano",
                principalColumn: "Id");
        }
    }
}
