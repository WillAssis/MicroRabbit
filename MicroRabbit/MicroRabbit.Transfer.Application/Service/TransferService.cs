using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interface;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Service
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository transferRepository;
        private readonly IEventBus bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            this.transferRepository = transferRepository;
            this.bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferRepository.GetTransferLogs();
        }
    }
}
