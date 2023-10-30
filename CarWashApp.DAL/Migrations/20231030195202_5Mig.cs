using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _5Mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWasher",
                table: "Personels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWasher",
                table: "Personels");
        }
    }
}
