using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactProj.Domain.EntityConfigurations
{
	class IncidentConfiguration : IEntityTypeConfiguration<Entities.Incident>
	{
		public void Configure(EntityTypeBuilder<Entities.Incident> builder)
		{
			builder.ToTable("Incident");
			builder.HasKey(i => i.Name);

			builder.Property(i => i.Name).HasDefaultValueSql("NEWID()");
		}
	}
}
