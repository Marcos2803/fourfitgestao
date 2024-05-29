using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class DbCorreco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Colaboradores",
                newName: "Observacaes");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Colaboradores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Colaboradores",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Colaboradores");

            migrationBuilder.RenameColumn(
                name: "Observacaes",
                table: "Colaboradores",
                newName: "Celular");
        }
    }
}
