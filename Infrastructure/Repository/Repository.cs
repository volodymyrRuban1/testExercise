using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Domain.Context;

namespace ContactProj.Infrastructure.Repository
{
	public class Repository<TEntity> : IRepository<TEntity>
		where TEntity : class
	{
		protected readonly ContactProjContext DbContext;

		public Repository(ContactProjContext dbContext)
		{
			DbContext = dbContext;
		}

		public async Task<TEntity> AddSync(TEntity entity)
		{
			return (await DbContext.Set<TEntity>().AddAsync(entity)).Entity;
		}

		public async Task<int> SaveChangesAsync()
		{
			return await DbContext.SaveChangesAsync();
		}
	}
}
