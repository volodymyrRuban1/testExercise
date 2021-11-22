using System.Threading.Tasks;
using ContactProj.Application.Dto;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Interfaces
{
	public interface IAccountService
	{
		Task<AccountCreationDto> AddAccountAsync(AccountCreationDto accountCreation);

		AccountCreationDto GetJsonTestAccount();
	}
}
