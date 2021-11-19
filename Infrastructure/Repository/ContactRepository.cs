using System.Threading.Tasks;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Context;
using ContactProj.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactProj.Infrastructure.Repository
{
	public class ContactRepository : Repository<Contact>, IContactRepository
	{

		public ContactRepository(ContactProjContext dbContext)
		:base(dbContext)
		{

		}

		public async Task<Contact> FindContactByEmailAsync(string email)
		{
			return await DbContext.Contacts.FirstOrDefaultAsync(c => c.Email == email);
		}
		public async Task<Contact> FindAccountByIdAsync(int id)
		{
			return await DbContext.Contacts.FirstOrDefaultAsync(c => c.AccountId == id);
		}
	}
}
