using FluentValidation;

namespace ContactProj.Domain.FluentValidation
{
	public class AccountValidator : AbstractValidator<Entities.Account>
	{
		public AccountValidator()
		{
			RuleFor(a => a.Contacts).NotNull();
		}
	}
}
