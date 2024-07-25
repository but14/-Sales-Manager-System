using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7L);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Employees",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "RoleID",
                table: "Employees",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Password", "Phone", "RoleID" },
                values: new object[] { "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh", new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "talychieu@gmail.com", false, "Lý Chiều Tà", "111", "0133456789", (byte)0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Password", "Phone", "RoleID" },
                values: new object[] { "1110 Lê Thái Tổ, P1, Q2, TP. Hồ Chí Minh", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "hatranvan@gmail.com", true, "Trần Văn Hà", "111", "0973456789", (byte)1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Password", "Phone", "RoleID" },
                values: new object[] { "91/2A Trần Quốc Toản, P4, Q5, TP. Hồ Chí Minh", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "suhoangduocy@gmail.com", null, "Hoàng Dược Y Sư", "111", "0823456789", (byte)2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4L,
                columns: new[] { "Address", "BirthDay", "Email", "Name", "Password", "Phone", "RoleID" },
                values: new object[] { "34212 Nguyễn Trãi, P1, Tân An, Long An", new DateTime(1991, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "truccaothu@gmail.com", "Cao Thu Trúc", "111", "0623456789", (byte)2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Password", "Phone", "RoleID" },
                values: new object[] { "567/81 Nguyễn ĐÌnh Chiểu, P6, Gò Dầu, Tây Ninh", new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "annguyenan@gmail.com", false, "Nguyễn An An", "111", "0923456789", (byte)3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Employees",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Phone" },
                values: new object[] { "123 Main St, City, Country", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "John Doe", "0123456789" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Phone" },
                values: new object[] { "456 Elm St, City, Country", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", false, "Jane Smith", "9876543210" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Phone" },
                values: new object[] { "789 Oak St, City, Country", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.johnson@example.com", true, "Michael Johnson", "5551234567" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4L,
                columns: new[] { "Address", "BirthDay", "Email", "Name", "Phone" },
                values: new object[] { "101 Pine St, City, Country", new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.brown@example.com", "Emily Brown", "5559876543" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5L,
                columns: new[] { "Address", "BirthDay", "Email", "Gender", "Name", "Phone" },
                values: new object[] { "202 Maple St, City, Country", new DateTime(1995, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.wilson@example.com", true, "David Wilson", "5555551234" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "BirthDay", "Email", "Gender", "Name", "Phone", "Status" },
                values: new object[,]
                {
                    { 6L, "303 Cedar St, City, Country", new DateTime(1993, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.taylor@example.com", false, "Emma Taylor", "5555559876", true },
                    { 7L, "404 Birch St, City, Country", new DateTime(1991, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", "5554567890", true }
                });
        }
    }
}
