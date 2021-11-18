using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	class IncidentServices : IIncidentService
	{
		public Task<bool> AddInicidentAsync(Incident incident)
		{
			throw new System.NotImplementedException();
		}
	}
}
