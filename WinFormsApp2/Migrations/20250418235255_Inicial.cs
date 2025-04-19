using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Situacao = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FuncionarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Situacao = table.Column<string>(type: "TEXT", nullable: false),
                    DataModificacao = table.Column<DateTime>(type: "TEXT", maxLength: 1, nullable: false),
                    FuncionarioId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Funcionarios_FuncionarioId1",
                        column: x => x.FuncionarioId1,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_Cpf",
                table: "Funcionarios",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionarioId",
                table: "Tickets",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionarioId1",
                table: "Tickets",
                column: "FuncionarioId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
