using Microsoft.EntityFrameworkCore.Migrations;

namespace Huflix.Migrations
{
    public partial class Tes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a155565-c9d0-41d4-9eeb-35cc2dc7c31c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42628ce2-b7c4-4877-a854-52121dd0576b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c09a72b5-b7c3-495b-a6d5-aeb4d633e739", "3c06b9f4-42cd-4d4e-90ad-a984e9181b44", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a885816d-164b-43ba-8edb-99bbd788b18f", "d6d44e3e-ca8f-4840-976c-5587721bbbf5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a885816d-164b-43ba-8edb-99bbd788b18f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c09a72b5-b7c3-495b-a6d5-aeb4d633e739");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a155565-c9d0-41d4-9eeb-35cc2dc7c31c", "4b7e9d5e-8c74-4a64-a11b-f613d1f8f163", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42628ce2-b7c4-4877-a854-52121dd0576b", "f4ec4a80-6691-466e-921e-9de2b4448a50", "Administrator", "ADMINISTRATOR" });
        }
    }
}
