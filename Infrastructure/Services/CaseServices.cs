using System.Security;
using System.Threading.Tasks;
using AutoMapper;
using ContactProj.Application.Models;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Application.Services;
using ContactProj.Application.Dto;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	public class CaseServices : ICaseService
	{
		private readonly IAccountRepository _accountRepository;
		private readonly IContactRepository _contactRepository;
		private readonly IIncidentRepository _incidentRepository;
		private readonly IAccountService _accountService;
		private readonly IContactService _contactService;
		private readonly IIncidentService _incidentService;
		private readonly IMapper _mapper;

		public CaseServices(
			//IAccountRepository accountRepository, 
			//IContactRepository contactRepository, 
			//IIncidentRepository incidentRepository,
			IAccountService accountService,
			IContactService contactService,
			IIncidentService incidentService,
			IMapper mapper)
		{
			//_accountRepository = accountRepository;
			//_contactRepository = contactRepository;
			//_incidentRepository = incidentRepository;
			_accountService = accountService;
			_contactService = contactService;
			_incidentService = incidentService;
			_mapper = mapper;
		}
		
		public async Task<CaseModel> CreateCaseAsync (CaseModel caseDto)
		{
			var accountCreation = _mapper.Map<CaseModel, AccountCreationDto>(caseDto);
			if (accountCreation is null)
				return null;

			var incident = _mapper.Map<CaseModel, Incident>(caseDto);
			
			var resIncident = await _incidentRepository.AddAsync(incident);
			
			accountCreation.Account.IncidentName = incident.Name;

			var resAccountWithContact = await _accountService.AddAccountAsync(accountCreation);

			return new CaseModel()
			{
				Account = _mapper.Map<AccountCreationDto, Account>(resAccountWithContact),
				Contact = _mapper.Map<AccountCreationDto, Contact>(resAccountWithContact),
				Incident = resIncident
			};
		}
	}
}
