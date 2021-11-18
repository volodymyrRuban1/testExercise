using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	public class AccountServices : IAccountService
	{
		private readonly IAccountRepository _accountRepository;

		public AccountServices(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}

		public async Task<Account> AddAccountAsync(Account account)
		{
			var newAccount = await _accountRepository.AddSync(account);
			return newAccount;
		}
	}
}
