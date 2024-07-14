using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class Despesas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pagamento",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "Vencimento",
                table: "Despesas");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Despesas",
                newName: "ImpostosId");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Despesas",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Despesas",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Despesas",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AddColumn<int>(
                name: "ColaboradoresId",
                table: "Despesas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContasBancariasId",
                table: "Despesas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPagamento",
                table: "Despesas",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Despesas",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FornecedoresId",
                table: "Despesas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Despesas",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDespesa",
                table: "Despesas",
                type: " decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_ColaboradoresId",
                table: "Despesas",
                column: "ColaboradoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_ContasBancariasId",
                table: "Despesas",
                column: "ContasBancariasId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_FornecedoresId",
                table: "Despesas",
                column: "FornecedoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_ImpostosId",
                table: "Despesas",
                column: "ImpostosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_Colaboradores_ColaboradoresId",
                table: "Despesas",
                column: "ColaboradoresId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_ContasBancarias_ContasBancariasId",
                table: "Despesas",
                column: "ContasBancariasId",
                principalTable: "ContasBancarias",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_Colaboradores_ColaboradoresId",
                table: "Despesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_ContasBancarias_ContasBancariasId",
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
                name: "IX_Despesas_ContasBancariasId",
                table: "Despesas");

            migrationBuilder.DropIndex(
                name: "IX_Despesas_FornecedoresId",
                table: "Despesas");

            migrationBuilder.DropIndex(
                name: "IX_Despesas_ImpostosId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "ColaboradoresId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "ContasBancariasId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "DataPagamento",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "FornecedoresId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "ValorDespesa",
                table: "Despesas");

            migrationBuilder.RenameColumn(
                name: "ImpostosId",
                table: "Despesas",
                newName: "Valor");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Despesas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Despesas",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Despesas",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Pagamento",
                table: "Despesas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Vencimento",
                table: "Despesas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
