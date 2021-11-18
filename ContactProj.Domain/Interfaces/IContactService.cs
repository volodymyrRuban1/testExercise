using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Interfaces
{
	public interface IContactService
	{
		Task<Contact> AddContactAsync(Contact contact);
	}
}
