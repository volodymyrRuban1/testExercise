using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;
using ContactProj.Infrastructure.Repository;
using ContactProj.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ContactProj.Infrastructure
{
	public static class DependencyInjection	
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.TryAddScoped<IRepository<Account>, Repository<Account>>();
			services.TryAddScoped<IRepository<Account>, Repository<Account>>();
			services.TryAddScoped<IRepository<Account>, Repository<Account>>();

			services.TryAddTransient<IAccountService, AccountServices>();
			services.TryAddTransient<IContactService, ContactServices>();
			services.TryAddTransient<IIncidentService, IncidentServices>();

			return services;
		}
	}
}
