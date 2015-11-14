using System.Collections.Generic;

namespace CashManager.DOMAIN.Models
{
    public class Order
    {
        public long OrderId { get; set; }
        public OrderType OrderType { get; set; }
        public double Price { get; set; }
        public long UserAuthorizingId { get; set; }
        public long UserId { get; set; }
        public long SessionId { get; set; }
        public User User { get; set; }
        public User UserAuthorizing { get; set; }
        public Session Session { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}