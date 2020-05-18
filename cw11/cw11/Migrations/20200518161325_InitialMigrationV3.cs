using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class InitialMigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 18, 13, 25, 396, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 18, 13, 25, 399, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 18, 13, 25, 399, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 18, 13, 25, 399, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 18, 13, 25, 399, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(1030), new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2800), new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2850), new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2860), new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2870), new DateTime(2020, 5, 18, 18, 13, 25, 402, DateTimeKind.Local).AddTicks(2870) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 17, 0, 17, 194, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "Birthdate",
                value: new DateTime(2020, 5, 18, 17, 0, 17, 197, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 0, 17, 200, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 5, 18, 17, 0, 17, 200, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(150), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(200), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(210), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(220), new DateTime(2020, 5, 18, 17, 0, 17, 201, DateTimeKind.Local).AddTicks(220) });
        }
    }
}
