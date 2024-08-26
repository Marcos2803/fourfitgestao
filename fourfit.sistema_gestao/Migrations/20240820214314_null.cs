using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class @null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_ContasBancarias_ContasBancariasId",
                table: "Pagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_FormaPagamento_FormaPagamentoId",
                table: "Pagamentos");

            migrationBuilder.AlterColumn<int>(
                name: "FormaPagamentoId",
                table: "Pagamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContasBancariasId",
                table: "Pagamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_ContasBancarias_ContasBancariasId",
                table: "Pagamentos",
                column: "ContasBancariasId",
                principalTable: "ContasBancarias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_FormaPagamento_FormaPagamentoId",
                table: "Pagamentos",
                column: "FormaPagamentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_ContasBancarias_ContasBancariasId",
                table: "Pagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_FormaPagamento_FormaPagamentoId",
                table: "Pagamentos");

            migrationBuilder.AlterColumn<int>(
                name: "FormaPagamentoId",
                table: "Pagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContasBancariasId",
                table: "Pagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_ContasBancarias_ContasBancariasId",
                table: "Pagamentos",
                column: "ContasBancariasId",
                principalTable: "ContasBancarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_FormaPagamento_FormaPagamentoId",
                table: "Pagamentos",
                column: "FormaPagamentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
