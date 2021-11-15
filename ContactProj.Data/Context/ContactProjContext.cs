using ContactProj.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactProj.Data.Context
{
	class ContactProjContext : DbContext
	{
		public DbSet<Incident> Incidents { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Account> Contacts { get; set; }

		public ContactProjContext(DbContextOptions options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
