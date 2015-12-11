using System;

namespace CashManager.DOMAIN.Entities
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public BillingMethod BillingMethod { get; set; }
        public double Price { get; set; }
        public long TransactionReferenceId { get; set; }
        public long UserId { get; set; }
        public long OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Transaction TransactionReference { get; set; }
        public virtual User User { get; set; }
    }
}
