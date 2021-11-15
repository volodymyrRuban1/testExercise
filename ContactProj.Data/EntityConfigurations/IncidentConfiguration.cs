using ContactProj.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactProj.Data.EntityConfigurations
{
	class IncidentConfiguration : IEntityTypeConfiguration<Incident>
	{
		public void Configure(EntityTypeBuilder<Incident> builder)
		{
			builder.ToTable("Incident");
			builder.HasKey(i => i.Name);
		}
	}
}
