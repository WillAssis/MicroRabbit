using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private SqlContext context;

        public TransferRepository(SqlContext context)
        {
            this.context = context;
        }

        public void Add(TransferLog transferLog)
        {
            context.TransferLogs.Add(transferLog);
            context.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return context.TransferLogs;
        }
    }
}
