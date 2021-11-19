using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Context;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Repository
{
	public class AccountRepository : Repository<Account>, IAccountRepository
	{
		public AccountRepository(ContactProjContext dbContext)
			:base(dbContext)
		{
		}

	}
}
