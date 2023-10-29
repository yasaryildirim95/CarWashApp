using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonelId",
                table: "Washes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Washes_PersonelId",
                table: "Washes",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_Personels_PersonelId",
                table: "Washes",
                column: "PersonelId",
                principalTable: "Personels",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Washes_Personels_PersonelId",
                table: "Washes");

            migrationBuilder.DropIndex(
                name: "IX_Washes_PersonelId",
                table: "Washes");

            migrationBuilder.DropColumn(
                name: "PersonelId",
                table: "Washes");
        }
    }
}
