using CashManager.DATA.EntityFramework.Configurations;
using CashManager.DATA.EntityFramework.Context.Interfaces;
using CashManager.DATA.EntityFramework.Repositories;
using CashManager.DOMAIN.Contracts;
using CashManager.DOMAIN.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace CashManager.DATA.EF.Context
{
    public sealed class ModelContext : DbContext, ICashManagerDataContext
    {
        #region Repositories
        public IOrderRepository OrderRepository { get; set; }
        public ISessionRepository SessionRepository { get; set; }
        public ITransactionRepository TransactionRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        #endregion

        #region DbSets
        IDbSet<Order> Order { get; set; }
        IDbSet<Transaction> Transaction { get; set; }
        IDbSet<Session> Session { get; set; }
        IDbSet<User> User { get; set; }
        #endregion

        #region Constructor
        public ModelContext()
            : base("CashManager")
        {
            Configuration.ValidateOnSaveEnabled = false;

            OrderRepository = new OrderRepository();
            SessionRepository = new SessionRepository();
            TransactionRepository = new TransactionRepository();
            UserRepository = new UserRepository();
        }

        public static ModelContext Create()
        {
            return new ModelContext();
        } 
        #endregion

        #region Configurations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new OrderConfigurations());
            modelBuilder.Configurations.Add(new SessionConfigurations());
            modelBuilder.Configurations.Add(new TransactionConfigurations());
            modelBuilder.Configurations.Add(new UserConfigurations());
        }

        public override Task<int> SaveChangesAsync ()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Created") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Created").CurrentValue = DateTimeOffset.UtcNow;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Created").IsModified = false;
                    entry.Property("Updated").CurrentValue = DateTimeOffset.UtcNow;
                }
            }
            return base.SaveChangesAsync();
        }

        public Task SaveAsync()
        {
            return SaveChangesAsync();
        }
        #endregion
    }
}
