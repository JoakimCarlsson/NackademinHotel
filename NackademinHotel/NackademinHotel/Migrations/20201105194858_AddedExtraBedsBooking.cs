using Microsoft.EntityFrameworkCore.Migrations;

namespace NackademinHotel.Migrations
{
    public partial class AddedExtraBedsBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraBeds",
                table: "HotelRooms");

            migrationBuilder.AddColumn<int>(
                name: "ExtraBeds",
                table: "Bookings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraBeds",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "ExtraBeds",
                table: "HotelRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
