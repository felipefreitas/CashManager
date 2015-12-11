using CashManager.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManager.APPLICATION.Services.Interfaces
{
    public interface ITransactionEngine
    {
        Transaction CreateTransaction(Order order, TransactionType transactionType, BillingMethod billingMethod, double price, Transaction transactionReference = null);
        Transaction CreateTransaction(Order order, TransactionType transactionType, double price, Transaction transactionReference = null);
        Transaction ExecuteTransaction(Transaction transaction);
        Transaction CancelTransaction(Transaction transaction);
        Transaction ChargebackTransaction(Transaction transaction);
    }
}
