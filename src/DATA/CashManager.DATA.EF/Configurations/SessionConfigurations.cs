using System.Data.Entity.ModelConfiguration;

namespace CashManager.DATA.EntityFramework.Configurations
{
    public class SessionConfigurations : EntityTypeConfiguration<DOMAIN.Entities.Session>
    {
        public SessionConfigurations()
        {
            HasKey(s => s.SessionId);

            Property(s => s.SessionStatus)
                .IsRequired();

            Property(s => s.Created)
                .IsRequired();

            Property(s => s.Updated)
                .IsRequired();

            HasMany(s => s.Orders)
                .WithRequired(o => o.Session);

            HasRequired(s => s.User);
        }
    }
}
