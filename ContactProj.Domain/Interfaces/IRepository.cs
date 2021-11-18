using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProj.Application.Interfaces
{	
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> AddSync(TEntity entity);
	}
}
