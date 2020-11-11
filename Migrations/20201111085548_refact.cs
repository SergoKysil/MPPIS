using Microsoft.EntityFrameworkCore.Migrations;

namespace MPPIS.Migrations
{
    public partial class refact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_User_UserId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_UserId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Location");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "LocationId", "passwordhash" },
                values: new object[] { 1, "AQAAAAEAACcQAAAAEBtjnV13Xu3yisnnAIYfpqvWrx0RX8uS1IMrksiHm5PG+mf/ud7b9SOZaAovgckfuA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "LocationId", "passwordhash" },
                values: new object[] { 2, "AQAAAAEAACcQAAAAEJrS6rwpPl1snK588k+Q5TW4vy6jSU0WZ2ktREBGQaGZ5PcYJHPzvFWJfbDcjc4mOg==" });

            migrationBuilder.CreateIndex(
                name: "IX_User_LocationId",
                table: "User",
                column: "LocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Location_LocationId",
                table: "User",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Location_LocationId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_LocationId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Location",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                column: "passwordhash",
                value: "AQAAAAEAACcQAAAAEIbcLzNrkH71ioIV78ORrt+rAHZMhNjusmitvNthkkZBaeAH4Ckt83lOUxMosjgUoA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 2,
                column: "passwordhash",
                value: "AQAAAAEAACcQAAAAEO+c05wGToAZiXQBi/A/tvOuOzcY5yrEy8JFouicbSBpIdbCVQcV2QRcErOPJCf0/Q==");

            migrationBuilder.CreateIndex(
                name: "IX_Location_UserId",
                table: "Location",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_User_UserId",
                table: "Location",
                column: "UserId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
