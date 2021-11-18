using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	public class ContactServices : IContactService
	{
		private readonly IContactRepository _contactRepository;
		public ContactServices(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task<Contact> AddContactAsync(Contact contact)
		{
			if (await IsContactExist(contact))
			{
				return await ModifyContact(contact);
			}

			var newContact = await _contactRepository.AddSync(contact);
			await _contactRepository.SaveChangesAsync();
			return newContact;
		}

		private async Task<bool> IsContactExist(Contact contact)
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
			result.AccountId = contact.AccountId;

			await _contactRepository.SaveChangesAsync();

			return result;
		}
	}
}