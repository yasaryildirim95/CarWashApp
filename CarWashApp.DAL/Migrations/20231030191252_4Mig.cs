using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarWashApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _4Mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginDetails_Personels_PersonelId",
                table: "LoginDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonelLeaves_Personels_PersonelId",
                table: "PersonelLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Shifts_ShifTypeId",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleOwners_VehicleOwnerId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Washes_DirtinessLevels_DirtinessLevelId",
                table: "Washes");

            migrationBuilder.DropForeignKey(
                name: "FK_Washes_Personels_PersonelId",
                table: "Washes");

            migrationBuilder.DropForeignKey(
                name: "FK_Washes_WashTypes_WashTypeId",
                table: "Washes");

            migrationBuilder.DropForeignKey(
                name: "FK_WashTypeProducts_Products_ProductTypeId",
                table: "WashTypeProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_WashTypeProducts_WashTypes_WashTypeId",
                table: "WashTypeProducts");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "WashTypeId",
                table: "WashTypes",
                newName: "WashTypeID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WashTypes",
                newName: "WashTypeName");

            migrationBuilder.RenameColumn(
                name: "ProductTypeId",
                table: "WashTypeProducts",
                newName: "ProductTypeID");

            migrationBuilder.RenameColumn(
                name: "WashTypeId",
                table: "WashTypeProducts",
                newName: "WashTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_WashTypeProducts_ProductTypeId",
                table: "WashTypeProducts",
                newName: "IX_WashTypeProducts_ProductTypeID");

            migrationBuilder.RenameColumn(
                name: "WashTypeId",
                table: "Washes",
                newName: "WashTypeID");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "Washes",
                newName: "PersonelID");

            migrationBuilder.RenameColumn(
                name: "DirtinessLevelId",
                table: "Washes",
                newName: "DirtinessLevelID");

            migrationBuilder.RenameColumn(
                name: "WashId",
                table: "Washes",
                newName: "WashID");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Washes",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Washes",
                newName: "StartTime");

            migrationBuilder.RenameIndex(
                name: "IX_Washes_WashTypeId",
                table: "Washes",
                newName: "IX_Washes_WashTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Washes_PersonelId",
                table: "Washes",
                newName: "IX_Washes_PersonelID");

            migrationBuilder.RenameIndex(
                name: "IX_Washes_DirtinessLevelId",
                table: "Washes",
                newName: "IX_Washes_DirtinessLevelID");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeId",
                table: "VehicleTypes",
                newName: "VehicleTypeID");

            migrationBuilder.RenameColumn(
                name: "VehicleName",
                table: "VehicleTypes",
                newName: "VehicleTypeName");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeId",
                table: "Vehicles",
                newName: "VehicleTypeID");

            migrationBuilder.RenameColumn(
                name: "VehicleOwnerId",
                table: "Vehicles",
                newName: "VehicleOwnerID");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Vehicles",
                newName: "VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleOwnerId",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleOwnerID");

            migrationBuilder.RenameColumn(
                name: "VehicleOwnerId",
                table: "VehicleOwners",
                newName: "VehicleOwnerID");

            migrationBuilder.RenameColumn(
                name: "ShiftTypeId",
                table: "Shifts",
                newName: "ShiftTypeID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Shifts",
                newName: "ShiftName");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "WarningStock",
                table: "Products",
                newName: "StockWarningThreshold");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "ShifTypeId",
                table: "Personels",
                newName: "ShifTypeID");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "Personels",
                newName: "PersonelID");

            migrationBuilder.RenameColumn(
                name: "LeaveNum",
                table: "Personels",
                newName: "LeavesLeft");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_ShifTypeId",
                table: "Personels",
                newName: "IX_Personels_ShifTypeID");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "PersonelLeaves",
                newName: "PersonelID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PersonelLeaves",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DayCount",
                table: "PersonelLeaves",
                newName: "NumOfDays");

            migrationBuilder.RenameIndex(
                name: "IX_PersonelLeaves_PersonelId",
                table: "PersonelLeaves",
                newName: "IX_PersonelLeaves_PersonelID");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "LoginDetails",
                newName: "PersonelID");

            migrationBuilder.RenameColumn(
                name: "DirtinessLevelId",
                table: "DirtinessLevels",
                newName: "DirtinessLevelID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DirtinessLevels",
                newName: "DirtinessLevelName");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "DirtinessLevels",
                newName: "AdditionalDuration");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Washes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "VehicleOwners",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "LoginDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                table: "WashTypeProducts",
                columns: new[] { "ProductTypeID", "WashTypeID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 1, 3, 1 },
                    { 2, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwners_PhoneNumber",
                table: "VehicleOwners",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginDetails_Personels_PersonelID",
                table: "LoginDetails",
                column: "PersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelLeaves_Personels_PersonelID",
                table: "PersonelLeaves",
                column: "PersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Shifts_ShifTypeID",
                table: "Personels",
                column: "ShifTypeID",
                principalTable: "Shifts",
                principalColumn: "ShiftTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleOwners_VehicleOwnerID",
                table: "Vehicles",
                column: "VehicleOwnerID",
                principalTable: "VehicleOwners",
                principalColumn: "VehicleOwnerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeID",
                table: "Vehicles",
                column: "VehicleTypeID",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_DirtinessLevels_DirtinessLevelID",
                table: "Washes",
                column: "DirtinessLevelID",
                principalTable: "DirtinessLevels",
                principalColumn: "DirtinessLevelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_Personels_PersonelID",
                table: "Washes",
                column: "PersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_WashTypes_WashTypeID",
                table: "Washes",
                column: "WashTypeID",
                principalTable: "WashTypes",
                principalColumn: "WashTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WashTypeProducts_Products_ProductTypeID",
                table: "WashTypeProducts",
                column: "ProductTypeID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WashTypeProducts_WashTypes_WashTypeID",
                table: "WashTypeProducts",
                column: "WashTypeID",
                principalTable: "WashTypes",
                principalColumn: "WashTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginDetails_Personels_PersonelID",
                table: "LoginDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonelLeaves_Personels_PersonelID",
                table: "PersonelLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Shifts_ShifTypeID",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleOwners_VehicleOwnerID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Washes_DirtinessLevels_DirtinessLevelID",
                table: "Washes");

            migrationBuilder.DropForeignKey(
                name: "FK_Washes_Personels_PersonelID",
                table: "Washes");

            migrationBuilder.DropForeignKey(
                name: "FK_Washes_WashTypes_WashTypeID",
                table: "Washes");

            migrationBuilder.DropForeignKey(
                name: "FK_WashTypeProducts_Products_ProductTypeID",
                table: "WashTypeProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_WashTypeProducts_WashTypes_WashTypeID",
                table: "WashTypeProducts");

            migrationBuilder.DropIndex(
                name: "IX_VehicleOwners_PhoneNumber",
                table: "VehicleOwners");

            migrationBuilder.DeleteData(
                table: "DirtinessLevels",
                keyColumn: "DirtinessLevelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DirtinessLevels",
                keyColumn: "DirtinessLevelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DirtinessLevels",
                keyColumn: "DirtinessLevelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ShiftTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ShiftTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeID",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WashTypes",
                keyColumn: "WashTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WashTypes",
                keyColumn: "WashTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WashTypes",
                keyColumn: "WashTypeID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Washes");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "LoginDetails");

            migrationBuilder.RenameColumn(
                name: "WashTypeID",
                table: "WashTypes",
                newName: "WashTypeId");

            migrationBuilder.RenameColumn(
                name: "WashTypeName",
                table: "WashTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductTypeID",
                table: "WashTypeProducts",
                newName: "ProductTypeId");

            migrationBuilder.RenameColumn(
                name: "WashTypeID",
                table: "WashTypeProducts",
                newName: "WashTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_WashTypeProducts_ProductTypeID",
                table: "WashTypeProducts",
                newName: "IX_WashTypeProducts_ProductTypeId");

            migrationBuilder.RenameColumn(
                name: "WashTypeID",
                table: "Washes",
                newName: "WashTypeId");

            migrationBuilder.RenameColumn(
                name: "PersonelID",
                table: "Washes",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "DirtinessLevelID",
                table: "Washes",
                newName: "DirtinessLevelId");

            migrationBuilder.RenameColumn(
                name: "WashID",
                table: "Washes",
                newName: "WashId");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Washes",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Washes",
                newName: "TotalPrice");

            migrationBuilder.RenameIndex(
                name: "IX_Washes_WashTypeID",
                table: "Washes",
                newName: "IX_Washes_WashTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Washes_PersonelID",
                table: "Washes",
                newName: "IX_Washes_PersonelId");

            migrationBuilder.RenameIndex(
                name: "IX_Washes_DirtinessLevelID",
                table: "Washes",
                newName: "IX_Washes_DirtinessLevelId");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeID",
                table: "VehicleTypes",
                newName: "VehicleTypeId");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeName",
                table: "VehicleTypes",
                newName: "VehicleName");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeID",
                table: "Vehicles",
                newName: "VehicleTypeId");

            migrationBuilder.RenameColumn(
                name: "VehicleOwnerID",
                table: "Vehicles",
                newName: "VehicleOwnerId");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Vehicles",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleTypeID",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleOwnerID",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleOwnerId");

            migrationBuilder.RenameColumn(
                name: "VehicleOwnerID",
                table: "VehicleOwners",
                newName: "VehicleOwnerId");

            migrationBuilder.RenameColumn(
                name: "ShiftTypeID",
                table: "Shifts",
                newName: "ShiftTypeId");

            migrationBuilder.RenameColumn(
                name: "ShiftName",
                table: "Shifts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "StockWarningThreshold",
                table: "Products",
                newName: "WarningStock");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ShifTypeID",
                table: "Personels",
                newName: "ShifTypeId");

            migrationBuilder.RenameColumn(
                name: "PersonelID",
                table: "Personels",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "LeavesLeft",
                table: "Personels",
                newName: "LeaveNum");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_ShifTypeID",
                table: "Personels",
                newName: "IX_Personels_ShifTypeId");

            migrationBuilder.RenameColumn(
                name: "PersonelID",
                table: "PersonelLeaves",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PersonelLeaves",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NumOfDays",
                table: "PersonelLeaves",
                newName: "DayCount");

            migrationBuilder.RenameIndex(
                name: "IX_PersonelLeaves_PersonelID",
                table: "PersonelLeaves",
                newName: "IX_PersonelLeaves_PersonelId");

            migrationBuilder.RenameColumn(
                name: "PersonelID",
                table: "LoginDetails",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "DirtinessLevelID",
                table: "DirtinessLevels",
                newName: "DirtinessLevelId");

            migrationBuilder.RenameColumn(
                name: "DirtinessLevelName",
                table: "DirtinessLevels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AdditionalDuration",
                table: "DirtinessLevels",
                newName: "Duration");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "VehicleOwners",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Personels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginDetails_Personels_PersonelId",
                table: "LoginDetails",
                column: "PersonelId",
                principalTable: "Personels",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelLeaves_Personels_PersonelId",
                table: "PersonelLeaves",
                column: "PersonelId",
                principalTable: "Personels",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Shifts_ShifTypeId",
                table: "Personels",
                column: "ShifTypeId",
                principalTable: "Shifts",
                principalColumn: "ShiftTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleOwners_VehicleOwnerId",
                table: "Vehicles",
                column: "VehicleOwnerId",
                principalTable: "VehicleOwners",
                principalColumn: "VehicleOwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_DirtinessLevels_DirtinessLevelId",
                table: "Washes",
                column: "DirtinessLevelId",
                principalTable: "DirtinessLevels",
                principalColumn: "DirtinessLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_Personels_PersonelId",
                table: "Washes",
                column: "PersonelId",
                principalTable: "Personels",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Washes_WashTypes_WashTypeId",
                table: "Washes",
                column: "WashTypeId",
                principalTable: "WashTypes",
                principalColumn: "WashTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WashTypeProducts_Products_ProductTypeId",
                table: "WashTypeProducts",
                column: "ProductTypeId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WashTypeProducts_WashTypes_WashTypeId",
                table: "WashTypeProducts",
                column: "WashTypeId",
                principalTable: "WashTypes",
                principalColumn: "WashTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
