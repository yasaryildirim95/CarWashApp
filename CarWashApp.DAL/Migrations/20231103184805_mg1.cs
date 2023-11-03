using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DirtinessLevels",
                columns: table => new
                {
                    DirtinessLevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirtinessLevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirtinessLevels", x => x.DirtinessLevelID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    StockWarningThreshold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftTypeID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleOwners",
                columns: table => new
                {
                    VehicleOwnerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOwners", x => x.VehicleOwnerID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    VehicleTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceMultiplier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.VehicleTypeID);
                });

            migrationBuilder.CreateTable(
                name: "WashTypes",
                columns: table => new
                {
                    WashTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WashTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashTypes", x => x.WashTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    LeavesLeft = table.Column<int>(type: "int", nullable: false),
                    ShifTypeID = table.Column<int>(type: "int", nullable: false),
                    IsWasher = table.Column<bool>(type: "bit", nullable: false),
                    IsWorking = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personels_Shifts_ShifTypeID",
                        column: x => x.ShifTypeID,
                        principalTable: "Shifts",
                        principalColumn: "ShiftTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleOwnerID = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleOwners_VehicleOwnerID",
                        column: x => x.VehicleOwnerID,
                        principalTable: "VehicleOwners",
                        principalColumn: "VehicleOwnerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleTypes_VehicleTypeID",
                        column: x => x.VehicleTypeID,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WashTypeProducts",
                columns: table => new
                {
                    WashTypeID = table.Column<int>(type: "int", nullable: false),
                    ProductTypeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashTypeProducts", x => new { x.WashTypeID, x.ProductTypeID });
                    table.ForeignKey(
                        name: "FK_WashTypeProducts_Products_ProductTypeID",
                        column: x => x.ProductTypeID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WashTypeProducts_WashTypes_WashTypeID",
                        column: x => x.WashTypeID,
                        principalTable: "WashTypes",
                        principalColumn: "WashTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelID = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LoginDetails_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelLeaves",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumOfDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelLeaves", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonelLeaves_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Washes",
                columns: table => new
                {
                    WashID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    WashTypeID = table.Column<int>(type: "int", nullable: false),
                    DirtinessLevelID = table.Column<int>(type: "int", nullable: false),
                    PersonelID = table.Column<int>(type: "int", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Washes", x => x.WashID);
                    table.ForeignKey(
                        name: "FK_Washes_DirtinessLevels_DirtinessLevelID",
                        column: x => x.DirtinessLevelID,
                        principalTable: "DirtinessLevels",
                        principalColumn: "DirtinessLevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Washes_Personels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personels",
                        principalColumn: "PersonelID");
                    table.ForeignKey(
                        name: "FK_Washes_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Washes_WashTypes_WashTypeID",
                        column: x => x.WashTypeID,
                        principalTable: "WashTypes",
                        principalColumn: "WashTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DirtinessLevels",
                columns: new[] { "DirtinessLevelID", "AdditionalDuration", "DirtinessLevelName" },
                values: new object[,]
                {
                    { 1, 5, "Az" },
                    { 2, 15, "Orta" },
                    { 3, 25, "Çok" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductName", "Stock", "StockWarningThreshold" },
                values: new object[,]
                {
                    { 1, "İç Deterjan", 1, 20 },
                    { 2, "Dış Deterjan", 1, 20 }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ShiftTypeID", "ShiftName" },
                values: new object[,]
                {
                    { 1, "Sabah" },
                    { 2, "Akşam" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "VehicleTypeID", "PriceMultiplier", "VehicleTypeName" },
                values: new object[,]
                {
                    { 1, 1, "Sedan" },
                    { 2, 2, "SUV" },
                    { 3, 2, "Truck" }
                });

            migrationBuilder.InsertData(
                table: "WashTypes",
                columns: new[] { "WashTypeID", "Duration", "Price", "WashTypeName" },
                values: new object[,]
                {
                    { 1, 60, 150, "İç" },
                    { 2, 30, 100, "Dış" },
                    { 3, 90, 225, "İç&Dış" }
                });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "PersonelID", "IsWasher", "IsWorking", "LeavesLeft", "Name", "Salary", "ShifTypeID", "Surname" },
                values: new object[] { 1, false, false, 14, "admin", 1, 1, "admin" });

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

            migrationBuilder.InsertData(
                table: "LoginDetails",
                columns: new[] { "ID", "IsAdmin", "Password", "PersonelID", "Username" },
                values: new object[] { 1, true, "admin", 1, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_LoginDetails_PersonelID",
                table: "LoginDetails",
                column: "PersonelID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonelLeaves_PersonelID",
                table: "PersonelLeaves",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_ShifTypeID",
                table: "Personels",
                column: "ShifTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwners_PhoneNumber",
                table: "VehicleOwners",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Plate",
                table: "Vehicles",
                column: "Plate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleOwnerID",
                table: "Vehicles",
                column: "VehicleOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeID",
                table: "Vehicles",
                column: "VehicleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_DirtinessLevelID",
                table: "Washes",
                column: "DirtinessLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_PersonelID",
                table: "Washes",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_VehicleId",
                table: "Washes",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Washes_WashTypeID",
                table: "Washes",
                column: "WashTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WashTypeProducts_ProductTypeID",
                table: "WashTypeProducts",
                column: "ProductTypeID");
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
                name: "DirtinessLevels");

            migrationBuilder.DropTable(
                name: "Personels");

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
