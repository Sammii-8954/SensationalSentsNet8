using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a7fcd79-9c52-42c2-81f5-h463703d36be", null, "Administrator", "ADMINISTRATOR" },
                    { "0b8bbd79-6c52-42a3-81g5-h463503b36de", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DatofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TRN", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b7fbc79-9d52-42a2-81f5-f463703d36be", 0, null, "3cd82364-8988-409d-adef-998610d86304", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost1.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST1.COM", null, "AQAAAAIAAYagAAAAEMu73PSSV6AUBL8OUkHh85f0MLKWq2mtnsGtkjEKRQpIZES6lDAD9cVXAcrXglvF/Q==", null, null, false, "e5863042-c84f-4006-972a-f6f287d5f958", null, false, null },
                    { "bd90e64b-c379-40e3-ad61-5f4cd2c70038", 0, null, "979a532c-aafa-4b0c-bd79-0ca3e1806bc9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost1.com", false, "System", "User", false, null, "USER@LOCALHOST1.COM", null, "AQAAAAIAAYagAAAAEBe/bSoj8DN8ijREOMmD8Hw8mCINmcnSF9He+KJ2Hh9kdU/IG7FS6KXgiPLj5uAgRw==", null, null, false, "a8f79445-e5af-492b-8630-bab427e31505", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0a7fcd79-9c52-42c2-81f5-h463703d36be", "0b7fbc79-9d52-42a2-81f5-f463703d36be" },
                    { "0b8bbd79-6c52-42a3-81g5-h463503b36de", "bd90e64b-c379-40e3-ad61-5f4cd2c70038" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a7fcd79-9c52-42c2-81f5-h463703d36be", "0b7fbc79-9d52-42a2-81f5-f463703d36be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b8bbd79-6c52-42a3-81g5-h463503b36de", "bd90e64b-c379-40e3-ad61-5f4cd2c70038" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a7fcd79-9c52-42c2-81f5-h463703d36be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8bbd79-6c52-42a3-81g5-h463503b36de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b7fbc79-9d52-42a2-81f5-f463703d36be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd90e64b-c379-40e3-ad61-5f4cd2c70038");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}
