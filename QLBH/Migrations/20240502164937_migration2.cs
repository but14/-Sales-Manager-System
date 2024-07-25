using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "BirthDay", "Email", "Gender", "Name", "Phone", "Status" },
                values: new object[,]
                {
                    { 1L, "111/2 Lê Lợi, P5, Q1, TP. Hồ Chí Minh", new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "caulyqua@gmail.com", false, "Lý Qua Cầu", "0123456789", true },
                    { 2L, "2/10 Lý Thái Tổ, P1, Q2, TP. Hồ ChíM inh", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "sontranvan@gmail.com", true, "Trần Văn Sơn", "0923456789", true },
                    { 3L, "9/2 Hoàng Diệu, P4, Q5, TP.Hồ Chí Minh", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mochoangduocthao@gmail.com", null, "Hoàng Dược Thảo Mộc", "0723456789", true },
                    { 4L, "666/3 Nguyễn Trãi, P1, Tân An,Long An", new DateTime(1991, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "trangcaothu@gmail.com", false, "Cao Thu Trang", "0623456789", true },
                    { 5L, "466/3 Nguyễn Du, P6, Gò Dầu, Tây Ninh", new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "kieunguyen@gmail.com", false, "Nguyễn Kiểu", "0823456789", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5L);
        }
    }
}
