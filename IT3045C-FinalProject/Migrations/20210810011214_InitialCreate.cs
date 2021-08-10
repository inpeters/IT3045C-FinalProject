using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IT3045C_FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breakfast",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteBreakfastFood = table.Column<string>(nullable: true),
                    FavoriteSide = table.Column<string>(nullable: true),
                    FavoriteBreakfastTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakfast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dinner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteEntree = table.Column<string>(nullable: true),
                    FavoriteSide = table.Column<string>(nullable: true),
                    FavoriteRestaurant = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteHobby = table.Column<string>(nullable: true),
                    HowStarted = table.Column<string>(nullable: true),
                    WhyStarted = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    CollegeProgram = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Breakfast",
                columns: new[] { "Id", "FavoriteBreakfastFood", "FavoriteBreakfastTime", "FavoriteSide", "FullName" },
                values: new object[,]
                {
                    { 1, "Waffles", "10:00 AM", "Bacon", "Isabella Peters" },
                    { 2, "Waffles", "12:00 PM", "Bacon", "Logan Nemec" },
                    { 3, "French Toast", "6:00 AM", "Coffee", "Joseph Berger" },
                    { 4, "Bacon Egg & Cheese Biscuit", "8:00 AM", "Toast", "Tony Herrera" },
                    { 5, "Egg Sandwich", "7:30 AM", "Coffee", "Taylor O'Black" }
                });

            migrationBuilder.InsertData(
                table: "Dinner",
                columns: new[] { "Id", "FavoriteEntree", "FavoriteRestaurant", "FavoriteSide", "FullName" },
                values: new object[,]
                {
                    { 4, "Cheeseburger", "Culver's", "Fries", "Tony Herrera" },
                    { 3, "Pizza", "Dewey's", "Fries", "Joseph Berger" },
                    { 5, "Shephards Pie", "CheeseCake Factory", "Roasted Potatoes", "Taylor O'Black" },
                    { 1, "Steak", "Alladins' Eatery", "Mashed Potatoes", "Isabella Peters" },
                    { 2, "Steak", "Swensons", "Fried rice and noodles", "Logan Nemec" }
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "Id", "FavoriteHobby", "FullName", "HowStarted", "WhyStarted" },
                values: new object[,]
                {
                    { 1, "Hiking", "Isabella Peters", "My family would take me.", "To exercise" },
                    { 2, "Playing Video Games", "Logan Nemec", "Family and Friends", "For fun and good stress relief" },
                    { 3, "Extreme Deep Sea Diving", "Joseph Berger", "Became best friends with a local fisherman", "To gaze upon the amazing underwater sea" },
                    { 4, "Video Games", "Tony Herrera", "My brother made fun of me for being bad at them", "To beat my brother for bragging rights" },
                    { 5, "Raising a Puppy", "Taylor O'Black", "Got a Shiba Inu with my partner", "I love puppies" }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 4, new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Tony Herrera", "Fourth Year" },
                    { 1, new DateTime(2001, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Isabella Peters", "Junior" },
                    { 2, new DateTime(2000, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Logan Nemec", "First Year" },
                    { 3, new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Joseph Berger", "Third Year" },
                    { 5, new DateTime(2000, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Taylor O'Black", "Third Year" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breakfast");

            migrationBuilder.DropTable(
                name: "Dinner");

            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
