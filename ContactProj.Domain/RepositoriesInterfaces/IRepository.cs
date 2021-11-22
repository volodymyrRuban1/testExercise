using System.Threading.Tasks;

namespace ContactProj.Application.RepositoriesInterfaces
{	
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> AddAsync(TEntity entity);

		Task<int> SaveChangesAsync();

		ValueTask<TEntity> FindByIdAsync(params object[] keys);
	}
}
