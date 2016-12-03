using System;

namespace EJ2.DAL.EntityFramework
{
    /// <summary>
    /// Ìmplementacion del patron Unit of Work
    /// </summary>
    class UnitOfWork : IUnitOfWork
    {
        //Almacena el Contexto a utilizar en los repositorios
        private readonly AccountManagerDbContext iDbContext;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pContext">Contexto a utilizar en los repositorios</param>
        public UnitOfWork(AccountManagerDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
            this.ClientRepository = new ClientRepository(this.iDbContext);
            this.AccountRepository = new AccountRepository(this.iDbContext);
        }

        /// <summary>
        /// Repositorio de Cuentas
        /// </summary>
        public IAccountRepository AccountRepository
        {
            get; private set;
        }

        /// <summary>
        /// Repositorio de Clientes
        /// </summary>
        public IClientRepository ClientRepository
        {
            get; private set;
        }

        /// <summary>
        /// Metodo para persistir los cambios
        /// </summary>
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        /// <summary>
        /// Metodo para terminar la transaccion
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
