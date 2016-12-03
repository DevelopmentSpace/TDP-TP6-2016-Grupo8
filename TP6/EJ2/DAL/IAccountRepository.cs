using EJ2.Domain;
using System.Collections.Generic;

namespace EJ2.DAL
{
    /// <summary>
    /// Interface correspondiente al repositorio de Cuentas
    /// </summary>
    interface IAccountRepository : IRepository<Account>
    {
        /// <summary>
        /// Obtiene el balance de una cuenta
        /// </summary>
        /// <param name="pAccount">Cuenta</param>
        /// <returns>Valor del balance</returns>
        double GetAccountBalance(Account pAccount);

        /// <summary>
        /// Obtiene todas las cuentas con saldo negativo y que superan el limite de descubierto
        /// </summary>
        /// <returns>Lista de cuentas</returns>
        IEnumerable<Account> GetOverdrawnAccounts();

        /// <summary>
        /// Obtiene los ultimos movimientos de una cuenta
        /// </summary>
        /// <param name="pAccount">Cuenta</param>
        /// <param name="pCount">Cantidad de movimientos</param>
        /// <returns>Lista de movimientos</returns>
        IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7);

    }
}
