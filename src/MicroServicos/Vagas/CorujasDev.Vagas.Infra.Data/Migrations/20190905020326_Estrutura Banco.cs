using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorujasDev.Vagas.Infra.Data.Migrations
{
    public partial class EstruturaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    Empresa = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Curso = table.Column<string>(nullable: false),
                    Salario = table.Column<decimal>(nullable: true),
                    Ativa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
