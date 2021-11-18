using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Interfaces
{
	public interface IAccountService
	{
		Task<Account> AddAccountAsync(Account account);
	}
}
