using CashManager.APPLICATION.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashManager.DOMAIN.Entities;

namespace CashManager.APPLICATION.Services.Engines
{
    public class TransactionEngine : ITransactionEngine
    {
        public Transaction CancelTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction ChargebackTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction CreateTransaction(Order order, TransactionType transactionType, double price, Transaction transactionReference = null)
        {
            throw new NotImplementedException();
        }

        public Transaction CreateTransaction(Order order, TransactionType transactionType, BillingMethod billingMethod, double price, Transaction transactionReference = null)
        {
            throw new NotImplementedException();
        }

        public Transaction ExecuteTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
