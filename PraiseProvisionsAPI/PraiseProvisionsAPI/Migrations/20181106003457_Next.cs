using Microsoft.EntityFrameworkCore.Migrations;

namespace PraiseProvisionsAPI.Migrations
{
    public partial class Next : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "ID", "City", "FirstName", "LastName" },
                values: new object[] { 2, "Los Angeles", "Gordon", "Ramsey" });

            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "ID", "City", "FirstName", "LastName" },
                values: new object[] { 3, "Jamaica", "Jimmy", "Fallon" });

            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "ID", "City", "FirstName", "LastName" },
                values: new object[] { 4, "Omaha", "Jack", "TheRipper" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
