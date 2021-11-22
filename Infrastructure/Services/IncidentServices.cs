using System.Threading.Tasks;
using ContactProj.Application.ServicesInterfaces;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	public class IncidentServices : IIncidentService
	{
		private readonly IIncidentRepository _incidentRepository;

		public IncidentServices(IIncidentRepository incidentRepository)
		{
			_incidentRepository = incidentRepository;
		}

		public async Task<Incident> AddIncidentAsync(Incident incident)
		{
			var newIncident = await _incidentRepository.AddAsync(incident);
			await _incidentRepository.SaveChangesAsync();
			return newIncident;
		}
	}
}
