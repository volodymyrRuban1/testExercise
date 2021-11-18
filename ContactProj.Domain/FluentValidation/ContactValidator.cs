using FluentValidation;

namespace ContactProj.Data.FluentValidation
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
