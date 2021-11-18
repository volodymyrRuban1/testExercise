using System.Threading;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	class ContactServices : IContactService
	{
		private readonly IRepository<Contact> _contactRepository;
		public ContactServices(IRepository<Contact> contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task<Contact> AddContactAsync(Contact contact)
		{
			var newContact = await _contactRepository.AddSync(contact);
			return contact;
		}
	}
}