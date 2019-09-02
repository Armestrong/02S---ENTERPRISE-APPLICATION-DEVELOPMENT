using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _05_Fiap.Web.AspNet.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ZOO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Jaula = table.Column<int>(nullable: false),
                    DataAbertura = table.Column<DateTime>(name: "Data Abertura", nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Entidadeadministradora = table.Column<int>(name: "Entidade administradora", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ZOO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ZOO");
        }
    }
}
