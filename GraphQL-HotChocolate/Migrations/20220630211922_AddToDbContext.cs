using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQL_HotChocolate.Migrations
{
    public partial class AddToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Command_Platforms_PlatformId",
                table: "Command");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Command",
                table: "Command");

            migrationBuilder.RenameTable(
                name: "Command",
                newName: "Commands");

            migrationBuilder.RenameIndex(
                name: "IX_Command_PlatformId",
                table: "Commands",
                newName: "IX_Commands_PlatformId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commands",
                table: "Commands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Platforms_PlatformId",
                table: "Commands",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Platforms_PlatformId",
                table: "Commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commands",
                table: "Commands");

            migrationBuilder.RenameTable(
                name: "Commands",
                newName: "Command");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_PlatformId",
                table: "Command",
                newName: "IX_Command_PlatformId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Command",
                table: "Command",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_Platforms_PlatformId",
                table: "Command",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id");
        }
    }
}
