using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Interfaces
{
	public interface IAccountService
	{
		Task<bool> AddAccountAsync(Account account);
	}
}
