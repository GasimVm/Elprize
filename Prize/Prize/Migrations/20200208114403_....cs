using Microsoft.EntityFrameworkCore.Migrations;

namespace Prize.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GetUserId",
                table: "Transactions",
                newName: "SendUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SendUserId",
                table: "Transactions",
                newName: "GetUserId");
        }
    }
}
