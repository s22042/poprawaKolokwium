using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace poprawa.Migrations
{
    public partial class Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationID", "OrganizationDomain", "OrganizationName" },
                values: new object[,]
                {
                    { 1, "g", "google" },
                    { 2, "microsoft", "Microsoft" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "OrganizationID", "OrganizationId", "TeamDescription", "TeamName" },
                values: new object[,]
                {
                    { 1, null, 1, "Pierscienia", "Druzyna" },
                    { 2, null, 2, "kot", "Team" }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "FileId", "TeamId", "FileExtension", "FileName", "FileSize" },
                values: new object[,]
                {
                    { 1, 1, ".txt", "plik", 1 },
                    { 2, 2, ".txt", "plik2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "MemberName", "MemberNickName", "MemberSurname", "OrganizationId" },
                values: new object[,]
                {
                    { 1, "Ala", "grzyb ", "Kot", 1 },
                    { 2, "Pawel", "Szybki ", "Klekot", 2 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "MemberId", "TeamId", "MembershipDate" },
                values: new object[] { 1, 1, new DateTime(2022, 6, 23, 11, 25, 18, 875, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "MemberId", "TeamId", "MembershipDate" },
                values: new object[] { 2, 2, new DateTime(2022, 6, 23, 11, 25, 18, 882, DateTimeKind.Local).AddTicks(8496) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Files",
                keyColumns: new[] { "FileId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumns: new[] { "FileId", "TeamId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumns: new[] { "MemberId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumns: new[] { "MemberId", "TeamId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationID",
                keyValue: 2);
        }
    }
}
