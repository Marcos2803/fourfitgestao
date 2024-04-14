using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fourfit.sistema_gestao.Migrations
{
    /// <inheritdoc />
    public partial class ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPagamentos_TipoPagamentoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoPagamentos_TipoPagamentoPc_TipoPagamentoPcId",
                table: "TipoPagamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPagamentos",
                table: "TipoPagamentos");

            migrationBuilder.DropColumn(
                name: "IdTipoPagamentoPc",
                table: "TipoPagamentos");

            migrationBuilder.RenameTable(
                name: "TipoPagamentos",
                newName: "TipoPagamento");

            migrationBuilder.RenameIndex(
                name: "IX_TipoPagamentos_TipoPagamentoPcId",
                table: "TipoPagamento",
                newName: "IX_TipoPagamento_TipoPagamentoPcId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompleto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddColumn<int>(
                name: "TipoPagamentoId1",
                table: "Alunos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPlanoId1",
                table: "Alunos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Alunos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPagamento",
                table: "TipoPagamento",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AlunosPesquisa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DescTipoPlano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosPesquisa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoPagamentoId1",
                table: "Alunos",
                column: "TipoPagamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoPlanoId1",
                table: "Alunos",
                column: "TipoPlanoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_UserId1",
                table: "Alunos",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_AspNetUsers_UserId1",
                table: "Alunos",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPagamento_TipoPagamentoId",
                table: "Alunos",
                column: "TipoPagamentoId",
                principalTable: "TipoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPagamento_TipoPagamentoId1",
                table: "Alunos",
                column: "TipoPagamentoId1",
                principalTable: "TipoPagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPlano_TipoPlanoId1",
                table: "Alunos",
                column: "TipoPlanoId1",
                principalTable: "TipoPlano",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoPagamento_TipoPagamentoPc_TipoPagamentoPcId",
                table: "TipoPagamento",
                column: "TipoPagamentoPcId",
                principalTable: "TipoPagamentoPc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_AspNetUsers_UserId1",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPagamento_TipoPagamentoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPagamento_TipoPagamentoId1",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoPlano_TipoPlanoId1",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoPagamento_TipoPagamentoPc_TipoPagamentoPcId",
                table: "TipoPagamento");

            migrationBuilder.DropTable(
                name: "AlunosPesquisa");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoPagamentoId1",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoPlanoId1",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_UserId1",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPagamento",
                table: "TipoPagamento");

            migrationBuilder.DropColumn(
                name: "TipoPagamentoId1",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TipoPlanoId1",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "TipoPagamento",
                newName: "TipoPagamentos");

            migrationBuilder.RenameIndex(
                name: "IX_TipoPagamento_TipoPagamentoPcId",
                table: "TipoPagamentos",
                newName: "IX_TipoPagamentos_TipoPagamentoPcId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompleto",
                table: "AspNetUsers",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "AspNetUsers",
                type: "varchar(2)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "AspNetUsers",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "AspNetUsers",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "AspNetUsers",
                type: "varchar(16)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "AspNetUsers",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoPagamentoPc",
                table: "TipoPagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPagamentos",
                table: "TipoPagamentos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoPagamentos_TipoPagamentoId",
                table: "Alunos",
                column: "TipoPagamentoId",
                principalTable: "TipoPagamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoPagamentos_TipoPagamentoPc_TipoPagamentoPcId",
                table: "TipoPagamentos",
                column: "TipoPagamentoPcId",
                principalTable: "TipoPagamentoPc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
