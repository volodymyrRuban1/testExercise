using ContactProj.Domain.Entities;

namespace ContactProj.Application.Dto
{
	public sealed class AccountCreationDto
	{
		public Account Account { get; set; }
		public Contact Contact { get; set; }
	}
}
