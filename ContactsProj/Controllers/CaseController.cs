using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactsProj.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CaseController : Controller
	{
		public CaseController()
		{

		}

		//public Task<IActionResult> CreateCase(Account account, Contact contact, Incident incident)
		//{
		//	return Ok();
		//}
		//public Task<IActionResult> CreateCase(string accountName, string contactFirstName,
		//	string lastLastName, string email, string description)
		//{
		//	return Ok();
		//}
	}
}
