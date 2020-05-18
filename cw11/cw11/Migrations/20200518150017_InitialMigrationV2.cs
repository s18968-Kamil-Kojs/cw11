using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class InitialMigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "a.mordacz@gmail.com", "Anna", "Mordacz" },
                    { 2, "t.tomaczowski@gmail.com", "Tomasz", "Tomaczowski" },
                    { 3, "a.andrzejewski@gmail.com", "Andrzej", "Andrzejewski" }
                });

            migrationBuilder.InsertData(
                table: "GetPrescription_Medicamant",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 3, 3, "3 razy dziennie", 3 },
                    { 2, 2, "1 raz dziennie", 1 },
                    { 1, 1, "2 razy dziennie", 2 },
                    { 4, 4, "2 razy dziennie", 2 },
                    { 5, 5, "2 razy dziennie", 2 }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 4, "Lek na odpornosc", "Witamina C", "Wzmacniajacy" },
                    { 3, "Lek na odciski", "Acutol", "Leczniczy" },
                    { 2, "Lek na goraczke", "Gripex", "Przeciwgoraczkowy" },
                    { 1, "Lek na goraczke", "Fervex", "Przeciwgoraczkowy" },
                    { 5, "Lek na odpornosc", "Witamina B", "Wzmacniajacy" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 18, 17, 0, 17, 194, DateTimeKind.Local).AddTicks(6930), "Jan", "Kowalski" },
                    { 2, new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9000), "Ania", "Andrzejewska" },
                    { 3, new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9070), "Ola", "Sparc" },
                    { 5, new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9080), "Bartosz", "Nowak" },
                    { 4, new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9070), "Kasia", "Kowalczyk" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 18, 17, 0, 17, 200, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 5, 18, 17, 0, 17, 200, DateTimeKind.Local).AddTicks(8940), 1, 1 },
                    { 2, new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(150), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(170), 1, 2 },
                    { 3, new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(200), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(210), 2, 3 },
                    { 4, new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(210), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(210), 3, 4 },
                    { 5, new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(220), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(220), 3, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GetPrescription_Medicamant",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GetPrescription_Medicamant",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GetPrescription_Medicamant",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GetPrescription_Medicamant",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GetPrescription_Medicamant",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5);
        }
    }
}
