using System;
using System.Collections.Generic;

namespace CashManager.DOMAIN.Models
{
    public class Session
    {
        public long SessionId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public SessionStatus SessionStatus { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}