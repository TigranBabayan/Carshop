using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop.Migrations
{
    public partial class Carshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarMakers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(nullable: false),
                    Modefication = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Bodystyle = table.Column<int>(nullable: false),
                    Mileage = table.Column<long>(nullable: false),
                    CarModelColor = table.Column<string>(nullable: false),
                    Gearbox = table.Column<int>(nullable: false),
                    Fueltype = table.Column<int>(nullable: false),
                    Handdrive = table.Column<int>(nullable: false),
                    Customcleared = table.Column<int>(nullable: false),
                    Price = table.Column<long>(nullable: false),
                    CarModelImage = table.Column<string>(nullable: true),
                    TopAnnouncements = table.Column<bool>(nullable: false),
                    EngineValue = table.Column<decimal>(type: "decimal", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    HoursePower = table.Column<long>(nullable: true),
                    CarModelExteriorColor = table.Column<string>(nullable: true),
                    DoorCount = table.Column<int>(nullable: false),
                    Drivetrain = table.Column<int>(nullable: false),
                    Condition = table.Column<int>(nullable: false),
                    Vin = table.Column<string>(nullable: true),
                    CarMakerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarMakers_CarMakerId",
                        column: x => x.CarMakerId,
                        principalTable: "CarMakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarMakerId",
                table: "CarModels",
                column: "CarMakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CarMakers");
        }
    }
}
