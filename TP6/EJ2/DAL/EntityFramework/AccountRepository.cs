using EJ2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EJ2.DAL.EntityFramework
{
    /// <summary>
    /// Implementacion del repositorio de cuentas
    /// </summary>
    class AccountRepository : EFRepository<Account, AccountManagerDbContext>, IAccountRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pContext">Contexto a utilizar</param>
        public AccountRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Obtiene el balance de una cuenta
        /// </summary>
        /// <param name="pAccount">Cuenta</param>
        /// <returns>Valor del balance</returns>
        public double GetAccountBalance(Account pAccount)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            return pAccount.Movements.Sum(pMovement => pMovement.Amount);
        }

        /// <summary>
        /// Obtiene los ultimos movimientos de una cuenta
        /// </summary>
        /// <param name="pAccount">Cuenta</param>
        /// <param name="pCount">Cantidad de movimientos</param>
        /// <returns>Lista de movimientos</returns>
        public IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            /*
             * La consulta que sigue estaba al reves
             * Cambiamos OrderBy por OrderByDescending 
             */
            return pAccount.Movements.OrderByDescending(pMovement => pMovement.Date).Take(pCount);

        }

        /// <summary>
        /// Obtiene todas las cuentas con saldo negativo y que superan el limite de descubierto
        /// </summary>
        /// <returns>Lista de cuentas</returns>
        public IEnumerable<Account> GetOverdrawnAccounts()
        {
            return from account in this.iDbContext.Set<Account>()
                   select new { Account = account, Balance = account.Movements.Sum(pMovement => pMovement.Amount) } into accountWithBalance
                   where accountWithBalance.Balance < 0 && Math.Abs(accountWithBalance.Balance) > accountWithBalance.Account.OverdraftLimit
                   select accountWithBalance.Account;
        }
    }
}
