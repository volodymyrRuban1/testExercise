using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Services
{
	public interface IIncidentService
	{
		Task<Incident> AddIncidentAsync(Incident incident);
	}
}
