using ContactProj.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactProj.Domain.EntityConfigurations
{
	class ContactConfiguration : IEntityTypeConfiguration<Contact>
	{
		public void Configure(EntityTypeBuilder<Contact> builder)
		{
			builder.ToTable("Contact");
			builder.HasKey(c => c.Id);

			builder.HasOne(c => c.Accounts)
				.WithMany(a => a.Contacts)
				.HasForeignKey(c => c.AccountId);
		}
	}
}
