using Microsoft.EntityFrameworkCore.Migrations;

namespace PraiseProvisions.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "ID", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "1234 Fake St. Seattle, WA 98122", "Brian's delicious comfort food, the dumplings are A+!", "Dough Zone" },
                    { 2, "1234 Fake St. Seattle, WA 98122", "Top fried chicken in Seattle according to Jeff Weng!", "Karaage Setsuna" },
                    { 3, "1234 Fake St. Seattle, WA 98122", "ALL YOU CAN EAT MEAT. ALL DAY, EVERYDAY.", "Novilho's Brazilian Steakhouse" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "ID", "fullName" },
                values: new object[,]
                {
                    { 1, "Jimmy Nguyen" },
                    { 2, "Brian Nelson" }
                });

            migrationBuilder.InsertData(
                table: "UserFavorites",
                columns: new[] { "RestaurantID", "UserProfileID" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "UserFavorites",
                columns: new[] { "RestaurantID", "UserProfileID" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "UserFavorites",
                columns: new[] { "RestaurantID", "UserProfileID" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserFavorites",
                keyColumns: new[] { "RestaurantID", "UserProfileID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserFavorites",
                keyColumns: new[] { "RestaurantID", "UserProfileID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserFavorites",
                keyColumns: new[] { "RestaurantID", "UserProfileID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
