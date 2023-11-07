using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobs_Portal.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Level_LevelID",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Title_TitleCodeNo",
                table: "Job");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropIndex(
                name: "IX_Job_LevelID",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_TitleCodeNo",
                table: "Job");

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Job");

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerLevel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    JobCategory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    TitleCodeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CivilServiceTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TitleClassification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleCodeNo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Job_LevelID",
                table: "Job",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_TitleCodeNo",
                table: "Job",
                column: "TitleCodeNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Level_LevelID",
                table: "Job",
                column: "LevelID",
                principalTable: "Level",
                principalColumn: "LevelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Title_TitleCodeNo",
                table: "Job",
                column: "TitleCodeNo",
                principalTable: "Title",
                principalColumn: "TitleCodeNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
