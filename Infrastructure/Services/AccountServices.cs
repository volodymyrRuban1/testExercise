using System;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	class AccountServices : IAccountService
	{
		public Task<bool> AddAccountAsync(Account account)
		{
			throw new NotImplementedException();
		}
	}
}
