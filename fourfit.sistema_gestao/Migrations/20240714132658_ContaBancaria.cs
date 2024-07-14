using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class ContaBancaria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_Colaboradores_ColaboradoresId",
                table: "Despesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_Fornecedores_FornecedoresId",
                table: "Despesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_Impostos_ImpostosId",
                table: "Despesas");

            migrationBuilder.DropIndex(
                name: "IX_Despesas_ColaboradoresId",
                table: "Despesas");

            migrationBuilder.DropIndex(
                name: "IX_Despesas_FornecedoresId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "ColaboradoresId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "FornecedoresId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Despesas");

            migrationBuilder.RenameColumn(
                name: "ImpostosId",
                table: "Despesas",
                newName: "TipoDespesasId");

            migrationBuilder.RenameIndex(
                name: "IX_Despesas_ImpostosId",
                table: "Despesas",
                newName: "IX_Despesas_TipoDespesasId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ContasBancarias",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ContasBancarias",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bancos",
                table: "ContasBancarias",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "TipoDespesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpostosId = table.Column<int>(type: "int", nullable: false),
                    ColaboradoresId = table.Column<int>(type: "int", nullable: false),
                    FornecedoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDespesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoDespesas_Colaboradores_ColaboradoresId",
                        column: x => x.ColaboradoresId,
                        principalTable: "Colaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoDespesas_Fornecedores_ColaboradoresId",
                        column: x => x.ColaboradoresId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoDespesas_Impostos_ImpostosId",
                        column: x => x.ImpostosId,
                        principalTable: "Impostos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoDespesas_ColaboradoresId",
                table: "TipoDespesas",
                column: "ColaboradoresId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoDespesas_ImpostosId",
                table: "TipoDespesas",
                column: "ImpostosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_TipoDespesas_TipoDespesasId",
                table: "Despesas",
                column: "TipoDespesasId",
                principalTable: "TipoDespesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_TipoDespesas_TipoDespesasId",
                table: "Despesas");

            migrationBuilder.DropTable(
                name: "TipoDespesas");

            migrationBuilder.RenameColumn(
                name: "TipoDespesasId",
                table: "Despesas",
                newName: "ImpostosId");

            migrationBuilder.RenameIndex(
                name: "IX_Despesas_TipoDespesasId",
                table: "Despesas",
                newName: "IX_Despesas_ImpostosId");

            migrationBuilder.AddColumn<int>(
                name: "ColaboradoresId",
                table: "Despesas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FornecedoresId",
                table: "Despesas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Despesas",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "ContasBancarias",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ContasBancarias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Bancos",
                table: "ContasBancarias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_ColaboradoresId",
                table: "Despesas",
                column: "ColaboradoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_FornecedoresId",
                table: "Despesas",
                column: "FornecedoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_Colaboradores_ColaboradoresId",
                table: "Despesas",
                column: "ColaboradoresId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_Fornecedores_FornecedoresId",
                table: "Despesas",
                column: "FornecedoresId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_Impostos_ImpostosId",
                table: "Despesas",
                column: "ImpostosId",
                principalTable: "Impostos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
