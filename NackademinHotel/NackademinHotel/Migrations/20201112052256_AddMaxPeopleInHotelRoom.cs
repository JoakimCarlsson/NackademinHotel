using Microsoft.EntityFrameworkCore.Migrations;

namespace NackademinHotel.Migrations
{
    public partial class AddMaxPeopleInHotelRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxPeople",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxPeople",
                table: "HotelRooms");
        }
    }
}
