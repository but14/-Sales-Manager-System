using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Configuration;
using QLBH.Models; //truy xuất đến các lớp: Customer,…

namespace QLBH
{
    internal class EFDbContext : DbContext
    {
     
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }


        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<EFDbContext>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<OrderDetail>().HasKey("OrderDetailID");
            modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderID, o.ProductID });
            modelBuilder.Entity<Employee>().HasData(
    new Employee { EmployeeID = 1, Name = "Lý Chiều Tà", Gender = false, BirthDay = DateTime.Parse("1990-01-25"), Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh", Phone = "0133456789", Status = true, Email = "talychieu@gmail.com", Password = "111", RoleID = 0 },
    new Employee { EmployeeID = 2, Name = "Trần Văn Hà", Gender = true, BirthDay = DateTime.Parse("2000-11-20"), Address = "1110 Lê Thái Tổ, P1, Q2, TP. Hồ Chí Minh", Phone = "0973456789", Status = true, Email = "hatranvan@gmail.com", Password = "111", RoleID = 1 },
    new Employee { EmployeeID = 3, Name = "Hoàng Dược Y Sư", Gender = null, BirthDay = DateTime.Parse("1980-05-15"), Address = "91/2A Trần Quốc Toản, P4, Q5, TP. Hồ Chí Minh", Phone = "0823456789", Status = true, Email = "suhoangduocy@gmail.com", Password = "111", RoleID = 2 },
    new Employee { EmployeeID = 4, Name = "Cao Thu Trúc", Gender = false, BirthDay = DateTime.Parse("1991-07-09"), Address = "34212 Nguyễn Trãi, P1, Tân An, Long An", Phone = "0623456789", Status = true, Email = "truccaothu@gmail.com", Password = "111", RoleID = 2 },
    new Employee { EmployeeID = 5, Name = "Nguyễn An An", Gender = false, BirthDay = DateTime.Parse("1982-03-04"), Address = "567/81 Nguyễn ĐÌnh Chiểu, P6, Gò Dầu, Tây Ninh", Phone = "0923456789", Status = true, Email = "annguyenan@gmail.com", Password = "111", RoleID = 3 }
);


            modelBuilder.Entity<Customer>(
            c =>
            {
                c.Property(b => b.Address)
           .HasColumnType("nvarchar(250)").IsRequired();
                c.Property(b => b.BirthDay).HasColumnType("date");
            });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    Name = "Lý Qua Cầu",
                    Gender = false,
                    BirthDay = DateTime.Parse("1990-01-25"),
                    Address = "111/2 Lê Lợi, P5, Q1, TP. Hồ Chí Minh",
                    Phone = "0123456789",
                    Status = true,
                    Email = "caulyqua@gmail.com"
                }, new Customer
                {
                    CustomerID = 2,
                    Name = "Trần Văn Sơn",
                    Gender = true,
                    BirthDay = DateTime.Parse("2000-11-20"),
                    Address = "2/10 Lý Thái Tổ, P1, Q2, TP. Hồ ChíM inh",
                    Phone = "0923456789",
                    Status = true,
                    Email = "sontranvan@gmail.com"
                }, new Customer
                {
                    CustomerID = 3,
                    Name = "Hoàng Dược Thảo Mộc",
                    Gender= null,
                    BirthDay = DateTime.Parse("1980-05-15"),
                    Address = "9/2 Hoàng Diệu, P4, Q5, TP.Hồ Chí Minh",
                    Phone = "0723456789",
                    Status = true,
                    Email = "mochoangduocthao@gmail.com"
                },
                new Customer
                {
                    CustomerID = 4,
                    Name = "Cao Thu Trang",
                    Gender = false,
                    BirthDay = DateTime.Parse("1991-07-09"),
                    Address = "666/3 Nguyễn Trãi, P1, Tân An,Long An",
                    Phone = "0623456789",
                    Status = true,
                    Email = "trangcaothu@gmail.com"
                }, new Customer
                {
                    CustomerID = 5,
                    Name = "Nguyễn Kiểu",
                    Gender = false,
                    BirthDay = DateTime.Parse("1982-03-04"),
                    Address = "466/3 Nguyễn Du, P6, Gò Dầu, Tây Ninh",
                    Phone = "0823456789",
                    Status = true,
                    Email = "kieunguyen@gmail.com"
                });
            modelBuilder.Entity<Category>().HasData(
 new Category { CategoryID = 1, Name = "Laptop", Order = 1, Status = true },
 new Category { CategoryID = 2, Name = "Màn hình", Order = 4, Status = true },
 new Category { CategoryID = 3, Name = "Chuột", Order = 2, Status = true },
 new Category { CategoryID = 4, Name = "Bàn phím", Order = 3, Status = true });
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductID = 1,
                Name = "Laptop ToBaShi 12N4",
                Quantity = 0,
                Price = 150.50M,
                MarketPrice
           = null,
                Description = "Chơi game tốt",
                ImageFile = "1.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 2,
                Name = "Laptop ShiBaCo N4T0",
                Quantity = 15,
                Price = 250.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "2.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 3,
                Name = "Lapto ToBaShi 12N5",
                Quantity = 14,
                Price = 180.50M,
                MarketPrice
           = null,
                Description = "Chơi game tốt",
                ImageFile = "3.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 4,
                Name = "Laptop ShiBaCo N4T1",
                Quantity = 13,
                Price = 250.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "4.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 5,
                Name = "Laptop ToBaShi 12N6",
                Quantity = 20,
                Price = 350.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "5.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 6,
                Name = "Laptop ShiBaCo N4T2",
                Quantity = 40,
                Price = 380.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "6.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 7,
                Name = "Laptop ToBaShi 12N7",
                Quantity = 29,
                Price = 280.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "7.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 8,
                Name = "Laptop ShiBaCo N4T3",
                Quantity = 30,
                Price = 450.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "8.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 9,
                Name = "Laptop ToBaShi 12N8",
                Quantity = 15,
                Price = 380.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "9.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 10,
                Name = "Laptop ShiBaCo N4T4",
                Quantity = 50,
                Price = 550.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "10.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 11,
                Name = "Laptop ToBaShi 12N9",
                Quantity = 60,
                Price = 450.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "11.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 12,
                Name = "Laptop ShiBaCo N4T5",
                Quantity = 40,
                Price = 650.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "12.png",
                Status = true,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 13,
                Name = "Màn hình ToBaShi 12N4",
                Quantity = 4,
                Price = 50.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "13.png",
                Status = true,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 14,
                Name = "Màn hình ShiBaCo N4T0",
                Quantity = 12,
                Price = 60.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "14.png",
                Status = true,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 15,
                Name = "Màn hình ToBaShi 12N5",
                Quantity = 15,
                Price = 60.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "15.png",
                Status = true,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 16,
                Name = "Màn hình ShiBaCo N4T1",
                Quantity = 14,
                Price = 70.50M,
                MarketPrice = null,
                Description = "Xử lý đồ họa tốt",
                ImageFile = "16.png",
                Status = true,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 17,
                Name = "Màn hình ToBaShi 12N6",
                Quantity = 26,
                Price = 70.50M,
                MarketPrice = null,
                Description = "Chơi game tốt",
                ImageFile = "17.png",
                Status = true,
                CategoryID = 2
            },
 new Product
 {
     ProductID = 18,
     Name = "Màn hình ShiBaCo N4T2",
     Quantity = 30,
     Price = 80.50M,
     MarketPrice = null,
     Description = "Xử lý đồ họa tốt",
     ImageFile = "18.png",
     Status = true,
     CategoryID = 2
 },
 new Product
 {
     ProductID = 19,
     Name = "Màn hình ToBaShi 12N7",
     Quantity = 12,
     Price = 80.50M,
     MarketPrice = null,
     Description = "Chơi game tốt",
     ImageFile = "19.png",
     Status = true,
     CategoryID = 2
 },
 new Product
 {
     ProductID = 20,
     Name = "Màn hình ShiBaCo N4T3",
     Quantity = 10,
     Price = 90.50M,
     MarketPrice = null,
     Description = "Xử lý đồ họa tốt",
     ImageFile = "20.png",
     Status = true,
     CategoryID = 2
 },
 new Product
 {
     ProductID = 21,
     Name = "Màn hình ToBaShi 12N8",
     Quantity = 12,
     Price = 100.50M,
     MarketPrice = null,
     Description = "Chơi game tốt",
     ImageFile = "21.png",
     Status = true,
     CategoryID = 2
 },
 new Product
 {
     ProductID = 22,
     Name = "Màn hình ShiBaCo N4T4",
     Quantity = 12,
     Price = 110.50M,
     MarketPrice = null,
     Description = "Xử lý đồ họa tốt",
     ImageFile = "22.png",
     Status = true,
     CategoryID = 2
 },
 new Product
 {
     ProductID = 23,
     Name = "Màn hình ToBaShi 12N9",
     Quantity = 11,
     Price = 110.50M,
     MarketPrice = null,
     Description = "Chơi game tốt",
     ImageFile = "23.png",
     Status = true,
     CategoryID = 2
 },
 new Product
 {
     ProductID = 24,
     Name = "Màn hình ShiBaCo N4T5",
     Quantity = 5,
     Price = 120.00M,
     MarketPrice = null,
     Description = "Xử lý đồ họa tốt",
     ImageFile = "24.png",
     Status = true,
     CategoryID = 2
 });
            modelBuilder.Entity<Progress>().HasData(
        new Progress { ProgressID = 1, Name = "New" },
        new Progress { ProgressID = 2, Name = "Processing" },
        new Progress { ProgressID = 3, Name = "Shipping" },
        new Progress { ProgressID = 4, Name = "Canceled" },
        new Progress { ProgressID = 5, Name = "Instalment" },
        new Progress { ProgressID = 6, Name = "Failed" },
        new Progress { ProgressID = 7, Name = "Completed" });
            modelBuilder.Entity<Order>().HasData(
         new Order
         {
             OrderID = 1,
             OrderDate = DateTime.Parse("2016-11-25"),
             OrderTime = TimeSpan.Parse("16:18:30"),
             ReceiveDate = DateTime.Parse("2016-11-26"),
             ReceiveTime = TimeSpan.Parse("08:30:00"),
             ReceiveAddress = "1Z Cao Thắng, P1, Q1,TPHCM",
             ProgressID = 7,
             CustomerID = 1,
             EmployeeID = 1
         },
        new Order
    {
    OrderID = 2,
    OrderDate = DateTime.Parse("2016-12-25"),
    OrderTime = TimeSpan.Parse("16:40:50"),
    ReceiveDate = DateTime.Parse("2016-12-26"),
    ReceiveTime = TimeSpan.Parse("09:00:00"),
    ReceiveAddress = "123N Lê Lai, P7,QPN, TPHCM",
    ProgressID = 7,
    CustomerID = 2,
    EmployeeID = 2
},
      new Order
   {
    OrderID = 3,
    OrderDate = DateTime.Parse("2016-12-25"),
    OrderTime = TimeSpan.Parse("17:19:12"),
    ReceiveDate = DateTime.Parse("2016-12-26"),
    ReceiveTime = TimeSpan.Parse("09:00:00"),
    ReceiveAddress = "345G Lê Lợi, P4, Q1, TP Mỹ Tho, Tiền Giang",
    ProgressID = 6,
    CustomerID = 3,
    EmployeeID = 1
},
    new Order
{
    OrderID = 4,
    OrderDate = DateTime.Parse("2017-01-13"),
    OrderTime = TimeSpan.Parse("07:42:19"),
    ReceiveDate = DateTime.Parse("2017-01-13"),
    ReceiveTime = TimeSpan.Parse("10:00:00"),
    ReceiveAddress = "1B Lý Thái Tổ, P2, TPHCM",
    ProgressID = 1,
    CustomerID = 4,
    EmployeeID = 2
}


                );
          

        }


    }




}
