using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey(nameof(OrderDetailID))]
    internal class OrderDetail
    {
        public long OrderDetailID;
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; } //nếu muốn bảng có cột này
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
