using System;

namespace EJ2.DAL
{
    /// <summary>
    /// Interface correspondiente al patron Unidad de trabajo
    /// </summary>
    interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Repositorio de Cuentas
        /// </summary>
        IAccountRepository AccountRepository { get; }

        /// <summary>
        /// Repositorio de Clientes
        /// </summary>
        IClientRepository ClientRepository { get; }

        /// <summary>
        /// Metodo para persistir los cambios
        /// </summary>
        void Complete();

    }
}
