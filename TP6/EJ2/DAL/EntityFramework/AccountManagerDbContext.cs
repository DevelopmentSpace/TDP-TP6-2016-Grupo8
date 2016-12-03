using EJ2.DAL.EntityFramework.Mappings;
using EJ2.Domain;
using System.Data.Entity;

namespace EJ2.DAL.EntityFramework
{
    /// <summary>
    /// Especifica el contexto para almacenar Clientes, Cuentas y sus movimientos.
    /// </summary>
    internal class AccountManagerDbContext : DbContext
    {
        /// <summary>
        /// DbSet para Clientes
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// DbSet para Cuentas
        /// </summary>
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// DbSet para Movimientos de cuentas
        /// </summary>
        public DbSet<AccountMovement> AccountMovements { get; set; }

        /// <summary>
        /// Constrcutor
        /// </summary>
        public AccountManagerDbContext() : base("AccountManagerContext")
        {
            // Se establece la estrategia personalizada de inicialización de la BBDD.
            Database.SetInitializer<AccountManagerDbContext>(new DatabaseInitializationStrategy());
        }

        /// <summary>
        /// Sustitucion del metodo OnModelCreating
        /// </summary>
        /// <param name="pModelBuilder">Model builder</param>
        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.Add(new ClientMap());
            pModelBuilder.Configurations.Add(new AccountMap());
            pModelBuilder.Configurations.Add(new AccountMovementMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}