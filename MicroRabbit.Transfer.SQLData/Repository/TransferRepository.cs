
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.TransferData.Context;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{

    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDBContext _context;

        public TransferRepository(TransferDBContext context)
        {
            _context = context;
        }

        public void Add(TransferLog transferLog)
        {
            _context.TransferLogs.Add(transferLog);
            _context.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }
    }
}
