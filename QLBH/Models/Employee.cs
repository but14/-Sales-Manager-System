using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }

        public long EmployeeID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDay { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string? Email { get; set; }

        public bool Status { get; set; }

        [StringLength(6)]
        [Required]
        public string Password { get; set; }

        public byte RoleID { get; set; } // Đảm bảo thuộc tính RoleID được thêm vào

        internal virtual ICollection<Order> Orders { get; set; }
    }
}
