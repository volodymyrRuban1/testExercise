using System.Threading.Tasks;
using ContactProj.Application.Dto;

namespace ContactProj.Application.Services
{
	public interface IAccountService
	{
		Task<AccountCreationDto> AddAccountAsync(AccountCreationDto accountCreation);

		AccountCreationDto GetJsonTestAccount();
	}
}
