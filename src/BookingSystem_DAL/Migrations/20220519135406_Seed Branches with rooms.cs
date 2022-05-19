using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem_DAL.Migrations
{
    public partial class SeedBrancheswithrooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxPeople",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "110 Gardens street, Nasr city, Cairo", "Cairo branch" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "510 King street, Mamoura, Alexandria", "Alexandria branch" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BranchId", "MaxPeople", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 1, 1, "R1", 100m, "Single" },
                    { 2, 1, 1, "R2", 100m, "Single" },
                    { 3, 1, 1, "R3", 100m, "Single" },
                    { 4, 1, 2, "R4", 200m, "Double" },
                    { 5, 1, 2, "R5", 200m, "Double" },
                    { 6, 1, 3, "R6", 500m, "Suite" },
                    { 7, 1, 3, "R7", 500m, "Suite" },
                    { 8, 2, 1, "R1", 100m, "Single" },
                    { 9, 2, 1, "R2", 100m, "Single" },
                    { 10, 2, 1, "R3", 100m, "Single" },
                    { 11, 2, 2, "R4", 200m, "Double" },
                    { 12, 2, 2, "R5", 200m, "Double" },
                    { 13, 2, 3, "R6", 500m, "Suite" },
                    { 14, 2, 3, "R7", 500m, "Suite" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "MaxPeople",
                table: "Rooms");
        }
    }
}
