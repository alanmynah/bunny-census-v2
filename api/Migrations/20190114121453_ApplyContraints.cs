using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class ApplyContraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Census_Bunny_BunnyId",
                table: "Census");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bunny",
                table: "Bunny");

            migrationBuilder.RenameTable(
                name: "Bunny",
                newName: "Bunnies");

            migrationBuilder.AlterColumn<string>(
                name: "Residence",
                table: "Bunnies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bunnies",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Bunnies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bunnies",
                table: "Bunnies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Census_Bunnies_BunnyId",
                table: "Census",
                column: "BunnyId",
                principalTable: "Bunnies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Census_Bunnies_BunnyId",
                table: "Census");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bunnies",
                table: "Bunnies");

            migrationBuilder.RenameTable(
                name: "Bunnies",
                newName: "Bunny");

            migrationBuilder.AlterColumn<string>(
                name: "Residence",
                table: "Bunny",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bunny",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Bunny",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bunny",
                table: "Bunny",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Census_Bunny_BunnyId",
                table: "Census",
                column: "BunnyId",
                principalTable: "Bunny",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
