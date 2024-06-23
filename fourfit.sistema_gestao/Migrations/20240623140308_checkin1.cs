using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class checkin1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkin_Alunos_AlunosId1",
                table: "Checkin");

            migrationBuilder.DropIndex(
                name: "IX_Checkin_AlunosId1",
                table: "Checkin");

            migrationBuilder.DropColumn(
                name: "AlunosId",
                table: "Checkin");

            migrationBuilder.DropColumn(
                name: "AlunosId1",
                table: "Checkin");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Checkin",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_UserId",
                table: "Checkin",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkin_AspNetUsers_UserId",
                table: "Checkin",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkin_AspNetUsers_UserId",
                table: "Checkin");

            migrationBuilder.DropIndex(
                name: "IX_Checkin_UserId",
                table: "Checkin");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Checkin");

            migrationBuilder.AddColumn<string>(
                name: "AlunosId",
                table: "Checkin",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
