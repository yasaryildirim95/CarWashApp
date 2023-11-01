using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Washes");

            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "Washes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsWorking",
                table: "Personels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "Washes");

            migrationBuilder.DropColumn(
                name: "IsWorking",
                table: "Personels");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Washes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
