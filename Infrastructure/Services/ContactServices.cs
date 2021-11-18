using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Services
{
	class ContactServices : IContactService
	{
		public Task<bool> AddContactAsync(Contact contact)
		{
			throw new System.NotImplementedException();
		}
	}
}