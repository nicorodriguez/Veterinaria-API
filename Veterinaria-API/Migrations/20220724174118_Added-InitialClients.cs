using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinaria_API.Migrations
{
    public partial class AddedInitialClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "LastName", "Name" },
                values: new object[] { 1, "loren_luis@gmail.com", "Lorenzetti", "Luis" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "LastName", "Name" },
                values: new object[] { 2, "monica_barrientos_39@gmail.com", "Barrientos", "Mónica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
