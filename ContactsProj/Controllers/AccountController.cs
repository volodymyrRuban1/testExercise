using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ContactProj.Application.Dto;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactsProj.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AccountController : Controller
	{
		private readonly IAccountService _accountService;

		public AccountController(IAccountService accountService)
		{
			_accountService = accountService;
		}

		/// <summary>
		/// Created account with contact related to that contact
		/// </summary>
		/// <returns>Account with contact</returns>
		[HttpPost]
		public async Task<IActionResult> CreateAccount([FromBody]AccountCreationDto account)
		{
			return Ok(await _accountService.AddAccountAsync(account));
		}

		/// <summary>
		/// Temporary test method. Returns custom contact
		/// </summary>
		/// <returns>Account with contact</returns>
		[HttpGet]
		public IActionResult GetTestValues()
		{
			return Ok(_accountService.GetJsonTestAccount());
		}
	}
}
