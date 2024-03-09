using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class NovasTableasTipoPlano : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPagamentoPc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamentoPc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPlano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescTipoPlano = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPlano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoPagamentoPc = table.Column<int>(type: "int", nullable: false),
                    TipoPagamentoPcId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoPagamentos_TipoPagamentoPc_TipoPagamentoPcId",
                        column: x => x.TipoPagamentoPcId,
                        principalTable: "TipoPagamentoPc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoPagamentoId",
                table: "Alunos",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoPlanoId",
                table: "Alunos",
                column: "TipoPlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPagamentos_TipoPagamentoPcId",
                table: "TipoPagamentos",
                column: "TipoPagamentoPcId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPagamentos_TipoPagamentoId",
                table: "Alunos",
                column: "TipoPagamentoId",
                principalTable: "TipoPagamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPlano_TipoPlanoId",
                table: "Alunos",
                column: "TipoPlanoId",
                principalTable: "TipoPlano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPagamentos_TipoPagamentoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPlano_TipoPlanoId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "TipoPagamentos");

            migrationBuilder.DropTable(
                name: "TipoPlano");

            migrationBuilder.DropTable(
                name: "TipoPagamentoPc");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoPagamentoId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoPlanoId",
                table: "Alunos");
        }
    }
}
