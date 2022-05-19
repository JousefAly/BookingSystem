using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem_DAL.Migrations
{
    public partial class AddedGuests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Name", "PhoneNumber", "SSN" },
                values: new object[] { 1, "Yousef", "01112233444", "30001172511355" });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Name", "PhoneNumber", "SSN" },
                values: new object[] { 2, "Aly", "01112255666", "30001172511477" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
