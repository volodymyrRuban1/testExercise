using FluentValidation;

namespace ContactProj.Domain.FluentValidation
{
	public class ContactValidator : AbstractValidator<Entities.Contact>
	{
		public ContactValidator()
		{
			RuleFor(c => c.Email)
				.EmailAddress()
				.WithMessage("Invalid email!");

		}
	}
}
