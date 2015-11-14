namespace CashManager.DOMAIN.Models
{
    public enum OrderType
    {
        CashIn = 1,
        CashOut = 2,
        Chargeback = 3,
        CheckBalanceIn = 4,
        CheckBalanceOut = 5,
        BalanceDepletion = 6,
    }
}