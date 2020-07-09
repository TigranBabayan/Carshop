using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop.Migrations
{
    public partial class Carshop2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HoursePower",
                table: "CarModels",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EngineValue",
                table: "CarModels",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "HoursePower",
                table: "CarModels",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EngineValue",
                table: "CarModels",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
