using System;
using System.Collections.Generic;

namespace CashManager.DOMAIN.Entities
{
    public class Order
    {
        public long OrderId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public OrderType OrderType { get; set; }
        public double Price { get; set; }
        public long UserAuthorizingId { get; set; }
        public long UserId { get; set; }
        public long SessionId { get; set; }
        public virtual User User { get; set; }
        public virtual User UserAuthorizing { get; set; }
        public virtual Session Session { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}