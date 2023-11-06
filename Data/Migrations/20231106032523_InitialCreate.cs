using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobs_Portal.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    TitleClassification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CivilServiceTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleCodeNo);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Agency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NumberOfPositions = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    ResidencyRequirement = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RecruitmentContact = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SalaryFrequency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SalaryRangeFrom = table.Column<double>(type: "float", nullable: false),
                    SalaryRangeTo = table.Column<double>(type: "float", nullable: false),
                    FullTimePartTimeIndicator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TitleCodeNo = table.Column<int>(type: "int", nullable: false),
                    TitleCodeNo1 = table.Column<int>(type: "int", nullable: false),
                    WorkLocationAgency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DivisionWorkUnit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MinimumQualRequirements = table.Column<string>(type: "text", nullable: false),
                    JobDescription = table.Column<string>(type: "text", nullable: false),
                    PreferredSkills = table.Column<string>(type: "text", nullable: false),
                    ToApply = table.Column<string>(type: "text", nullable: false),
                    HoursShift = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostingUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkLocation1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AdditionalInformation = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobID);
                    table.ForeignKey(
                        name: "FK_Job_Level_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Level",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Job_Title_TitleCodeNo",
                        column: x => x.TitleCodeNo,
                        principalTable: "Title",
                        principalColumn: "TitleCodeNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Job_LevelID",
                table: "Job",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_TitleCodeNo",
                table: "Job",
                column: "TitleCodeNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Title");
        }
    }
}
