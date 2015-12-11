using System;
using System.Threading.Tasks;

namespace CashManager.DATA.EntityFramework.Context.Interfaces
{
    public interface IUnitOfWorkAsync : IDisposable
    {
        Task SaveAsync();
    }
}