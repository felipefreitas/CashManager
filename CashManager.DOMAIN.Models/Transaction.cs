using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashManager.DOMAIN.Models
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public BillingMethod BillingPayment { get; set; }
        public double Price { get; set; }
        public long TransactionReferenceId { get; set; }
        public long UserId { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public Transaction TransactionReference { get; set; }
        public User User { get; set; }
    }
}
