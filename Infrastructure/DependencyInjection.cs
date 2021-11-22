using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Entities;
using ContactProj.Domain.FluentValidation;
using ContactProj.Infrastructure.Repository;
using ContactProj.Infrastructure.Services;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ContactProj.Application.ServicesInterfaces;
using ContactProj.Application.Mapping;

namespace ContactProj.Infrastructure
{
	public static class DependencyInjection	
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IAccountService, AccountServices>();
			services.AddScoped<IContactService, ContactServices>();
			services.AddScoped<IIncidentService, IncidentServices>();
			services.AddScoped<ICaseService, CaseServices>();

			services.AddAutoMapper(typeof(AccountMapper));
			services.AddAutoMapper(typeof(ContactMapper));
			services.AddAutoMapper(typeof(CaseMapper));

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
