using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinaria_API.Migrations
{
    public partial class AddedInitialPatients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AdmissionDate", "Breed", "ClientId", "DischargeDate", "Name", "Symptoms", "Type" },
                values: new object[] { 1, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labrador", 1, null, "Cascote", "Inanición, falta de movilidad", "Perro" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AdmissionDate", "Breed", "ClientId", "DischargeDate", "Name", "Symptoms", "Type" },
                values: new object[] { 2, new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persa", 2, null, "Pelusa", "A determinar", "Gato" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
