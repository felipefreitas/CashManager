using CashManager.APPLICATION.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashManager.DOMAIN.Entities;

namespace CashManager.APPLICATION.Services.Engines
{
    public sealed class SessionEngine : ISessionEngine
    {
        public Session FinishSession(Session session)
        {
            throw new NotImplementedException();
        }

        public Session RemoveSession(Session session)
        {
            throw new NotImplementedException();
        }

        public Session StartSession()
        {
            throw new NotImplementedException();
        }
    }
}
