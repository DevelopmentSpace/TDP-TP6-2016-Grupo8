using EJ2.DAL.EntityFramework.Mappings;
using EJ2.Domain;
using System.Data.Entity;

namespace EJ2.DAL.EntityFramework
{
    internal class AccountManagerDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountMovement> AccountMovements { get; set; }

        public AccountManagerDbContext() : base("AccountManagerContext")
        {
            //Database.SetInitializer<AccountManagerDbContext>(new CreateDatabaseIfNotExists<AccountManagerDbContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseIfModelChanges<AccountManagerDbContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseAlways<AccountManagerDbContext>());

            // Se establece la estrategia personalizada de inicialización de la BBDD.
            Database.SetInitializer<AccountManagerDbContext>(new DatabaseInitializationStrategy());
        }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.Add(new ClientMap());
            pModelBuilder.Configurations.Add(new AccountMap());
            pModelBuilder.Configurations.Add(new AccountMovementMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}