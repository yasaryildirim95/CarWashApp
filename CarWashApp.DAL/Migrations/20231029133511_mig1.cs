using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DirtinessLevels",
                columns: table => new
                {
                    DirtinessLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirtinessLevels", x => x.DirtinessLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    WarningStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleOwners",
                columns: table => new
                {
                    VehicleOwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOwners", x => x.VehicleOwnerId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceMultiplier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "WashTypes",
                columns: table => new
                {
                    WashTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashTypes", x => x.WashTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    LeaveNum = table.Column<int>(type: "int", nullable: false),
                    ShifTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personels_Shifts_ShifTypeId",
                        column: x => x.ShifTypeId,
                        principalTable: "Shifts",
                        principalColumn: "ShiftTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleOwnerId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleOwners_VehicleOwnerId",
                        column: x => x.VehicleOwnerId,
                        principalTable: "VehicleOwners",
                        principalColumn: "VehicleOwnerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WashTypeProducts",
                columns: table => new
                {
                    WashTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashTypeProducts", x => new { x.WashTypeId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_WashTypeProducts_Products_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WashTypeProducts_WashTypes_WashTypeId",
                        column: x => x.WashTypeId,
                        principalTable: "WashTypes",
                        principalColumn: "WashTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginDetails",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginDetails", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_LoginDetails_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelLeaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelLeaves_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Washes",
                columns: table => new
                {
                    WashId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    WashTypeId = table.Column<int>(type: "int", nullable: false),
                    DirtinessLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Washes", x => x.WashId);
                    table.ForeignKey(
                        name: "FK_Washes_DirtinessLevels_DirtinessLevelId",
                        column: x => x.DirtinessLevelId,
                        principalTable: "DirtinessLevels",
                        principalColumn: "DirtinessLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Washes_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Washes_WashTypes_WashTypeId",
                        column: x => x.WashTypeId,
                        principalTable: "WashTypes",
                        principalColumn: "WashTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelLeaves_PersonelId",
                table: "PersonelLeaves",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_ShifTypeId",
                table: "Personels",
                column: "ShifTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleOwnerId",
                table: "Vehicles",
                column: "VehicleOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_DirtinessLevelId",
                table: "Washes",
                column: "DirtinessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_VehicleId",
                table: "Washes",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_WashTypeId",
                table: "Washes",
                column: "WashTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WashTypeProducts_ProductTypeId",
                table: "WashTypeProducts",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginDetails");

            migrationBuilder.DropTable(
                name: "PersonelLeaves");

            migrationBuilder.DropTable(
                name: "Washes");

            migrationBuilder.DropTable(
                name: "WashTypeProducts");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "DirtinessLevels");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WashTypes");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "VehicleOwners");

            migrationBuilder.DropTable(
                name: "VehicleTypes");
        }
    }
}
