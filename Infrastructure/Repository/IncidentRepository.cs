using System;
using System.Threading.Tasks;
using ContactProj.Application.Interfaces;
using ContactProj.Application.RepositoriesInterfaces;
using ContactProj.Domain.Context;
using ContactProj.Domain.Entities;

namespace ContactProj.Infrastructure.Repository
{
	public class IncidentRepository : Repository<Incident>, IIncidentRepository
	{

	public IncidentRepository(ContactProjContext dbContext)
		:base(dbContext)
		{
		}

	}
}
