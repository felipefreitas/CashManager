using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashManager.DOMAIN.Models
{
    public class User
    {
        public long UserId { get; set; }
        public UserType UserType { get; set; }
        public string Identifier { get; set; }
        public string Password { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
