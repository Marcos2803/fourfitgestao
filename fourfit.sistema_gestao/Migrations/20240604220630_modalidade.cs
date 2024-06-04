using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class modalidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkin_Alunos_AlunosId",
                table: "Checkin");

            migrationBuilder.DropIndex(
                name: "IX_Checkin_AlunosId",
                table: "Checkin");

            migrationBuilder.AlterColumn<string>(
                name: "AlunosId",
                table: "Checkin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AlunosId1",
                table: "Checkin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_AlunosId1",
                table: "Checkin",
                column: "AlunosId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkin_Alunos_AlunosId1",
                table: "Checkin",
                column: "AlunosId1",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkin_Alunos_AlunosId1",
                table: "Checkin");

            migrationBuilder.DropIndex(
                name: "IX_Checkin_AlunosId1",
                table: "Checkin");

            migrationBuilder.DropColumn(
                name: "AlunosId1",
                table: "Checkin");

            migrationBuilder.AlterColumn<int>(
                name: "AlunosId",
                table: "Checkin",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_AlunosId",
                table: "Checkin",
                column: "AlunosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkin_Alunos_AlunosId",
                table: "Checkin",
                column: "AlunosId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
