using ContactProj.Data.Entities;
using ContactProj.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ContactProj.Data.Context
{
	public class ContactProjContext : DbContext
	{
		public DbSet<Incident> Incidents { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Account> Contacts { get; set; }

		public ContactProjContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Incident>().Property(i => i.Name).HasDefaultValueSql("NEWID()");

			modelBuilder.ApplyConfiguration(new IncidentConfiguration());
			modelBuilder.ApplyConfiguration(new AccountConfiguration());
			modelBuilder.ApplyConfiguration(new ContactConfiguration());
		}
	}
}
