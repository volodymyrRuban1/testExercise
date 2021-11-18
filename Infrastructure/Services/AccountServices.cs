using System;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	class AccountServices : IAccountService
	{
		private readonly IRepository<Account> _accountRepository;

		public AccountServices(IRepository<Account> accountRepository)
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
