using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PraiseProvisions.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserFavorites",
                columns: table => new
                {
                    UserProfileID = table.Column<int>(nullable: false),
                    RestaurantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavorites", x => new { x.RestaurantID, x.UserProfileID });
                    table.ForeignKey(
                        name: "FK_UserFavorites_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavorites_UserProfiles_UserProfileID",
                        column: x => x.UserProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_UserProfileID",
                table: "UserFavorites",
                column: "UserProfileID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFavorites");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
