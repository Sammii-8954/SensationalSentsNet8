using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRolesupdatedvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b7fbc79-9d52-42a2-81f5-f463703d36be",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ba722915-256a-426c-8602-8fbd0bd4c901", true, "ADMIN@LOCALHOST1.COM", "AQAAAAIAAYagAAAAEBIcg+IfIgNb6HOFPGPl8O4QEkI12fdixtP9gJfqzqYbEVToXqlJtuPkZ4brOo2AFw==", "3ac5c16e-8747-4a1c-a1f4-3bc74f3a516e", "admin@localhost1.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd90e64b-c379-40e3-ad61-5f4cd2c70038",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2d5d3d86-75fd-4d36-83cb-6b5419c5c001", true, "USER@LOCALHOST1.COM", "AQAAAAIAAYagAAAAEBJheqgLAjdoHEslBvrAacmqnlmRovf+Uxpek0pem0cvnl5mNGWYRcjc3yHwbovqxg==", "ca4100d6-362e-43cf-858b-c48291d19832", "user@localhost1.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b7fbc79-9d52-42a2-81f5-f463703d36be",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3cd82364-8988-409d-adef-998610d86304", false, null, "AQAAAAIAAYagAAAAEMu73PSSV6AUBL8OUkHh85f0MLKWq2mtnsGtkjEKRQpIZES6lDAD9cVXAcrXglvF/Q==", "e5863042-c84f-4006-972a-f6f287d5f958", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd90e64b-c379-40e3-ad61-5f4cd2c70038",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "979a532c-aafa-4b0c-bd79-0ca3e1806bc9", false, null, "AQAAAAIAAYagAAAAEBe/bSoj8DN8ijREOMmD8Hw8mCINmcnSF9He+KJ2Hh9kdU/IG7FS6KXgiPLj5uAgRw==", "a8f79445-e5af-492b-8630-bab427e31505", null });
        }
    }
}
