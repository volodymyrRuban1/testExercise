using ContactProj.Domain.Entities;
using ContactProj.Domain.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ContactProj.Domain.Context
{
	public class ContactProjContext : DbContext
	{
		public DbSet<Incident> Incidents { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Contact> Contacts { get; set; }

		public ContactProjContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new IncidentConfiguration());
			modelBuilder.ApplyConfiguration(new AccountConfiguration());
			modelBuilder.ApplyConfiguration(new ContactConfiguration());
		}
	}
}
