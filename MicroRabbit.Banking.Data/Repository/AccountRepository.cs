using MicroRabbit.Banking.SQLData.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.SQLData.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDBContext _dbContext;
        public AccountRepository(BankingDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts;
        }
    }
}
