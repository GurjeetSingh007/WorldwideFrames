using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldwideFrames.Migrations
{
    public partial class DecimalColoumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FrameWidth",
                table: "Frame",
                type: "decimal(7, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FramePrice",
                table: "Frame",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FrameHeight",
                table: "Frame",
                type: "decimal(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FrameWidth",
                table: "Frame",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FramePrice",
                table: "Frame",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FrameHeight",
                table: "Frame",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)");
        }
    }
}
