using CashManager.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManager.APPLICATION.Services.Interfaces
{
    public interface ISessionEngine
    {
        Session StartSession();
        Session FinishSession(Session session);
        Session RemoveSession(Session session);
    }
}
