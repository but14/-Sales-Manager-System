using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Transaction
    {
        public int TransactionId { get; set; }
        // Các thuộc tính khác nếu có
        [ForeignKey("Sender")]
        public int? SenderId { get; set; }
        [InverseProperty("SendedTransactions")]
        public Customer Sender { get; set; }
        [ForeignKey("Receiver")]
        public int? ReceiverId { get; set; }
        [InverseProperty("ReceivedTransactions")]
        public Customer Receiver { get; set; }
    }
}
