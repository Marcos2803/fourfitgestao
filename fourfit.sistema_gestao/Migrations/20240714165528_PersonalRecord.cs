using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class PersonalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pagamento",
                table: "Investimentos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Investimentos");

            migrationBuilder.DropColumn(
                name: "Vencimento",
                table: "Investimentos");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Investimentos",
                newName: "ContasBancariasId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Investimentos",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Investimentos",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Investimentos",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPagamento",
                table: "Investimentos",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Investimentos",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "ValorInvestido",
                table: "Investimentos",
                type: " decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "IdadeCorporal",
                table: "AvaliacaoFisica",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoId = table.Column<int>(type: "int", nullable: false),
                    ProblemaCardiaco = table.Column<bool>(type: "bit", nullable: false),
                    DorNoPeitoAoSeExercitar = table.Column<bool>(type: "bit", nullable: false),
                    DesmaiaOuSenteTontura = table.Column<bool>(type: "bit", nullable: false),
                    ProblemaOssosOuArticulacoes = table.Column<bool>(type: "bit", nullable: false),
                    TomaMedicamentosPressaoCardiaco = table.Column<bool>(type: "bit", nullable: false),
                    MotivoFisicoOuDeSaude = table.Column<bool>(type: "bit", nullable: false),
                    DataPreenchimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parq", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parq_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunosId = table.Column<int>(type: "int", nullable: false),
                    ExerciciosId = table.Column<int>(type: "int", nullable: false),
                    PesoPR = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DataPR = table.Column<DateTime>(type: "date", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalRecord_Alunos_AlunosId",
                        column: x => x.AlunosId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalRecord_Exercicios_ExerciciosId",
                        column: x => x.ExerciciosId,
                        principalTable: "Exercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investimentos_ContasBancariasId",
                table: "Investimentos",
                column: "ContasBancariasId");

            migrationBuilder.CreateIndex(
                name: "IX_Parq_AlunoId",
                table: "Parq",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalRecord_AlunosId",
                table: "PersonalRecord",
                column: "AlunosId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalRecord_ExerciciosId",
                table: "PersonalRecord",
                column: "ExerciciosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investimentos_ContasBancarias_ContasBancariasId",
                table: "Investimentos",
                column: "ContasBancariasId",
                principalTable: "ContasBancarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investimentos_ContasBancarias_ContasBancariasId",
                table: "Investimentos");

            migrationBuilder.DropTable(
                name: "Parq");

            migrationBuilder.DropTable(
                name: "PersonalRecord");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropIndex(
                name: "IX_Investimentos_ContasBancariasId",
                table: "Investimentos");

            migrationBuilder.DropColumn(
                name: "DataPagamento",
                table: "Investimentos");

            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "Investimentos");

            migrationBuilder.DropColumn(
                name: "ValorInvestido",
                table: "Investimentos");

            migrationBuilder.RenameColumn(
                name: "ContasBancariasId",
                table: "Investimentos",
                newName: "Valor");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Investimentos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Investimentos",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Investimentos",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Pagamento",
                table: "Investimentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Investimentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Vencimento",
                table: "Investimentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<decimal>(
                name: "IdadeCorporal",
                table: "AvaliacaoFisica",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
