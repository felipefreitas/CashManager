using System;
using System.Collections.Generic;

namespace CashManager.DOMAIN.Entities
{
    public class User
    {
        public long UserId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public UserType UserType { get; set; }
        public string Identifier { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
