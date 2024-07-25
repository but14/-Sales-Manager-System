using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        public virtual Employee Employee { get; set; }

        public long OrderID { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }

        public TimeSpan OrderTime { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? ReceiveDate { get; set; }

        public TimeSpan? ReceiveTime { get; set; }

        [StringLength(250)]
        public string ReceiveAddress { get; set; }

        [ForeignKey("ProgressID")]
        public int ProgressID { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }

        [ForeignKey("EmployeeID")]
        public long EmployeeID { get; set; }

        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }

        [InverseProperty("Orders")]
        public virtual Progress Progress { get; set; }

       
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
    }
