using System.Data.Entity.ModelConfiguration;

namespace CashManager.DATA.EntityFramework.Configurations
{
    public class UserConfigurations : EntityTypeConfiguration<DOMAIN.Entities.User>
    {
        public UserConfigurations()
        {
            HasKey(u => u.UserId);

            Property(u => u.UserType)
                .IsRequired();

            Property(u => u.Identifier)
                .IsRequired()
                .HasMaxLength(250);

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(250);

            HasMany(u => u.Sessions)
                .WithRequired(s => s.User);
        }
    }
}
