using System;

namespace EJ2.DAL
{
    interface IUnitOfWork : IDisposable
    {

        IAccountRepository AccountRepository { get; }

        IClientRepository ClientRepository { get; }

        void Complete();

    }
}
