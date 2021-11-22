using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ContactsProj.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class IncidentController : Controller
	{
		private readonly IIncidentService _incidentService;

		public IncidentController(IIncidentService incidentService)
		{
			_incidentService = incidentService;
		}

		/// <summary>
		/// Creates incident
		/// </summary>
		/// <param name="incident"></param>
		/// <returns>Created incident</returns>
		[HttpPost]
		public async Task<IActionResult> CreateIncident(Incident incident)
		{
			return Ok(await _incidentService.AddIncidentAsync(incident));
		}

	}
}
