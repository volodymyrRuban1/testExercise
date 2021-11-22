using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProj.Application.Models;
using ContactProj.Application.Services;

namespace ContactsProj.WebApi.Controllers
{
	public class CaseController : Controller
	{
		private readonly ICaseService _caseService;
		public CaseController(ICaseService caseService)
		{
			_caseService = caseService;
		}

		public async Task<IActionResult> CreateCase(CaseModel caseModel)
		{
			var newCaseModel = await _caseService.CreateCaseAsync(caseModel) ;
			return newCaseModel is null ? NotFound() : Ok(newCaseModel);
		}
	}
}
