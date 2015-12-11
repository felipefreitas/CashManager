using CashManager.DOMAIN.Entities;

namespace CashManager.SECURITY.Service.Contracts
{
    public interface ISecurityContext
    {
        User CurrentUser { get; set; }
        Session CurrentSession { get; set; }
    }
}
