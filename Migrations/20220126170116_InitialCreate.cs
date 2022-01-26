using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAlpha.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersTables",
                columns: table => new
                {
                    UsersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersName = table.Column<string>(nullable: true),
                    UsersEmail = table.Column<string>(nullable: false),
                    UsersDOB = table.Column<string>(nullable: true),
                    UsersPassword = table.Column<string>(nullable: false),
                    UsersMobile = table.Column<string>(nullable: true),
                    UsersImages = table.Column<string>(nullable: true),
                    UsersAbout = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTables", x => x.UsersId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersTables");
        }
    }
}
