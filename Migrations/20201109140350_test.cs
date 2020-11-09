using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MPPIS.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DayPrice",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "money", nullable: false, defaultValue: 0m),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayPrice", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RouteDay",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    route = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteDay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    middlename = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    passwordhash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    registered_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    is_email_confirmed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    role_id = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Role_role_id",
                        column: x => x.role_id,
                        principalTable: "Role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    district = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    vilage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.id);
                    table.ForeignKey(
                        name: "FK_Location_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_added = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    count_production = table.Column<decimal>(type: "decimal", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DayPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageData", x => x.id);
                    table.ForeignKey(
                        name: "FK_StorageData_DayPrice_DayPriceId",
                        column: x => x.DayPriceId,
                        principalTable: "DayPrice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StorageData_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "id", "name" },
                values: new object[] { 1, "User" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "id", "name" },
                values: new object[] { 2, "Admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "email", "firstname", "lastname", "middlename", "passwordhash", "role_id" },
                values: new object[] { 1, "test@gmail.com", "Tester", "Testerovich", "Test", "AQAAAAEAACcQAAAAEIbcLzNrkH71ioIV78ORrt+rAHZMhNjusmitvNthkkZBaeAH4Ckt83lOUxMosjgUoA==", 1 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "email", "firstname", "lastname", "middlename", "passwordhash", "role_id" },
                values: new object[] { 2, "admin@gmail.com", "Admin", "Adminovich", "Adminovski", "AQAAAAEAACcQAAAAEO+c05wGToAZiXQBi/A/tvOuOzcY5yrEy8JFouicbSBpIdbCVQcV2QRcErOPJCf0/Q==", 2 });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "city", "district", "HouseNumber", "street", "UserId", "vilage" },
                values: new object[] { 1, "Lviv", "Mostisky", "53", "Sagaydachnogo", 1, "Tvirzha" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "city", "district", "HouseNumber", "street", "UserId", "vilage" },
                values: new object[] { 2, "Lviv", "Mostisky", "53", "Sagaydachnogo", 2, "Tvirzha" });

            migrationBuilder.CreateIndex(
                name: "IX_Location_UserId",
                table: "Location",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorageData_DayPriceId",
                table: "StorageData",
                column: "DayPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageData_UserId",
                table: "StorageData",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_role_id",
                table: "User",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "RouteDay");

            migrationBuilder.DropTable(
                name: "StorageData");

            migrationBuilder.DropTable(
                name: "DayPrice");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
