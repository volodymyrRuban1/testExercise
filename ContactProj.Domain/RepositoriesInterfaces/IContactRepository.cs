using System;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.RepositoriesInterfaces
{
	public interface IContactRepository : IRepository<Contact>
	{
		Task<Contact> FindContactByEmailAsync(string email);

		Task<Contact> FindAccountByIdAsync(int id);

		Task<Contact> ModifyContact(Contact contactToModify, Contact inputContact);

	}
}
