using EJ2.Domain;

namespace EJ2.DAL.EntityFramework
{
    class ClientRepository : EFRepository<Client, AccountManagerDbContext>, IClientRepository
    {
        public ClientRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }
    }
}
