using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class ApplyContraintsForColour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Bunnies",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Bunnies",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
