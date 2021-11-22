using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Application.Services;
using ContactProj.Domain.Entities;
using ContactProj.Domain.FluentValidation;
using ContactProj.Infrastructure.Repository;
using ContactProj.Infrastructure.Services;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IAccountService = ContactProj.Application.Interfaces.IAccountService;
using IContactService = ContactProj.Application.Interfaces.IContactService;
using IIncidentService = ContactProj.Application.Interfaces.IIncidentService;
using AutoMapper;

namespace ContactProj.Infrastructure
{
	public static class DependencyInjection	
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IAccountService, AccountServices>();
			services.AddScoped<IContactService, ContactService>();
			services.AddScoped<IIncidentService, IncidentServices>();
			//services.AddScoped<ICaseService, CaseServices>();
			services.AddAutoMapper(typeof(Application.Mapper.AccountMapper));
			services.AddAutoMapper(typeof(Application.Mapper.ContactMapper));

			services.AddScoped<IAccountRepository, AccountRepository>();
			services.AddScoped<IContactRepository, ContactRepository>();
			services.AddScoped<IIncidentRepository, IncidentRepository>();

			services.AddScoped<IValidator<Incident>, IncidentValidator>();
			services.AddScoped<IValidator<Account>, AccountValidator>();
			services.AddScoped<IValidator<Contact>, ContactValidator>();

			return services;
		}
	}
}
