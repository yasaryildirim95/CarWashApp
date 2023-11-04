using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WashTypeProducts",
                table: "WashTypeProducts");

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumns: new[] { "ProductTypeID", "WashTypeID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumns: new[] { "ProductTypeID", "WashTypeID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumns: new[] { "ProductTypeID", "WashTypeID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumns: new[] { "ProductTypeID", "WashTypeID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.AddColumn<int>(
                name: "WashTypeProductID",
                table: "WashTypeProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WashTypeProducts",
                table: "WashTypeProducts",
                column: "WashTypeProductID");

            migrationBuilder.InsertData(
                table: "WashTypeProducts",
                columns: new[] { "WashTypeProductID", "ProductTypeID", "Quantity", "WashTypeID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 1, 1, 3 },
                    { 4, 2, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WashTypeProducts_WashTypeID",
                table: "WashTypeProducts",
                column: "WashTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WashTypeProducts",
                table: "WashTypeProducts");

            migrationBuilder.DropIndex(
                name: "IX_WashTypeProducts_WashTypeID",
                table: "WashTypeProducts");

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumn: "WashTypeProductID",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumn: "WashTypeProductID",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumn: "WashTypeProductID",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WashTypeProducts",
                keyColumn: "WashTypeProductID",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "WashTypeProductID",
                table: "WashTypeProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WashTypeProducts",
                table: "WashTypeProducts",
                columns: new[] { "WashTypeID", "ProductTypeID" });

            migrationBuilder.InsertData(
                table: "WashTypeProducts",
                columns: new[] { "ProductTypeID", "WashTypeID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 1, 3, 1 },
                    { 2, 3, 1 }
                });
        }
    }
}
