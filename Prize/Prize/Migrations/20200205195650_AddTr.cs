using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prize.Migrations
{
    public partial class AddTr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_StatusTrans_StatusTransId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Users_UserId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Balans_BalansId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Balans");

            migrationBuilder.DropIndex(
                name: "IX_Users_BalansId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "BalansId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_UserId",
                table: "Transactions",
                newName: "IX_Transactions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_StatusTransId",
                table: "Transactions",
                newName: "IX_Transactions_StatusTransId");

            migrationBuilder.AddColumn<double>(
                name: "Cash",
                table: "Users",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_StatusTrans_StatusTransId",
                table: "Transactions",
                column: "StatusTransId",
                principalTable: "StatusTrans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_StatusTrans_StatusTransId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Cash",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_UserId",
                table: "Transaction",
                newName: "IX_Transaction_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_StatusTransId",
                table: "Transaction",
                newName: "IX_Transaction_StatusTransId");

            migrationBuilder.AddColumn<int>(
                name: "BalansId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Balans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<double>(maxLength: 100, nullable: false),
                    Valuta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balans", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BalansId",
                table: "Users",
                column: "BalansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_StatusTrans_StatusTransId",
                table: "Transaction",
                column: "StatusTransId",
                principalTable: "StatusTrans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Users_UserId",
                table: "Transaction",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Balans_BalansId",
                table: "Users",
                column: "BalansId",
                principalTable: "Balans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
