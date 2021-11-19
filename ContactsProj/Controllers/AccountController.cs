using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactsProj.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AccountController : Controller
	{
		private IAccountService _accountService;

		public AccountController(IAccountService accountService)
		{
			_accountService = accountService;
		}

		[HttpPost]
		public async Task<IActionResult> CreateAccount([FromBody]Account account)
		{
			return Ok(await _accountService.AddAccountAsync(account));
		}
	}
}
