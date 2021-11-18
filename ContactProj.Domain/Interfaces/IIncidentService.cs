using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Interfaces
{
	public interface IIncidentService
	{
		Task<bool> AddInicidentAsync(Incident incident);
	}
}
