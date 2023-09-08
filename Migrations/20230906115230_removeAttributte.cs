using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeFuel.Migrations
{
    /// <inheritdoc />
    public partial class removeAttributte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyReports_Symptoms_SymptomId",
                table: "DailyReports");

            migrationBuilder.DropIndex(
                name: "IX_DailyReports_SymptomId",
                table: "DailyReports");

            migrationBuilder.DropColumn(
                name: "SymptomId",
                table: "DailyReports");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SymptomId",
                table: "DailyReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_SymptomId",
                table: "DailyReports",
                column: "SymptomId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyReports_Symptoms_SymptomId",
                table: "DailyReports",
                column: "SymptomId",
                principalTable: "Symptoms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
