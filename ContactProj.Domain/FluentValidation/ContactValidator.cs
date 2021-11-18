using FluentValidation;

namespace ContactProj.Application.FluentValidation
{
	public class ContactValidator : AbstractValidator<Domain.Entities.Contact>
	{
		public ContactValidator()
		{
			RuleFor(c => c.Email)
				.EmailAddress()
				.WithMessage("Invalid email!");

		}
	}
}
