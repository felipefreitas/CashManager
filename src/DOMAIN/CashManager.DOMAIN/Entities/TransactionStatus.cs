namespace CashManager.DOMAIN.Entities
{
    public enum TransactionStatus
    {
        Pending = 0,
        Authorized = 1,
        Finished = 2,
        Cancelled = 3,
        Failed = 4,
        Unauthorized = 5,
    }
}