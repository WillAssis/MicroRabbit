using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private SqlContext context;

        public AccountRepository(SqlContext context)
        {
            this.context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return context.Accounts;
        }
    }
}
