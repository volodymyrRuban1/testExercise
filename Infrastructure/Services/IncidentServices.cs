using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	class IncidentServices : IIncidentService
	{
		private readonly IRepository<Incident> _incidentRepository;

		public IncidentServices(IRepository<Incident> incidentRepository)
		{
			_incidentRepository = incidentRepository;
		}

		public async Task<Incident> AddIncidentAsync(Incident incident)
		{
			var newIncident = await _incidentRepository.AddSync(incident);
			return newIncident;
		}
	}
}
