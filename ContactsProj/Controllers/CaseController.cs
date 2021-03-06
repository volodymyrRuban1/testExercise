using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProj.Application.Models;
using ContactProj.Application.ServicesInterfaces;

namespace ContactsProj.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CaseController : Controller
	{
		private readonly ICaseService _caseService;
		public CaseController(ICaseService caseService)
		{
			_caseService = caseService;
		}

		/// <summary>
		/// Creates case, which includes incident, account and contact
		/// </summary>
		/// <param name="caseModel"></param>
		/// <returns>Created CaseModel</returns>
		[HttpPost]
		public async Task<IActionResult> CreateCase([FromBody]CaseModel caseModel)
		{
			var newCaseModel = await _caseService.CreateCaseAsync(caseModel) ;
			return newCaseModel is null ? NotFound() : Ok(newCaseModel);
		}
	}
}
