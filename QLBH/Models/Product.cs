using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }


        public long ProductID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MarketPrice { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string? ImageFile { get; set; }
        public bool Status { get; set; }
        [ForeignKey(nameof(Category))]
        public long CategoryID { get; set; }
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }

}
