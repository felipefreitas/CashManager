using System.Data.Entity.ModelConfiguration;

namespace CashManager.DATA.EntityFramework.Configurations
{
    public class TransactionConfigurations : EntityTypeConfiguration<DOMAIN.Entities.Transaction>
    {
        public TransactionConfigurations()
        {
            HasKey(t => t.TransactionId);

            Property(t => t.Created)
                .IsRequired();

            Property(t => t.Updated)
                .IsRequired();

            Property(t => t.TransactionType)
                .IsRequired();

            Property(t => t.BillingMethod)
                .IsRequired();

            Property(t => t.Price)
                .IsRequired();

            Property(t => t.TransactionStatus)
                .IsRequired();

            HasOptional(t => t.TransactionReference);

            HasRequired(t => t.Order)
                .WithMany(o => o.Transactions);

            HasRequired(t => t.User);
        }
    }
}
