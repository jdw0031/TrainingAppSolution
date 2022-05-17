using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingApp.Data.Migrations
{
    public partial class AddedApplicationUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "athletePosition",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sportType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TrainerSchedules",
                columns: table => new
                {
                    trainerScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainerScheduleStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trainerScheduleEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false),
                    trainerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerSchedules", x => x.trainerScheduleID);
                    table.ForeignKey(
                        name: "FK_TrainerSchedules_AspNetUsers_trainerId",
                        column: x => x.trainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSessions",
                columns: table => new
                {
                    trainingSessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainingSessionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trainingSessionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    athleteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    trainerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSessions", x => x.trainingSessionID);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_AspNetUsers_athleteId",
                        column: x => x.athleteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_AspNetUsers_trainerId",
                        column: x => x.trainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSchedules_trainerId",
                table: "TrainerSchedules",
                column: "trainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_athleteId",
                table: "TrainingSessions",
                column: "athleteId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_trainerId",
                table: "TrainingSessions",
                column: "trainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainerSchedules");

            migrationBuilder.DropTable(
                name: "TrainingSessions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "athletePosition",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "location",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sportType",
                table: "AspNetUsers");
        }
    }
}
