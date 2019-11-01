using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkDistrict.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Neighborhood",
                table: "Parks",
                newName: "Location");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "PicnicArea", "Playground" },
                values: new object[,]
                {
                    { 1, "N Edison St. and Pittsburg Ave.", "Cathedral Park", true, true },
                    { 2, "9360 N Columbia Blvd.", "Columbia Park", true, true },
                    { 3, "N Fremont St. and Interstate Ave.", "Overlook Park", true, true },
                    { 4, "N Marine Dr. and Lombard St.", "Kelley Point Park", true, true },
                    { 5, "700 N Rosa Parks Way", "Peninsula Park", true, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Parks",
                newName: "Neighborhood");
        }
    }
}
