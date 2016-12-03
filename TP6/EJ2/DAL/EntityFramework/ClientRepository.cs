using EJ2.Domain;

namespace EJ2.DAL.EntityFramework
{
    /// <summary>
    /// Implementacion del Repositorio de clientes
    /// </summary>
    class ClientRepository : EFRepository<Client, AccountManagerDbContext>, IClientRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pContext">Contexto a utilizar</param>
        public ClientRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }
    }
}
