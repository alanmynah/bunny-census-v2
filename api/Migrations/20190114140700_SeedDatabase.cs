using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Bunnies (Name, Residence, Colour) VALUES ('Stomper', 'the UK', 'Brown')");
            migrationBuilder.Sql("INSERT INTO Bunnies (Name, Residence, Colour) VALUES ('Fluffster', 'Switzerland', 'Snow')");
            migrationBuilder.Sql("INSERT INTO Bunnies (Name, Residence, Colour) VALUES ('Twinkles', 'Wales', 'Black')");
            
            migrationBuilder.Sql("INSERT INTO Census (BunnyId) VALUES ((SELECT ID FROM Bunnies WHERE Name = 'Stomper'))");
            migrationBuilder.Sql("INSERT INTO Census (BunnyId) VALUES ((SELECT ID FROM Bunnies WHERE Name = 'Fluffster'))");
            migrationBuilder.Sql("INSERT INTO Census (BunnyId) VALUES ((SELECT ID FROM Bunnies WHERE Name = 'Twinkles'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
