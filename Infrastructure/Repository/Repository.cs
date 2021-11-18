using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Context;

namespace ContactProj.Infrastructure.Repository
{
	public class Repository<TEntity> : IRepository<TEntity>
		where TEntity : class
	{
		private readonly ContactProjContext _context;

		public Repository(ContactProjContext context)
		{
			_context = context;
		}
		public async Task<TEntity> AddSync(TEntity entity)
		{
			await _context.AddAsync(entity);
			await _context.SaveChangesAsync();
			return entity;
		}
	}
}
