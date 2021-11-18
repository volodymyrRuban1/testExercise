using System.Threading.Tasks;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Interfaces
{
	public interface IContactService
	{
		Task<bool> AddContactAsync(Contact contact);
	}
}
