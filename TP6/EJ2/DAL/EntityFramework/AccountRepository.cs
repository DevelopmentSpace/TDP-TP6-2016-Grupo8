﻿using EJ2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EJ2.DAL.EntityFramework
{
    class AccountRepository : EFRepository<Account, AccountManagerDbContext>, IAccountRepository
    {
        public AccountRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }

        public double GetAccountBalance(Account pAccount)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            return pAccount.Movements.Sum(pMovement => pMovement.Amount);
        }

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

        public IEnumerable<Account> GetOverdrawnAccounts()
        {
            return from account in this.iDbContext.Set<Account>()
                   select new { Account = account, Balance = account.Movements.Sum(pMovement => pMovement.Amount) } into accountWithBalance
                   where accountWithBalance.Balance < 0 && Math.Abs(accountWithBalance.Balance) > accountWithBalance.Account.OverdraftLimit
                   select accountWithBalance.Account;
        }
    }
}
