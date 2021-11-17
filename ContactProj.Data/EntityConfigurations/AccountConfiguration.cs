using ContactProj.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactProj.Data.EntityConfigurations
{
	class AccountConfiguration : IEntityTypeConfiguration<Account>
	{
		public void Configure(EntityTypeBuilder<Account> builder)
		{
			builder.ToTable("Account");
			builder.HasKey(a => a.Id);

			builder.HasIndex(a => a.Name).IsUnique();

			builder.HasOne(a => a.Incident)
				.WithMany(i => i.Account)
				.HasForeignKey(a => a.IncidentName);
		}
	}
}
