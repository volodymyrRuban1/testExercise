using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.ServicesInterfaces
{
	public interface IIncidentService
	{
		Task<Incident> AddIncidentAsync(Incident incident);
	}
}
