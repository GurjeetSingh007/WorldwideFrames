using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldwideFrames.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrameType = table.Column<string>(nullable: true),
                    FrameStyle = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    FrameHeight = table.Column<decimal>(nullable: false),
                    FrameWidth = table.Column<decimal>(nullable: false),
                    FramePrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frame");
        }
    }
}
