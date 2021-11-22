using System.Threading.Tasks;
using AutoMapper;
using ContactProj.Application.Dto;
using ContactProj.Application.ServicesInterfaces;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	public class AccountServices : IAccountService
	{
		private readonly IAccountRepository _accountRepository;
		private readonly IContactService _contactService;
		private readonly IMapper _mapper;

		public AccountServices(
			IAccountRepository accountRepository,
			IContactService contactService,
			IMapper mapper)
		{
			_accountRepository = accountRepository;
			_contactService = contactService;
			_mapper = mapper;
		}

		public async Task<AccountCreationDto> AddAccountAsync(AccountCreationDto accountCreation)
		{
			var account = _mapper.Map<AccountCreationDto, Account>(accountCreation);
			var contact = _mapper.Map<AccountCreationDto, Contact>(accountCreation);
			
			var newAccount = await _accountRepository.AddAsync(account);
			await _accountRepository.SaveChangesAsync();

			contact.AccountId = newAccount.Id;
			var newContact = await _contactService.AddContactAsync(contact);

			return new AccountCreationDto() {Account = newAccount, Contact = newContact};
		}

		/// <summary>
		/// Method for testing
		/// </summary>
		/// <returns>AccountCreationDto with custom params</returns>
		public AccountCreationDto GetJsonTestAccount()
		{
			var testRes = new AccountCreationDto()
			{
				Account = new Account() { Name = "Test1" },
				Contact = new Contact()
					{ FirstName = "TestName", LastName = "TestLastName", Email = "TestEmail1@gmail.com" }
			};

			return testRes;
		}
	}
}
