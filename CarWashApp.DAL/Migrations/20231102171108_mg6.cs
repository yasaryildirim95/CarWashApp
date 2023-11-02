using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "PersonelID", "IsWasher", "IsWorking", "LeavesLeft", "Name", "Salary", "ShifTypeID", "Surname" },
                values: new object[] { 1, false, false, 14, "admin", 1, 1, "admin" });

            migrationBuilder.InsertData(
                table: "LoginDetails",
                columns: new[] { "PersonelID", "IsAdmin", "Password", "Username" },
                values: new object[] { 1, true, "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoginDetails",
                keyColumn: "PersonelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personels",
                keyColumn: "PersonelID",
                keyValue: 1);
        }
    }
}
