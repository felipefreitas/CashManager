using System;
using System.Collections.Generic;

namespace CashManager.DOMAIN.Entities
{
    public class Session
    {
        public long SessionId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public long UserId { get; set; }
        public SessionStatus SessionStatus { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}