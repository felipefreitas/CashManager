using CashManager.DOMAIN.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManager.DATA.EntityFramework.Context.Interfaces
{
    public interface ICashManagerDataContext : IUnitOfWorkAsync
    {
        IOrderRepository OrderRepository { get; set; }
        ISessionRepository SessionRepository { get; set; }
        ITransactionRepository TransactionRepository { get; set; }
        IUserRepository UserRepository { get; set; }
    }
}
