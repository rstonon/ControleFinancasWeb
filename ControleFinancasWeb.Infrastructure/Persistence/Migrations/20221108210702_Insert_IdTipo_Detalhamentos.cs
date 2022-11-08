using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleFinancasWeb.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InsertIdTipoDetalhamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Detalhamentos_IdDetalhamento",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Tipos_IdTipo",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoDetalhamentos_Tipos_TipoId",
                table: "TipoDetalhamentos");

            migrationBuilder.DropIndex(
                name: "IX_TipoDetalhamentos_TipoId",
                table: "TipoDetalhamentos");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "TipoDetalhamentos");

            migrationBuilder.AddColumn<int>(
                name: "IdTipo",
                table: "Detalhamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Detalhamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Detalhamentos_IdTipo",
                table: "Detalhamentos",
                column: "IdTipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Detalhamentos_IdDetalhamento",
                table: "Contas",
                column: "IdDetalhamento",
                principalTable: "Detalhamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Tipos_IdTipo",
                table: "Contas",
                column: "IdTipo",
                principalTable: "Tipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalhamentos_Tipos_IdTipo",
                table: "Detalhamentos",
                column: "IdTipo",
                principalTable: "Tipos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Detalhamentos_IdDetalhamento",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Tipos_IdTipo",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalhamentos_Tipos_IdTipo",
                table: "Detalhamentos");

            migrationBuilder.DropIndex(
                name: "IX_Detalhamentos_IdTipo",
                table: "Detalhamentos");

            migrationBuilder.DropColumn(
                name: "IdTipo",
                table: "Detalhamentos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Detalhamentos");

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "TipoDetalhamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoDetalhamentos_TipoId",
                table: "TipoDetalhamentos",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Detalhamentos_IdDetalhamento",
                table: "Contas",
                column: "IdDetalhamento",
                principalTable: "Detalhamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Tipos_IdTipo",
                table: "Contas",
                column: "IdTipo",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoDetalhamentos_Tipos_TipoId",
                table: "TipoDetalhamentos",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id");
        }
    }
}
