using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIListaDeTarefas.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDataCriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dataCriacao",
                table: "Tarefa",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataCriacao",
                table: "Tarefa");
        }
    }
}
