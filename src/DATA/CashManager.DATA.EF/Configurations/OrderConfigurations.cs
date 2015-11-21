using System.Data.Entity.ModelConfiguration;

namespace CashManager.DATA.EntityFramework.Configurations
{
    public class OrderConfigurations : EntityTypeConfiguration<DOMAIN.Entities.Order>
    {
        public OrderConfigurations()
        {
            HasKey(o => o.OrderId);

            Property(o => o.Created)
                .IsRequired();

            Property(o => o.Updated)
                .IsRequired();

            Property(o => o.OrderType)
                .IsRequired();

            Property(o => o.Price)
                .IsRequired();

            HasMany(o => o.Transactions)
                .WithRequired(t => t.Order);

            HasRequired(o => o.User);

            HasOptional(o => o.UserAuthorizing);
        }
    }
}
