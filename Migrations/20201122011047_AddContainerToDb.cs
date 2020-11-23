using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudT2S.Migrations
{
    public partial class AddContainerToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(nullable: false),
                    NumeroContainer = table.Column<string>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Categoria = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Container");
        }
    }
}
