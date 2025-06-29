using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PowerStationMonitoring.Infrasturcture.Migrations
{
    /// <inheritdoc />
    public partial class AddDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sensors_Slaves_SlaveId",
                table: "Sensors");

            migrationBuilder.DropTable(
                name: "Slaves");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_Sensors_SlaveId",
                table: "Sensors");

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "SensorId", "SensorName", "SensorType", "SlaveId" },
                values: new object[,]
                {
                    { 1, "Temperature", "Temperature", 1 },
                    { 2, "Pressure", "Pressure", 2 },
                    { 3, "Radiation", "Radiation", 3 },
                    { 4, "Humidity", "Humitdity", 4 },
                    { 5, "Flow", "Flow", 5 }
                });

            migrationBuilder.InsertData(
                table: "SensorData",
                columns: new[] { "SensorDataId", "MeasuredValue", "MeasurementType", "Notes", "SensorId", "Timestamp", "Unit" },
                values: new object[,]
                {
                    { 1, 25.5m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7888), "Celsius" },
                    { 2, 101325m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7895), "Pascal" },
                    { 3, 0.1m, "Radiation", "Normal", 3, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7901), "mSv/h" },
                    { 4, 45.0m, "Humidity", "Normal", 4, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7903), "%" },
                    { 5, 10.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7904), "L/min" },
                    { 6, 26.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7906), "Celsius" },
                    { 7, 12.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7908), "L/min" },
                    { 8, 102000m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7910), "Pascal" },
                    { 9, 50.0m, "Humidity", "Normal", 4, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7911), "%" },
                    { 10, 0.2m, "Radiation", "Normal", 3, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7913), "mSv/h" },
                    { 11, 101500m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7915), "Pascal" },
                    { 12, 101800m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7981), "Pascal" },
                    { 13, 27.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7983), "Celsius" },
                    { 14, 15.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7985), "L/min" },
                    { 15, 28.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7987), "Celsius" },
                    { 16, 18.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7989), "L/min" },
                    { 17, 29.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7991), "Celsius" },
                    { 18, 102500m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7992), "Pascal" },
                    { 19, 0.3m, "Radiation", "Normal", 3, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7994), "mSv/h" },
                    { 20, 55.0m, "Humidity", "Normal", 4, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7996), "%" },
                    { 21, 20.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7998), "L/min" },
                    { 22, 30.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(7999), "Celsius" },
                    { 23, 22.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8001), "L/min" },
                    { 24, 103000m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8003), "Pascal" },
                    { 25, 60.0m, "Humidity", "Normal", 4, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8004), "%" },
                    { 26, 0.4m, "Radiation", "Normal", 3, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8006), "mSv/h" },
                    { 27, 103500m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8008), "Pascal" },
                    { 28, 104000m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8009), "Pascal" },
                    { 29, 31.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8011), "Celsius" },
                    { 30, 25.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8013), "L/min" },
                    { 31, 25.5m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8015), "Celsius" },
                    { 32, 101325m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8016), "Pascal" },
                    { 33, 0.1m, "Radiation", "Normal", 3, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8018), "mSv/h" },
                    { 34, 45.0m, "Humidity", "Normal", 4, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8020), "%" },
                    { 35, 10.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8021), "L/min" },
                    { 36, 26.0m, "Temperature", "Normal", 1, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8023), "Celsius" },
                    { 37, 12.0m, "Flow", "Normal", 5, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8025), "L/min" },
                    { 38, 102000m, "Pressure", "Normal", 2, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8027), "Pascal" },
                    { 39, 50.0m, "Humidity", "Normal", 4, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8028), "%" },
                    { 40, 0.2m, "Radiation", "Normal", 3, new DateTime(2025, 4, 29, 18, 15, 1, 713, DateTimeKind.Utc).AddTicks(8030), "mSv/h" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SensorData",
                keyColumn: "SensorDataId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "SensorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "SensorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "SensorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "SensorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "SensorId",
                keyValue: 5);

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    MasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.MasterId);
                });

            migrationBuilder.CreateTable(
                name: "Slaves",
                columns: table => new
                {
                    SlaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    SlaveName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slaves", x => x.SlaveId);
                    table.ForeignKey(
                        name: "FK_Slaves_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "MasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sensors_SlaveId",
                table: "Sensors",
                column: "SlaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Slaves_MasterId",
                table: "Slaves",
                column: "MasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sensors_Slaves_SlaveId",
                table: "Sensors",
                column: "SlaveId",
                principalTable: "Slaves",
                principalColumn: "SlaveId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
