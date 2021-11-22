using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactsProj.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ContactController : Controller
	{
		private readonly IContactService _contactService;
		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		/// <summary>
		/// Creates contact
		/// </summary>
		/// <param name="contact"></param>
		/// <returns>Created contact</returns>
		[HttpPost]
		public async Task<IActionResult> CreateContact([FromBody] Contact contact)
		{
			return Ok(await _contactService.AddContactAsync(contact));
		}
	}
}
