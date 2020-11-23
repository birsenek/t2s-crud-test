using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudT2S.Migrations
{
    public partial class AddNavioToMovimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Navio",
                table: "Movimentacao",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Navio",
                table: "Movimentacao");
        }
    }
}
