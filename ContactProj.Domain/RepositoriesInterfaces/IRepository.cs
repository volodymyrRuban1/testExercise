using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContactProj.Application.Interfaces
{	
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> AddAsync(TEntity entity);

		Task<int> SaveChangesAsync();

		ValueTask<TEntity> FindByIdAsync(params object[] keys);
	}
}
