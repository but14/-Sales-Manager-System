using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Progress
    {
        public Progress()
        {
            this.Orders = new HashSet<Order>();
        }

        public int ProgressID { get; set; }
        [Column(TypeName = "nchar(15)")]
        public string Name { get; set; }
        [InverseProperty("Progress")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

