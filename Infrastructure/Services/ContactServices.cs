using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	public class ContactService : IContactService
	{
		private readonly IContactRepository _contactRepository;
		public ContactService(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task<Contact> AddContactAsync(Contact contact)
		{
				if (await IsContactExistAsync(contact))
				{
					return await ModifyContact(contact);
				}

				var newContact = await _contactRepository.AddAsync(contact);
				await _contactRepository.SaveChangesAsync();
				return newContact;
		}

		private async Task<bool> IsContactExistAsync(Contact contact)
		{
			var result = await _contactRepository.FindContactByEmailAsync(contact.Email);

			if (result is null)
				return false;

			return true;
		}

		private async Task<Contact> ModifyContact(Contact contact)
		{
			var result = await _contactRepository.FindContactByEmailAsync(contact.Email);

			result.FirstName = contact.FirstName;
			result.LastName = contact.LastName;

			await _contactRepository.SaveChangesAsync();

			return result;
		}

		private async Task<bool> IsAccountExistsAsync(Contact contact)
		{
			return await _contactRepository.FindAccountByIdAsync(contact.AccountId) is not null;
		}
	}
}