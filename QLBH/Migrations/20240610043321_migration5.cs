using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Progresses",
                columns: table => new
                {
                    ProgressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progresses", x => x.ProgressID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transaction_Customers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Transaction_Customers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    OrderTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ReceiveDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ReceiveTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ReceiveAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProgressID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Progresses_ProgressID",
                        column: x => x.ProgressID,
                        principalTable: "Progresses",
                        principalColumn: "ProgressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDetailID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name", "Order", "Status" },
                values: new object[,]
                {
                    { 1L, "Laptop", 1, true },
                    { 2L, "Màn hình", 4, true },
                    { 3L, "Chuột", 2, true },
                    { 4L, "Bàn phím", 3, true }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "BirthDay", "Email", "Gender", "Name", "Phone", "Status" },
                values: new object[,]
                {
                    { 1, "111/2 Lê Lợi, P5, Q1, TP. Hồ Chí Minh", new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "caulyqua@gmail.com", false, "Lý Qua Cầu", "0123456789", true },
                    { 2, "2/10 Lý Thái Tổ, P1, Q2, TP. Hồ ChíM inh", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "sontranvan@gmail.com", true, "Trần Văn Sơn", "0923456789", true },
                    { 3, "9/2 Hoàng Diệu, P4, Q5, TP.Hồ Chí Minh", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mochoangduocthao@gmail.com", null, "Hoàng Dược Thảo Mộc", "0723456789", true },
                    { 4, "666/3 Nguyễn Trãi, P1, Tân An,Long An", new DateTime(1991, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "trangcaothu@gmail.com", false, "Cao Thu Trang", "0623456789", true },
                    { 5, "466/3 Nguyễn Du, P6, Gò Dầu, Tây Ninh", new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "kieunguyen@gmail.com", false, "Nguyễn Kiểu", "0823456789", true }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "BirthDay", "Email", "Gender", "Name", "Phone", "Status" },
                values: new object[,]
                {
                    { 1L, "123 Main St, City, Country", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "John Doe", "0123456789", true },
                    { 2L, "456 Elm St, City, Country", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", false, "Jane Smith", "9876543210", true },
                    { 3L, "789 Oak St, City, Country", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.johnson@example.com", true, "Michael Johnson", "5551234567", true },
                    { 4L, "101 Pine St, City, Country", new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.brown@example.com", false, "Emily Brown", "5559876543", true },
                    { 5L, "202 Maple St, City, Country", new DateTime(1995, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.wilson@example.com", true, "David Wilson", "5555551234", true },
                    { 6L, "303 Cedar St, City, Country", new DateTime(1993, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.taylor@example.com", false, "Emma Taylor", "5555559876", true },
                    { 7L, "404 Birch St, City, Country", new DateTime(1991, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", "5554567890", true }
                });

            migrationBuilder.InsertData(
                table: "Progresses",
                columns: new[] { "ProgressID", "Name" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Processing" },
                    { 3, "Shipping" },
                    { 4, "Canceled" },
                    { 5, "Instalment" },
                    { 6, "Failed" },
                    { 7, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "OrderTime", "ProgressID", "ReceiveAddress", "ReceiveDate", "ReceiveTime" },
                values: new object[,]
                {
                    { 1L, 1, 1L, new DateTime(2016, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 18, 30, 0), 7, "1Z Cao Thắng, P1, Q1,TPHCM", new DateTime(2016, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 30, 0, 0) },
                    { 2L, 2, 2L, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 40, 50, 0), 7, "123N Lê Lai, P7,QPN, TPHCM", new DateTime(2016, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0) },
                    { 3L, 3, 1L, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 19, 12, 0), 6, "345G Lê Lợi, P4, Q1, TP Mỹ Tho, Tiền Giang", new DateTime(2016, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0) },
                    { 4L, 4, 2L, new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 42, 19, 0), 1, "1B Lý Thái Tổ, P2, TPHCM", new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageFile", "MarketPrice", "Name", "Price", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, "Chơi game tốt", "1.png", null, "Laptop ToBaShi 12N4", 150.50m, 0, true },
                    { 2L, 1L, "Xử lý đồ họa tốt", "2.png", null, "Laptop ShiBaCo N4T0", 250.50m, 15, true },
                    { 3L, 1L, "Chơi game tốt", "3.png", null, "Lapto ToBaShi 12N5", 180.50m, 14, true },
                    { 4L, 1L, "Xử lý đồ họa tốt", "4.png", null, "Laptop ShiBaCo N4T1", 250.50m, 13, true },
                    { 5L, 1L, "Chơi game tốt", "5.png", null, "Laptop ToBaShi 12N6", 350.50m, 20, true },
                    { 6L, 1L, "Xử lý đồ họa tốt", "6.png", null, "Laptop ShiBaCo N4T2", 380.50m, 40, true },
                    { 7L, 1L, "Chơi game tốt", "7.png", null, "Laptop ToBaShi 12N7", 280.50m, 29, true },
                    { 8L, 1L, "Xử lý đồ họa tốt", "8.png", null, "Laptop ShiBaCo N4T3", 450.50m, 30, true },
                    { 9L, 1L, "Chơi game tốt", "9.png", null, "Laptop ToBaShi 12N8", 380.50m, 15, true },
                    { 10L, 1L, "Xử lý đồ họa tốt", "10.png", null, "Laptop ShiBaCo N4T4", 550.50m, 50, true },
                    { 11L, 1L, "Chơi game tốt", "11.png", null, "Laptop ToBaShi 12N9", 450.50m, 60, true },
                    { 12L, 1L, "Xử lý đồ họa tốt", "12.png", null, "Laptop ShiBaCo N4T5", 650.50m, 40, true },
                    { 13L, 2L, "Chơi game tốt", "13.png", null, "Màn hình ToBaShi 12N4", 50.50m, 4, true },
                    { 14L, 2L, "Xử lý đồ họa tốt", "14.png", null, "Màn hình ShiBaCo N4T0", 60.50m, 12, true },
                    { 15L, 2L, "Chơi game tốt", "15.png", null, "Màn hình ToBaShi 12N5", 60.50m, 15, true },
                    { 16L, 2L, "Xử lý đồ họa tốt", "16.png", null, "Màn hình ShiBaCo N4T1", 70.50m, 14, true },
                    { 17L, 2L, "Chơi game tốt", "17.png", null, "Màn hình ToBaShi 12N6", 70.50m, 26, true },
                    { 18L, 2L, "Xử lý đồ họa tốt", "18.png", null, "Màn hình ShiBaCo N4T2", 80.50m, 30, true },
                    { 19L, 2L, "Chơi game tốt", "19.png", null, "Màn hình ToBaShi 12N7", 80.50m, 12, true },
                    { 20L, 2L, "Xử lý đồ họa tốt", "20.png", null, "Màn hình ShiBaCo N4T3", 90.50m, 10, true },
                    { 21L, 2L, "Chơi game tốt", "21.png", null, "Màn hình ToBaShi 12N8", 100.50m, 12, true },
                    { 22L, 2L, "Xử lý đồ họa tốt", "22.png", null, "Màn hình ShiBaCo N4T4", 110.50m, 12, true },
                    { 23L, 2L, "Chơi game tốt", "23.png", null, "Màn hình ToBaShi 12N9", 110.50m, 11, true },
                    { 24L, 2L, "Xử lý đồ họa tốt", "24.png", null, "Màn hình ShiBaCo N4T5", 120.00m, 5, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeID",
                table: "Orders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProgressID",
                table: "Orders",
                column: "ProgressID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ReceiverId",
                table: "Transaction",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_SenderId",
                table: "Transaction",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Progresses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
